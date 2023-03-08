
namespace TracerStock.Menegament.Page_Product
{
    partial class Page_Product_Mng
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.User_Dash = new System.Windows.Forms.Panel();
            this.User_Profile = new System.Windows.Forms.Button();
            this.LogOut = new System.Windows.Forms.Button();
            this.Super_User_Name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Page_Employee = new System.Windows.Forms.Button();
            this.Page_Report = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Page_Main = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Product_ID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Product_Name = new System.Windows.Forms.TextBox();
            this.Product_Owner = new System.Windows.Forms.TextBox();
            this.Product_Stock_Amount = new System.Windows.Forms.TextBox();
            this.Product_Category = new System.Windows.Forms.ComboBox();
            this.Save_Change = new System.Windows.Forms.Button();
            this.Delete_This_Product = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Product_Stock_State = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Product_Category_Display = new System.Windows.Forms.Label();
            this.Proccess_Info = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.User_Dash.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TracerStock.Properties.Resources._2942813;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // User_Dash
            // 
            this.User_Dash.Controls.Add(this.User_Profile);
            this.User_Dash.Controls.Add(this.LogOut);
            this.User_Dash.Controls.Add(this.Super_User_Name);
            this.User_Dash.Controls.Add(this.label1);
            this.User_Dash.Location = new System.Drawing.Point(622, 12);
            this.User_Dash.Name = "User_Dash";
            this.User_Dash.Size = new System.Drawing.Size(166, 96);
            this.User_Dash.TabIndex = 20;
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
            this.panel2.Controls.Add(this.Page_Employee);
            this.panel2.Controls.Add(this.Page_Report);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.Page_Main);
            this.panel2.Location = new System.Drawing.Point(12, 114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(146, 324);
            this.panel2.TabIndex = 19;
            // 
            // Page_Employee
            // 
            this.Page_Employee.Location = new System.Drawing.Point(8, 96);
            this.Page_Employee.Name = "Page_Employee";
            this.Page_Employee.Size = new System.Drawing.Size(131, 23);
            this.Page_Employee.TabIndex = 6;
            this.Page_Employee.Text = "Çalşan Listesi";
            this.Page_Employee.UseVisualStyleBackColor = true;
            this.Page_Employee.Click += new System.EventHandler(this.Page_Employee_Click);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ürün İşlemleri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.panel1.TabIndex = 18;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label.ForeColor = System.Drawing.Color.Indigo;
            this.label.Location = new System.Drawing.Point(13, 39);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(107, 24);
            this.label.TabIndex = 4;
            this.label.Text = "Ürün Listesi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Ürün ID";
            // 
            // Product_ID
            // 
            this.Product_ID.Location = new System.Drawing.Point(93, 12);
            this.Product_ID.Name = "Product_ID";
            this.Product_ID.ReadOnly = true;
            this.Product_ID.Size = new System.Drawing.Size(100, 20);
            this.Product_ID.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Ürün Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Ürün marka";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Ürün kategori";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Stok sayı";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Product_Name
            // 
            this.Product_Name.Location = new System.Drawing.Point(93, 38);
            this.Product_Name.Name = "Product_Name";
            this.Product_Name.Size = new System.Drawing.Size(100, 20);
            this.Product_Name.TabIndex = 28;
            // 
            // Product_Owner
            // 
            this.Product_Owner.Location = new System.Drawing.Point(93, 66);
            this.Product_Owner.Name = "Product_Owner";
            this.Product_Owner.Size = new System.Drawing.Size(100, 20);
            this.Product_Owner.TabIndex = 29;
            // 
            // Product_Stock_Amount
            // 
            this.Product_Stock_Amount.Location = new System.Drawing.Point(93, 118);
            this.Product_Stock_Amount.Name = "Product_Stock_Amount";
            this.Product_Stock_Amount.Size = new System.Drawing.Size(100, 20);
            this.Product_Stock_Amount.TabIndex = 31;
            // 
            // Product_Category
            // 
            this.Product_Category.FormattingEnabled = true;
            this.Product_Category.Location = new System.Drawing.Point(93, 91);
            this.Product_Category.Name = "Product_Category";
            this.Product_Category.Size = new System.Drawing.Size(100, 21);
            this.Product_Category.TabIndex = 33;
            // 
            // Save_Change
            // 
            this.Save_Change.BackColor = System.Drawing.Color.GreenYellow;
            this.Save_Change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_Change.Location = new System.Drawing.Point(713, 415);
            this.Save_Change.Name = "Save_Change";
            this.Save_Change.Size = new System.Drawing.Size(75, 23);
            this.Save_Change.TabIndex = 34;
            this.Save_Change.Text = "Kaydet";
            this.Save_Change.UseVisualStyleBackColor = false;
            this.Save_Change.Click += new System.EventHandler(this.Save_Change_Click);
            // 
            // Delete_This_Product
            // 
            this.Delete_This_Product.BackColor = System.Drawing.Color.LightCoral;
            this.Delete_This_Product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_This_Product.Location = new System.Drawing.Point(164, 415);
            this.Delete_This_Product.Name = "Delete_This_Product";
            this.Delete_This_Product.Size = new System.Drawing.Size(75, 23);
            this.Delete_This_Product.TabIndex = 35;
            this.Delete_This_Product.Text = "Ürünü sil";
            this.Delete_This_Product.UseVisualStyleBackColor = false;
            this.Delete_This_Product.Click += new System.EventHandler(this.Delete_This_Product_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Stok durumu";
            // 
            // Product_Stock_State
            // 
            this.Product_Stock_State.Location = new System.Drawing.Point(93, 144);
            this.Product_Stock_State.Name = "Product_Stock_State";
            this.Product_Stock_State.ReadOnly = true;
            this.Product_Stock_State.Size = new System.Drawing.Size(100, 20);
            this.Product_Stock_State.TabIndex = 32;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Product_Category_Display);
            this.panel3.Controls.Add(this.Product_ID);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.Product_Category);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.Product_Stock_State);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.Product_Stock_Amount);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.Product_Owner);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.Product_Name);
            this.panel3.Location = new System.Drawing.Point(164, 114);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(624, 295);
            this.panel3.TabIndex = 36;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // Product_Category_Display
            // 
            this.Product_Category_Display.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Product_Category_Display.Location = new System.Drawing.Point(199, 91);
            this.Product_Category_Display.Name = "Product_Category_Display";
            this.Product_Category_Display.Size = new System.Drawing.Size(125, 21);
            this.Product_Category_Display.TabIndex = 34;
            this.Product_Category_Display.Text = "default";
            this.Product_Category_Display.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Proccess_Info
            // 
            this.Proccess_Info.AutoSize = true;
            this.Proccess_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Proccess_Info.Location = new System.Drawing.Point(408, 418);
            this.Proccess_Info.Name = "Proccess_Info";
            this.Proccess_Info.Size = new System.Drawing.Size(0, 17);
            this.Proccess_Info.TabIndex = 34;
            this.Proccess_Info.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Page_Product_Mng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Proccess_Info);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Delete_This_Product);
            this.Controls.Add(this.Save_Change);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.User_Dash);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Page_Product_Mng";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Page_Product_Mng";
            this.Load += new System.EventHandler(this.Page_Product_Mng_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.User_Dash.ResumeLayout(false);
            this.User_Dash.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel User_Dash;
        private System.Windows.Forms.Button User_Profile;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.Label Super_User_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Page_Employee;
        private System.Windows.Forms.Button Page_Report;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Page_Main;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Product_ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Product_Name;
        private System.Windows.Forms.TextBox Product_Owner;
        private System.Windows.Forms.TextBox Product_Stock_Amount;
        private System.Windows.Forms.ComboBox Product_Category;
        private System.Windows.Forms.Button Save_Change;
        private System.Windows.Forms.Button Delete_This_Product;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Product_Stock_State;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Proccess_Info;
        private System.Windows.Forms.Label Product_Category_Display;
    }
}