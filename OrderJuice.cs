using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Pizza
{
    public partial class OrderJuiceForm : Form
    {
        private readonly ShoppingCartService _shoppingCartService;
        private int _customerId;

        public OrderJuiceForm(ShoppingCartService shoppingCartService, int customerId)
        {
            InitializeComponent();
            _shoppingCartService = shoppingCartService;
            _customerId = customerId;
            InitializeForm();
        }

        private void InitializeForm()
        {
            rbSmall.Checked = true;
            rbMango.Checked = true;
            numericUpDownAmount.Value = 1;
            UpdateTotalPrice();
        }

        private decimal GetSizePrice()
        {
            if (rbSmall.Checked) return 2m;
            if (rbMedium.Checked) return 3.5m;
            if (rbLarge.Checked) return 5m;
            return 0m;
        }

        private decimal GetJuiceTypePrice()
        {
            if (rbMango.Checked) return 1m;
            if (rbOrange.Checked) return 1.2m;
            if (rbCocktail.Checked) return 1.5m;
            if (rbStrawberry.Checked) return 1.3m;
            return 0m;
        }

        private void UpdateTotalPrice()
        {

            lbAmount.Text = numericUpDownAmount.Value.ToString();
            decimal total = (GetSizePrice() + GetJuiceTypePrice()) * numericUpDownAmount.Value;
            lblTotalPrice.Text = $"${total:F2}";
        }

      

        private void UpdateAll()
        {

           
            lblSize.Text = GetSelectedSize();
            lblType.Text = GetSelectedJuiceType();
            UpdateTotalPrice();
        }
       
        private string GetSelectedSize()
        {
            if (rbSmall.Checked) return "Small";
            if (rbMedium.Checked) return "Medium";
            if (rbLarge.Checked) return "Large";
            return "";
        }

        private string GetSelectedEat()
        {
            if (rbTakeOut.Checked) return "Take Out";
            if (rbEatIn.Checked) return "Eat In";
           
            return "";
        }

        private string GetSelectedJuiceType()
        {
            if (rbMango.Checked) return "Mango";
            if (rbOrange.Checked) return "Orange";
            if (rbCocktail.Checked) return "Cocktail";
            if (rbStrawberry.Checked) return "Strawberry";
            return "";
        }

        private void ResetForm()
        {
            rbSmall.Checked = true;
            rbMango.Checked = true;
            numericUpDownAmount.Value = 1;
            UpdateTotalPrice();
        }

        private void AnyOptionChanged(object sender, EventArgs e)
        {
            UpdateAll();
        }

        private void OrderJuiceForm_Load(object sender, EventArgs e)
        {

        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            _customerId = _shoppingCartService.GetNextCustomerId();
        }

       

        private void numericUpDownAmount_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            _shoppingCartService.AddOrder(_customerId, "Juice", GetSelectedJuiceType(),
                GetSelectedSize(), "No Toppings", (int)numericUpDownAmount.Value, lblTotalPrice.Text.Trim('$'));
            ResetForm();
        }
    }
}