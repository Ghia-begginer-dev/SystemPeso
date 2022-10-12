
namespace SystemPeso
{
    partial class PendingApprovalPanel
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
            this.DeniedBTN = new System.Windows.Forms.Button();
            this.ApprovedBTN = new System.Windows.Forms.Button();
            this.PendingBTN = new System.Windows.Forms.Button();
            this.PendingPanel = new SystemPeso.UserControls.CustomPanel();
            this.ucPendingHomeownerAcc1 = new SystemPeso.UserControls.UCPendingHomeownerAcc();
            this.ucPendingEmployerAcc1 = new SystemPeso.UserControls.UCPendingEmployerAcc();
            this.ucPendingSkilledAcc1 = new SystemPeso.UserControls.UCPendingSkilledAcc();
            this.PendingPanel.SuspendLayout();
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
            this.DeniedBTN.TabIndex = 7;
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
            this.ApprovedBTN.TabIndex = 8;
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
            this.PendingBTN.TabIndex = 9;
            this.PendingBTN.Text = "Pending";
            this.PendingBTN.UseVisualStyleBackColor = false;
            // 
            // PendingPanel
            // 
            this.PendingPanel.BackColor = System.Drawing.Color.White;
            this.PendingPanel.BorderRadius = 30;
            this.PendingPanel.Controls.Add(this.ucPendingHomeownerAcc1);
            this.PendingPanel.Controls.Add(this.ucPendingEmployerAcc1);
            this.PendingPanel.Controls.Add(this.ucPendingSkilledAcc1);
            this.PendingPanel.ForeColor = System.Drawing.Color.Black;
            this.PendingPanel.GradientAngle = 90F;
            this.PendingPanel.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.PendingPanel.GradientTopColor = System.Drawing.Color.Gray;
            this.PendingPanel.Location = new System.Drawing.Point(38, 168);
            this.PendingPanel.Name = "PendingPanel";
            this.PendingPanel.Size = new System.Drawing.Size(1207, 473);
            this.PendingPanel.TabIndex = 10;
            // 
            // ucPendingHomeownerAcc1
            // 
            this.ucPendingHomeownerAcc1.Location = new System.Drawing.Point(83, 320);
            this.ucPendingHomeownerAcc1.Name = "ucPendingHomeownerAcc1";
            this.ucPendingHomeownerAcc1.Size = new System.Drawing.Size(1050, 111);
            this.ucPendingHomeownerAcc1.TabIndex = 2;
            // 
            // ucPendingEmployerAcc1
            // 
            this.ucPendingEmployerAcc1.Location = new System.Drawing.Point(83, 181);
            this.ucPendingEmployerAcc1.Name = "ucPendingEmployerAcc1";
            this.ucPendingEmployerAcc1.Size = new System.Drawing.Size(1050, 111);
            this.ucPendingEmployerAcc1.TabIndex = 1;
            // 
            // ucPendingSkilledAcc1
            // 
            this.ucPendingSkilledAcc1.Location = new System.Drawing.Point(83, 49);
            this.ucPendingSkilledAcc1.Name = "ucPendingSkilledAcc1";
            this.ucPendingSkilledAcc1.Size = new System.Drawing.Size(1050, 111);
            this.ucPendingSkilledAcc1.TabIndex = 0;
            // 
            // PendingApprovalPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1279, 677);
            this.Controls.Add(this.PendingPanel);
            this.Controls.Add(this.DeniedBTN);
            this.Controls.Add(this.ApprovedBTN);
            this.Controls.Add(this.PendingBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PendingApprovalPanel";
            this.Text = "PendingApprovalPanel";
            this.PendingPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DeniedBTN;
        private System.Windows.Forms.Button ApprovedBTN;
        private System.Windows.Forms.Button PendingBTN;
        private UserControls.CustomPanel PendingPanel;
        private UserControls.UCPendingSkilledAcc ucPendingSkilledAcc1;
        private UserControls.UCPendingHomeownerAcc ucPendingHomeownerAcc1;
        private UserControls.UCPendingEmployerAcc ucPendingEmployerAcc1;
    }
}