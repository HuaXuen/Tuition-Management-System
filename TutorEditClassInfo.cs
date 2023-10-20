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
using System.Data.SqlClient;
using System.Configuration;
using System.Reflection;

namespace IOOP_Assignment
{
    public partial class TutorEditClassInfo : Form
    {
        private string username;
        private string name;
        private Schedule subjects;
        private Tutor tutor;
        private Subject subject;
        private int countAdd;

        public TutorEditClassInfo(string name, string username) //parameters passed by User.cs to ge the name and username of tutors
        {
            InitializeComponent();
            lblName.Text = name;
            this.username = username;
            this.name = name;
            tutor = new Tutor(username);
            subjects = new Schedule(username);
            subject = new Subject(tutor.Subject);
            countAdd = 0;

            loadTable();
        }

        private void loadTable() //to load the schedule onto datagridview by extracting data from SQL database
        {
            txtCRate.Text = subject.ChargeRate.ToString();
            for (int i = 0; i < subjects.Subject.Count; i++)
            {
                gridList.Rows.Add(name, subjects.SubjectName[i], subjects.Day[i], subjects.StartTime[i], 
                subjects.EndTime[i], (new Subject(subjects.Subject[i])).ChargeRate);
            }
        }

        private void btnAddRow_Click(object sender, EventArgs e) //to add new rows into the schedule via datagridview
        {
            countAdd++;
            gridList.Rows.Add(name, "", "", "");
        }

        private void btnDeleteRow_Click(object sender, EventArgs e) //to delete rows from the schedule and the SQL database
        {
            gridList.Rows.RemoveAt(gridList.CurrentCell.RowIndex);
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbETC"].ToString()))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {                  
                        cmd.CommandText = "DELETE FROM [Schedule] where Username = '" + username + "'";
                        cmd.ExecuteNonQuery();                
                }
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e) 
        {        
            decimal charges;
            if ( decimal.TryParse(txtCRate.Text.ToString(), out charges) == false) 
            {
                MessageBox.Show("Enter a Valid Price for Charge Rate", "Price Error", MessageBoxButtons.OK);
                return;
            }

            Subject subObj = new Subject(tutor.Subject); //to save the updated charge rate into the SQL database
            subObj.ChargeRate = charges;
            subObj.SaveSubject();

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["dbETC"].ToString()))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    for (int index = gridList.Rows.Count - countAdd ; index < gridList.Rows.Count; index++) //to save the updated schedule into the SQL database
                    {
                        string subjectname = gridList.Rows[index].Cells[1].Value.ToString();
                        string day = gridList.Rows[index].Cells[2].Value.ToString();
                        string startTime = gridList.Rows[index].Cells[3].Value.ToString();
                        string endTime = gridList.Rows[index].Cells[4].Value.ToString();
                        cmd.CommandText = "INSERT INTO Schedule(Username, Subject, SubjectName, Day, StartTime, EndTime) " + "VALUES ('"+ username + "','" + tutor.Subject + "','" + subjectname + "','" + day + "','" + startTime + "','" + endTime + "')";
                        cmd.ExecuteNonQuery();                   
                    }
                }
                MessageBox.Show("Schedule updated successfully");
            }
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        { 
            Close();
        }
    }
}
