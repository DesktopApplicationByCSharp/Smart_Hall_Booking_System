namespace HallsProjects
{
    partial class LoginForm
    {

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code



        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        /// 

        private void InitializeComponent()

        {
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnTogglePassword = new Button();
            btnLogin = new Button();
            lnkRegister = new LinkLabel();
            lblTitle = new Label();
            lblEmail = new Label();
            lblPassword = new Label();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.None;
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Location = new Point(66, 153);
            txtEmail.Margin = new Padding(5, 4, 5, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(372, 30);
            txtEmail.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.Font = new Font("Segoe UI", 10F);
            txtPassword.Location = new Point(66, 247);
            txtPassword.Margin = new Padding(5, 4, 5, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(372, 30);
            txtPassword.TabIndex = 1;
            // 
            // btnTogglePassword
            // 
            btnTogglePassword.Anchor = AnchorStyles.None;
            btnTogglePassword.FlatStyle = FlatStyle.Flat;
            btnTogglePassword.Location = new Point(446, 244);
            btnTogglePassword.Margin = new Padding(3, 4, 3, 4);
            btnTogglePassword.Name = "btnTogglePassword";
            btnTogglePassword.Size = new Size(34, 33);
            btnTogglePassword.TabIndex = 7;
            btnTogglePassword.Text = "👁";
            btnTogglePassword.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.None;
            btnLogin.BackColor = Color.DarkSlateBlue;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(66, 323);
            btnLogin.Margin = new Padding(5, 4, 5, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(374, 61);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // lnkRegister
            // 
            lnkRegister.Anchor = AnchorStyles.None;
            lnkRegister.AutoSize = true;
            lnkRegister.LinkColor = Color.DarkSlateBlue;
            lnkRegister.Location = new Point(106, 416);
            lnkRegister.Margin = new Padding(5, 0, 5, 0);
            lnkRegister.Name = "lnkRegister";
            lnkRegister.Size = new Size(254, 20);
            lnkRegister.TabIndex = 3;
            lnkRegister.TabStop = true;
            lnkRegister.Text = "Don't have an account? Register here";
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.DarkSlateBlue;
            lblTitle.Location = new Point(146, 47);
            lblTitle.Margin = new Padding(5, 0, 5, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(203, 37);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Welcome Back";
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.None;
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(66, 123);
            lblEmail.Margin = new Padding(5, 0, 5, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email:";
            // 
            // lblPassword
            // 
            lblPassword.Anchor = AnchorStyles.None;
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(66, 216);
            lblPassword.Margin = new Padding(5, 0, 5, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(73, 20);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "Password:";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(534, 539);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Controls.Add(lblTitle);
            Controls.Add(lnkRegister);
            Controls.Add(btnTogglePassword);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Margin = new Padding(5, 4, 5, 4);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HallEase - Login";
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnTogglePassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel lnkRegister;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
    }

            

}


