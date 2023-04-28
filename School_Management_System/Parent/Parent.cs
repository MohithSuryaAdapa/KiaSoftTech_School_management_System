using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System.Parent
{
    public partial class Parent : Form
    {
        public Parent()
        {
            InitializeComponent();
        }

        public string lbl;
        private void Parent_Load(object sender, EventArgs e)
        {
            lblheading.Text = lbl;
            if (lblheading.Text == "Add New Parent")
            {
                btnadd.Text = "Add Parent";
            }
            else if(lblheading.Text== "Update Parent")
            {
                btnadd.Text = "Update Parent";
            }
        }
    }
}
