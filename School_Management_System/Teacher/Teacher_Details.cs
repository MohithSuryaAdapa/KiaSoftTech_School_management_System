using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System.Teacher
{
    public partial class Teacher_Details : Form
    {
        public Teacher_Details()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            using (Teacher tchr = new Teacher())
            {
                tchr.lbl = "Add New Teacher";
                tchr.ShowDialog();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            using (Teacher tchr = new Teacher())
            {
                tchr.lbl = "Update Teacher";
                tchr.ShowDialog();
            }
        }
    }
}
