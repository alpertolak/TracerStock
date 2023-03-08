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

namespace TracerStock.Menegament
{
    public partial class Page_Report : Form
    {
        public Page_Report()
        {
            InitializeComponent();
        }

        Slim4DesktopEntities DB = new Slim4DesktopEntities(); //veri tablolarının kullanabilmek için oluşturulan nesne

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
        private void Page_Employee_Click(object sender, EventArgs e)
        {
            Page_Employee employee = new Page_Employee();
            this.Hide();
            employee.Show();
        }

        private void Report_Click(object sender, EventArgs e)
        {
            Page_Report report = new Page_Report();
            this.Hide();
            report.Show();

            
        }
        private void User_Profile_Click(object sender, EventArgs e)
        {
            User_Settings user = new User_Settings(Entity.User_Session_Model.User_ID);
            this.Hide();
            user.Show();
        }

        private void Page_Report_Load(object sender, EventArgs e)
        {
            Super_User_Name.Text = Entity.User_Session_Model.User_Nick; // kullanıcı adı yazdırlıyor.

            var user = (from x in DB.Users //veri tabanından katagoriler çekiliyor.
                            select new
                            {
                                x.User_ID,
                                x.User_Nick,
                            }).ToList();
            Users_List_Sell.ValueMember = "User_ID";
            Users_List_Sell.DisplayMember = "User_Nick";
            Users_List_Sell.DataSource = user;

            var user2 = (from x in DB.Users //veri tabanından katagoriler çekiliyor.
                            select new
                            {
                                x.User_ID,
                                x.User_Nick,
                            }).ToList();
            User_List_Access.ValueMember = "User_ID";
            User_List_Access.DisplayMember = "User_Nick";
            User_List_Access.DataSource = user2;
        }

        private void Result_Sell_Click(object sender, EventArgs e)
        {
            menegament.Page_Report.Page_Report_Result_Sell sell = new menegament.Page_Report.Page_Report_Result_Sell(Convert.ToInt32(Users_List_Sell.SelectedValue),Visa_State.Text);
            this.Hide();
            sell.Show();
        }

        private void Result_Access_Click(object sender, EventArgs e)
        {
            menegament.Page_Report.Page_Report_Result_Access page = new menegament.Page_Report.Page_Report_Result_Access(User_List_Access.Text);
            this.Hide();
            page.Show();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            Login.LoginPage page = new Login.LoginPage();
            this.Hide();
            page.Show();
        }
    }
}
