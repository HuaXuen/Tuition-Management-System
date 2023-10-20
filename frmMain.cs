using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Assignment
{
    public partial class frmMain : Form
    {
        Student student;

        public frmMain(string name,string username)
        {
            student = new Student(username);
            InitializeComponent();
            lblName_StuID.Text = student.Name + "|" + student.StudentID;
        }
        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmEdit obj2 = new frmEdit(student);
            obj2.ShowDialog();
        }

        private void picStu_Click(object sender, EventArgs e)
        {

        }

        private void grpFunc_Enter(object sender, EventArgs e)
        {

        }

        private void btnViewSch_Click(object sender, EventArgs e)
        {
            frmSchedule obj1=new frmSchedule(student);
            obj1.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void frmMain_Load_1(object sender, EventArgs e)
        {

        }

        private void btnChangeSubEnroll_Click(object sender, EventArgs e)
        {
            frmChangeSubEnrol obj3 = new frmChangeSubEnrol(student);
            obj3.ShowDialog();
        }

        private void btnViewReqStatus_Click(object sender, EventArgs e)
        {
            frmViewStatus obj4 = new frmViewStatus(student);
            obj4.ShowDialog();
        }
    }
}
