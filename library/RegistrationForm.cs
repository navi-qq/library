using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void handleAccountRegistration(object sender, EventArgs e)
        {
            if (emailField.Text.Length == 0 || passwordField.Text.Length == 0 || confirmPasswordField.Text.Length == 0)
            {
                MessageBox.Show("Field is empty!", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            if (passwordField.Text != confirmPasswordField.Text)
            {
                MessageBox.Show("Please enter the same password", "Confirmation Password Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            SqlConnection connection = new SqlConnection("Data Source=LAPTOP-QG0KG0AK;Initial Catalog=accountLogin;Integrated Security=True;TrustServerCertificate=True");

            connection.Open();

            string insertQuery = "INSERT INTO account_login VALUES (@user_email, @user_password)";

            SqlCommand command = new SqlCommand(insertQuery, connection);
            command.Parameters.AddWithValue("@user_email", emailField.Text);
            command.Parameters.AddWithValue("@user_password", passwordField.Text);
            command.ExecuteNonQuery();

            connection.Close();

            DialogResult dialogResult = MessageBox.Show("Account is successfully registered.", "Account Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (dialogResult == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
