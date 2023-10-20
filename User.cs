using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_Assignment
{
    public class User
    {
        private string username;
        private string role;
        protected string password;    
        public string Role
        {
            get { return role; }
        }

        public string Username
        {
            get { return username; }
        }

        public User(string a)
        {
            username = a;
        }

        public string ShowUsername_Name(string username)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbETC"].ToString());
            con.Open();

            SqlCommand cmd = new SqlCommand("select name from [User] where username='" + username + "'", con);
            return (cmd + "|" + username);
        }

        public void ChangeName(string Name)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbETC"].ToString()))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "UPDATE [User] set " +
                        "[Name] = '" + Name + "'" +
                        "where Username = '" + username + "'";
                    cmd.ExecuteNonQuery();

                }
            }
        }

        public string getPassword()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbETC"].ToString()))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                { 
                    cmd.CommandText = "SELECT Password FROM [User] WHERE Username = '"+ username +"'";
                    password = cmd.ExecuteScalar().ToString();
                    return password;
                }
            }
        }


        public Form login(string password)
        {
            //SqlCommand objectName = new Constructor(sqlQuery, ConnectionString);
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbETC"].ToString()))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT count(*) FROM [User] WHERE Username = '" + username + "' and Password = '" + password + "'", con);
                int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());

                if (count > 0)
                {
                    SqlCommand cmd2 = new SqlCommand("select Role from [User] where Username ='" + username + "' and Password ='" + password + "'", con);
                    SqlCommand cmd3 = new SqlCommand("select Name from [User] where Username ='" + username + "' and Password ='" + password + "'", con);
                    string userRole = cmd2.ExecuteScalar().ToString();
                    string name = cmd3.ExecuteScalar().ToString();
                    if (userRole == "admin")
                    {
                        adminHome adm= new adminHome(name);
                        adm.Show();
                        return (adm);
                    }
                    else if (userRole == "student")
                    {
                        frmMain stu = new frmMain(name, username);
                        stu.Show();
                        return (stu);
                    }
                    else if (userRole == "reception")
                    {
                        ReceptionHomepage recepForm = new ReceptionHomepage(name, username);
                        recepForm.Show();
                        return (recepForm);
                    }
                    else if (userRole == "tutor")
                    {
                        TutorClassInfo tut = new TutorClassInfo(name, username);
                        tut.Show();
                        return (tut);
                    }
                }
                return null;
            }
        }

        public static ArrayList ViewAllUser()
        {
            ArrayList staff = new ArrayList();
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbETC"].ToString()))
            {
                
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "Select Username from [User] where role='reception' or role='tutor'";
                    SqlDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        staff.Add(rd["Username"].ToString());
                    }
                    rd.Close();
                }
            }
            return staff;

        }
        
        
    }
}
