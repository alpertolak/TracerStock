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
    public partial class Page_Report2 : Form
    {
        public Page_Report2()
        {
            InitializeComponent();
        }

        private void mainPage_Click(object sender, EventArgs e)
        {
            Page_Main main = new Page_Main();
            this.Hide();
            main.Show();
        }

        private void Page_Sel_Click(object sender, EventArgs e)
        {
            Page_Sell sell = new Page_Sell();
            sell.Show();
            this.Hide();
        }

        private void User_Profile_Click(object sender, EventArgs e)
        {
            TracerStock.Menegament.User_Settings user = new Menegament.User_Settings(Entity.User_Session_Model.User_ID);
            user.Show();
            this.Hide();
        }

        private void Result_Click(object sender, EventArgs e)
        {
            Page_Report.Page_Report_Result report_Result = new Page_Report.Page_Report_Result(Visa_State.Text);
            this.Hide();
            report_Result.Show();
        }

        private void Page_Report2_Load(object sender, EventArgs e)
        {
            Super_User_Name.Text = Entity.User_Session_Model.User_Nick; //kullanıcı adı yazdırlıyor.
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            Login.LoginPage page = new Login.LoginPage();
            this.Hide();
            page.Show();
        }
    }
}
