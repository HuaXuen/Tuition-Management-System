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
    public partial class frmViewStatus : Form
    {
        Student student;
        List<List<string>> ViewRequests;

        public frmViewStatus(Student student)
        {
            this.student= student;
            lblName_StuID.Text = student.Name + "|" + student.StudentID;
            InitializeComponent();
            Requests ViewReq_Status = new Requests(student.StudentID);
            ViewRequests = ViewReq_Status.ViewReq_Status();
        }

        private void frmViewStatus_Load(object sender, EventArgs e)
        {
            foreach (List<string> s in ViewRequests)
            { lstRequest.Items.Add(s[0] + s[1]); }
        }

        private void lblName_StuID_Click(object sender, EventArgs e)
        {
            lblName_StuID.Text = student.Name + "|" + student.StudentID;
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            int Req;
            Req = lstRequest.SelectedIndex;
            Requests Stu_Req= new Requests(student.StudentID);
            Stu_Req.DelReq(ViewRequests[Req][0]);
        }

        private void lstRequest_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
