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
    public partial class Page_Product_Mng : Form
    {
        private int product_Id;
        Slim4DesktopEntities DB = new Slim4DesktopEntities(); //veri tablolarının kullanabilmek için oluşturulan nesne
        
        public Page_Product_Mng(int product_Id)
        {
            this.product_Id = product_Id;
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        
        private void Page_Product_Mng_Load(object sender, EventArgs e)
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


            Product body = Logic_Proccess_Product.getProduct_ById(product_Id);//DB_Crud işlemi çalıştırılarak veriler alınıyor.

            Product_ID.Text = body.Product_ID.ToString();
            Product_Name.Text = body.Product_Name.ToString();
            Product_Owner.Text = body.Product_Owner.ToString();
            Product_Category_Display.Text = DAL2.DB_CRUD_Product.GetCategory_ById_FromDB(Convert.ToInt32(body.Product_Category_ID)).Category_Name.ToString(); // karışık :)
            Product_Stock_Amount.Text = body.Product_Stock_Amount.ToString();
            Product_Stock_State.Text = body.Product_State.ToString();

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

        private void Save_Change_Click(object sender, EventArgs e)
        {
            Logic_Proccess_Product.updateProduct_ById(product_Id, Product_Name.Text, Product_Owner.Text,Convert.ToInt32(Product_Category.SelectedValue.ToString()), int.Parse(Product_Stock_Amount.Text));
            Proccess_Info.Text = "Ürün Kaydedildi";
        }

        private void Delete_This_Product_Click(object sender, EventArgs e)
        {
            logic.Logic_Proccess_Product.deleteProduct_ById(product_Id);
            Proccess_Info.Text = "Ürün Silindi";

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            Login.LoginPage page = new Login.LoginPage();
            this.Hide();
            page.Show();
        }
    }
}
