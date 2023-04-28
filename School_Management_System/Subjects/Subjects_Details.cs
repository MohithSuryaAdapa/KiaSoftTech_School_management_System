using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System.Subjects
{
    public partial class Subjects_Details : Form
    {
        public Subjects_Details()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            using (subject sub = new subject())
            {
                sub.lbl = "Add New Subject";
                sub.ShowDialog();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            using (subject sub = new subject())
            {
                sub.lbl = "Update Subject";
                sub.ShowDialog();
            }
        }
    }
}
