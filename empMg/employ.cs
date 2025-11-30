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
    public partial class employ : Form
    {
        functions Con;
        public employ()
        {
            InitializeComponent();
            Con = new functions();
            ShowEmp();
            GetDept();
        }
        private void ShowEmp()
        {
           // String Query = "SELECT empId AS رقم, empname AS اسم_الموظف, empgn AS الجنس, empdep AS رقم_الادارة, empdds AS تاريخ_الميلاد, empdate AS الانضمام, empsal AS الراتب FROM Employee";
            String Query = @"SELECT empId AS رقم, empname AS اسم_الموظف, empgn AS الجنس, empdep AS رقم_الادارة, FORMAT(empdds, 'yyyy-MM-dd') AS تاريخ_الميلاد, FORMAT(empdate, 'yyyy-MM-dd') AS الانضمام, empsal AS الراتب FROM Employee";


            // String Query = "select * from emp1";
            Emplist.DataSource = Con.GetData(Query);
        }
        private void GetDept()
        {
            /*string Query = "select * from Department";
            DeptCh.DisplayMember = Con.GetData(Query).Columns["depname"].ToString();
            DeptCh.ValueMember = Con.GetData(Query).Columns["depId"].ToString();
            DeptCh.DataSource = Con.GetData(Query);*/

            string Query = "select * from Department";
            DataTable dt = Con.GetData(Query);
            DeptCh.DataSource = dt;
            DeptCh.DisplayMember = "depname"; // اسم العمود لعرضه
            DeptCh.ValueMember = "depId";     // اسم العمود للقيمة
            DeptCh.SelectedIndex = -1;        // لا نختار أي عنصر افتراضياً
        

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void employ_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Empname.Text == "" || Gench.SelectedIndex == -1 || DaySalTb.Text == "")
                {
                    MessageBox.Show("Missing Data");
                }
                else
                {
                    string name = Empname.Text;
                    string Gender = Gench.SelectedItem.ToString();
                    if (DeptCh.SelectedIndex == -1)
                    {
                        MessageBox.Show("الرجاء اختيار القسم أولاً");
                        return; // نخرج من الدالة لمنع الخطأ
                    }

                    string Dep = DeptCh.SelectedValue.ToString();
                    //string Dep = DeptCh.SelectedValue.ToString();
                    string DOB = DatOBtb.Value.ToString("yyyy-MM-dd");
                    string Jdat = jDate.Value.ToString("yyyy-MM-dd");
                    int salary = Convert.ToInt32(DaySalTb.Text);
                    
                    string Query = "insert into Employee values (N'" + name + "', N'" + Gender + "', N'" + Dep + "', '" + DOB + "', '" + Jdat + "', " + salary + ")";

                    Con.SetData(Query);
                    ShowEmp();
                    MessageBox.Show("تم اضافة الموظف بنجاح");
                    Empname.Text = " ";
                    DaySalTb.Text = " ";
                    Gench.SelectedIndex = -1;
                    DeptCh.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        int Key = 0;
        private void Emplist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            Empname.Text = Emplist.SelectedRows[0].Cells[1].Value.ToString();
            Gench.Text = Emplist.SelectedRows[0].Cells[2].Value.ToString();
            DeptCh.SelectedValue = Emplist.SelectedRows[0].Cells[3].Value.ToString();
            DatOBtb.Text = Emplist.SelectedRows[0].Cells[4].Value.ToString();
            jDate.Text = Emplist.SelectedRows[0].Cells[5].Value.ToString();
            DaySalTb.Text = Emplist.SelectedRows[0].Cells[6].Value.ToString();
        
            if (Empname.Text == "")
                {
                    Key = 0;
                }
                else
                {
                    Key = Convert.ToInt32(Emplist.SelectedRows[0].Cells[0].Value.ToString());
                }
            
            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void delbutn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Key == 0)
                {
                    MessageBox.Show("Missing Data");
                }
                else
                {
                 
                    string Query = "delete from Employee where empId = {0}";
                    Query = string.Format(Query, Key);
                    Con.SetData(Query);
                    ShowEmp();
                    MessageBox.Show("تم حذف الموظف بنجاح");
                    Empname.Text = "";
                    DaySalTb.Text = "";
                    Gench.SelectedIndex = -1;
                    DeptCh.SelectedIndex = -1;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UbdatBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // التحقق من الحقول المفقودة
                if (Empname.Text == "" || Gench.SelectedIndex == -1 || DaySalTb.Text == "")
                {
                    MessageBox.Show("بعض البيانات مفقودة. يرجى تعبئة جميع الحقول المطلوبة.");
                }
                else
                {
                    // قراءة القيم من الحقول
                    string name = Empname.Text; // اسم الموظف
                    string gender = Gench.SelectedItem.ToString(); // الجنس
                    string department = DeptCh.SelectedValue.ToString(); // القسم
                    string dateOfBirth = DatOBtb.Value.ToString("yyyy-MM-dd"); // تاريخ الميلاد
                    string joiningDate = jDate.Value.ToString("yyyy-MM-dd"); // تاريخ الانضمام
                    int salary = Convert.ToInt32(DaySalTb.Text); // الراتب اليومي

                    // صياغة استعلام التعديل
                    string query = "UPDATE Employee SET empname = N'{0}', empgn = N'{1}', empdep = N'{2}', empdds = '{3}', empdate = '{4}', empsal = {5} WHERE empId = {6}";
                    query = string.Format(query, name, gender, department, dateOfBirth, joiningDate, salary, Key);

                    // تنفيذ الاستعلام
                    Con.SetData(query);

                    // تحديث بيانات الموظفين في الواجهة
                    ShowEmp();

                    // عرض رسالة تأكيد
                    MessageBox.Show("تم تعديل بيانات الموظف بنجاح!");

                    // إعادة تعيين الحقول إلى حالتها الافتراضية
                    Empname.Text = "";
                    DaySalTb.Text = "";
                    Gench.SelectedIndex = -1;
                    DeptCh.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                // عرض رسالة الخطأ للمستخدم
                MessageBox.Show("حدث خطأ أثناء تحديث البيانات: " + ex.Message);
            }

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            login Obj = new login();
            Obj.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            salaries Obj = new salaries();
            Obj.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            dept Obj = new dept();
            Obj.Show();
            this.Hide();
        }
    }
}
