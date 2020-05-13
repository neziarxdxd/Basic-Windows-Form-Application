using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjMessageBox
{
    public partial class frmMessageBox : Form
    {
        private Random rnd = new Random();


        public frmMessageBox()
        {
            InitializeComponent();
        }

        private void btnClickMe_Click(object sender, EventArgs e)
        {
            string message = "Do you want to abort this operation?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.AbortRetryIgnore;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
            if (result == DialogResult.Abort)
            {
                this.Close();
            }
            if (result == DialogResult.Retry)
            {
                // Do nothing
            }
            else
            {
                Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));

                BackColor = randomColor;
            } 
        }
    }
}
