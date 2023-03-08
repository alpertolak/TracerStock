using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TracerStock.Employee.Page_Report
{
    public partial class Page_Report_Result : Form
    {
        private string visa_State;
        public Page_Report_Result(String visa_State)
        {
            this.visa_State = visa_State;
            InitializeComponent();
        }

        private void mainPage_Click(object sender, EventArgs e)
        {
            Page_Main page = new Page_Main();
            page.Show();
            this.Hide();

        }

        private void Page_Sel_Click(object sender, EventArgs e)
        {
            Page_Sell sell = new Page_Sell();
            this.Hide();
            sell.Show();
        }
        private void User_Profile_Click(object sender, EventArgs e)
        {
            TracerStock.Menegament.User_Settings user = new Menegament.User_Settings(Entity.User_Session_Model.User_ID);
            this.Hide();
            user.Show();
        }

        private void Page_Report_Result_Load(object sender, EventArgs e)
        {
            Super_User_Name.Text = Entity.User_Session_Model.User_Nick; // kullanıcı adı yazdırlıyor.
            if (visa_State == "")
            {
                dataGridView1.DataSource = logic.Logic_Proccess_Visa.get_Visas_ByUserId(Entity.User_Session_Model.User_ID);
            }
            else
            {
                dataGridView1.DataSource = logic.Employee.Emp_Proccess_Product.
                    get_Visas_ByStateByUserId(Entity.User_Session_Model.User_ID, visa_State);
            }
        }

        private void Page_Report_Click(object sender, EventArgs e)
        {
            Page_Report2 page = new Page_Report2();
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
