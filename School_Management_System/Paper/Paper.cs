using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System.Paper
{
    public partial class Paper_Details : Form
    {
        public Paper_Details()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            using (Add_Paper add_Paper = new Add_Paper())
            {
                add_Paper.ShowDialog();
            }
        }
    }
}
