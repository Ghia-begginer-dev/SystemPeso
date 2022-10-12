
namespace SystemPeso
{
    partial class ApprovedPanel
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
            this.DeniedBTN = new System.Windows.Forms.Button();
            this.ApprovedBTN = new System.Windows.Forms.Button();
            this.PendingBTN = new System.Windows.Forms.Button();
            this.ApprovedDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barangay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateRegistered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ApprovedDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // DeniedBTN
            // 
            this.DeniedBTN.BackColor = System.Drawing.Color.White;
            this.DeniedBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeniedBTN.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeniedBTN.Location = new System.Drawing.Point(851, 38);
            this.DeniedBTN.Name = "DeniedBTN";
            this.DeniedBTN.Size = new System.Drawing.Size(248, 103);
            this.DeniedBTN.TabIndex = 1;
            this.DeniedBTN.Text = "Denied";
            this.DeniedBTN.UseVisualStyleBackColor = false;
            // 
            // ApprovedBTN
            // 
            this.ApprovedBTN.BackColor = System.Drawing.Color.White;
            this.ApprovedBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApprovedBTN.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApprovedBTN.Location = new System.Drawing.Point(507, 38);
            this.ApprovedBTN.Name = "ApprovedBTN";
            this.ApprovedBTN.Size = new System.Drawing.Size(248, 103);
            this.ApprovedBTN.TabIndex = 2;
            this.ApprovedBTN.Text = "Approved";
            this.ApprovedBTN.UseVisualStyleBackColor = false;
            // 
            // PendingBTN
            // 
            this.PendingBTN.BackColor = System.Drawing.Color.White;
            this.PendingBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PendingBTN.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PendingBTN.Location = new System.Drawing.Point(164, 38);
            this.PendingBTN.Name = "PendingBTN";
            this.PendingBTN.Size = new System.Drawing.Size(248, 103);
            this.PendingBTN.TabIndex = 3;
            this.PendingBTN.Text = "Pending";
            this.PendingBTN.UseVisualStyleBackColor = false;
            // 
            // ApprovedDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.ApprovedDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ApprovedDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ApprovedDGV.BackgroundColor = System.Drawing.Color.White;
            this.ApprovedDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ApprovedDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ApprovedDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ApprovedDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ApprovedDGV.ColumnHeadersHeight = 21;
            this.ApprovedDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Image,
            this.FullName,
            this.Age,
            this.gender,
            this.barangay,
            this.DateRegistered});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ApprovedDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.ApprovedDGV.EnableHeadersVisualStyles = false;
            this.ApprovedDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ApprovedDGV.Location = new System.Drawing.Point(63, 192);
            this.ApprovedDGV.Name = "ApprovedDGV";
            this.ApprovedDGV.RowHeadersVisible = false;
            this.ApprovedDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ApprovedDGV.Size = new System.Drawing.Size(1162, 450);
            this.ApprovedDGV.TabIndex = 4;
            this.ApprovedDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ApprovedDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ApprovedDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ApprovedDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ApprovedDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ApprovedDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ApprovedDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ApprovedDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ApprovedDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ApprovedDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ApprovedDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ApprovedDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ApprovedDGV.ThemeStyle.HeaderStyle.Height = 21;
            this.ApprovedDGV.ThemeStyle.ReadOnly = false;
            this.ApprovedDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ApprovedDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ApprovedDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ApprovedDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ApprovedDGV.ThemeStyle.RowsStyle.Height = 22;
            this.ApprovedDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ApprovedDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Image
            // 
            this.Image.HeaderText = "Image";
            this.Image.Name = "Image";
            // 
            // FullName
            // 
            this.FullName.HeaderText = "Full Name";
            this.FullName.Name = "FullName";
            // 
            // Age
            // 
            this.Age.HeaderText = "Age";
            this.Age.Name = "Age";
            // 
            // gender
            // 
            this.gender.HeaderText = "Gender";
            this.gender.Name = "gender";
            // 
            // barangay
            // 
            this.barangay.HeaderText = "Barangay";
            this.barangay.Name = "barangay";
            // 
            // DateRegistered
            // 
            this.DateRegistered.HeaderText = "Date Registered";
            this.DateRegistered.Name = "DateRegistered";
            // 
            // ApprovedPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1279, 677);
            this.Controls.Add(this.ApprovedDGV);
            this.Controls.Add(this.DeniedBTN);
            this.Controls.Add(this.ApprovedBTN);
            this.Controls.Add(this.PendingBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ApprovedPanel";
            this.Text = "ApprovedPanel";
            ((System.ComponentModel.ISupportInitialize)(this.ApprovedDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DeniedBTN;
        private System.Windows.Forms.Button ApprovedBTN;
        private System.Windows.Forms.Button PendingBTN;
        private Guna.UI2.WinForms.Guna2DataGridView ApprovedDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn barangay;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateRegistered;
    }
}