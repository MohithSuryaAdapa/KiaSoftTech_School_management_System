using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System.Assets
{
    public partial class Assets_Details : Form
    {
        public Assets_Details()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            using (add_assets add = new add_assets())
            {
                add.lbl = "Add New Assets";
                add.ShowDialog();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            using (add_assets add = new add_assets())
            {
                add.lbl = "Update Assets";
                add.ShowDialog();
            }
        }
    }
}
