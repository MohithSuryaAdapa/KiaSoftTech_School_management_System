using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System.Examination
{
    public partial class Exam_Details : Form
    {
        public Exam_Details()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            using (Add_Exam ex = new Add_Exam())
            {
                ex.lbl = "Add New Exam";
                ex.ShowDialog();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (Add_Exam ex = new Add_Exam())
            {
                ex.lbl = "Update Exam";
                ex.ShowDialog();
            }
        }
    }
}
