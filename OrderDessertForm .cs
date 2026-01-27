using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pizza
{
    public partial class OrderDessertForm : Form
    {
        private readonly ShoppingCartService _shoppingCartService;
        private int _customerId;

        public OrderDessertForm(ShoppingCartService shoppingCartService, int customerId)
        {
            InitializeComponent();
            _shoppingCartService = shoppingCartService;
            _customerId = customerId;
            InitializeForm();
        }

        private void InitializeForm()
        {
            rbKunafa.Checked = true;
            rbPiece.Checked = true;
            numericUpDownAmount.Value = 1;
            UpdateTotalPrice();
        }

        private decimal GetDessertBasePrice()
        {
            if (rbKunafa.Checked) return 4m;
            if (rbCake.Checked) return 3.5m;
            if (rbBaklava.Checked) return 5m;
            if (rbBrownie.Checked) return 3m;
            if (rbDonut.Checked) return 2.5m;
            return 0m;
        }

        private decimal GetSizeMultiplier()
        {
            if (rbPiece.Checked) return 1m;
            if (rbSmall.Checked) return 1.5m;
            if (rbLarge.Checked) return 2m;
            return 1m;
        }

        private decimal GetToppingsPrice()
        {
            decimal price = 0m;
            if (chkChocolate.Checked) price += 0.5m;
            if (chkCream.Checked) price += 0.5m;
            if (chkNuts.Checked) price += 0.7m;
            if (chkFruits.Checked) price += 0.6m;
            if (chkHoney.Checked) price += 0.4m;
            return price;
        }

        private void UpdateTotalPrice()
        {
            lbAm.Text = numericUpDownAmount.Value.ToString();
            decimal total = (GetDessertBasePrice() * GetSizeMultiplier() + GetToppingsPrice()) * numericUpDownAmount.Value;
            lblTotalPrice.Text = $"${total:F2}";
            
        }


     

        private void UpdateAll()
        {
           
            lblSize.Text = GetSelectedSize();
            lblDessertType.Text = GetSelectedDessert();
            lblToppings.Text = GetSelectedToppings();
            lblWhereToEat.Text = GetSelectedEat();
            UpdateTotalPrice();
        }
        private void btnAddOrder_Click(object sender, EventArgs e)
        {
          
            var product = new Product
            {
                OrderId = _shoppingCartService.Products.Count > 0 ? _shoppingCartService.Products.Max(n => n.OrderId) + 1 : 0,
                CustomerId = _customerId,
                Kind = "Dessert",
                Name = GetSelectedDessert(),
                Size = GetSelectedSize(),
                Topping = GetSelectedToppings(),
                Amount = (int)numericUpDownAmount.Value,
                Price = decimal.Parse(lblTotalPrice.Text.Trim('$')),
                Status = "Pending"
            };

            _shoppingCartService.AddProduct(product);
            _shoppingCartService.Save();
           
          
            MessageBox.Show("Dessert order added successfully!");
            ResetForm();
        }

        private string GetSelectedDessert()
        {
            if (rbKunafa.Checked) return "Kunafa";
            if (rbCake.Checked) return "Cake";
            if (rbBaklava.Checked) return "Baklava";
            if (rbBrownie.Checked) return "Brownie";
            if (rbDonut.Checked) return "Donut";
            return "";
        }

        private string GetSelectedSize()
        {
            if (rbPiece.Checked) return "Piece";
            if (rbSmall.Checked) return "Small";
            if (rbLarge.Checked) return "Large";
            return "";
        }

        private string GetSelectedToppings()
        {
            var toppings = new List<string>();
            if (chkChocolate.Checked) toppings.Add("Chocolate");
            if (chkCream.Checked) toppings.Add("Cream");
            if (chkNuts.Checked) toppings.Add("Nuts");
            if (chkFruits.Checked) toppings.Add("Fruits");
            if (chkHoney.Checked) toppings.Add("Honey");
            return toppings.Count > 0 ? string.Join(", ", toppings) : "No Toppings";
        }

        private void ResetForm()
        {
            rbKunafa.Checked = true;
            rbPiece.Checked = true;
            chkChocolate.Checked = false;
            chkCream.Checked = false;
            chkNuts.Checked = false;
            chkFruits.Checked = false;
            chkHoney.Checked = false;
            numericUpDownAmount.Value = 1;
            UpdateTotalPrice();
        }

        private void AnyOptionChanged(object sender, EventArgs e)
        {
            UpdateAll();
           
        }

        private string GetSelectedEat()
        {
            if (rbTakeOut.Checked) return "Take Out";
            if (rbEatIn.Checked) return "Eat In";

            return "";
        }
        private void OrderDessertForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           

            _shoppingCartService.AddOrder(_customerId, "Dessert", GetSelectedDessert(), 
                GetSelectedSize(), GetSelectedToppings(), (int)numericUpDownAmount.Value, lblTotalPrice.Text.Trim('$'));
            ResetForm();
        }

        private void btnNewuser_Click(object sender, EventArgs e)
        {
            _customerId=_shoppingCartService.GetNextCustomerId();
        }

        private void numericUpDownAmount_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }
    }
}