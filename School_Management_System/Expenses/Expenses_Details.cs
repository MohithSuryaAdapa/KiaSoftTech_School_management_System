using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System.Expenses
{
    public partial class Expenses_Details : Form
    {
        public Expenses_Details()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            using (Expense exp = new Expense())
            {
                exp.lbl = "Add New Expense";
                exp.ShowDialog();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            using (Expense exp = new Expense())
            {
                exp.lbl = "Update Expense";
                exp.ShowDialog();
            }
        }

        private void Expenses_Details_Load(object sender, EventArgs e)
        {

        }
    }
}
