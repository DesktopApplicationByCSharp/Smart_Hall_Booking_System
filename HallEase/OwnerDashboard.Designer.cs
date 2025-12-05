namespace HallsProjects
{
    partial class OwnerDashboard
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
            btnMyHalls = new Button();
            btnAddHall = new Button();
            btnMyBookings = new Button();
            btnProfile = new Button();
            btnLogout = new Button();
            lblWelcome = new Label();
            SuspendLayout();
            // 
            // btnMyHalls
            // 
            btnMyHalls.Anchor = AnchorStyles.None;
            btnMyHalls.BackColor = Color.SeaGreen;
            btnMyHalls.FlatStyle = FlatStyle.Flat;
            btnMyHalls.Font = new Font("Segoe UI", 11F);
            btnMyHalls.ForeColor = Color.White;
            btnMyHalls.Location = new Point(175, 92);
            btnMyHalls.Margin = new Padding(4, 3, 4, 3);
            btnMyHalls.Name = "btnMyHalls";
            btnMyHalls.Size = new Size(350, 52);
            btnMyHalls.TabIndex = 0;
            btnMyHalls.Text = "My Halls";
            btnMyHalls.UseVisualStyleBackColor = false;
            // 
            // btnAddHall
            // 
            btnAddHall.Anchor = AnchorStyles.None;
            btnAddHall.BackColor = Color.SeaGreen;
            btnAddHall.FlatStyle = FlatStyle.Flat;
            btnAddHall.Font = new Font("Segoe UI", 11F);
            btnAddHall.ForeColor = Color.White;
            btnAddHall.Location = new Point(175, 162);
            btnAddHall.Margin = new Padding(4, 3, 4, 3);
            btnAddHall.Name = "btnAddHall";
            btnAddHall.Size = new Size(350, 52);
            btnAddHall.TabIndex = 1;
            btnAddHall.Text = "Add New Hall";
            btnAddHall.UseVisualStyleBackColor = false;
            btnAddHall.Click += btnAddHall_Click_1;
            // 
            // btnMyBookings
            // 
            btnMyBookings.Anchor = AnchorStyles.None;
            btnMyBookings.BackColor = Color.SeaGreen;
            btnMyBookings.FlatStyle = FlatStyle.Flat;
            btnMyBookings.Font = new Font("Segoe UI", 11F);
            btnMyBookings.ForeColor = Color.White;
            btnMyBookings.Location = new Point(175, 231);
            btnMyBookings.Margin = new Padding(4, 3, 4, 3);
            btnMyBookings.Name = "btnMyBookings";
            btnMyBookings.Size = new Size(350, 52);
            btnMyBookings.TabIndex = 2;
            btnMyBookings.Text = "My Bookings";
            btnMyBookings.UseVisualStyleBackColor = false;
            // 
            // btnProfile
            // 
            btnProfile.Anchor = AnchorStyles.None;
            btnProfile.BackColor = Color.SeaGreen;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Font = new Font("Segoe UI", 11F);
            btnProfile.ForeColor = Color.White;
            btnProfile.Location = new Point(175, 300);
            btnProfile.Margin = new Padding(4, 3, 4, 3);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(350, 52);
            btnProfile.TabIndex = 3;
            btnProfile.Text = "My Profile";
            btnProfile.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLogout.BackColor = Color.IndianRed;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(525, 23);
            btnLogout.Margin = new Padding(4, 3, 4, 3);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(117, 35);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.DarkSlateBlue;
            lblWelcome.Location = new Point(23, 23);
            lblWelcome.Margin = new Padding(4, 0, 4, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(0, 25);
            lblWelcome.TabIndex = 5;
            // 
            // OwnerDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(700, 519);
            Controls.Add(lblWelcome);
            Controls.Add(btnLogout);
            Controls.Add(btnProfile);
            Controls.Add(btnMyBookings);
            Controls.Add(btnAddHall);
            Controls.Add(btnMyHalls);
            Margin = new Padding(4, 3, 4, 3);
            Name = "OwnerDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HallEase - Owner Dashboard";
            Load += OwnerDashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnMyHalls;
        private System.Windows.Forms.Button btnAddHall;
        private System.Windows.Forms.Button btnMyBookings;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblWelcome;
    }
}

