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
    public partial class dept : Form
    {
        functions Con;
        int Key = 0;
        public dept()
        {
            InitializeComponent();
            Con = new functions();
            ShowDepts();
        }

        private void dept_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        
        private void ShowDepts()
        {
            String Query = "select depId AS رقم_القسم, depname As اسم_القسم from Department";
            Deptlist.DataSource = Con.GetData(Query);
        }
        private void Addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DeptNameTb.Text == " ")
                {
                    MessageBox.Show("Missing Data");
                }
                else
                {
                    string Dep = DeptNameTb.Text;
                    string Query = "insert into Department values (N'" + DeptNameTb.Text + "')";
                    Con.SetData(Query);
                    ShowDepts();
                    MessageBox.Show("تم اضافة القسم بنجاح");
                    DeptNameTb.Text = " ";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Updbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DeptNameTb.Text == "")
                {
                    MessageBox.Show("Missing Data");
                }
                else
                {
                    string Dep = DeptNameTb.Text;
                    string Query = "update Department set depname = N'{0}' where depId = {1};";
                    Query = string.Format(Query, DeptNameTb.Text,Key);
                    Con.SetData(Query);
                    ShowDepts();
                    MessageBox.Show("تم التعديل بنجاح");
                    DeptNameTb.Text = " ";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       
        private void Deptlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Deptlist.SelectedRows.Count > 0)
            {
                DeptNameTb.Text = Deptlist.SelectedRows[0].Cells[1].Value.ToString();
                if (DeptNameTb.Text == "")
                {
                    Key = 0;
                }
                else
                {
                    Key = Convert.ToInt32(Deptlist.SelectedRows[0].Cells[0].Value.ToString());
                }
            }
            else
            {
                MessageBox.Show("Please select a row first!");
            }


        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Key == 0)
                {
                    MessageBox.Show("من فضلك  😊 حدد القسم اولا  ");
                }
                else
                {
                    string Query = "delete from Department where depId= {0};";
                    Query = string.Format(Query, Key);
                    Con.SetData(Query);
                    ShowDepts();
                    MessageBox.Show("تم الحذف بنجاح");
                    DeptNameTb.Text = " ";
                    Key = 0; // إعادة تعيين المفتاح
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void EmpLab_Click(object sender, EventArgs e)
        {
            employ Obj = new employ();
            Obj.Show();
            this.Hide();
        }

        private void sallab_Click(object sender, EventArgs e)
        {
            salaries Obj = new salaries();
            Obj.Show();
            this.Hide();

        }

        private void label9_Click(object sender, EventArgs e)
        {
            login Obj = new login();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
