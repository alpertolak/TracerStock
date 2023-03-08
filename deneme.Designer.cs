
namespace TracerStock
{
    partial class deneme
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
            this.Product_Category = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Product_Category
            // 
            this.Product_Category.FormattingEnabled = true;
            this.Product_Category.Location = new System.Drawing.Point(350, 215);
            this.Product_Category.Name = "Product_Category";
            this.Product_Category.Size = new System.Drawing.Size(100, 21);
            this.Product_Category.TabIndex = 34;
            // 
            // deneme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Product_Category);
            this.Name = "deneme";
            this.Text = "deneme";
            this.Load += new System.EventHandler(this.deneme_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Product_Category;
    }
}