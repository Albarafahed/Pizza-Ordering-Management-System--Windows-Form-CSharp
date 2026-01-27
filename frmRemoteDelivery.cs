using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Pizza
{
    public partial class RemoteForm : Form
    {
        private readonly ShoppingCartService _shoppingCartService;
        private List<Product> filteredOrders = new List<Product>();

        public RemoteForm()
        {
            InitializeComponent();

            _shoppingCartService = new ShoppingCartService();

            SetupFilters();
            LoadOrders();

            comboBoxCustomer.SelectedIndexChanged += (s, e) => LoadOrders();
            comboBoxStatus.SelectedIndexChanged += (s, e) => LoadOrders();
            btnUpdateStatus.Click += BtnUpdateStatus_Click;
        }

        private void SetupFilters()
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

            comboBoxStatus.Items.Clear();
            comboBoxStatus.Items.Add("الكل");
            comboBoxStatus.Items.Add("Pending");
            comboBoxStatus.Items.Add("Delivering");
            comboBoxStatus.Items.Add("Delivered");
            comboBoxStatus.SelectedIndex = 0;
        }

        private void LoadOrders()
        {
            int? customerId = comboBoxCustomer.SelectedIndex > 0 ? int.Parse(comboBoxCustomer.SelectedItem.ToString()) : (int?)null;
            string status = comboBoxStatus.SelectedIndex > 0 ? comboBoxStatus.SelectedItem.ToString() : null;

            IEnumerable<Product> orders = _shoppingCartService.Products;

            if (customerId.HasValue)
                orders = orders.Where(p => p.CustomerId == customerId.Value);

            if (!string.IsNullOrEmpty(status))
                orders = orders.Where(p => p.Status == status);

            filteredOrders = orders.ToList();

            dataGridViewStatus.DataSource = null;
            dataGridViewStatus.DataSource = filteredOrders;

            // تلوين الصفوف حسب الحالة
            foreach (DataGridViewRow row in dataGridViewStatus.Rows)
            {
                if (row.Cells["Status"].Value != null)
                {
                    string statusValue = row.Cells["Status"].Value.ToString();
                    switch (statusValue)
                    {
                        case "Pending":
                            row.DefaultCellStyle.BackColor = Color.LightYellow;
                            break;
                        case "Delivering":
                            row.DefaultCellStyle.BackColor = Color.LightBlue;
                            break;
                        case "Delivered":
                            row.DefaultCellStyle.BackColor = Color.LightGreen;
                            break;
                        default:
                            row.DefaultCellStyle.BackColor = Color.White;
                            break;
                    }
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }

        private void BtnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (dataGridViewStatus.SelectedRows.Count == 0)
            {
                MessageBox.Show("يرجى اختيار طلب لتحديث حالته.");
                return;
            }

            int orderId = Convert.ToInt32(dataGridViewStatus.SelectedRows[0].Cells["OrderId"].Value);
            Product order = _shoppingCartService.Products.FirstOrDefault(p => p.OrderId == orderId);

            if (order == null)
                return;

            string currentStatus = order.Status;
            string newStatus = currentStatus;

            if (currentStatus == "Pending")
            {
                newStatus = "Delivering";
            }
            else if (currentStatus == "Delivering")
            {
                newStatus = "Delivered";
            }
            else if (currentStatus == "Delivered")
            {
                MessageBox.Show("الطلب تم تسليمه مسبقاً.");
                return;
            }

            order.Status = newStatus;
            MessageBox.Show($"تم تغيير الحالة من {currentStatus} إلى {newStatus}");

            _shoppingCartService.Save();

            LoadOrders();
        }

        private void comboBoxCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RemoteForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewStatus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
