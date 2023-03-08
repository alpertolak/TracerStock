using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TracerStock.menegament.Page_Report
{
    public partial class Page_Report_Result_Sell : Form
    {
        private int user_Id;
        private string visa_State;

        public Page_Report_Result_Sell(int user_Id, String visa_State)
        {
            this.user_Id = user_Id;
            this.visa_State = visa_State;
            InitializeComponent();
        }

        private void Page_Report_Result_Load(object sender, EventArgs e)
        {
            Super_User_Name.Text = Entity.User_Session_Model.User_Nick; // kullanıcı adı yazdırlıyor.

            if (visa_State == "") dataGridView1.DataSource = logic.Employee.Emp_Proccess_Product.get_Visas_ByUserId(user_Id);
            else dataGridView1.DataSource = logic.Employee.Emp_Proccess_Product.get_Visas_ByStateByUserId(user_Id, visa_State);

        }

        private void Page_Main_Click(object sender, EventArgs e)
        {
            TracerStock.Menegament.mainPage page = new Menegament.mainPage();
            this.Hide();
            page.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TracerStock.Menegament.Page_Product.Page_Product page = new Menegament.Page_Product.Page_Product();
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
            Menegament.User_Settings page = new Menegament.User_Settings(Entity.User_Session_Model.User_ID);
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
