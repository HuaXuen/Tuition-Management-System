using System.Configuration;
using System.Data.SqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Drawing;
using System;

namespace IOOP_Assignment
{
    public partial class ReceptionHomepage : Form
    {
        private string StudentID;
        private Student student;
        private string username;

        public ReceptionHomepage()
        {
            InitializeComponent();
        }

        public ReceptionHomepage(string Name, string Username)
        {
            InitializeComponent();
            label_Username.Text = Name;
            username = Username;
        }

        private void loadStudent(string StuID)
        {
            student = new Student(StuID);
            label_StudentName.Text = student.Name;
            label_StudentID.Text = student.StudentID;
            label_Email.Text = "E-mail: " + student.Email;
            label_Contact.Text = "Contact Number: " + student.Contact;
            label_Level.Text = "Level: " + student.Level;
            label_Date.Text = "Date Enrolled: " + student.Date.ToString("dd/MM/yyyy");
            label_Address.Text = "Address: " + student.Address;
            label_IC.Text = "IC Number: " + student.IC;
            label_FeeDue.Text = "Total Due: RM" + student.FeeTotal.ToString();
            label_FeePaid.Text = "Total Paid: RM" + student.FeePaid.ToString();
            label_FeeOutstand.Text = "Total Outstanding: RM" + (student.FeeTotal - student.FeePaid).ToString();
            listBox_Subject.Items.Clear();
            if (student.GetSubjects() != null) 
            {
                foreach (string subj in student.GetSubjects())
                {
                    if (subj != null) listBox_Subject.Items.Add(subj);
                }
            }
        }


        private void button_Search_Click(object sender, EventArgs e)
        {
            if (Student.Exists(textBox_Search.Text))
            {
                StudentID = textBox_Search.Text;
                loadStudent(StudentID);
            }
            else MessageBox.Show("Record does not exist.", "Null Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button_Enroll_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbETC"].ToString()))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "select Username from [User] order by Username desc";
                    int Highest = Convert.ToInt32( cmd.ExecuteScalar().ToString().Remove(0, 2) );
                    string ID = (Highest + 1).ToString().PadLeft(3, '0');
                    string NewID = "ET" + ID;
                    ReceptionEditDetail formAddStudent = new ReceptionEditDetail(NewID);
                    formAddStudent.Show();
                    StudentID = formAddStudent.CurrentID;
                    formAddStudent.FormClosing += EditFormClosing;
                }
            }
            
        }

        private void button_EditDetails_Click(object sender, EventArgs e)
        {
            if (label_StudentID.Text != "Student ID")
            {
                ReceptionEditDetail formAddStudent = new ReceptionEditDetail(student);
                formAddStudent.Show();
                StudentID = formAddStudent.CurrentID;
                formAddStudent.FormClosing += EditFormClosing;
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (label_StudentID.Text == "Student ID")
            {
                return;
            }
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbETC"].ToString()))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    /*try
                    {
                        cmd.CommandText = "DELETE FROM [Students] where Username = '" + label_StudentID.Text.ToString() + "'";
                        cmd.ExecuteNonQuery();
                    } finally { cmd.Dispose(); }
                    try
                    {
                        cmd.CommandText = "DELETE FROM [PaymentInfo] where Username = '" + label_StudentID.Text.ToString() + "'";
                        cmd.ExecuteNonQuery();
                    } finally { cmd.Dispose(); }*/
                    try
                    {
                        cmd.CommandText = "DELETE FROM [User] where Username = '" + label_StudentID.Text.ToString() + "'";
                        cmd.ExecuteNonQuery();
                    } finally { cmd.Dispose(); }
                }
            }
            MessageBox.Show("Record Successfully Deleted", "Deleted", MessageBoxButtons.OK);
            label_StudentName.Text = "Student Name";
            label_StudentID.Text = "Student ID";
            label_Email.Text = "E-mail: ";
            label_Contact.Text = "Contact Number: ";
            label_Level.Text = "Level: ";
            label_Date.Text = "Date Enrolled: ";
            label_Address.Text = "Address: ";
            label_IC.Text = "IC Number: ";
            listBox_Subject.Items.Clear();

        }


        private void button_EditSubject_Click(object sender, EventArgs e)
        {
            if (Student.Exists(textBox_Search.Text))
            {
                ReceptionEditSubjects formSubject = new ReceptionEditSubjects(label_Username.Text, student);
                formSubject.FormClosing += EditFormClosing;
                formSubject.ShowDialog();
            }
            else MessageBox.Show("Record does not exist.", "Null Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void button_Receipt_Click(object sender, EventArgs e)
        {
            ReceptionReceipt formReceipt = new ReceptionReceipt(label_Username.Text, student);
            formReceipt.ShowDialog();
        }

        private void EditFormClosing(object sender, FormClosingEventArgs e)
        {
            if (Student.Exists(StudentID))
            {
                loadStudent(StudentID);
                textBox_Search.Text = StudentID;
            }
        }

        private void button_Profile_Click(object sender, EventArgs e)
        {
            EditProfile formEditProfile = new EditProfile(Name,username);
            formEditProfile.ShowDialog();
        }

        private void ReceptionHomepage_Load(object sender, EventArgs e)
        {

        }
    }
}