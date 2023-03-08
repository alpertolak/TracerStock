
namespace TracerStock.management.Page_Employee
{
    partial class Page_Employee_Mng
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel3 = new System.Windows.Forms.Panel();
            this.User_Profile = new System.Windows.Forms.Button();
            this.LogOut = new System.Windows.Forms.Button();
            this.Super_User_Name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Page_Report = new System.Windows.Forms.Button();
            this.Page_Product = new System.Windows.Forms.Button();
            this.Page_Main = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.User_Auth_Display = new System.Windows.Forms.Label();
            this.Product_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.User_Auth = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.User_Phone_Number = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.User_Last_Name = new System.Windows.Forms.TextBox();
            this.User_Name = new System.Windows.Forms.TextBox();
            this.Proccess_Info = new System.Windows.Forms.Label();
            this.Delete_This_User = new System.Windows.Forms.Button();
            this.Save_Change = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.User_Nick = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.User_Profile);
            this.panel3.Controls.Add(this.LogOut);
            this.panel3.Controls.Add(this.Super_User_Name);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(622, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(166, 96);
            this.panel3.TabIndex = 17;
            // 
            // User_Profile
            // 
            this.User_Profile.Location = new System.Drawing.Point(4, 62);
            this.User_Profile.Name = "User_Profile";
            this.User_Profile.Size = new System.Drawing.Size(99, 26);
            this.User_Profile.TabIndex = 1;
            this.User_Profile.Text = "Profil";
            this.User_Profile.UseVisualStyleBackColor = true;
            this.User_Profile.Click += new System.EventHandler(this.User_Profile_Click);
            // 
            // LogOut
            // 
            this.LogOut.Location = new System.Drawing.Point(101, 62);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(60, 26);
            this.LogOut.TabIndex = 2;
            this.LogOut.Text = "Log Out";
            this.LogOut.UseVisualStyleBackColor = true;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // Super_User_Name
            // 
            this.Super_User_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Super_User_Name.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Super_User_Name.Location = new System.Drawing.Point(58, 13);
            this.Super_User_Name.Name = "Super_User_Name";
            this.Super_User_Name.Size = new System.Drawing.Size(103, 19);
            this.Super_User_Name.TabIndex = 1;
            this.Super_User_Name.Text = "Default";
            this.Super_User_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.Page_Report);
            this.panel2.Controls.Add(this.Page_Product);
            this.panel2.Controls.Add(this.Page_Main);
            this.panel2.Location = new System.Drawing.Point(12, 114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(146, 324);
            this.panel2.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Çalşan Listesi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Page_Report
            // 
            this.Page_Report.Location = new System.Drawing.Point(8, 67);
            this.Page_Report.Name = "Page_Report";
            this.Page_Report.Size = new System.Drawing.Size(131, 23);
            this.Page_Report.TabIndex = 5;
            this.Page_Report.Text = "Raporlama İşlemleri";
            this.Page_Report.UseVisualStyleBackColor = true;
            this.Page_Report.Click += new System.EventHandler(this.Page_Report_Click);
            // 
            // Page_Product
            // 
            this.Page_Product.Location = new System.Drawing.Point(8, 38);
            this.Page_Product.Name = "Page_Product";
            this.Page_Product.Size = new System.Drawing.Size(131, 23);
            this.Page_Product.TabIndex = 4;
            this.Page_Product.Text = "Ürün İşlemleri";
            this.Page_Product.UseVisualStyleBackColor = true;
            this.Page_Product.Click += new System.EventHandler(this.Page_Product_Click);
            // 
            // Page_Main
            // 
            this.Page_Main.Location = new System.Drawing.Point(8, 8);
            this.Page_Main.Name = "Page_Main";
            this.Page_Main.Size = new System.Drawing.Size(131, 24);
            this.Page_Main.TabIndex = 3;
            this.Page_Main.Text = "Anasayfa";
            this.Page_Main.UseVisualStyleBackColor = true;
            this.Page_Main.Click += new System.EventHandler(this.Page_Main_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label);
            this.panel1.Location = new System.Drawing.Point(164, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 96);
            this.panel1.TabIndex = 15;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label.ForeColor = System.Drawing.Color.Indigo;
            this.label.Location = new System.Drawing.Point(13, 39);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(127, 24);
            this.label.TabIndex = 4;
            this.label.Text = "Çalışan Listesi";
            // 
            // User_Auth_Display
            // 
            this.User_Auth_Display.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.User_Auth_Display.Location = new System.Drawing.Point(377, 229);
            this.User_Auth_Display.Name = "User_Auth_Display";
            this.User_Auth_Display.Size = new System.Drawing.Size(125, 21);
            this.User_Auth_Display.TabIndex = 47;
            this.User_Auth_Display.Text = "default";
            this.User_Auth_Display.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Product_ID
            // 
            this.Product_ID.Location = new System.Drawing.Point(271, 122);
            this.Product_ID.Name = "Product_ID";
            this.Product_ID.ReadOnly = true;
            this.Product_ID.Size = new System.Drawing.Size(100, 20);
            this.Product_ID.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Kullanıcı ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "kullanıcı Ad";
            // 
            // User_Auth
            // 
            this.User_Auth.FormattingEnabled = true;
            this.User_Auth.Items.AddRange(new object[] {
            "Müdür",
            "Çalışan"});
            this.User_Auth.Location = new System.Drawing.Point(271, 229);
            this.User_Auth.Name = "User_Auth";
            this.User_Auth.Size = new System.Drawing.Size(100, 21);
            this.User_Auth.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "kullanıcı Soyad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(225, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Yetkisi";
            // 
            // User_Phone_Number
            // 
            this.User_Phone_Number.Location = new System.Drawing.Point(271, 256);
            this.User_Phone_Number.Name = "User_Phone_Number";
            this.User_Phone_Number.Size = new System.Drawing.Size(100, 20);
            this.User_Phone_Number.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(173, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Telefon Numarası";
            // 
            // User_Last_Name
            // 
            this.User_Last_Name.Location = new System.Drawing.Point(271, 176);
            this.User_Last_Name.Name = "User_Last_Name";
            this.User_Last_Name.Size = new System.Drawing.Size(100, 20);
            this.User_Last_Name.TabIndex = 43;
            // 
            // User_Name
            // 
            this.User_Name.Location = new System.Drawing.Point(271, 148);
            this.User_Name.Name = "User_Name";
            this.User_Name.Size = new System.Drawing.Size(100, 20);
            this.User_Name.TabIndex = 42;
            // 
            // Proccess_Info
            // 
            this.Proccess_Info.AutoSize = true;
            this.Proccess_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Proccess_Info.Location = new System.Drawing.Point(418, 418);
            this.Proccess_Info.Name = "Proccess_Info";
            this.Proccess_Info.Size = new System.Drawing.Size(0, 17);
            this.Proccess_Info.TabIndex = 48;
            this.Proccess_Info.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Delete_This_User
            // 
            this.Delete_This_User.BackColor = System.Drawing.Color.LightCoral;
            this.Delete_This_User.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_This_User.Location = new System.Drawing.Point(164, 415);
            this.Delete_This_User.Name = "Delete_This_User";
            this.Delete_This_User.Size = new System.Drawing.Size(75, 23);
            this.Delete_This_User.TabIndex = 50;
            this.Delete_This_User.Text = "Kullanıcıyı sil";
            this.Delete_This_User.UseVisualStyleBackColor = false;
            this.Delete_This_User.Click += new System.EventHandler(this.Delete_This_User_Click);
            // 
            // Save_Change
            // 
            this.Save_Change.BackColor = System.Drawing.Color.GreenYellow;
            this.Save_Change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_Change.Location = new System.Drawing.Point(713, 415);
            this.Save_Change.Name = "Save_Change";
            this.Save_Change.Size = new System.Drawing.Size(75, 23);
            this.Save_Change.TabIndex = 49;
            this.Save_Change.Text = "Kaydet";
            this.Save_Change.UseVisualStyleBackColor = false;
            this.Save_Change.Click += new System.EventHandler(this.Save_Change_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TracerStock.Properties.Resources._2942813;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(166, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 51;
            this.label7.Text = "Kullanıcı Takma Ad";
            // 
            // User_Nick
            // 
            this.User_Nick.Location = new System.Drawing.Point(271, 203);
            this.User_Nick.Name = "User_Nick";
            this.User_Nick.Size = new System.Drawing.Size(100, 20);
            this.User_Nick.TabIndex = 52;
            // 
            // Page_Employee_Mng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.User_Nick);
            this.Controls.Add(this.Proccess_Info);
            this.Controls.Add(this.Delete_This_User);
            this.Controls.Add(this.Save_Change);
            this.Controls.Add(this.User_Auth_Display);
            this.Controls.Add(this.Product_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.User_Auth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.User_Phone_Number);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.User_Last_Name);
            this.Controls.Add(this.User_Name);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Page_Employee_Mng";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Page_Employee_Mng";
            this.Load += new System.EventHandler(this.Page_Employee_Mng_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button User_Profile;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.Label Super_User_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Page_Report;
        private System.Windows.Forms.Button Page_Product;
        private System.Windows.Forms.Button Page_Main;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label User_Auth_Display;
        private System.Windows.Forms.TextBox Product_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox User_Auth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox User_Phone_Number;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox User_Last_Name;
        private System.Windows.Forms.TextBox User_Name;
        private System.Windows.Forms.Label Proccess_Info;
        private System.Windows.Forms.Button Delete_This_User;
        private System.Windows.Forms.Button Save_Change;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox User_Nick;
    }
}