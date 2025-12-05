using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HallsProjects
{

    public partial class LoginForm : Form
    {
        private AuthService _authService;

        public LoginForm()
        {
            _authService = new AuthService();
            InitializeComponent();

            // Wire events to designer controls
            btnLogin.Click += BtnLogin_Click;
            lnkRegister.Click += LnkRegister_Click;

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


        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter email and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            User user = _authService.Login(email, password);

            if (user != null)
            {
                this.Hide();
                Form dashboard = null;

                switch (user.Role)
                {
                    case "Admin":
                        dashboard = new AdminDashboard(user);
                        break;
                    case "Owner":
                        dashboard = new OwnerDashboard(user);
                        break;
                    case "Customer":
                        dashboard = new CustomerDashboard(user);
                        break;
                    default:
                        MessageBox.Show("Unknown role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Show();
                        return;
                }

                if (dashboard != null)
                {
                    dashboard.FormClosed += (s, args) => this.Show(); // Show login when dashboard closes (or handle logout)
                    dashboard.Show();
                }
            }
            else
            {
                MessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LnkRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            this.Hide();
            registerForm.FormClosed += (s, args) => this.Show();
            registerForm.Show();
        }
    }

}
