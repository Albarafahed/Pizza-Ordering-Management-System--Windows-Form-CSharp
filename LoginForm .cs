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
    public partial class LoginForm : Form
    {
        private readonly ShoppingCartService _shoppingCartService;
       
        public string LoggedInUser { get; private set; }
        public LoginForm()
        {
            InitializeComponent();
            _shoppingCartService = new ShoppingCartService();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsername.Focus();
           
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter username and password.");
                return;
            }

            // تبسيط: تحقق من المستخدمين الثابتين
            if ((username.Equals("Admin", StringComparison.OrdinalIgnoreCase) && password == "A1234") ||
                (username.Equals("User 1", StringComparison.OrdinalIgnoreCase) && password == "a1234"))
            {
                LoggedInUser = username;
                this.DialogResult = DialogResult.OK;
                
                errorProvider1.Clear();
                txtPassword.Clear();
                txtUsername.Clear();
               
                txtUsername.Focus();
                Form frm=new MainMenu(_shoppingCartService);
                frm.Show();

               
            }
            else
            {

                errorProvider1.SetError(txtPassword, "Invalid username or password!");
                txtPassword.Clear();
                txtUsername.Clear();
                txtUsername.Focus();
                //button2.Enabled = false;
                //txtPassword.Enabled = false;

            }

        }

       
        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            //this.FormBorderStyle = FormBorderStyle.None;
            //button2.Enabled = false;
            //txtPassword.Enabled = false;
            txtUsername.Focus();
            //textBox2.PasswordChar = '\0';
            //textBox1.PasswordChar = '*';
            
        }

      
       

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            Environment.Exit(0);

        }

      
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {

            //if (e.KeyCode == Keys.Enter)
            //{
            //    e.Handled = true;
            //    e.SuppressKeyPress = true;
            //    txtPassword.Focus();
            //}

        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (txtUsername.Text != "")
           {
             //txtPassword.Enabled = true;
              
               
           }
               
        //    //else 
            //    txtPassword.Enabled=false;
           
          
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtPassword.Text != "")
            {
                
              this.AcceptButton = button2;

            }
           
      
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            label4.BackColor = Color.LightYellow;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            txtPassword.PasswordChar=txtPassword.PasswordChar=='*'? '\0':'*';
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if(txtUsername.Text=="Enter User Name")
            {
                txtUsername.Clear();
                txtUsername.ForeColor = Color.Black;
            }
           
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtUsername.Text))
            {
                txtUsername.Text = "Enter User Name";
                txtUsername.ForeColor= Color.Gray;
            }
        }

        

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Enter Your Passowrd")
            {
                txtPassword.Clear();
                txtPassword.ForeColor = Color.Black;
                txtPassword.PasswordChar = '*';
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                txtPassword.Text = "Enter Your Passowrd";
                txtPassword.ForeColor = Color.Gray;
                txtPassword.PasswordChar = '\0';
            }
        }

       
    }
}


