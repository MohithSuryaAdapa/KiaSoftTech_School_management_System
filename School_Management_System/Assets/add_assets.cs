using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System.Assets
{
    public partial class add_assets : Form
    {
        public add_assets()
        {
            InitializeComponent();
        }
        public string lbl;
        private void add_assets_Load(object sender, EventArgs e)
        {
            lblast.Text = lbl;
            if (lblast.Text == "Add New Assets")
            {
                btnadd.Text = "Add Assets";
            }
            else if (lblast.Text == "Update Assets")
            {
                btnadd.Text = "Update Assets";

            }

        }
    }
}
