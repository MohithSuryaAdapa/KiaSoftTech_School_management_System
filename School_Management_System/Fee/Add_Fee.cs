using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System.Fee
{
    public partial class Add_Fee : Form
    {
        public Add_Fee()
        {
            InitializeComponent();
        }

        public string lbl;
        private void Add_Fee_Load(object sender, EventArgs e)
        {
            lblfee.Text = lbl;
            if (lblfee.Text=="Add New Fee")
            {
                btnadd.Text = "Add Fee";
            }
            else if (lblfee.Text=="Update Fee")
            {
                btnadd.Text = "Update Fee";
            }

        }
    }
}
