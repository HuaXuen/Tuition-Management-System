using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace IOOP_Assignment
{
    public partial class EditProfile : Form
    {
        private User user;

        public EditProfile(string name, string username)
        {
            InitializeComponent();
            grpPass.Visible = false;
            txtName.Text = name;
            user = new User(username);
            txtUsername.Text = username;
            lblName.Text = name;
            lblRole.Text = user.Role;
         
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            grpPass.Visible = true;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbETC"].ToString()))
            {
                con.Open();
                if (txtCurrPassword.Text != user.getPassword())
                {
                    MessageBox.Show("Passwords do not match, please check again.");
                    return;
                }
                using (SqlCommand cmd = con.CreateCommand())
                {
                    if (txtPassword.Text == txtCPassword.Text)
                    {
                        user.ChangeName(txtName.Text);
                        cmd.CommandText = "UPDATE [User] set " +
                        "Password = '" + txtCPassword.Text + "'" +
                        "where Username = '" + user.Username + "'";
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("Password do not match");
                        return;
                    }
                MessageBox.Show("Profile updated successfully");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
