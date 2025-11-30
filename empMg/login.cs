using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace empMg
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            username.Text = "";
            pass.Text = "";
           
        }

        private void lognBtn_Click(object sender, EventArgs e)
        {
            if(username.Text == "" || pass.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else if(username.Text == "qusai" && pass.Text == "pass")
            {
                employ Obj = new employ();
                Obj.Show();
                this.Hide();

           
            }
            else
            {
                MessageBox.Show("خط في اسم المستخدم او الباسوورد");
            }

        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
