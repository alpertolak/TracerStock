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

namespace TracerStock.menegament.Page_Report
{
    public partial class Page_Report_Result_Access : Form
    {
        private string user_Nick;

        public Page_Report_Result_Access(String user_Nick)
        {
            this.user_Nick = user_Nick;
            InitializeComponent();
        }

        private void Page_Main_Click(object sender, EventArgs e)
        {
            mainPage main = new mainPage();
            this.Hide();
            main.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menegament.Page_Product.Page_Product page = new Menegament.Page_Product.Page_Product();
            this.Hide();
            page.Show();
        }

        private void Page_Report_Click(object sender, EventArgs e)
        {
            Menegament.Page_Report page = new Menegament.Page_Report();
            this.Hide();
            page.Show();
        }

        private void Page_Employee_Click(object sender, EventArgs e)
        {
            Menegament.Page_Employee page = new Menegament.Page_Employee();
            this.Hide();
            page.Show();
        }

        private void User_Profile_Click(object sender, EventArgs e)
        {
            User_Settings page = new User_Settings(Entity.User_Session_Model.User_ID);
            this.Hide();
            page.Show();
        }

        private void Page_Report_Result_Access_Load(object sender, EventArgs e)
        {
            Super_User_Name.Text = Entity.User_Session_Model.User_Nick; // kullanıcı adı yazdırlıyor.

            dataGridView1.DataSource = logic.Logic_Proccess_User.get_User_Access_ByNick(user_Nick);
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            Login.LoginPage page = new Login.LoginPage();
            this.Hide();
            page.Show();
        }
    }
}
