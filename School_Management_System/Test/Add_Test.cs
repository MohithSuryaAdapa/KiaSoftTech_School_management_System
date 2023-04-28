using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System.Test
{
    public partial class Add_Test : Form
    {
        public Add_Test()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        public string lbl;

        private void Add_Test_Load(object sender, EventArgs e)
        {
            lbltest.Text = lbl;
            if (lbltest.Text == "Add New Test")
            {
                btnadd.Text = "Add Test";
            }
            else if (lbltest.Text=="Update Test")
            {
                btnadd.Text = "Update Test";
            }
        }
    }
}
