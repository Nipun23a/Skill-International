using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skills_International 
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtmail.Text = "";
            txtpass.Text = "";

        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            string mail = txtmail.Text;
            string pass = txtpass.Text;

            if (mail == "admin@gmail.com" &&
                pass == "skills@123")

            {
                MessageBox.Show("login success");
                this.Hide();
                Registration obj = new Registration();
                obj.Show();
            }
            else
            {
                MessageBox.Show("Invalid Details");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e) { 
            Application.Exit();
        }
    }
    
}
