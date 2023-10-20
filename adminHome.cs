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
    public partial class adminHome : Form
    {
        public adminHome()
        {
            InitializeComponent();
        }

        public adminHome(string Name)
        {
            InitializeComponent();
            lblName.Text = Name;
        }

        private void adminHome_Load(object sender, EventArgs e)
        {
            ArrayList name = new ArrayList();
            name = User.ViewAllUser();
            foreach (var item in name)
            {
                listBoxStaff.Items.Add(item);   
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form f1 = new addStaff();
            f1.Show();

        }
    }
}
