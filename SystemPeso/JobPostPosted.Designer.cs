
namespace SystemPeso
{
    partial class JobPostPosted
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
            this.JobPostReportsBTN = new Guna.UI2.WinForms.Guna2Button();
            this.JobTitleLbl = new System.Windows.Forms.Label();
            this.CandidatesLbl = new System.Windows.Forms.Label();
            this.JobStatusLbl = new System.Windows.Forms.Label();
            this.CreatePostBTN = new Guna.UI2.WinForms.Guna2Button();
            this.ucJobPostPosted1 = new SystemPeso.UserControls.UCJobPostPosted();
            this.JobPostReportsPanel = new SystemPeso.UserControls.CustomPanel();
            this.JobPostReportsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // JobPostReportsBTN
            // 
            this.JobPostReportsBTN.BorderRadius = 8;
            this.JobPostReportsBTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.JobPostReportsBTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.JobPostReportsBTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.JobPostReportsBTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.JobPostReportsBTN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JobPostReportsBTN.ForeColor = System.Drawing.Color.White;
            this.JobPostReportsBTN.Location = new System.Drawing.Point(264, 35);
            this.JobPostReportsBTN.Name = "JobPostReportsBTN";
            this.JobPostReportsBTN.Size = new System.Drawing.Size(167, 61);
            this.JobPostReportsBTN.TabIndex = 10;
            this.JobPostReportsBTN.Text = "Job Post Reports";
            // 
            // JobTitleLbl
            // 
            this.JobTitleLbl.AutoSize = true;
            this.JobTitleLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JobTitleLbl.Location = new System.Drawing.Point(179, 130);
            this.JobTitleLbl.Name = "JobTitleLbl";
            this.JobTitleLbl.Size = new System.Drawing.Size(71, 19);
            this.JobTitleLbl.TabIndex = 0;
            this.JobTitleLbl.Text = "Job Title";
            // 
            // CandidatesLbl
            // 
            this.CandidatesLbl.AutoSize = true;
            this.CandidatesLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CandidatesLbl.Location = new System.Drawing.Point(578, 130);
            this.CandidatesLbl.Name = "CandidatesLbl";
            this.CandidatesLbl.Size = new System.Drawing.Size(99, 19);
            this.CandidatesLbl.TabIndex = 0;
            this.CandidatesLbl.Text = "Candidates";
            // 
            // JobStatusLbl
            // 
            this.JobStatusLbl.AutoSize = true;
            this.JobStatusLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JobStatusLbl.Location = new System.Drawing.Point(1005, 130);
            this.JobStatusLbl.Name = "JobStatusLbl";
            this.JobStatusLbl.Size = new System.Drawing.Size(85, 19);
            this.JobStatusLbl.TabIndex = 0;
            this.JobStatusLbl.Text = "Job Status";
            // 
            // CreatePostBTN
            // 
            this.CreatePostBTN.BorderRadius = 8;
            this.CreatePostBTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CreatePostBTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CreatePostBTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CreatePostBTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CreatePostBTN.FillColor = System.Drawing.Color.White;
            this.CreatePostBTN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatePostBTN.ForeColor = System.Drawing.Color.Black;
            this.CreatePostBTN.Image = global::SystemPeso.Properties.Resources.add__1_;
            this.CreatePostBTN.ImageSize = new System.Drawing.Size(32, 32);
            this.CreatePostBTN.Location = new System.Drawing.Point(68, 35);
            this.CreatePostBTN.Name = "CreatePostBTN";
            this.CreatePostBTN.Size = new System.Drawing.Size(167, 61);
            this.CreatePostBTN.TabIndex = 9;
            this.CreatePostBTN.Text = "Create Post";
            // 
            // ucJobPostPosted1
            // 
            this.ucJobPostPosted1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ucJobPostPosted1.Location = new System.Drawing.Point(44, 31);
            this.ucJobPostPosted1.Name = "ucJobPostPosted1";
            this.ucJobPostPosted1.Size = new System.Drawing.Size(1050, 111);
            this.ucJobPostPosted1.TabIndex = 0;
            // 
            // JobPostReportsPanel
            // 
            this.JobPostReportsPanel.BackColor = System.Drawing.Color.White;
            this.JobPostReportsPanel.BorderRadius = 30;
            this.JobPostReportsPanel.Controls.Add(this.ucJobPostPosted1);
            this.JobPostReportsPanel.ForeColor = System.Drawing.Color.Black;
            this.JobPostReportsPanel.GradientAngle = 90F;
            this.JobPostReportsPanel.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.JobPostReportsPanel.GradientTopColor = System.Drawing.Color.Gray;
            this.JobPostReportsPanel.Location = new System.Drawing.Point(68, 169);
            this.JobPostReportsPanel.Name = "JobPostReportsPanel";
            this.JobPostReportsPanel.Size = new System.Drawing.Size(1145, 477);
            this.JobPostReportsPanel.TabIndex = 11;
            // 
            // JobPostPosted
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 681);
            this.Controls.Add(this.JobPostReportsPanel);
            this.Controls.Add(this.JobStatusLbl);
            this.Controls.Add(this.CandidatesLbl);
            this.Controls.Add(this.CreatePostBTN);
            this.Controls.Add(this.JobTitleLbl);
            this.Controls.Add(this.JobPostReportsBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "JobPostPosted";
            this.Text = " ";
            this.JobPostReportsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button CreatePostBTN;
        private Guna.UI2.WinForms.Guna2Button JobPostReportsBTN;
        private System.Windows.Forms.Label JobTitleLbl;
        private System.Windows.Forms.Label JobStatusLbl;
        private System.Windows.Forms.Label CandidatesLbl;
        private UserControls.UCJobPostPosted ucJobPostPosted1;
        private UserControls.CustomPanel JobPostReportsPanel;
    }
}