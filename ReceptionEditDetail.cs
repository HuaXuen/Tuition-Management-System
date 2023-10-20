using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace IOOP_Assignment
{
    public partial class ReceptionEditDetail : Form
    {
        public string CurrentID;
        Student student;

        public ReceptionEditDetail(string newID)
        {
            InitializeComponent();
            CurrentID = newID;
            textBox_StudentID.Text = newID;
        }

        public ReceptionEditDetail(Student student)
        {
            InitializeComponent();
            this.student = student;
            this.CurrentID = student.StudentID;
            textBox_Name.Text = student.Name;
            textBox_StudentID.Text = student.StudentID;
            textBox_Email.Text = student.Email;
            textBox_Contact.Text = student.Contact;
            comboBox_Level.Text = student.Level;
            string[] date = student.Date.ToString("dd/MM/yyyy").Split("/");
            textBox_Day.Text = date[0];
            textBox_Month.Text = date[1];
            textBox_Year.Text = date[2];
            textBox_Address.Text = student.Address;
            textBox_IC.Text = student.IC;
        }

        private void button_Confirm_Click(object sender, EventArgs e)
        {
            DateTime date = Convert.ToDateTime(String.Join("/", new List<string> {
                        textBox_Day.Text.ToString(),
                        textBox_Month.Text.ToString(),
                        textBox_Year.Text.ToString()
                }));

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbETC"].ToString()))
            {
                con.Open();
                using (SqlCommand cmdTest = con.CreateCommand())
                {
                    if (Student.Exists(textBox_StudentID.Text))
                    {
                        student.Name = textBox_Name.Text.ToString();
                        student.Email = textBox_Email.Text.ToString();
                        student.Contact = textBox_Contact.Text.ToString();
                        student.Level = comboBox_Level.Text.ToString();
                        student.Date = date;
                        student.Address = textBox_Address.Text.ToString();
                        student.IC = textBox_IC.Text.ToString();

                        student.ChangeName(student.Name);
                        student.SaveData();

                        MessageBox.Show("Edited Student Records.", "Edit Status", MessageBoxButtons.OK);

                    }
                    else
                    {
                        string newdata = String.Join("','", new List<string> {
                            textBox_StudentID.Text.ToString(),
                            textBox_Email.Text.ToString(),
                            textBox_Contact.Text.ToString(),
                            comboBox_Level.Text.ToString(),
                            date.ToString("dd/MM/yyyy"),
                            textBox_Address.Text.ToString(),
                            textBox_IC.Text.ToString()
                        });


                        using (SqlCommand cmd = con.CreateCommand())
                        {
                            cmd.CommandText = "INSERT INTO [User](Username, Name, Role, Password) values('" +
                                textBox_StudentID.Text.ToString() + "','" +
                                textBox_Name.Text.ToString() + "','" +
                                "student" + "','" +
                                textBox_StudentID.Text.ToString() + "')";
                            cmd.ExecuteNonQuery();

                        }

                        using (SqlCommand cmd = con.CreateCommand())
                        {
                            cmd.CommandText = "INSERT INTO [PaymentInfo](Username, Amount, PaidAmount, Outstanding) " +
                                "values('" + textBox_StudentID.Text.ToString() + "', 0, 0, 0)";
                            cmd.ExecuteNonQuery();

                        }

                        using (SqlCommand cmd = con.CreateCommand())
                        {
                            cmd.CommandText = "INSERT INTO [Students](Username, Email, ContactNumber, Level, DateEnrolled, Address, IC) values('" + newdata + "')";
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Added new Record.", "Enroll Status", MessageBoxButtons.OK);
                    }
                    this.Close();
                }
            }
        }


        private void textBox_Date_TextChanged(object sender, EventArgs e)
        {
            string date = String.Join("/", new string[] { textBox_Day.Text, textBox_Month.Text, textBox_Year.Text });
            if (String.IsNullOrEmpty(textBox_Month.Text)  || String.IsNullOrEmpty(textBox_Day.Text) || String.IsNullOrEmpty(textBox_Year.Text))
            {
                button_Confirm.Enabled = false;
                textBox_Month.ForeColor = Color.Black;
                textBox_Day.ForeColor = Color.Black;
                textBox_Year.ForeColor = Color.Black;
            }
            else if (DateTime.TryParse(date, out _))
            {
                button_Confirm.Enabled = true;
                textBox_Month.ForeColor = Color.Black;
                textBox_Day.ForeColor = Color.Black;
                textBox_Year.ForeColor = Color.Black;
            }
            else
            {
                button_Confirm.Enabled = false;
                textBox_Month.ForeColor = Color.Red;
                textBox_Day.ForeColor = Color.Red;
                textBox_Year.ForeColor = Color.Red;
            }
        }

        private void label_Username_Click(object sender, EventArgs e)
        {

        }
        //d
        private void ReceptionEditDetail_Load(object sender, EventArgs e)
        {

        }
    }
}
