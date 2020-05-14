using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjSwitchCaseBox
{
    public partial class frmSwitchCaseBox : Form
    {
        public frmSwitchCaseBox()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            try
            {

                string letter = txtShadow.Text;
                if (Char.IsDigit(letter, 0))
                {
                    DialogResult result = MessageBox.Show("It's a Number?", "Close Window", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        this.Close();
                    }
                    else
                    {
                        // Do Nothing
                    }
                }


                else if (Char.IsLetter(letter, 0))
                {
                    DialogResult result1 = MessageBox.Show("It's a Letter?", "Close Window", MessageBoxButtons.YesNo);
                    if (result1 == DialogResult.Yes)
                    {
                        this.Close();
                    }
                    else
                    {
                        // Do Nothing
                    }
                }
                else
                {
                    DialogResult result2 = MessageBox.Show("It's Something Else?", "Close Window", MessageBoxButtons.YesNo);
                    if (result2 == DialogResult.Yes)
                    {
                        this.Close();
                    }
                    else
                    {
                        // Do Nothing
                    }
                }

            }
            catch (Exception exc)
            {
                DialogResult result2 = MessageBox.Show("It's Something Else?", "Close Window", MessageBoxButtons.YesNo);
                if (result2 == DialogResult.Yes)
                {
                    this.Close();
                }
                else
                {
                    // Do Nothing
                }
            }
        }
        
       

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            txtShadow.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
    
