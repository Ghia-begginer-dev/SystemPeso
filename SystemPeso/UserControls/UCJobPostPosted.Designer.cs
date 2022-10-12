
namespace SystemPeso.UserControls
{
    partial class UCJobPostPosted
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.JobPostPanel = new SystemPeso.UserControls.CustomPanel();
            this.JobTitleLbl = new System.Windows.Forms.Label();
            this.WaitingLbl = new System.Windows.Forms.Label();
            this.ActiveLbl = new System.Windows.Forms.Label();
            this.ReviewedLbl = new System.Windows.Forms.Label();
            this.StatusCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.WaitingNoLbl = new System.Windows.Forms.Label();
            this.ActiveNoLbl = new System.Windows.Forms.Label();
            this.ReviewedNoLbl = new System.Windows.Forms.Label();
            this.JobPostPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // JobPostPanel
            // 
            this.JobPostPanel.BackColor = System.Drawing.Color.White;
            this.JobPostPanel.BorderRadius = 30;
            this.JobPostPanel.Controls.Add(this.ReviewedNoLbl);
            this.JobPostPanel.Controls.Add(this.ActiveNoLbl);
            this.JobPostPanel.Controls.Add(this.WaitingNoLbl);
            this.JobPostPanel.Controls.Add(this.StatusCB);
            this.JobPostPanel.Controls.Add(this.ReviewedLbl);
            this.JobPostPanel.Controls.Add(this.ActiveLbl);
            this.JobPostPanel.Controls.Add(this.WaitingLbl);
            this.JobPostPanel.Controls.Add(this.JobTitleLbl);
            this.JobPostPanel.ForeColor = System.Drawing.Color.Black;
            this.JobPostPanel.GradientAngle = 90F;
            this.JobPostPanel.GradientBottomColor = System.Drawing.Color.White;
            this.JobPostPanel.GradientTopColor = System.Drawing.Color.White;
            this.JobPostPanel.Location = new System.Drawing.Point(3, 3);
            this.JobPostPanel.Name = "JobPostPanel";
            this.JobPostPanel.Size = new System.Drawing.Size(1043, 103);
            this.JobPostPanel.TabIndex = 0;
            // 
            // JobTitleLbl
            // 
            this.JobTitleLbl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JobTitleLbl.Location = new System.Drawing.Point(39, 45);
            this.JobTitleLbl.Name = "JobTitleLbl";
            this.JobTitleLbl.Size = new System.Drawing.Size(201, 23);
            this.JobTitleLbl.TabIndex = 0;
            this.JobTitleLbl.Text = "Quality Control Specialist";
            // 
            // WaitingLbl
            // 
            this.WaitingLbl.AutoSize = true;
            this.WaitingLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WaitingLbl.Location = new System.Drawing.Point(423, 65);
            this.WaitingLbl.Name = "WaitingLbl";
            this.WaitingLbl.Size = new System.Drawing.Size(62, 16);
            this.WaitingLbl.TabIndex = 1;
            this.WaitingLbl.Text = "Waiting ";
            // 
            // ActiveLbl
            // 
            this.ActiveLbl.AutoSize = true;
            this.ActiveLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActiveLbl.Location = new System.Drawing.Point(516, 65);
            this.ActiveLbl.Name = "ActiveLbl";
            this.ActiveLbl.Size = new System.Drawing.Size(49, 16);
            this.ActiveLbl.TabIndex = 1;
            this.ActiveLbl.Text = "Active";
            // 
            // ReviewedLbl
            // 
            this.ReviewedLbl.AutoSize = true;
            this.ReviewedLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReviewedLbl.Location = new System.Drawing.Point(607, 65);
            this.ReviewedLbl.Name = "ReviewedLbl";
            this.ReviewedLbl.Size = new System.Drawing.Size(70, 16);
            this.ReviewedLbl.TabIndex = 1;
            this.ReviewedLbl.Text = "Reviewed";
            // 
            // StatusCB
            // 
            this.StatusCB.BackColor = System.Drawing.Color.Transparent;
            this.StatusCB.BorderRadius = 10;
            this.StatusCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.StatusCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StatusCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StatusCB.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.StatusCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.StatusCB.ItemHeight = 30;
            this.StatusCB.Items.AddRange(new object[] {
            "Open ",
            "Close"});
            this.StatusCB.Location = new System.Drawing.Point(886, 36);
            this.StatusCB.Name = "StatusCB";
            this.StatusCB.Size = new System.Drawing.Size(118, 36);
            this.StatusCB.TabIndex = 3;
            // 
            // WaitingNoLbl
            // 
            this.WaitingNoLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WaitingNoLbl.Location = new System.Drawing.Point(430, 32);
            this.WaitingNoLbl.Name = "WaitingNoLbl";
            this.WaitingNoLbl.Size = new System.Drawing.Size(44, 23);
            this.WaitingNoLbl.TabIndex = 4;
            this.WaitingNoLbl.Text = "No.";
            // 
            // ActiveNoLbl
            // 
            this.ActiveNoLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActiveNoLbl.Location = new System.Drawing.Point(521, 32);
            this.ActiveNoLbl.Name = "ActiveNoLbl";
            this.ActiveNoLbl.Size = new System.Drawing.Size(44, 23);
            this.ActiveNoLbl.TabIndex = 4;
            this.ActiveNoLbl.Text = "No.";
            // 
            // ReviewedNoLbl
            // 
            this.ReviewedNoLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReviewedNoLbl.Location = new System.Drawing.Point(621, 32);
            this.ReviewedNoLbl.Name = "ReviewedNoLbl";
            this.ReviewedNoLbl.Size = new System.Drawing.Size(44, 23);
            this.ReviewedNoLbl.TabIndex = 4;
            this.ReviewedNoLbl.Text = "No.";
            // 
            // UCJobPostPosted
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.JobPostPanel);
            this.Name = "UCJobPostPosted";
            this.Size = new System.Drawing.Size(1050, 111);
            this.JobPostPanel.ResumeLayout(false);
            this.JobPostPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomPanel JobPostPanel;
        private System.Windows.Forms.Label ReviewedNoLbl;
        private System.Windows.Forms.Label ActiveNoLbl;
        private System.Windows.Forms.Label WaitingNoLbl;
        private Guna.UI2.WinForms.Guna2ComboBox StatusCB;
        private System.Windows.Forms.Label ReviewedLbl;
        private System.Windows.Forms.Label ActiveLbl;
        private System.Windows.Forms.Label WaitingLbl;
        private System.Windows.Forms.Label JobTitleLbl;
    }
}
