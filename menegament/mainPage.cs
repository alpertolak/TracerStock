using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL2;
using Entity;

namespace TracerStock.Menegament
{
    public partial class mainPage : Form
    {
        public mainPage()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Super_User_Name_Click(object sender, EventArgs e)
        {

        }

        private void mainPage_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DAL2.DB_CRUD_Product.CriticalStock(); // kritik sok verileri çekiliyor.
            Super_User_Name.Text = User_Session_Model.User_Nick; // kullanıcı adı çekiliyor.
        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Page_Main_Click(object sender, EventArgs e)
        {
            mainPage main = new mainPage();
            this.Hide();
            main.Show();
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

        private void Product_Setting_Click(object sender, EventArgs e)
        {
            int row_Index = dataGridView1.SelectedCells[0].RowIndex;
            int product_Id = Convert.ToInt32(dataGridView1.Rows[row_Index].Cells[0].Value);
            TracerStock.Menegament.Page_Product.Page_Product_Mng product_Mng = new Page_Product.Page_Product_Mng(product_Id);
            product_Mng.Show();
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
