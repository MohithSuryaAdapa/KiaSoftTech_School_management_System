using Devart.Data.PostgreSql;
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
    public partial class Add_Class : Form
    {
        public Add_Class()
        {
            InitializeComponent();
        }
        public string lbl;
        
        private void Add_Class_Load(object sender, EventArgs e)
        {
            lblclass.Text = lbl;
            if (lblclass.Text== "Add New Class")
            {
                btnadd.Text = "Add Class";
            }
            else if (lblclass.Text== "Update Class")
            {
                btnadd.Text = "Update Class";
            }
         
        }

        // remove this from there and add in new class also remove both buttons
        PgSqlConnection conn;
        string connstring = "User Id=postgres;Host=localhost;Port=5433;Database=sms;Initial Schema=public;password=mysys";
        private void button1_Click(object sender, EventArgs e)
        {
            conn = new PgSqlConnection(connstring);
            try
            {
                conn.Open();
                MessageBox.Show("Successfully connected with DataBase");
            }
            catch (Exception)
            {
                MessageBox.Show("Error while connecting with DataBase");

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Close();
                MessageBox.Show("Successfully Disconnected with DataBase");

            }
            catch (Exception)
            {
                MessageBox.Show("Error while Disconnecting From DataBase");

            }
        }
    }
}
