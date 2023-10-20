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
    public partial class ReceptionReceipt : Form
    {
        Student student;
        public ReceptionReceipt(string name, Student student)
        {
            InitializeComponent();
            this.student = student;
            label_Username.Text = name;
            label_Name.Text = student.Name;
            label_Due.Text = "RM" + student.FeeTotal.ToString();
            label_Paid.Text = "RM" + student.FeePaid.ToString();
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Print_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Receipt Sent to printer.", "Print Receipt", MessageBoxButtons.OK);
        }
    }
}
