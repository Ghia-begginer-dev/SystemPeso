
namespace SystemPeso
{
    partial class JobPostReports
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CreatePostBTN = new Guna.UI2.WinForms.Guna2Button();
            this.JobPostReportsBTN = new Guna.UI2.WinForms.Guna2Button();
            this.JobPostReportsDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoOfApplicants = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatePosted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobPostStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.JobPostReportsDGV)).BeginInit();
            this.SuspendLayout();
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
            this.CreatePostBTN.TabIndex = 7;
            this.CreatePostBTN.Text = "Create Post";
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
            this.JobPostReportsBTN.TabIndex = 8;
            this.JobPostReportsBTN.Text = "Job Post Reports";
            // 
            // JobPostReportsDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.JobPostReportsDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.JobPostReportsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.JobPostReportsDGV.BackgroundColor = System.Drawing.Color.White;
            this.JobPostReportsDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.JobPostReportsDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.JobPostReportsDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.JobPostReportsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.JobPostReportsDGV.ColumnHeadersHeight = 21;
            this.JobPostReportsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Image,
            this.CompanyName,
            this.NoOfApplicants,
            this.JobType,
            this.DatePosted,
            this.JobPostStatus});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.JobPostReportsDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.JobPostReportsDGV.EnableHeadersVisualStyles = false;
            this.JobPostReportsDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.JobPostReportsDGV.Location = new System.Drawing.Point(68, 151);
            this.JobPostReportsDGV.Name = "JobPostReportsDGV";
            this.JobPostReportsDGV.RowHeadersVisible = false;
            this.JobPostReportsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.JobPostReportsDGV.Size = new System.Drawing.Size(1162, 450);
            this.JobPostReportsDGV.TabIndex = 9;
            this.JobPostReportsDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.JobPostReportsDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.JobPostReportsDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.JobPostReportsDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.JobPostReportsDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.JobPostReportsDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.JobPostReportsDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.JobPostReportsDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.JobPostReportsDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.JobPostReportsDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.JobPostReportsDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.JobPostReportsDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.JobPostReportsDGV.ThemeStyle.HeaderStyle.Height = 21;
            this.JobPostReportsDGV.ThemeStyle.ReadOnly = false;
            this.JobPostReportsDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.JobPostReportsDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.JobPostReportsDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.JobPostReportsDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.JobPostReportsDGV.ThemeStyle.RowsStyle.Height = 22;
            this.JobPostReportsDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.JobPostReportsDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Image
            // 
            this.Image.HeaderText = "Image";
            this.Image.Name = "Image";
            // 
            // CompanyName
            // 
            this.CompanyName.HeaderText = "Company Name";
            this.CompanyName.Name = "CompanyName";
            // 
            // NoOfApplicants
            // 
            this.NoOfApplicants.HeaderText = "No. of Applicants";
            this.NoOfApplicants.Name = "NoOfApplicants";
            // 
            // JobType
            // 
            this.JobType.HeaderText = "Job Type";
            this.JobType.Name = "JobType";
            // 
            // DatePosted
            // 
            this.DatePosted.HeaderText = "Date Posted";
            this.DatePosted.Name = "DatePosted";
            // 
            // JobPostStatus
            // 
            this.JobPostStatus.HeaderText = "Job Post Status";
            this.JobPostStatus.Name = "JobPostStatus";
            // 
            // JobPostReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 681);
            this.Controls.Add(this.JobPostReportsDGV);
            this.Controls.Add(this.CreatePostBTN);
            this.Controls.Add(this.JobPostReportsBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "JobPostReports";
            this.Text = "JobPostReports";
            ((System.ComponentModel.ISupportInitialize)(this.JobPostReportsDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button CreatePostBTN;
        private Guna.UI2.WinForms.Guna2Button JobPostReportsBTN;
        private Guna.UI2.WinForms.Guna2DataGridView JobPostReportsDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoOfApplicants;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobType;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatePosted;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobPostStatus;
    }
}