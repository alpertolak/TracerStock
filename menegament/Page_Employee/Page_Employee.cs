using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TracerStock.management.Page_Employee;

namespace TracerStock.Menegament
{
    public partial class Page_Employee : Form
    {
        public Page_Employee()
        {
            InitializeComponent();
        }

        private void Page_Main_Click(object sender, EventArgs e)
        {
            mainPage main = new mainPage();
            this.Hide();
            main.Show();
        }

        private void User_Profile_Click(object sender, EventArgs e)
        {
            User_Settings user = new User_Settings(Entity.User_Session_Model.User_ID);
            this.Hide();
            user.Show();
        }

        private void Page_Product_Click(object sender, EventArgs e)
        {
            Page_Product.Page_Product product = new Page_Product.Page_Product();
            this.Hide();
            product.Show();
        }

        private void Page_Report_Click(object sender, EventArgs e)
        {
            Page_Report report = new Page_Report();
            this.Hide();
            report.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Page_Employee employee = new Page_Employee();
            this.Hide();
            employee.Show();
        }

        private void Page_Employee_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DAL2.DB_CRUD_User.GetUsers_FromDB();

            Super_User_Name.Text = Entity.User_Session_Model.User_Nick; // kullanıcı adı yazdırlıyor.
        }

        private void Employee_Settings_Click(object sender, EventArgs e)
        {
            int row_Index = dataGridView1.SelectedCells[0].RowIndex;
            int user_Id = Convert.ToInt32(dataGridView1.Rows[row_Index].Cells[0].Value);
            Page_Employee_Mng page = new Page_Employee_Mng(user_Id);
            page.Show();
            this.Hide();
        }

        private void Insert_User_Click(object sender, EventArgs e)
        {
            TracerStock.menegament.Page_Employee.Page_Employee_Insert page_Employee_Insert = new menegament.Page_Employee.Page_Employee_Insert();
            page_Employee_Insert.Show();
            this.Hide();

        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            Login.LoginPage page = new Login.LoginPage();
            this.Hide();
            page.Show();
        }
    }
}
