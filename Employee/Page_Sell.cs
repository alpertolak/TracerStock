using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TracerStock.Employee
{
    public partial class Page_Sell : Form
    {
        public Page_Sell()
        {
            InitializeComponent();
        }

        Slim4DesktopEntities DB = new Slim4DesktopEntities(); //veri tablolarının kullanabilmek için oluşturulan nesne

        private void Page_Sell_Load(object sender, EventArgs e)
        {
            Super_User_Name.Text = Entity.User_Session_Model.User_Nick; // kullanıcı adı yazdırlıyor.

            var Product = (from x in DB.Product //veri tabanından katagoriler çekiliyor.
                            select new
                            {
                                x.Product_ID,
                                x.Product_Name,
                            }).ToList();
            Product_List.ValueMember = "Product_ID";
            Product_List.DisplayMember = "Product_Name";
            Product_List.DataSource = Product;
        }

        private void Create_Sell_Click(object sender, EventArgs e)
        {
            Product prod = logic.Logic_Proccess_Product.getProduct_ById(Convert.ToInt32(Product_List.SelectedValue));

            logic.Logic_Proccess_Visa.insertVisa(prod.Product_ID, prod.Product_Name,Convert.ToInt32(prod.Product_Category_ID),Convert.ToInt32(Sell_Amount.Text),
                Entity.User_Session_Model.User_ID, Entity.User_Session_Model.User_Nick, Client_Name.Text);
            Proccess_Info.Text = "Satış Talebi oluşturulmuştur";
        }

        private void Page_Report_Click(object sender, EventArgs e)
        {
            Page_Report2 page = new Page_Report2();
            this.Hide();
            page.Show();
        }

        private void mainPage_Click(object sender, EventArgs e)
        {
            TracerStock.Employee.Page_Main page = new Page_Main();
            page.Show();
            this.Hide();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            Login.LoginPage page = new Login.LoginPage();
            this.Hide();
            page.Show();
        }

        private void User_Profile_Click(object sender, EventArgs e)
        {
            Menegament.User_Settings user = new Menegament.User_Settings(Entity.User_Session_Model.User_ID);
            this.Hide();
            user.Show();
        }
    }
}
