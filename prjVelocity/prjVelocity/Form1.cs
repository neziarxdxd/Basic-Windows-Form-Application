using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjVelocity
{
    public partial class frmVelocity : Form
    {
        public frmVelocity()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Double a = Double.Parse(txtDistance.Text);
            Double b = Double.Parse(txtTime.Text);
            Double c = a / b;
            c=Math.Round(c, 2);
            txtVelocity.Text = c.ToString();
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDistance.Text = "";
            txtTime.Text = "";
            txtVelocity.Text = "";
        }
    }
}
