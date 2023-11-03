using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUPizzaPalace
{
    public partial class frmMain : Form
    {
        // Constants for prices
        private const decimal SmallPrice = 2.00M;
        private const decimal MediumPrice = 5.00M;
        private const decimal LargePrice = 10.00M;
        private const decimal XLargePrice = 15.00M;
        private const decimal GinormousPrice = 20.00M;
        private const decimal ToppingPrice = 1.00M;
        private const decimal SpecialToppingPrice = 2.00M;
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            //Exception
            if (cboSize.SelectedItem == null || (rdoThin.Checked == false && rdoThick.Checked == false && rdoRegular.Checked == false))
            {
                MessageBox.Show("Select a pizza size and crust type, please.");
                return;
            }

            // Initializing variables
            decimal subTotal = 0.0M;
            decimal taxRate = 0.08M; // 8% tax rate

            // Cost for pizza size
            decimal pizzaSizeCost = 0.0M;
            switch (cboSize.SelectedItem.ToString())
            {
                case "Small":
                    pizzaSizeCost = SmallPrice;
                    break;
                case "Medium":
                    pizzaSizeCost = MediumPrice;
                    break;
                case "Large":
                    pizzaSizeCost = LargePrice;
                    break;
                case "X-Large":
                    pizzaSizeCost = XLargePrice;
                    break;
                case "Ginormous":
                    pizzaSizeCost = GinormousPrice;
                    break;
            }

            subTotal += pizzaSizeCost;

           
            // Cost for toppings
            subTotal += CountToppingCost();

            // Cost for tax
            decimal tax = subTotal * taxRate;

            // Total cost calculation
            decimal total = subTotal + tax;

            // REsults displayed
            txtSubTotal.Text = subTotal.ToString("C"); // Format as currency
            txtTax.Text = tax.ToString("C"); // Format as currency
            txtTotal.Text = total.ToString("C"); // Format as currency

            // Order summary
            rtfOrderSummary.Text = GenerateOrderSummary(pizzaSizeCost, tax, subTotal);
        }

        private decimal CountToppingCost()
        {
            decimal toppingCost = 0.0M;

            // Check each topping checkbox and add the cost if selected
            if (ckbPepperoni.Checked) toppingCost += SpecialToppingPrice;
            if (ckbSausage.Checked) toppingCost += SpecialToppingPrice;
            if (ckbCanadianBacon.Checked) toppingCost += SpecialToppingPrice;
            if (ckbSpicyItalianSausage.Checked) toppingCost += SpecialToppingPrice;
            if (ckbBlackOlives.Checked) toppingCost += ToppingPrice;
            if (ckbGreenOlives.Checked) toppingCost += ToppingPrice;
            if (ckbOnion.Checked) toppingCost += ToppingPrice;
            if (ckbGreenPepper.Checked) toppingCost += ToppingPrice;
            if (ckbBananaPeppers.Checked) toppingCost += ToppingPrice;
            if (ckbMushroom.Checked) toppingCost += ToppingPrice;
            if (ckbJalapeno.Checked) toppingCost += ToppingPrice;
            if (ckbExtraCheese.Checked) toppingCost += ToppingPrice;

            return toppingCost;
        }

        private string GenerateOrderSummary(decimal pizzaSizeCost, decimal tax, decimal subTotal)
        {
            // Create the order summary
            string summary = $"You ordered a {cboSize.SelectedItem} pizza with {GetSelectedCrust()} crust, and the following toppings:\n";

            string toppings = GetSelectedToppings();
            if (!string.IsNullOrWhiteSpace(toppings))
            {
                // Split the toppings into an array
                string[] toppingList = toppings.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

                // Create a bulleted list
                for (int i = 0; i < toppingList.Length; i++)
                {
                    toppingList[i] = $"• {toppingList[i]}";
                }

                toppings = string.Join("\n", toppingList);

                // Add a line break at the beginning
                toppings = "\n" + toppings;
            }

            summary += toppings;

            return summary;
        }



        private string GetSelectedCrust()
        {
            if (rdoThin.Checked) return "Thin";
            if (rdoThick.Checked) return "Thick";
            if (rdoRegular.Checked) return "Regular";
            return "N/A";
        }

        private string GetSelectedToppings()
        {
            string toppings = "";
            foreach (Control c in grpSelections.Controls)
            {
                if (c is CheckBox && (c as CheckBox).Checked)
                {
                    toppings += (c as CheckBox).Text + "\n";
                }
            }
            return toppings;
        }
    }
}