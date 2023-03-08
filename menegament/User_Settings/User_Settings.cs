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

namespace TracerStock.Menegament
{
    public partial class User_Settings : Form
    {
        private int user_Id;
        public User_Settings(int user_Id)
        {
            this.user_Id = user_Id;
            InitializeComponent();
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

        private void User_Settings_Load(object sender, EventArgs e)
        {
            Super_User_Name.Text = Entity.User_Session_Model.User_Nick; // kullanıcı adı yazdırlıyor.

            Users body = Logic_Proccess_User.getUser_ById(this.user_Id);
            User_ID.Text = body.User_ID.ToString();
            User_Name.Text = body.User_Name.ToString();
            User_Last_Name.Text = body.User_Last_Name.ToString();
            User_Nick.Text = body.User_Nick.ToString();
            User_Auth.Text = body.User_Auth.ToString();
            User_Phone_Number.Text = body.User_Phone_Number.ToString();
        }

        private void Save_Chance_Click(object sender, EventArgs e) 
        { 
            Logic_Proccess_User.updateUser_ById(int.Parse(User_ID.Text), User_Name.Text, User_Last_Name.Text,
                                User_Nick.Text, User_Auth.Text,"", User_Phone_Number.Text); // yeni girilen kullanıcı bilgileri güncelleme için gönderiliyor.
            
            Save_Info.Text = "Bilgiler Kaydedildi"; // kaydedildi bilgisi kullanıcıya gösteriliyor.
        }

        private void User_Profile_Click(object sender, EventArgs e)
        {
            User_Settings user = new User_Settings(Entity.User_Session_Model.User_ID);
            this.Hide();
            user.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
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
