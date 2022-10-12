
namespace SystemPeso.UserControls
{
    partial class UCPendingHomeownerAcc
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
            this.ApplicantPanel = new SystemPeso.UserControls.CustomPanel();
            this.AgeLbl = new System.Windows.Forms.Label();
            this.ApplicantGenderLbl = new System.Windows.Forms.Label();
            this.SkilledWorkerLbl = new System.Windows.Forms.Label();
            this.DateRegisteredLbl = new System.Windows.Forms.Label();
            this.ApplicantNameLbl = new System.Windows.Forms.Label();
            this.ApplicantPB = new SystemPeso.UserControls.CircularPictureBox();
            this.ApplicantPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ApplicantPB)).BeginInit();
            this.SuspendLayout();
            // 
            // ApplicantPanel
            // 
            this.ApplicantPanel.BackColor = System.Drawing.Color.White;
            this.ApplicantPanel.BorderRadius = 30;
            this.ApplicantPanel.Controls.Add(this.AgeLbl);
            this.ApplicantPanel.Controls.Add(this.ApplicantGenderLbl);
            this.ApplicantPanel.Controls.Add(this.SkilledWorkerLbl);
            this.ApplicantPanel.Controls.Add(this.DateRegisteredLbl);
            this.ApplicantPanel.Controls.Add(this.ApplicantNameLbl);
            this.ApplicantPanel.Controls.Add(this.ApplicantPB);
            this.ApplicantPanel.ForeColor = System.Drawing.Color.Black;
            this.ApplicantPanel.GradientAngle = 90F;
            this.ApplicantPanel.GradientBottomColor = System.Drawing.Color.White;
            this.ApplicantPanel.GradientTopColor = System.Drawing.Color.White;
            this.ApplicantPanel.Location = new System.Drawing.Point(4, 4);
            this.ApplicantPanel.Name = "ApplicantPanel";
            this.ApplicantPanel.Size = new System.Drawing.Size(1043, 103);
            this.ApplicantPanel.TabIndex = 1;
            // 
            // AgeLbl
            // 
            this.AgeLbl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeLbl.Location = new System.Drawing.Point(269, 60);
            this.AgeLbl.Name = "AgeLbl";
            this.AgeLbl.Size = new System.Drawing.Size(66, 22);
            this.AgeLbl.TabIndex = 1;
            this.AgeLbl.Text = "Age";
            // 
            // ApplicantGenderLbl
            // 
            this.ApplicantGenderLbl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplicantGenderLbl.Location = new System.Drawing.Point(181, 60);
            this.ApplicantGenderLbl.Name = "ApplicantGenderLbl";
            this.ApplicantGenderLbl.Size = new System.Drawing.Size(66, 22);
            this.ApplicantGenderLbl.TabIndex = 1;
            this.ApplicantGenderLbl.Text = "Gender";
            // 
            // SkilledWorkerLbl
            // 
            this.SkilledWorkerLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkilledWorkerLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(59)))), ((int)(((byte)(183)))));
            this.SkilledWorkerLbl.Location = new System.Drawing.Point(871, 39);
            this.SkilledWorkerLbl.Name = "SkilledWorkerLbl";
            this.SkilledWorkerLbl.Size = new System.Drawing.Size(145, 22);
            this.SkilledWorkerLbl.TabIndex = 1;
            this.SkilledWorkerLbl.Text = "Homeowner";
            // 
            // DateRegisteredLbl
            // 
            this.DateRegisteredLbl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateRegisteredLbl.Location = new System.Drawing.Point(499, 39);
            this.DateRegisteredLbl.Name = "DateRegisteredLbl";
            this.DateRegisteredLbl.Size = new System.Drawing.Size(213, 22);
            this.DateRegisteredLbl.TabIndex = 1;
            this.DateRegisteredLbl.Text = "Date Registered";
            // 
            // ApplicantNameLbl
            // 
            this.ApplicantNameLbl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplicantNameLbl.Location = new System.Drawing.Point(181, 28);
            this.ApplicantNameLbl.Name = "ApplicantNameLbl";
            this.ApplicantNameLbl.Size = new System.Drawing.Size(265, 22);
            this.ApplicantNameLbl.TabIndex = 1;
            this.ApplicantNameLbl.Text = "Name";
            // 
            // ApplicantPB
            // 
            this.ApplicantPB.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.ApplicantPB.BorderColor = System.Drawing.Color.RoyalBlue;
            this.ApplicantPB.BorderColor2 = System.Drawing.Color.HotPink;
            this.ApplicantPB.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.ApplicantPB.BorderSize = 2;
            this.ApplicantPB.GradientAngle = 50F;
            this.ApplicantPB.Location = new System.Drawing.Point(46, 3);
            this.ApplicantPB.Name = "ApplicantPB";
            this.ApplicantPB.Size = new System.Drawing.Size(92, 92);
            this.ApplicantPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ApplicantPB.TabIndex = 0;
            this.ApplicantPB.TabStop = false;
            // 
            // UCPendingHomeownerAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ApplicantPanel);
            this.Name = "UCPendingHomeownerAcc";
            this.Size = new System.Drawing.Size(1050, 111);
            this.ApplicantPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ApplicantPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomPanel ApplicantPanel;
        private System.Windows.Forms.Label AgeLbl;
        private System.Windows.Forms.Label ApplicantGenderLbl;
        private System.Windows.Forms.Label SkilledWorkerLbl;
        private System.Windows.Forms.Label DateRegisteredLbl;
        private System.Windows.Forms.Label ApplicantNameLbl;
        private CircularPictureBox ApplicantPB;
    }
}
