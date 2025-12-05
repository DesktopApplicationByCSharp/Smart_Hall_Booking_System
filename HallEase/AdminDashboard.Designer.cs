namespace HallsProjects
{
    partial class AdminDashboard
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
        private void InitializeComponent()
        {
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.btnManageHalls = new System.Windows.Forms.Button();
            this.btnManageBookings = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnManageUsers.BackColor = System.Drawing.Color.SteelBlue;
            this.btnManageUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageUsers.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnManageUsers.ForeColor = System.Drawing.Color.White;
            this.btnManageUsers.Location = new System.Drawing.Point(150, 80);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(300, 45);
            this.btnManageUsers.TabIndex = 0;
            this.btnManageUsers.Text = "Manage Users";
            this.btnManageUsers.UseVisualStyleBackColor = false;
            //this.btnManageUsers.Click += new System.EventHandler(this.BtnManageUsers_Click);
            // 
            // btnManageHalls
            // 
            this.btnManageHalls.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnManageHalls.BackColor = System.Drawing.Color.SteelBlue;
            this.btnManageHalls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageHalls.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnManageHalls.ForeColor = System.Drawing.Color.White;
            this.btnManageHalls.Location = new System.Drawing.Point(150, 140);
            this.btnManageHalls.Name = "btnManageHalls";
            this.btnManageHalls.Size = new System.Drawing.Size(300, 45);
            this.btnManageHalls.TabIndex = 1;
            this.btnManageHalls.Text = "Manage Halls";
            this.btnManageHalls.UseVisualStyleBackColor = false;
            //this.btnManageHalls.Click += new System.EventHandler(this.BtnManageHalls_Click);
            // 
            // btnManageBookings
            // 
            this.btnManageBookings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnManageBookings.BackColor = System.Drawing.Color.SteelBlue;
            this.btnManageBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageBookings.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnManageBookings.ForeColor = System.Drawing.Color.White;
            this.btnManageBookings.Location = new System.Drawing.Point(150, 200);
            this.btnManageBookings.Name = "btnManageBookings";
            this.btnManageBookings.Size = new System.Drawing.Size(300, 45);
            this.btnManageBookings.TabIndex = 2;
            this.btnManageBookings.Text = "Manage Bookings";
            this.btnManageBookings.UseVisualStyleBackColor = false;
            //this.btnManageBookings.Click += new System.EventHandler(this.BtnManageBookings_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.IndianRed;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(450, 20);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 30);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            //this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblWelcome.Location = new System.Drawing.Point(20, 20);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(0, 25);
            this.lblWelcome.TabIndex = 4;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnManageBookings);
            this.Controls.Add(this.btnManageHalls);
            this.Controls.Add(this.btnManageUsers);
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HallEase - Admin Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Button btnManageHalls;
        private System.Windows.Forms.Button     btnManageBookings;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblWelcome;
    }
}

