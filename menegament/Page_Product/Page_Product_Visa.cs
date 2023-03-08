using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using logic;

namespace TracerStock.Menegament.Page_Product
{
    public partial class Page_Product_Visa : Form
    {
        public Page_Product_Visa()
        {
            InitializeComponent();
        }

        private void Visa_Settings_Click(object sender, EventArgs e)
        {
            int row_Index = dataGridView1.SelectedCells[0].RowIndex;
            int visa_Id = Convert.ToInt32(dataGridView1.Rows[row_Index].Cells[0].Value);
            Page_Product_Visa_Mng visa_mng = new Page_Product_Visa_Mng(visa_Id); //ürün detaylarını görmek için id diğer sayfaya gönderiliyor.
            visa_mng.Show();
            this.Hide();
        }

        private void Page_Product_Visa_Load(object sender, EventArgs e)
        {
            Super_User_Name.Text = Entity.User_Session_Model.User_Nick; // kullanıcı adı yazdırlıyor.

            dataGridView1.DataSource = DAL2.DB_CRUD_Visa.getVisas_Waiting_FromDB();
        }

        private void Page_Main_Click(object sender, EventArgs e)
        {
            mainPage main = new mainPage();
            this.Hide();
            main.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Page_Product product = new Page_Product();
            this.Hide();
            product.Show();
        }

        private void Page_Report_Click(object sender, EventArgs e)
        {
            Page_Report report = new Page_Report();
            this.Hide();
            report.Show();
        }

        private void Page_Employee_Click(object sender, EventArgs e)
        {
            Page_Employee employee = new Page_Employee();
            this.Hide();
            employee.Show();
        }

        private void User_Profile_Click(object sender, EventArgs e)
        {
            User_Settings user = new User_Settings(Entity.User_Session_Model.User_ID);
            this.Hide();
            user.Show();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            Login.LoginPage page = new Login.LoginPage();
            this.Hide();
            page.Show();
        }
    }
}
