using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
namespace Pizza
{
    public partial class OrderPizzaForm : Form
    {
        private readonly ShoppingCartService _shoppingCartService;
        private int _customerId;

        public OrderPizzaForm(ShoppingCartService shoppingCartService, int customerId)
        {
            InitializeComponent();
            _shoppingCartService = shoppingCartService;
            _customerId = customerId;
            InitializeForm();
        }

        private void InitializeForm()
        {
            // إعداد القيم الافتراضية، مثلاً:
            rbMedium.Checked = true;
            numericUpDownAmount.Value = 1;
            lblTotalPrice.Text = "$0.00";
            UpdateTotalPrice();
        }

        private decimal GetSizePrice()
        {
            if (rbSmall.Checked) return 5m;
            if (rbMedium.Checked) return 8m;
            if (rbLarge.Checked) return 12m;
            return 0m;
        }

        private decimal GetToppingsPrice()
        {
            decimal price = 0m;
            if (chkExtraCheese.Checked) price += 1.5m;
            if (chkOnion.Checked) price += 0.5m;
            if (chkMushrooms.Checked) price += 0.7m;
            if (chkOlives.Checked) price += 0.6m;
            if (chkTomatoes.Checked) price += 0.5m;
            if (chkGreenPeppers.Checked) price += 0.5m;
            return price;
        }

        private decimal GetCrustPrice()
        {
            if (rbThinCrust.Checked) return 1m;
            if (rbThickCrust.Checked) return 1.5m;
            return 0m;
        }

        private String GetSelectCrustPrice()
        {
            if (rbThinCrust.Checked) return "ThinCrust";
            if (rbThickCrust.Checked) return "ThinckCrust";
            return "";
        }

        private string GetSelectedEat()
        {
            if (rbTakeOut.Checked) return "Take Out";
            if (rbEatIn.Checked) return "Eat In";

            return "";
        }
        private void UpdateTotalPrice()
        {
            lbAmount.Text = numericUpDownAmount.Value.ToString();
            decimal total = (GetSizePrice() + GetToppingsPrice() + GetCrustPrice()) * numericUpDownAmount.Value;
            lblTotalPrice.Text = $"${total:F2}";
            
        }

        private void UpdateAll()
        {
          
            lbAmount.Text = numericUpDownAmount.Value.ToString();
            lblToppings.Text = GetSelectedToppings();
            lblCrustType.Text = GetSelectCrustPrice();
            lblWhereToEat.Text = GetSelectedEat();
            UpdateTotalPrice();
        }
       

        private string GetSelectedSize()
        {
            if (rbSmall.Checked) return "Small";
            if (rbMedium.Checked) return "Medium";
            if (rbLarge.Checked) return "Large";
            return "";
        }

        private string GetSelectedToppings()
        {
            var toppings = new System.Collections.Generic.List<string>();
            if (chkExtraCheese.Checked) toppings.Add("Extra Cheese");
            if (chkOnion.Checked) toppings.Add("Onion");
            if (chkMushrooms.Checked) toppings.Add("Mushrooms");
            if (chkOlives.Checked) toppings.Add("Olives");
            if (chkTomatoes.Checked) toppings.Add("Tomatoes");
            if (chkGreenPeppers.Checked) toppings.Add("Green Peppers");
            return toppings.Count > 0 ? string.Join(", ", toppings) : "No Toppings";
        }

        private void ResetForm()
        {
            rbMedium.Checked = true;
            chkExtraCheese.Checked = false;
            chkOnion.Checked = false;
            chkMushrooms.Checked = false;
            chkOlives.Checked = false;
            chkTomatoes.Checked = false;
            chkGreenPeppers.Checked = false;
            rbThinCrust.Checked = true;
            numericUpDownAmount.Value = 1;
            UpdateTotalPrice();
        }

        // ربط الأحداث لتحديث السعر عند تغيير الخيارات
        private void AnyOptionChanged(object sender, EventArgs e)
        {
            UpdateAll();
        }

        private void OrderPizzaForm_Load(object sender, EventArgs e)
        {

        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            _customerId=_shoppingCartService.GetNextCustomerId();
        }

        private void numericUpDownAmount_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _shoppingCartService.AddOrder(_customerId, "Pizza", "Custom Pizza",
                GetSelectedSize(), GetSelectedToppings(), (int)numericUpDownAmount.Value, lblTotalPrice.Text.Trim('$'));
            ResetForm();
        }
    }
}