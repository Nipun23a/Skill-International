using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Skills_International
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }
      
        private void Button1_Click(object sender, EventArgs e)
        {
        }
        private void btnclear_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            txtname.Text = "";
            txtlname.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            txthphone.Text = "";
            txtpname.Text = "";
            txtnic.Text = "";
            txtcnumber.Text = "";
            txtadd.Text = "";
            txtmail.Text = "";



        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void btnre_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

          


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnup_Click(object sender, EventArgs e)
        {

        }

        private void btndelete_Click(object sender, EventArgs e)
        {

        }
    }
}
