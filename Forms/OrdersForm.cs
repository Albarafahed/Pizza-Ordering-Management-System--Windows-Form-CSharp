using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using YourNamespace;

namespace Pizza
{
    public partial class OrdersForm : Form
    {
        private ShoppingCartService _shoppingCartService;
        private List<Product> filteredOrders = new List<Product>();

        private PrintDocument printDocument;
        private List<Product> allOrdersToPrint;
        private List<string> distinctKinds;
        private int printPageIndex = 0;

        public OrdersForm()
        {
            InitializeComponent();

            _shoppingCartService = new ShoppingCartService();

            // تهيئة الطباعة
            printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;

            // أحداث الأزرار
            btnPrint.Click += BtnPrint_Click;
            btnDelete.Click += BtnDelete_Click;

            // تحميل الفلاتر
            LoadFilterOptions();
            LoadOrders();

            comboBoxFilter.SelectedIndexChanged += (s, e) => LoadOrders();
            comboBoxCustomer.SelectedIndexChanged += (s, e) => LoadOrders();
        }

        private void LoadFilterOptions()
        {
            comboBoxFilter.Items.Clear();
            comboBoxFilter.Items.Add("الطلبات الجديدة فقط");
            comboBoxFilter.Items.Add("الطلبات المطبوعة فقط");
            comboBoxFilter.Items.Add("كل الطلبات");
            comboBoxFilter.SelectedIndex = 0; // الافتراضي: الجديدة فقط

            LoadCustomerFilter();
        }

        private void LoadCustomerFilter()
        {
            var customers = _shoppingCartService.Products
                .Select(p => p.CustomerId)
                .Distinct()
                .OrderBy(id => id)
                .ToList();

            comboBoxCustomer.Items.Clear();
            comboBoxCustomer.Items.Add("الكل");
            comboBoxCustomer.Items.AddRange(customers.Select(c => c.ToString()).ToArray());
            comboBoxCustomer.SelectedIndex = 0;
        }

        private void LoadOrders()
        {
            var products = _shoppingCartService.Products;

            // فلترة حسب حالة الطباعة
            if (comboBoxFilter.SelectedIndex == 0) // الجديدة
                products = products.Where(p => !p.IsPrinted).ToList();
            else if (comboBoxFilter.SelectedIndex == 1) // المطبوعة
                products = products.Where(p => p.IsPrinted).ToList();

            // فلترة حسب العميل
            if (comboBoxCustomer.SelectedIndex > 0)
            {
                int selectedCustomerId = int.Parse(comboBoxCustomer.SelectedItem.ToString());
                products = products.Where(p => p.CustomerId == selectedCustomerId).ToList();
            }

            filteredOrders = products.ToList();

            dataGridViewOrders.DataSource = null;
            dataGridViewOrders.DataSource = filteredOrders;

            // إخفاء الأعمدة
            if (dataGridViewOrders.Columns["IsPrinted"] != null)
                dataGridViewOrders.Columns["IsPrinted"].Visible = false;
            if (dataGridViewOrders.Columns["Status"] != null)
                dataGridViewOrders.Columns["Status"].Visible = false;

            // تلوين الصفوف حسب العميل
            int lastCustomerId = -1;
            Color[] colors = { Color.White, Color.LightGray };
            int colorIndex = 0;

            foreach (DataGridViewRow row in dataGridViewOrders.Rows)
            {
                if (row.Cells["CustomerId"].Value != null)
                {
                    int currentCustomerId = Convert.ToInt32(row.Cells["CustomerId"].Value);
                    if (currentCustomerId != lastCustomerId)
                    {
                        colorIndex = 1 - colorIndex;
                        lastCustomerId = currentCustomerId;
                    }
                    row.DefaultCellStyle.BackColor = colors[colorIndex];
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrders.Rows.Count == 0)
            {
                MessageBox.Show("لا توجد طلبات للطباعة.");
                return;
            }

            // إذا اختار عميل من الجدول -> اطبع له فقط
            if (dataGridViewOrders.SelectedRows.Count > 0)
            {
                int customerId = Convert.ToInt32(dataGridViewOrders.SelectedRows[0].Cells["CustomerId"].Value);

                allOrdersToPrint = _shoppingCartService.Products
                    .Where(p => p.CustomerId == customerId && !p.IsPrinted)
                    .OrderBy(p => p.OrderId)
                    .ToList();
            }
            //else // اطبع الكل (حسب الفلتر)
            //{
            //    allOrdersToPrint = filteredOrders.ToList();
            //}

            if (allOrdersToPrint.Count == 0)
            {
                MessageBox.Show("لا توجد طلبات للطباعة.");
                return;
            }

            distinctKinds = allOrdersToPrint
                .Select(p => p.Kind)
                .Distinct()
                .OrderBy(k => k)
                .ToList();

            printPageIndex = 0;

            PrintPreviewDialog previewDialog = new PrintPreviewDialog
            {
                Document = printDocument,
                Width = 800,
                Height = 600
            };
            previewDialog.ShowDialog();

            // تحديث حالة الطباعة
            foreach (var order in allOrdersToPrint)
                order.IsPrinted = true;

            _shoppingCartService.Save(_shoppingCartService.Products);
            LoadOrders();
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            int startX = 50;
            int startY = 50;
            int rowHeight = 25;
            int colPadding = 5;

            Font titleFont = new Font("Arial", 18, FontStyle.Bold);
            Font headerFont = new Font("Arial", 14, FontStyle.Bold);
            Font cellFont = new Font("Arial", 12);
            Brush brush = Brushes.Black;

            string[] headers = { "رقم الطلب", "رقم العميل", "النوع", "الاسم", "الحجم", "الإضافات", "الكمية", "السعر" };
            int[] colWidths = { 80, 80, 80, 100, 80, 100, 60, 80 };

            List<Product> ordersToPrintThisPage;

            if (printPageIndex == 0)
            {
                g.DrawString("جميع الطلبات", titleFont, brush, startX, startY);
                startY += rowHeight + 20;

                ordersToPrintThisPage = allOrdersToPrint;
            }
            else
            {
                string kind = distinctKinds[printPageIndex - 1];
                g.DrawString($"طلبات نوع: {kind}", titleFont, brush, startX, startY);
                startY += rowHeight + 20;

                ordersToPrintThisPage = allOrdersToPrint.Where(p => p.Kind == kind).ToList();
            }

            int currentX = startX;
            for (int i = 0; i < headers.Length; i++)
            {
                g.DrawRectangle(Pens.Black, currentX, startY, colWidths[i], rowHeight);
                g.DrawString(headers[i], headerFont, brush, new RectangleF(currentX + colPadding, startY + 5, colWidths[i], rowHeight));
                currentX += colWidths[i];
            }
            g.DrawLine(Pens.Black, startX, startY + rowHeight, startX + colWidths.Sum(), startY + rowHeight);

            startY += rowHeight;

            int maxRowsPerPage = (e.MarginBounds.Height - startY) / rowHeight;
            int printedRows = 0;

            foreach (var p in ordersToPrintThisPage)
            {
                if (printedRows >= maxRowsPerPage)
                    break;

                currentX = startX;
                string[] row = {
                    p.OrderId.ToString(),
                    p.CustomerId.ToString(),
                    p.Kind,
                    p.Name,
                    p.Size,
                    p.Topping,
                    p.Amount.ToString(),
                    p.Price.ToString("F2"),
                };

                for (int i = 0; i < row.Length; i++)
                {
                    g.DrawRectangle(Pens.Black, currentX, startY, colWidths[i], rowHeight);
                    g.DrawString(row[i], cellFont, brush, new RectangleF(currentX + colPadding, startY + 5, colWidths[i], rowHeight));
                    currentX += colWidths[i];
                }

                startY += rowHeight;
                printedRows++;
            }

            bool moreRowsInPage = printedRows < ordersToPrintThisPage.Count;

            if (moreRowsInPage)
            {
                e.HasMorePages = true;
            }
            else
            {
                printPageIndex++;

                if (printPageIndex > distinctKinds.Count)
                {
                    e.HasMorePages = false;
                    printPageIndex = 0;
                }
                else
                {
                    e.HasMorePages = true;
                }
            }

            decimal totalPrice = ordersToPrintThisPage.Sum(p1 => p1.Price * p1.Amount);
            startY += 10;
            g.DrawString($"السعر الإجمالي: {totalPrice.ToString("C", CultureInfo.GetCultureInfo("en-US"))}",
              new Font("Arial", 14, FontStyle.Bold), Brushes.Black, startX, startY);

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("يرجى تحديد صف لحذفه.");
                return;
            }

            int orderId = Convert.ToInt32(dataGridViewOrders.SelectedRows[0].Cells["OrderId"].Value);

            var confirm = MessageBox.Show("هل تريد فعلاً حذف هذا الطلب؟",
                "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                _shoppingCartService.RemoveProduct(orderId);
                LoadOrders();
                MessageBox.Show("تم حذف الصف بنجاح.");
            }
        }
    }
}
