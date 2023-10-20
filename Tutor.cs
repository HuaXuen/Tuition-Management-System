using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_Assignment
{
    public class Tutor:User
    {
        private string username;
        private string subject;
        private int level;

        public string Subject { get { return subject; } }
        public int Level { get { return level; } }

        public Tutor(string u) : base(u)    
        {
            username = u;
            subject = getSubject();
            level = getLevel();
        }

        private string getSubject() //to get what subject the tutor is teaching
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbETC"].ToString()))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "SELECT Subject FROM [Tutors] WHERE Username = '" + username + "'";
                    subject = cmd.ExecuteScalar().ToString();
                    return subject;
                }
            }
        }

        private int getLevel() //to get what level the tutor is teaching 
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbETC"].ToString()))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "SELECT Level FROM [Tutors] WHERE Username = '" + username + "'";
                    level = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                    return level;
                }
            }
        }

        public ArrayList viewAll() //A method that shows all the students enrolled into the particular tutor's class
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbETC"].ToString()))
            {
                ArrayList nm = new ArrayList();
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Username FROM [Students] WHERE  Level = '"+ this.level + "' AND (Subject1 = '" + this.subject +"' OR Subject2 = '"+this.subject+"' OR Subject3 = '"+this.subject+"')", con);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    nm.Add(rd.GetString(0));
                }
                rd.Close();
                return nm;
            }   
        }
    }  
}
