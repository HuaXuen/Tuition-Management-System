using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace IOOP_Assignment
{
    internal class Subject
    {
        private string _name;
        private decimal _chargeRate;
        private int _studentNum;

        public string Name { get { return _name; } }
        public decimal ChargeRate { get { return _chargeRate; } set { _chargeRate = value; } }
        public int StudentNum { get { return _studentNum; } set { _studentNum = value; } }


        public Subject(string name)
        {
            if (GetExistingSubjects().Contains(name))
            {
                _name = name;
                _chargeRate = GetChargeRate(name);
                _studentNum = GetStudentNumber(name);
            }
        }

/*        public Subject(List<string> listName)
        {
            foreach (string name in listName)
            {
                if (GetExistingSubjects().Contains(name))
                {
                    _name = name;
                    _chargeRate = 0;
                    _studentNum = GetStudentNumber(name);
                }
            }
        }*/

        public static List<string> GetExistingSubjects()
        {
            List<string> subjects = new List<string>();

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbETC"].ToString()))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "Select Subject from Subjects";
                    SqlDataReader data = cmd.ExecuteReader();

                    while ( data.Read() )
                    {
                        subjects.Add(data["Subject"].ToString());
                    }
                    data.Close();
                }
            }
            return subjects;
        }


        public void SaveSubject()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbETC"].ToString()))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "UPDATE Subjects SET " +
                        "ChargeRate = '" + _chargeRate.ToString() + "'," +
                        "StudentNumber = '" + _studentNum.ToString() + "'" +
                        "WHERE Subject = '" + _name + "'";
                    cmd.ExecuteNonQuery();
                }
            }
        }


        private decimal GetChargeRate(string subject)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbETC"].ToString()))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "Select ChargeRate from Subjects where Subject = '" + subject + "'";
                    return (Convert.ToDecimal(cmd.ExecuteScalar().ToString()));
                }
                
            }
        }


        private int GetStudentNumber(string subject)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbETC"].ToString()))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "Select StudentNumber from Subjects where Subject = '" + subject + "'";
                    return (Convert.ToInt32(cmd.ExecuteScalar().ToString()));
                }
            }
        }


    }
}
