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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            User UserObj = new User(textBox_Username.Text);
            Form form = UserObj.login(textBox_Password.Text);
            if (form == null)
            {
                MessageBox.Show("Invalid Username or Password");
                textBox_Username.Text = String.Empty;
                textBox_Password.Text = String.Empty;
            }
            else
            {
                Hide();
                form.FormClosed += childForm_Closed;
            }
        }

        private void childForm_Closed(object? sender, FormClosedEventArgs e)
        {
            Show();
        }

    }
}
