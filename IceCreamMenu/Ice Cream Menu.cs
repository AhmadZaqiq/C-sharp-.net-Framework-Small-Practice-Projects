using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IceCreamMenu
{
    public partial class FormIceCream : Form
    {
        public FormIceCream()
        {
            InitializeComponent();
        }

        void Default()
        {
            ShowButtons();

            rbvanilla.Checked = true;
            rbCup.Checked = true;

            chkCaramelSauce.Checked = false;
            chkChocolateChips.Checked = false;
            chkNuts.Checked = false;
            chkSprinkles.Checked = false;

            numericUpDown1.Value= 1;
        }
        void HideButtons()
        {
            gbFlavor.Enabled = false;
            gbServing.Enabled = false;
            gbToppings.Enabled = false;

            btnOrder.Enabled = false;
            numericUpDown1.Enabled = false;
        }
        void ShowButtons()
        {
            gbFlavor.Enabled = true;
            gbServing.Enabled = true;
            gbToppings.Enabled = true;

            btnOrder.Enabled = true;
            numericUpDown1.Enabled = true;
        }

        float UpdateFlavorPrice()
        {
            if (rbvanilla.Checked)
            {
                return Convert.ToSingle(rbvanilla.Tag);
            }

            if (rbchocolate.Checked)
            {
                return Convert.ToSingle(rbchocolate.Tag);
            }

            if (rbstrawberry.Checked)
            {
                return Convert.ToSingle(rbstrawberry.Tag);
            }

            return -1;
        }
        float UpdateServingPrice()
        {
            if (rbCone.Checked)
            {
                return Convert.ToSingle(rbCone.Tag);
            }

            if (rbCup.Checked)
            {
                return Convert.ToSingle(rbCup.Tag);
            }

            return -1;
        }
        float UpdateToppingsPrice()
        {
            float ToppingPrice = 0;

            if (chkSprinkles.Checked)
            {
                ToppingPrice += Convert.ToSingle(chkSprinkles.Tag);
            }

            if (chkCaramelSauce.Checked)
            {
                ToppingPrice += Convert.ToSingle(chkCaramelSauce.Tag);
            }

            if (chkChocolateChips.Checked)
            {
                ToppingPrice += Convert.ToSingle(chkChocolateChips.Tag);
            }

            if (chkNuts.Checked)
            {
                ToppingPrice += Convert.ToSingle(chkNuts.Tag);
            }

            return ToppingPrice;
        }

        float GetTotalPrice()
        {
            return UpdateFlavorPrice() + UpdateServingPrice() + UpdateToppingsPrice();
        }
        void UpdatePrice()
        {        
            lblPrice.Text = "$" + GetTotalPrice().ToString();
            UpdateIcecreamNumbersPrice();
        }
        void UpdateFlavor()
        {
            UpdatePrice();

            if (rbvanilla.Checked)
            {
                lblFlavor.Text = rbvanilla.Text;
                return;
            }

            if (rbchocolate.Checked)
            {
                lblFlavor.Text = rbchocolate.Text;
                return;
            }

            if (rbstrawberry.Checked)
            {
                lblFlavor.Text = rbstrawberry.Text;
                return;
            }

        }
        void UpdateServing()
        {
            UpdatePrice();

            if (rbCone.Checked)
            {
                lblServing.Text = rbCone.Text;
                return;
            }

            if (rbCup.Checked)
            {
                lblServing.Text = rbCup.Text;
                return;
            }
        }
        void UpdateToppings()
        {
            UpdatePrice();

            string Toppings = "";

            if (chkSprinkles.Checked)
            {
                Toppings = chkSprinkles.Text + "\n";
            }

            if (chkChocolateChips.Checked)
            {
                Toppings += chkChocolateChips.Text + "\n";
            }

            if (chkCaramelSauce.Checked)
            {
                Toppings += chkCaramelSauce.Text + "\n";
            }

            if (chkNuts.Checked)
            {
                Toppings += chkNuts.Text + "\n";
            }

            if (Toppings.Length == 0)
            {
                Toppings = "No Toppings";
            }

            lblToppings.Text = Toppings;
        }

        private void FormIceCream_Load(object sender, EventArgs e)
        {
            Default();
        }

        private void Flavor_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFlavor();

        }

        private void Serving_CheckedChanged(object sender, EventArgs e)
        {
            UpdateServing();
        }

        private void Toppings_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Place Order ","Order",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1)==DialogResult.OK)
            {
                MessageBox.Show("Order Placed Successfully", "Order",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                HideButtons();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Default();
        }

        float GetIcecreamNumberPrice()
        {
            return (GetTotalPrice() * Convert.ToSingle(numericUpDown1.Value));
        }

        private void UpdateIcecreamNumbersPrice()
        {
            lblPrice.Text = "$" + GetIcecreamNumberPrice().ToString();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            UpdateIcecreamNumbersPrice();
        }
    }
}
