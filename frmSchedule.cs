namespace IOOP_Assignment
{
    public partial class frmSchedule : Form
    {
        Student student;
        public frmSchedule(Student student)
        {
            InitializeComponent();
            this.student = student;
            lblName_StuID.Text = student.Name + "|" + student.StudentID;
        }

        private void frmSchedule_Load(object sender, EventArgs e)
        {
            Schedule subjectSchedule= new Schedule();
            foreach (string subject in student.GetSubjects())
            {
                subjectSchedule.loadSub(subject);
            }
            for (int i=0;i<subjectSchedule.Subject.Count; i++)
            {
                grdSch.Rows.Add(subjectSchedule.Day[i], subjectSchedule.SubjectName[i], subjectSchedule.StartTime[i], subjectSchedule.EndTime[i]);
            }
        }

        private void grdSch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}