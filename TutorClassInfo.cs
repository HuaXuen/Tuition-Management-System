using System.Runtime.InteropServices;

namespace IOOP_Assignment
{
    public partial class TutorClassInfo : Form
    {
        private string name;
        private string username;
        private Schedule subjects;
        private Tutor tutor;

        public TutorClassInfo(string name, string username) //parameters passed by User.cs to ge the name and username of tutors
        {
            InitializeComponent();
            tutor = new Tutor(username);
            lblName.Text = name + " ("+ tutor.Subject +")";
            this.name = lblName.Text;
            this.username = username;
            subjects = new Schedule(username);
            Subject subObj = new Subject(tutor.Subject);
            txtCRate.Text = "RM"+ subObj.ChargeRate.ToString();
            loadTable();
        }

        private void loadTable() //to load the schedule onto datagridview by extracting data from SQL database
        {
            subjects.clearData();
            subjects.loadData();
            gridClass.Rows.Clear();
            for (int i = 0; i < subjects.Subject.Count; i++)
            {
                gridClass.Rows.Add(name, subjects.SubjectName[i], subjects.Day[i], subjects.StartTime[i], subjects.EndTime[i], (new Subject(subjects.Subject[i])).ChargeRate); 
            }
        }


        private void btnCInfo_Click(object sender, EventArgs e)
        {
            TutorEditClassInfo s = new TutorEditClassInfo(name, username);
            s.Show();
            this.Hide();
            s.FormClosed += child_FormClosed;
        }

        private void child_FormClosed(object? sender, FormClosedEventArgs e)
        {
            Show();
            loadTable();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EditProfile s = new EditProfile(name, username);
            s.Show();
            this.Hide();
            s.FormClosed += child_FormClosed;
        }

        private void btnSList_Click(object sender, EventArgs e)
        {
            TutorStudentList s = new TutorStudentList(username);
            s.Show();
            this.Hide();
            s.FormClosed += child_FormClosed;
        }
    }
}