using System;
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
    public partial class ReceptionEditSubjects : Form
    {
        private int checkCounter;
        private Student student;

        public ReceptionEditSubjects(string name, Student student)
        {
            InitializeComponent();
            label_Username.Text = name;
            this.student = student;
            label_Student.Text = student.Name + "\n" + student.StudentID;
            LoadSubjectList();
            
        }

        private void LoadSubjectList()
        {
            listBox_Subjects.Items.Clear();
            List<string> subjects = student.GetSubjects();
            if (subjects != null)
            {
                foreach (string subj in subjects)
                {
                    if (subj != null) listBox_Subjects.Items.Add(subj);
                }

                foreach (Control c in groupBox_CheckBox.Controls)
                {
                    if (c is CheckBox)
                    {
                        CheckBox box = (CheckBox)c;
                        if (subjects.Contains(box.Text))
                            box.Checked = true;
                    }
                }
            }
        }

        private void OnCheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = (CheckBox)sender;
            if (box.Checked)
                checkCounter++;
            else
                checkCounter--;

            if (checkCounter > 3)
            {
                MessageBox.Show("Max 3 subjects", "Subject");
                box.Checked = false;
            }
        }

        private void button_Confirm_Click(object sender, EventArgs e)
        {
            List<string> subjects = new List<string>();
            foreach (Control c in groupBox_CheckBox.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox box = (CheckBox)c;
                    if (box.Checked)
                    {
                        subjects.Add(box.Text);
                    }
                }
            }
            //MessageBox.Show(String.Join(",", subjects));
            student.SetSubjects(subjects);
            student.SaveSubject();
            Close();
        }
    }
}
