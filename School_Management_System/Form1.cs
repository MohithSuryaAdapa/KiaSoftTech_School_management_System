using School_Management_System.Class;
using School_Management_System.Employee;
using School_Management_System.Expenses;
using School_Management_System.Parent;
using School_Management_System.Student;
using School_Management_System.Subjects;
using School_Management_System.Teacher;
using School_Management_System.Fee;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using School_Management_System.Salary;
using School_Management_System.Paper;
using School_Management_System.Examination;

namespace School_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void addClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Class_Details cls = new Class_Details();
            cls.MdiParent = Form1.ActiveForm;
            cls.Show();
        }

        private void addParentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Parent_Details prnt = new Parent_Details();
            prnt.MdiParent = Form1.ActiveForm;
            prnt.Show();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student_Details std = new Student_Details();
            std.MdiParent = Form1.ActiveForm;
            std.Show();
        }

        private void newSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Subjects_Details sub = new Subjects_Details();
            sub.MdiParent = Form1.ActiveForm;
            sub.Show();

        }

        private void addTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Teacher_Details teacher = new Teacher_Details();
            teacher.MdiParent = Form1.ActiveForm;
            teacher.Show();
        }

        private void staffEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addNewEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee_Details emp = new Employee_Details();
            emp.MdiParent = Form1.ActiveForm;
            emp.Show();

        }

        private void addExpenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Expenses_Details exp = new Expenses_Details();
            exp.MdiParent = Form1.ActiveForm;
            exp.Show();
        }

        private void newFeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fee_Details fe = new Fee_Details();
            fe.MdiParent = Form1.ActiveForm;
            fe.Show();

        }

        private void newSalaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salary_Details sal = new Salary_Details();
            sal.MdiParent = Form1.ActiveForm;
            sal.Show();
        }

        private void addPaperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paper_Details paper_Detials = new Paper_Details();
            paper_Detials.MdiParent = Form1.ActiveForm;
            paper_Detials.Show();
        }

        private void newExamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exam_Details ex = new Exam_Details();
            ex.MdiParent = Form1.ActiveForm;
            ex.Show();
        }

        private void newNoticesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Noticses.Notices_DEtails ns = new Noticses.Notices_DEtails();
            ns.MdiParent = Form1.ActiveForm;
            ns.Show();
        }

        private void newTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Test.Test_Details td = new Test.Test_Details();
            td.MdiParent = Form1.ActiveForm;
            td.Show();
        }

        private void attendanceDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Attendance.Staff_Attendance.Staff_Attendance sa = new Attendance.Staff_Attendance.Staff_Attendance();
            sa.MdiParent = Form1.ActiveForm;
            sa.Show();
        }

        private void studentAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Attendance.Student.Student_attendance sa = new Attendance.Student.Student_attendance();
            sa.MdiParent = Form1.ActiveForm;
            sa.Show();
        }

        private void addAssetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Assets.Assets_Details ass = new Assets.Assets_Details();
            ass.MdiParent = Form1.ActiveForm;
            ass.Show();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setting.Users usr = new setting.Users();
            usr.MdiParent = Form1.ActiveForm;
            usr.Show();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporting rp = new Reporting();
            rp.MdiParent = Form1.ActiveForm;
            rp.Show();
        }
    }
}
