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

namespace TracerStock.Menegament.Page_Product
{
    public partial class Page_Product_Visa_Mng : Form
    {
        private int visa_ID;
        public Page_Product_Visa_Mng(int visa_ID)
        {
            this.visa_ID = visa_ID;
            InitializeComponent();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            logic.Logic_Proccess_Visa.update_Visa(visa_ID, "Onaylandı");
            Decide_Info.Text = "Satış Talebi Onaylandı";
        }

        private void Page_Product_Visa_Mng_Load(object sender, EventArgs e)
        {
            Super_User_Name.Text = Entity.User_Session_Model.User_Nick; // kullanıcı adı yazdırlıyor.

            Visa body = logic.Logic_Proccess_Visa.getVisa_ById(visa_ID);

            Product_ID.Text = body.Visa_Product_ID.ToString(); // gelen veriler eşitleniyor.
            Product_Name.Text = body.Visa_Product_Name.ToString();
            Product_Owner.Text = DAL2.DB_CRUD_Product.GetOwner_ById_FromDB(Convert.ToInt32(body.Visa_Product_ID)).ToString(); // karışık
            Product_Category.Text = body.Visa_Product_Category_ID.ToString();
            Sender_ID.Text = body.Visa_Sender_ID.ToString();
            Sender_Name.Text = body.Visa_Sender_Name.ToString();
            Product_Stock_Amount.Text = body.Visa_Product_Amount.ToString();
            Sell_Date.Text = body.Visa_Send_Date.ToString();
            Product_Stock_State.Text = body.Visa_State.ToString();
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

        private void Denied_Click(object sender, EventArgs e)
        {
            logic.Logic_Proccess_Visa.update_Visa(visa_ID, "Reddedildi");
            Decide_Info.Text = "Satış Talebi Reddedildi";
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            Login.LoginPage page = new Login.LoginPage();
            this.Hide();
            page.Show();
        }
    }
}
