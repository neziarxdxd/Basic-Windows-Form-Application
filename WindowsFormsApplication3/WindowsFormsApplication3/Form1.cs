using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WindowsFormsApplication3
{
   
    public partial class Form1 : Form
    {
       
      
        public Form1()
        {
            
            InitializeComponent();
            

        }       

        private void btn_Process_Click(object sender, EventArgs e)
        {
            String studentNumber = et_StudentNumber.Text;
            String  address = et_Address.Text;
            String name = et_Name.Text;
            String section= et_Section.Text;
            String degree = et_Degree.Text;
            txt_Address.Text = address.ToUpper();
            txt_StudentNumber.Text = studentNumber.ToUpper();
            txt_Section.Text = section.ToUpper();
            txt_Name.Text = name.ToUpper();
            txt_Degree.Text = degree.ToUpper();

            et_Address.Text = "";
            et_Degree.Text = "";
            et_Name.Text = "";
            et_Section.Text = "";
            et_Degree.Text = "";
            et_StudentNumber.Text = "";
                      
           
        }

        private void txtStudentNo_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void et_StudentNumber_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            et_Address.Text = "";
            et_Degree.Text = "";
            et_Name.Text = "";
            et_Section.Text = "";
            et_Degree.Text = "";
            et_StudentNumber.Text = "";
            txt_Address.Text = "";
            txt_StudentNumber.Text = "";
            txt_Section.Text = "";
            txt_Name.Text = "";
            txt_Degree.Text = "";
        }

        private void btn_Quit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);  
        }


    }
}


