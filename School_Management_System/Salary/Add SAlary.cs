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
    public partial class Add_SAlary : Form
    {
        public Add_SAlary()
        {
            InitializeComponent();
        }

        public string lbl;

        private void Add_SAlary_Load(object sender, EventArgs e)
        {
            lblsalary.Text = lbl;
            if (lblsalary.Text == "Add New Salary")
            {
                btnadd.Text = "Add Salary";
            }
            else if (lblsalary.Text == "Update Salary")
            {
                btnadd.Text = "Update Salary";
            }
        }
    }
}
