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

namespace TracerStock
{
    public partial class deneme : Form
    {
        public deneme()
        {
            InitializeComponent();
        }
        Slim4DesktopEntities db = new Slim4DesktopEntities();
        private void deneme_Load(object sender, EventArgs e)
        {
            var urun = (from x in db.Category
                        select new
                        {
                            x.Category_ID,
                            x.Category_Name
                        }).ToList();
            Product_Category.ValueMember = "Category_ID";
            Product_Category.DisplayMember = "Category_Name";
            Product_Category.DataSource = urun;
        }
    }
}
