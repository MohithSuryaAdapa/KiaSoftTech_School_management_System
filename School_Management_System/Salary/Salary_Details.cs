using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System.Salary
{
    public partial class Salary_Details : Form
    {
        public Salary_Details()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            using (Add_SAlary sal = new Add_SAlary())
            {
                sal.lbl = "Add New Salary";
                sal.ShowDialog();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            using (Add_SAlary sal = new Add_SAlary())
            {
                sal.lbl = "Update Salary";
                sal.ShowDialog();
            }
        }
    }
}
