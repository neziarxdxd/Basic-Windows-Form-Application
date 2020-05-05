using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjCurrencyConverter
{
    public partial class frmCurrency : Form
    {
        public frmCurrency()
        {
            InitializeComponent();
        }

        private void frmCurrency_Load(object sender, EventArgs e)
        {
            lblRate.Text = ("Rate :55.07");
        }

        private void rbtnDollar_CheckedChanged(object sender, EventArgs e)
        {
            lblAmount.Text = "Amount in Dollars:";
            lblEquivalent.Text = "Equivalent in Peso:";
        }

        private void rbtnPeso_CheckedChanged(object sender, EventArgs e)
        {
            lblAmount.Text = "Amount in Peso:";
            lblEquivalent.Text = "Equivalent in Dollar:";
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (rbtnDollar.CausesValidation == true)
            {
                Double a = Double.Parse(txtAmount.Text);
                Double b = a * 55.07;

                txtEquivalent.Text = b.ToString("0,0.##");
            }

            if (rbtnPeso.CausesValidation == true)
            {
                Double c = Double.Parse(txtAmount.Text);
                Double d = c / 55.07;
                txtEquivalent.Text = d.ToString("0,0.##");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEquivalent.Text = "";
            txtAmount.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
