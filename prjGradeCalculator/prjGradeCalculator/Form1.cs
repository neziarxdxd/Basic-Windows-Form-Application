using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjGradeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            double grade = Double.Parse((txtGrade.Text));
            if (97 <= grade && grade <= 100)
            {
                txtEquivalent.Text = "Excellent";
            }
            else if (93 <= grade && grade <= 96)
            {
                txtEquivalent.Text = "Above Average";
            }
            else if (90 <= grade && grade <= 94)
            {
                txtEquivalent.Text = "Average";
            }
            else if (85 <= grade && grade <= 89)
            {
                txtEquivalent.Text = "Very good";
            }
            else if (80 <= grade && grade <= 84)
            {
                txtEquivalent.Text = "Good";
            }
            else 
            {
                txtEquivalent.Text = "Fair";
            }


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtGrade.Text = "";
            txtEquivalent.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
