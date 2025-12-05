using System;
using System.Windows.Forms;
using System.Drawing;

namespace HallsProjects
{

    public partial class RegisterForm : Form
    {
        private AuthService _authService;

        public RegisterForm()
        {
            _authService = new AuthService();
            InitializeComponent();

            // Wire up events defined in the designer
            btnCreateAccount.Click += BtnCreateAccount_Click;
            btnBack.Click += (s, e) => this.Close();

            // Password toggle
            btnTogglePassword.Click += (s, e) => {
                if (txtPassword.PasswordChar == '*')
                {
                    txtPassword.PasswordChar = '\0';
                }
                else
                {
                    txtPassword.PasswordChar = '*';
                }
            };
        }

        private void BtnCreateAccount_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            string role = "Customer";

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_authService.Register(name, email, password, role))
            {
                MessageBox.Show("Account created successfully! Please login.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Registration failed. Email might already be in use.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}

