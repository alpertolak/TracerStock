using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TracerStock.Menegament;
using TracerStock.Menegament.Page_Product;

namespace TracerStock.menegament.Page_Employee
{
    public partial class Page_Employee_Insert : Form
    {
        public Page_Employee_Insert()
        {
            InitializeComponent();
        }

        private void Page_Employee_Insert_Load(object sender, EventArgs e)
        {
            Super_User_Name.Text = Entity.User_Session_Model.User_Nick; // kullanıcı adı yazdırlıyor.
        }

        private void Insert_Employee_Click(object sender, EventArgs e)
        {
            logic.Logic_Proccess_User.insertUser(User_Name.Text, User_Last_Name.Text, User_Nick.Text, User_Password.Text,
                                                 User_Auth.Text, User_Phone_Number.Text);
            Proccess_Info.Text = "kullanıcı eklenmiştir";
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
            TracerStock.Menegament.Page_Report report = new Menegament.Page_Report();
            this.Hide();
            report.Show();
        }

        private void Page_Employee_Click(object sender, EventArgs e)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
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
