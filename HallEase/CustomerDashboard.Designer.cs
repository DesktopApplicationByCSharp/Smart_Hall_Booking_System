namespace HallsProjects
{
    partial class CustomerDashboard
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
            this.btnViewHalls = new System.Windows.Forms.Button();
            this.btnMyBookings = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnViewHalls
            // 
            this.btnViewHalls.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnViewHalls.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnViewHalls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewHalls.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnViewHalls.ForeColor = System.Drawing.Color.White;
            this.btnViewHalls.Location = new System.Drawing.Point(150, 80);
            this.btnViewHalls.Name = "btnViewHalls";
            this.btnViewHalls.Size = new System.Drawing.Size(300, 45);
            this.btnViewHalls.TabIndex = 0;
            this.btnViewHalls.Text = "Browse Halls";
            this.btnViewHalls.UseVisualStyleBackColor = false;
            //this.btnViewHalls.Click += new System.EventHandler(this.BtnViewHalls_Click);
            // 
            // btnMyBookings
            // 
            this.btnMyBookings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMyBookings.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnMyBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyBookings.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnMyBookings.ForeColor = System.Drawing.Color.White;
            this.btnMyBookings.Location = new System.Drawing.Point(150, 140);
            this.btnMyBookings.Name = "btnMyBookings";
            this.btnMyBookings.Size = new System.Drawing.Size(300, 45);
            this.btnMyBookings.TabIndex = 1;
            this.btnMyBookings.Text = "My Bookings";
            this.btnMyBookings.UseVisualStyleBackColor = false;
            //this.btnMyBookings.Click += new System.EventHandler(this.BtnMyBookings_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProfile.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.Location = new System.Drawing.Point(150, 200);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(300, 45);
            this.btnProfile.TabIndex = 2;
            this.btnProfile.Text = "My Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            //this.btnProfile.Click += new System.EventHandler(this.BtnProfile_Click);
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
            // CustomerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnMyBookings);
            this.Controls.Add(this.btnViewHalls);
            this.Name = "CustomerDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HallEase - Customer Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnViewHalls;
        private System.Windows.Forms.Button btnMyBookings;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblWelcome;
    }
}

