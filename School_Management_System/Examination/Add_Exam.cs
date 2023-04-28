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
    public partial class Add_Exam : Form
    {
        public Add_Exam()
        {
            InitializeComponent();
        }

        public string lbl;
        private void Add_Exam_Load(object sender, EventArgs e)
        {
            lblexam.Text = lbl;
            if (lblexam.Text == "Add New Exam")
            {
                btnadd.Text = "Add Exam";
            }
            else if (lblexam.Text=="Update Exam")
            {
                btnadd.Text = "Update Exam";
            }
        }
    }
}
