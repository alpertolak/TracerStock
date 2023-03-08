
namespace TracerStock.menegament.Page_Report
{
    partial class Page_Report_Result_Access
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(164, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(624, 295);
            this.dataGridView1.TabIndex = 31;
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
            this.panel3.TabIndex = 30;
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
            this.panel2.TabIndex = 29;
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
            this.panel1.TabIndex = 28;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label.ForeColor = System.Drawing.Color.Indigo;
            this.label.Location = new System.Drawing.Point(13, 39);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(180, 24);
            this.label.TabIndex = 4;
            this.label.Text = "kullanıcı giriş bilgileri";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TracerStock.Properties.Resources._2942813;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // Page_Report_Result_Access
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Page_Report_Result_Access";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Page_Report_Result_Access";
            this.Load += new System.EventHandler(this.Page_Report_Result_Access_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
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
    }
}