using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using logic;

namespace TracerStock.Menegament.Page_Product
{
    public partial class Page_Product_Insert : Form
    {
        Slim4DesktopEntities DB = new Slim4DesktopEntities(); //veri tablolarının kullanabilmek için oluşturulan nesne

        public Page_Product_Insert()
        {
            InitializeComponent();
        }

        private void Page_Product_Insert_Load(object sender, EventArgs e)
        {
            Super_User_Name.Text = Entity.User_Session_Model.User_Nick; // kullanıcı adı yazdırlıyor.

            var category = (from x in DB.Category //veri tabanından katagoriler çekiliyor.
                            select new
                            {
                                x.Category_ID,
                                x.Category_Name,
                            }).ToList();
            Product_Category.ValueMember = "Category_ID";
            Product_Category.DisplayMember = "Category_Name";
            Product_Category.DataSource = category;
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

        private void Save_Change_Click(object sender, EventArgs e)
        {
            Logic_Proccess_Product.insertProduct(Product_Name.Text, Product_Owner.Text, Convert.ToInt32(Product_Category.SelectedValue.ToString()), Convert.ToInt32((Product_Stock_Amount.Text)));
            Save_Info.Text = "Ürün veri tabanına eklenmiştir";
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
