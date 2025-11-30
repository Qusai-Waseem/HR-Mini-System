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
    public partial class salaries : Form
    {
        functions Con;
        public salaries()
        {
            InitializeComponent();
            Con = new functions();
            //MessageBox.Show(Con.GetData("SELECT 1 AS Test").Rows.Count.ToString());
            GetEmp();
            ShowSal();
            
        }
        private void GetEmp()
        {
            string Query = "select * from Employee";
            EmpCb.DisplayMember = Con.GetData(Query).Columns["empname"].ToString();
            EmpCb.ValueMember = Con.GetData(Query).Columns["empId"].ToString();
            EmpCb.DataSource = Con.GetData(Query);
        }
        int DSal = 0;
       
        string period = "";
        private void GetSal()
        {
            string Query = "select empsal from Employee where empId = {0}";
            Query = string.Format(Query, EmpCb.SelectedValue.ToString());
            foreach (DataRow dr in Con.GetData(Query).Rows)
            {
                DSal = Convert.ToInt32(dr["empsal"].ToString());

            }
            if(DaysTb.Text == "")
            {
                AmountSal.Text = "Rs " + (d * DSal);
            }
            else if(Convert.ToInt32(DaysTb.Text) > 31)
            {
                MessageBox.Show("Days can not be greater then 31");
            }
            else
            {
                d = Convert.ToInt32(DaysTb.Text);       
                AmountSal.Text = "Rs " + (d * DSal);
            }
        }
        private void ShowSal()
        {
            String Query = "SELECT scode AS S_ID, Employee AS رقم_الموظف, atten AS عدد_الايام, period AS الفترة, amount AS اجمالي_الراتب, CONVERT(VARCHAR(10), paydate, 23) AS التاريخ FROM Salaries";
            //String Query = "select scode As S_ID, Employee As رقم_الموظف, atten As عدد_الايام, period As الفترة, amount As اجمالي_الراتب, paydate As التاريخ from Salaries;";
            Sallist.DataSource = Con.GetData(Query);
        }
      
        private void salaries_Load(object sender, EventArgs e)
        {

        }
        int Key =0;
        private void Emplist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        
            //Key = Convert.ToInt32(Sallist.SelectedRows[0].Cells[0].Value.ToString());
         {
                try
                {
                    Key = Convert.ToInt32(Sallist.SelectedRows[0].Cells[0].Value.ToString());
                    EmpCb.SelectedValue = Sallist.SelectedRows[0].Cells[1].Value.ToString();
                    DaysTb.Text = Sallist.SelectedRows[0].Cells[2].Value.ToString();
                    periodTb.Text = Sallist.SelectedRows[0].Cells[3].Value.ToString();
                    AmountSal.Text = Sallist.SelectedRows[0].Cells[4].Value.ToString();
                }
                catch { }

         }

        private void delbutn_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            dept Obj = new dept();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {
            employ Obj = new employ();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void UbdatBtn_Click(object sender, EventArgs e)
        {

            try
            {
                if (Key == 0 || EmpCb.SelectedIndex == -1 || DaysTb.Text == "" || periodTb.Text == "")
                {
                    MessageBox.Show("من فضلك قم بتحديد السجل أولاً");
                }
                else
                {
                    string period = periodTb.Text;
                    int days = Convert.ToInt32(DaysTb.Text);
                    int amount = DSal * days;
                    string paydate = DateTime.Today.ToString("yyyy-MM-dd");

                    string Query = "update Salaries set employee={0}, atten={1}, period='{2}', amount={3}, paydate='{4}' where scode={5}";
                    Query = string.Format(Query, EmpCb.SelectedValue.ToString(), days, period, amount, paydate, Key);

                    Con.SetData(Query);
                    ShowSal();
                    MessageBox.Show("تم التعديل بنجاح ✔");

                    // مسح الحقول
                    DaysTb.Text = "";
                    AmountSal.Text = "";
                    Key = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        int d = 1;
        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmpCb.SelectedIndex == -1 || DaysTb.Text == "" || periodTb.Text == "")
                {
                    MessageBox.Show("Missing Data");
                }
                else
                {
                    // تحديد الفترة (الشهر والسنة)
                    period = periodTb.Value.Date.Month.ToString() + " " + periodTb.Value.Date.Year.ToString();

                    // عدد الأيام
                    int days = Convert.ToInt32(DaysTb.Text);

                    // حساب المبلغ الكلي بناءً على الراتب اليومي وعدد الأيام
                    int amount = DSal * days; // تم تعديل هذه السطر فقط ليضرب DSal في عدد الأيام

                    // صياغة الاستعلام
                    string Query = "insert into Salaries values ({0},{1},'{2}',{3},'{4}')";
                    Query = string.Format(Query, EmpCb.SelectedValue.ToString(), days, period, amount, DateTime.Today.ToString("yyyy - MM - dd") );

                    // تنفيذ الاستعلام
                    Con.SetData(Query);
                    ShowSal();
                    MessageBox.Show("Salary paid successfully!");

                    // إعادة تعيين الحقول
                    DaysTb.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void jDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DatOBtb_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DeptCh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void DaySalTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Empname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Gench_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EmpCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetSal();
        }

        private void logoutl_Click(object sender, EventArgs e)
        {
            login Obj = new login();
            Obj.Show();
            this.Hide();
        }

        private void delsal_Click(object sender, EventArgs e)
        {
            try
            {
                if (Key == 0)
                {
                    MessageBox.Show("من فضلك  😊 حدد القسم اولا  ");
                }
                else
                {
                    string Query = "delete from Salaries where scode= {0};";
                    Query = string.Format(Query, Key);
                    Con.SetData(Query);
                    ShowSal();
                    MessageBox.Show("تم الحذف بنجاح");
                 //   DeptNameTb.Text = " ";
                    Key = 0; // إعادة تعيين المفتاح
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
