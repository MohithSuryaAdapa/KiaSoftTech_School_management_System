using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System.Student
{
    public partial class Student_Details : Form
    {
        public Student_Details()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            using (Student std = new Student())
            {
                std.lbl = "Add New Student";
                std.ShowDialog();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            using (Student std = new Student())
            {
                std.lbl = "Update Student";
                std.ShowDialog();
            }
        }
    }
}
