namespace HallsProjects
{
    partial class HallDetailsForm
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
            this.pbHallImage = new System.Windows.Forms.PictureBox();
            this.btnBookNow = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.grpDesc = new System.Windows.Forms.GroupBox();
            this.lblDesc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbHallImage)).BeginInit();
            this.grpDesc.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbHallImage
            // 
            this.pbHallImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbHallImage.BackColor = System.Drawing.Color.LightGray;
            this.pbHallImage.Location = new System.Drawing.Point(355, 20);
            this.pbHallImage.Name = "pbHallImage";
            this.pbHallImage.Size = new System.Drawing.Size(200, 150);
            this.pbHallImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHallImage.TabIndex = 7;
            this.pbHallImage.TabStop = false;
            // 
            // btnBookNow
            // 
            this.btnBookNow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBookNow.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnBookNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookNow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBookNow.ForeColor = System.Drawing.Color.White;
            this.btnBookNow.Location = new System.Drawing.Point(25, 350);
            this.btnBookNow.Name = "btnBookNow";
            this.btnBookNow.Size = new System.Drawing.Size(200, 50);
            this.btnBookNow.TabIndex = 0;
            this.btnBookNow.Text = "Book Now";
            this.btnBookNow.UseVisualStyleBackColor = false;
            //this.btnBookNow.Click += new System.EventHandler(this.BtnBookNow_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.BackColor = System.Drawing.Color.Gray;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(355, 350);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(200, 50);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            //this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblName.Location = new System.Drawing.Point(20, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 37);
            this.lblName.TabIndex = 2;
            // 
            // lblLocation
            // 
            this.lblLocation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblLocation.Location = new System.Drawing.Point(25, 70);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(0, 21);
            this.lblLocation.TabIndex = 3;
            // 
            // lblCapacity
            // 
            this.lblCapacity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCapacity.Location = new System.Drawing.Point(25, 100);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(0, 21);
            this.lblCapacity.TabIndex = 4;
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPrice.ForeColor = System.Drawing.Color.Green;
            this.lblPrice.Location = new System.Drawing.Point(25, 130);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(0, 21);
            this.lblPrice.TabIndex = 5;
            // 
            // grpDesc
            // 
            this.grpDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpDesc.Controls.Add(this.lblDesc);
            this.grpDesc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpDesc.Location = new System.Drawing.Point(25, 170);
            this.grpDesc.Name = "grpDesc";
            this.grpDesc.Size = new System.Drawing.Size(530, 150);
            this.grpDesc.TabIndex = 6;
            this.grpDesc.TabStop = false;
            this.grpDesc.Text = "Description";
            // 
            // lblDesc
            // 
            this.lblDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDesc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDesc.Location = new System.Drawing.Point(3, 19);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Padding = new System.Windows.Forms.Padding(10);
            this.lblDesc.Size = new System.Drawing.Size(524, 128);
            this.lblDesc.TabIndex = 0;
            // 
            // HallDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.grpDesc);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblCapacity);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnBookNow);
            this.Controls.Add(this.pbHallImage);
            this.Name = "HallDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HallEase - Hall Details";
            ((System.ComponentModel.ISupportInitialize)(this.pbHallImage)).EndInit();
            this.grpDesc.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnBookNow;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.GroupBox grpDesc;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.PictureBox pbHallImage;
    }
}

