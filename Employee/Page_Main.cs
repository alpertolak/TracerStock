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
    public partial class Page_Main : Form
    {
        public Page_Main()
        {
            InitializeComponent();
        }

        private void mainPage_Click(object sender, EventArgs e)
        {
            
        }

        private void Page_Sel_Click(object sender, EventArgs e)
        {
            Page_Sell sell = new Page_Sell();
            sell.Show();
            this.Hide();
        }


        private void Page_Main_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = logic.Employee.Emp_Proccess_Product.get_Visas_ByUserId(Entity.User_Session_Model.User_ID);
            Super_User_Name.Text = Entity.User_Session_Model.User_Nick; // kullanıcı adı yazdırlıyor.
        }

        private void User_Profile_Click(object sender, EventArgs e)
        {
            TracerStock.Menegament.User_Settings user = new Menegament.User_Settings(Entity.User_Session_Model.User_ID);
            user.Show();
            this.Hide();
        }

        private void Report_Click(object sender, EventArgs e)
        {
            Page_Report2 rp = new Page_Report2();
            rp.Show();
            this.Hide();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            Login.LoginPage page = new Login.LoginPage();
            this.Hide();
            page.Show();
        }
    }
}
