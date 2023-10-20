using System;
using System.Collections;
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
    public partial class TutorStudentList : Form
    {
        private Tutor tutor;
        public TutorStudentList(string username) //parameters passed by User.cs to ge the username of tutors
        {
            InitializeComponent();
            lblName.Text = username;
            tutor = new Tutor(username);
            updateGrid();
        }

        private void updateGrid() //to display the students enrolled in the particular tutor's class
        {
            ArrayList usernames = new ArrayList();
            gridList.Rows.Clear();
            usernames = tutor.viewAll();
            foreach (string username in usernames)
            {
                Student student = new Student(username);        
                gridList.Rows.Add(student.Name);
            }   
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
