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
    public partial class subject : Form
    {
        public subject()
        {
            InitializeComponent();
        }

        public string lbl;
        private void subject_Load(object sender, EventArgs e)
        {
            lblsub.Text = lbl;
            if (lblsub.Text== "Add New Subject")
            {
                btnadd.Text = "Add Subject";
            }
            else if (lblsub.Text== "Update Subject")
            {
                btnadd.Text ="Update Subject";
            }
        }
    }
}
