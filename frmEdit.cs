using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace IOOP_Assignment
{
    public partial class frmEdit : Form
    {
        Student student;

        public frmEdit(Student student)
        {
            InitializeComponent();
            lblOutputName.Text = student.Name;
            lblIC.Text = student.IC;
            txtAdd.Text = student.Address;
            txtEmail.Text = student.Email;
            txtContact.Text = student.Contact;
            lblLvl.Text = student.Level;
            lblName_StuID.Text = student.Name + "|" + student.StudentID;
            if (student.GetSubjects() != null)
            {
                foreach (string sub in student.GetSubjects())
                {
                    if (sub !=null) lstSub.Items.Add(sub);
                }
            }
            
        }


        private void lblIC_Click(object sender, EventArgs e)
        {

        }

        private void grpEdit_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void frmEdit_Load(object sender, EventArgs e)
        {
            

        }

        private void frmEdit_Load_1(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            student.Address=txtAdd.ToString();
            student.Email=txtEmail.ToString();
            student.Contact=txtContact.ToString();

            student.SaveData();

        }

        private void lstSub_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblName_StuID_Click(object sender, EventArgs e)
        {

        }
    }
}
