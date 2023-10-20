using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_Assignment
{
    internal class Schedule
    {
        private string username;
        private List<string> subjectName = new List<string>();
        private List<string> day = new List<string>();
        private List<TimeOnly> startTime = new List<TimeOnly>();
        private List<TimeOnly> endTime = new List<TimeOnly>();
        private List<string> subject = new List<string>();
        //public List<decimal> charges = new List<decimal>();

        public List<string> SubjectName { get { return subjectName; } }
        public List<string> Day { get { return day; } }
        public List<TimeOnly> StartTime { get { return startTime; } }
        public List<TimeOnly> EndTime { get { return endTime; } }
        public List<string> Subject { get { return subject; } }
        public Schedule(string username)
        {
            this.username = username;
            loadData();    
        }

        public Schedule()
        {

        }

        public void loadData()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbETC"].ToString()))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "select * from Schedule where Username = '" + username + "'";
                    //MessageBox.Show(cmd.ExecuteScalar().ToString());
                    SqlDataReader data = cmd.ExecuteReader();
                    while (data.Read())
                    {
                        subject.Add(data["Subject"].ToString());
                        day.Add(data["Day"].ToString());
                        startTime.Add(TimeOnly.FromDateTime(Convert.ToDateTime(data["StartTime"].ToString())));
                        endTime.Add(TimeOnly.FromDateTime(Convert.ToDateTime(data["EndTime"].ToString())));
                        subjectName.Add(data["SubjectName"].ToString());
                        //charges.Add(Convert.ToDecimal(data["Charges"]));
                    }
                    data.Close();
                }
            }
        }
        public void clearData()
        {
            subject.Clear();
            day.Clear();
            startTime.Clear();  
            endTime.Clear();    
            subjectName.Clear();
        }


        public void loadSub(string subject)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbETC"].ToString()))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "select * from Schedule where Subject = '" + subject + "'";
                    //MessageBox.Show(cmd.ExecuteScalar().ToString());
                    SqlDataReader data = cmd.ExecuteReader();
                    while (data.Read())
                    {
                        this.subject.Add(data["Subject"].ToString());
                        day.Add(data["Day"].ToString());
                        startTime.Add(TimeOnly.FromDateTime(Convert.ToDateTime(data["StartTime"].ToString())));
                        endTime.Add(TimeOnly.FromDateTime(Convert.ToDateTime(data["EndTime"].ToString())));
                        subjectName.Add(data["SubjectName"].ToString());
                        //charges.Add(Convert.ToDecimal(data["Charges"]));
                    }
                    data.Close();
                }
            }
        }
    }
}
