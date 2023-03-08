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
using TracerStock.Menegament;
using TracerStock.Menegament.Page_Product;

namespace TracerStock.management.Page_Employee
{
    public partial class Page_Employee_Mng : Form
    {
        private int user_Id;
        public Page_Employee_Mng(int user_Id)
        {
            this.user_Id = user_Id;
            InitializeComponent();
        }

        private void Save_Change_Click(object sender, EventArgs e)
        {
            logic.Logic_Proccess_User.updateUser_ById(user_Id,User_Name.Text,User_Last_Name.Text,User_Nick.Text,User_Auth.Text,User_Auth_Display.Text,User_Phone_Number.Text);
            Proccess_Info.Text = "kullanıcı verileri kaydedildi";
        }

        private void Page_Employee_Mng_Load(object sender, EventArgs e)
        {
            Super_User_Name.Text = Entity.User_Session_Model.User_Nick; // kullanıcı adı yazdırlıyor.

            Users body = Logic_Proccess_User.getUser_ById(user_Id);//DB_Crud işlemi çalıştırılarak veriler alınıyor.

            Product_ID.Text = body.User_ID.ToString();
            User_Name.Text = body.User_Name.ToString();
            User_Last_Name.Text = body.User_Last_Name.ToString();
            User_Nick.Text = body.User_Nick.ToString();
            User_Auth_Display.Text = body.User_Auth.ToString();
            User_Phone_Number.Text = body.User_Phone_Number.ToString();

        }

        private void Delete_This_User_Click(object sender, EventArgs e)
        {
            logic.Logic_Proccess_User.deleteUser_byId(user_Id);
            Proccess_Info.Text = "kullanıcı silinmiştir.";
        }

        private void Page_Main_Click(object sender, EventArgs e)
        {
            mainPage main = new mainPage();
            this.Hide();
            main.Show();
        }

        private void Page_Product_Click(object sender, EventArgs e)
        {
            TracerStock.Menegament.Page_Product.Page_Product product = new Page_Product();
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
            TracerStock.Menegament.Page_Employee employee = new Menegament.Page_Employee();
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
