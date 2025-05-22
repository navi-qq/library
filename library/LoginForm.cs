using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();
        }

        private void handleAccountLogin(object sender, EventArgs e)
        {

            if (emailLoginField.Text.Length == 0 || passwordLoginField.Text.Length == 0)
            {
                MessageBox.Show("The fields are empty",
                                "Empty Field",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                return;
            }
            SqlConnection connection = new SqlConnection("Data Source=LAPTOP-QG0KG0AK;Initial Catalog=accountLogin;Integrated Security=True;TrustServerCertificate=True");

            connection.Open();

            string insertQuery = "SELECT COUNT(*) FROM account_login WHERE user_email=@user_email AND user_password=@user_password";

            SqlCommand command = new SqlCommand(insertQuery, connection);

            command.Parameters.AddWithValue("@user_email", emailLoginField.Text);
            command.Parameters.AddWithValue("@user_password", passwordLoginField.Text);

            int count = (int)command.ExecuteScalar();

            connection.Close();



            if (count == 0)
            {
                MessageBox.Show("Please enter the correct password or email",
                                "Account Login Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                return;
            }


            MessageBox.Show("You're now logged in!",
                            "Login Successful",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            MainForm mainForm = new MainForm();
            mainForm.Show();
            mainForm.Shown += (sender, e) =>
            {
                this.Hide();
            };
        }

        private void handleShowPassword(object sender, EventArgs e)
        {
            passwordLoginField.PasswordChar = showPassword.Checked ? '\0' : '*';
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
