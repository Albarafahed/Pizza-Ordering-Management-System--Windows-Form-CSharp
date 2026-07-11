using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
    public partial class MainMenu : Form
    {
        private readonly ShoppingCartService _shoppingCartService;
        private  int _customerId;

        ToolTip toolTip = new ToolTip();
        public MainMenu(ShoppingCartService shoppingCartService)
        {
            InitializeComponent();
            _shoppingCartService = shoppingCartService;
            _customerId = _shoppingCartService.GetNextCustomerId();
            MainMenuLoad();
        }

        private void MainMenuLoad()
        {
           
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            string UserNam = "Admin";
            label1.Enabled = label2.Enabled = label3.Enabled = label4.Enabled = true;
            if (UserNam == "Admin")
            {

                label1.Enabled = label2.Enabled = label3.Enabled = label4.Enabled = true;
                label10.Text = "Admin";
            }
            else
            {
                label1.Enabled = label2.Enabled = label3.Enabled = label4.Enabled = false;
                label10.Text = "User1";
            }

            timer1.Start();
        }
        private void openchildForm(Form childForm)
        {
            penalContainer.Controls.Clear();
            childForm.TopLevel = false;
            childForm.Size = penalContainer.Size;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock= DockStyle.Fill;
           
            penalContainer.Controls.Add(childForm);
            childForm.Show();
        }
        private void MainMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            openchildForm(new OrderDessertForm(_shoppingCartService,_customerId));
        }

        private void label2_Click(object sender, EventArgs e)
        {
            openchildForm(new OrderPizzaForm(_shoppingCartService, _customerId));
        }

        private void label3_Click(object sender, EventArgs e)
        {
            openchildForm(new OrderJuiceForm(_shoppingCartService,_customerId));
        }

        private void label4_Click(object sender, EventArgs e)
        {
            openchildForm(new OrdersForm());
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.OpenForms["LoginForm"].Show();
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            openchildForm(new RemoteForm());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label7.Text = DateTime.Now.ToString();

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
