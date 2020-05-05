using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjAdditionOperator
{
    public partial class frmAddition : Form
    {
        public frmAddition()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmAddition_Load(object sender, EventArgs e)
        {

        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            Double a = Double.Parse(txtNum1.Text);
            Double b =Double.Parse(txtNum2.Text);
            Double c = a + b;

            txtResult.Text = c.ToString();
        }
    }
}
