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
    public partial class Parent_Details : Form
    {
        public Parent_Details()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            using (Parent pr = new School_Management_System.Parent.Parent())
            {
                pr.lbl = "Add New Parent";
                pr.ShowDialog();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            using (Parent pr = new School_Management_System.Parent.Parent())
            {
                pr.lbl = "Update Parent";
                pr.ShowDialog();
            }
        }
    }
}
