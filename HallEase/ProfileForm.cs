using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace HallsProjects
{
    public partial class ProfileForm : Form
    {
        private User _currentUser;

        public ProfileForm(User user)
        {
            InitializeComponent();
            _currentUser = user;

            // Wire events
            btnSave.Click += BtnSave_Click;
            btnBack.Click += (s, e) => this.Close();

            LoadUserData();

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

        private void LoadUserData()
        {
            if (_currentUser == null) return;
            txtName.Text = _currentUser.Name;
            txtEmail.Text = _currentUser.Email;
            txtPassword.Text = _currentUser.Password;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Name and Password cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "UPDATE Users SET Name = @Name, Password = @Password WHERE UserID = @UserID";
            SqlParameter[] parameters = {
                new SqlParameter("@Name", txtName.Text.Trim()),
                new SqlParameter("@Password", txtPassword.Text.Trim()),
                new SqlParameter("@UserID", _currentUser.UserID)
            };

            if (DatabaseHelper.ExecuteNonQuery(query, parameters) > 0)
            {
                _currentUser.Name = txtName.Text.Trim();
                _currentUser.Password = txtPassword.Text.Trim();
                MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to update profile.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            // Optional: ensure data is loaded when form Load fires
            LoadUserData();
        }
    }
}

