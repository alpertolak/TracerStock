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
    public partial class Page_Product : Form
    {
        public Page_Product()
        {
            InitializeComponent();
        }

        private void Page_Product_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Logic_Proccess_Product.getProduds();

            Super_User_Name.Text = Entity.User_Session_Model.User_Nick; // kullanıcı adı yazdırlıyor.
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

        private void Product_Setting_Click(object sender, EventArgs e)
        {
            int row_Index = dataGridView1.SelectedCells[0].RowIndex;
            int product_Id =Convert.ToInt32(dataGridView1.Rows[row_Index].Cells[0].Value);
            Page_Product_Mng product_mng = new Page_Product_Mng(product_Id); //ürün detaylarını görmek için id diğer sayfaya gönderiliyor.
            this.Hide();
            product_mng.Show();

            
        }

        private void Product_Insert_Click(object sender, EventArgs e)
        {
            Page_Product_Insert insert = new Page_Product_Insert();
            insert.Show();
            this.Hide();
        }

        private void Waiting_Sells_Click(object sender, EventArgs e)
        {
            Page_Product_Visa visa = new Page_Product_Visa();
            visa.Show();
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
