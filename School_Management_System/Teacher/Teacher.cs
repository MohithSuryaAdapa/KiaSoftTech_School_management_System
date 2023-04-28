using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System.Teacher
{
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
        }

        public string lbl;
        private void Teacher_Load(object sender, EventArgs e)
        {
            lbltchr.Text = lbl;
            if (lbltchr.Text== "Add New Teacher")
            {
                btnadd.Text = "Add Teacher";
            }
            else if (lbltchr.Text== "Update Teacher")
            {
                btnadd.Text = "Update";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        byte[] FileName;

        byte[] ImageToByteArray(Image img, PictureBox px)
        {

            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            if (px != null)
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

            }
            return ms.ToArray();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            DialogResult result = fileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                pictureBox1.BackgroundImage = Image.FromFile(fileDialog.FileName);
                pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
                FileName = ImageToByteArray(pictureBox1.BackgroundImage, pictureBox1);
            }
        }
    }
}
