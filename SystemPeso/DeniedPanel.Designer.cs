
namespace SystemPeso
{
    partial class DeniedPanel
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
            this.ApprovedaBTN = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.DeniedDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barangay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateRegistered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DeniedDGV)).BeginInit();
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
            this.DeniedBTN.TabIndex = 4;
            this.DeniedBTN.Text = "Denied";
            this.DeniedBTN.UseVisualStyleBackColor = false;
            // 
            // ApprovedaBTN
            // 
            this.ApprovedaBTN.BackColor = System.Drawing.Color.White;
            this.ApprovedaBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApprovedaBTN.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApprovedaBTN.Location = new System.Drawing.Point(507, 38);
            this.ApprovedaBTN.Name = "ApprovedaBTN";
            this.ApprovedaBTN.Size = new System.Drawing.Size(248, 103);
            this.ApprovedaBTN.TabIndex = 5;
            this.ApprovedaBTN.Text = "Approved";
            this.ApprovedaBTN.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(164, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 103);
            this.button1.TabIndex = 6;
            this.button1.Text = "Pending";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // DeniedDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DeniedDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DeniedDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DeniedDGV.BackgroundColor = System.Drawing.Color.White;
            this.DeniedDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DeniedDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DeniedDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DeniedDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DeniedDGV.ColumnHeadersHeight = 21;
            this.DeniedDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Image,
            this.Age,
            this.Gender,
            this.Barangay,
            this.DateRegistered});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DeniedDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.DeniedDGV.EnableHeadersVisualStyles = false;
            this.DeniedDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DeniedDGV.Location = new System.Drawing.Point(63, 192);
            this.DeniedDGV.Name = "DeniedDGV";
            this.DeniedDGV.RowHeadersVisible = false;
            this.DeniedDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DeniedDGV.Size = new System.Drawing.Size(1162, 450);
            this.DeniedDGV.TabIndex = 7;
            this.DeniedDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DeniedDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DeniedDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DeniedDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DeniedDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DeniedDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DeniedDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DeniedDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DeniedDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DeniedDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DeniedDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DeniedDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DeniedDGV.ThemeStyle.HeaderStyle.Height = 21;
            this.DeniedDGV.ThemeStyle.ReadOnly = false;
            this.DeniedDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DeniedDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DeniedDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DeniedDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DeniedDGV.ThemeStyle.RowsStyle.Height = 22;
            this.DeniedDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DeniedDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            // Age
            // 
            this.Age.HeaderText = "Age";
            this.Age.Name = "Age";
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            // 
            // Barangay
            // 
            this.Barangay.HeaderText = "Barangay";
            this.Barangay.Name = "Barangay";
            // 
            // DateRegistered
            // 
            this.DateRegistered.HeaderText = "Date Registered";
            this.DateRegistered.Name = "DateRegistered";
            // 
            // DeniedPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1279, 677);
            this.Controls.Add(this.DeniedDGV);
            this.Controls.Add(this.DeniedBTN);
            this.Controls.Add(this.ApprovedaBTN);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeniedPanel";
            this.Text = "DeniedPanel";
            ((System.ComponentModel.ISupportInitialize)(this.DeniedDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DeniedBTN;
        private System.Windows.Forms.Button ApprovedaBTN;
        private System.Windows.Forms.Button button1;
        private Guna.UI2.WinForms.Guna2DataGridView DeniedDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barangay;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateRegistered;
    }
}