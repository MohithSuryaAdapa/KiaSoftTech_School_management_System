using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System.Class
{
    public partial class Class_Details : Form
    {
        public Class_Details()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Add_Class cls = new Add_Class())
            {
                cls.lbl = "Add New Class";
                cls.ShowDialog();
                
               
              

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Add_Class cls = new Add_Class())
            {
                cls.lbl = "Update Class";
                cls.ShowDialog();
                
             
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
