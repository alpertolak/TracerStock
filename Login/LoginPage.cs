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

namespace TracerStock.Login
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void Login_Button_Click(object sender, EventArgs e)
        {

            Users user = Logic_Proccess_User.getUser_ByNick(User_Nick.Text); // user bilgileri veri tabanından çekiliyor.

            if (user.User_ID == 0) MessageBox.Show("kayıtlı kullanıcı bulunamadı.");
            else if (user.User_Nick != User_Nick.Text) MessageBox.Show("kullanıcı adı hatalıdır.");
            else if (user.User_Password != User_Password.Text) MessageBox.Show("parola hatalıdır.");
            else if (user.User_Nick == User_Nick.Text && user.User_Password == User_Password.Text)
            {
                //session bilgileri kaydediliyor.
                User_Session_Model.User_ID = user.User_ID;
                User_Session_Model.User_Name = user.User_Name;
                User_Session_Model.User_Last_Name = user.User_Last_Name;
                User_Session_Model.User_Nick = user.User_Nick;
                User_Session_Model.User_Auth = user.User_Auth;
                User_Session_Model.User_Password = user.User_Password;
                User_Session_Model.User_Phone_Number = user.User_Phone_Number;

                DAL2.DB_CRUD_Log.Access_Log_ToDB(); //giriş yapan kullanıcı veri tabanına kaydediliyor.

                if (user.User_Auth == "Çalışan") //yetki verisine göre sayfalara yönlendiriliyor.
                {
                    Employee.Page_Main main = new Employee.Page_Main();
                    this.Hide();
                    main.Show();
                }
                else
                {
                    Menegament.mainPage main = new Menegament.mainPage();
                    this.Hide();
                    main.Show();
                }
            }

            
        }
    }
}
