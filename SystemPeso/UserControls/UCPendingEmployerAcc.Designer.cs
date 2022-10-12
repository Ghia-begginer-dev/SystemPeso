
namespace SystemPeso.UserControls
{
    partial class UCPendingEmployerAcc
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
            this.EmployerPanel = new SystemPeso.UserControls.CustomPanel();
            this.AgeLbl = new System.Windows.Forms.Label();
            this.EmployerAcronymLbl = new System.Windows.Forms.Label();
            this.SkilledWorkerLbl = new System.Windows.Forms.Label();
            this.DateRegisteredLbl = new System.Windows.Forms.Label();
            this.EmployerNameLbl = new System.Windows.Forms.Label();
            this.EmployerPB = new SystemPeso.UserControls.CircularPictureBox();
            this.EmployerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployerPB)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployerPanel
            // 
            this.EmployerPanel.BackColor = System.Drawing.Color.White;
            this.EmployerPanel.BorderRadius = 30;
            this.EmployerPanel.Controls.Add(this.AgeLbl);
            this.EmployerPanel.Controls.Add(this.EmployerAcronymLbl);
            this.EmployerPanel.Controls.Add(this.SkilledWorkerLbl);
            this.EmployerPanel.Controls.Add(this.DateRegisteredLbl);
            this.EmployerPanel.Controls.Add(this.EmployerNameLbl);
            this.EmployerPanel.Controls.Add(this.EmployerPB);
            this.EmployerPanel.ForeColor = System.Drawing.Color.Black;
            this.EmployerPanel.GradientAngle = 90F;
            this.EmployerPanel.GradientBottomColor = System.Drawing.Color.White;
            this.EmployerPanel.GradientTopColor = System.Drawing.Color.White;
            this.EmployerPanel.Location = new System.Drawing.Point(4, 4);
            this.EmployerPanel.Name = "EmployerPanel";
            this.EmployerPanel.Size = new System.Drawing.Size(1043, 103);
            this.EmployerPanel.TabIndex = 1;
            // 
            // AgeLbl
            // 
            this.AgeLbl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeLbl.Location = new System.Drawing.Point(307, 60);
            this.AgeLbl.Name = "AgeLbl";
            this.AgeLbl.Size = new System.Drawing.Size(127, 22);
            this.AgeLbl.TabIndex = 1;
            this.AgeLbl.Text = "Employer Type";
            // 
            // EmployerAcronymLbl
            // 
            this.EmployerAcronymLbl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployerAcronymLbl.Location = new System.Drawing.Point(181, 60);
            this.EmployerAcronymLbl.Name = "EmployerAcronymLbl";
            this.EmployerAcronymLbl.Size = new System.Drawing.Size(78, 22);
            this.EmployerAcronymLbl.TabIndex = 1;
            this.EmployerAcronymLbl.Text = "Acronym";
            // 
            // SkilledWorkerLbl
            // 
            this.SkilledWorkerLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkilledWorkerLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(59)))), ((int)(((byte)(183)))));
            this.SkilledWorkerLbl.Location = new System.Drawing.Point(880, 39);
            this.SkilledWorkerLbl.Name = "SkilledWorkerLbl";
            this.SkilledWorkerLbl.Size = new System.Drawing.Size(145, 22);
            this.SkilledWorkerLbl.TabIndex = 1;
            this.SkilledWorkerLbl.Text = "Employer";
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
            // EmployerNameLbl
            // 
            this.EmployerNameLbl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployerNameLbl.Location = new System.Drawing.Point(181, 28);
            this.EmployerNameLbl.Name = "EmployerNameLbl";
            this.EmployerNameLbl.Size = new System.Drawing.Size(265, 22);
            this.EmployerNameLbl.TabIndex = 1;
            this.EmployerNameLbl.Text = "Name";
            // 
            // EmployerPB
            // 
            this.EmployerPB.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.EmployerPB.BorderColor = System.Drawing.Color.RoyalBlue;
            this.EmployerPB.BorderColor2 = System.Drawing.Color.HotPink;
            this.EmployerPB.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.EmployerPB.BorderSize = 2;
            this.EmployerPB.GradientAngle = 50F;
            this.EmployerPB.Location = new System.Drawing.Point(46, 3);
            this.EmployerPB.Name = "EmployerPB";
            this.EmployerPB.Size = new System.Drawing.Size(92, 92);
            this.EmployerPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EmployerPB.TabIndex = 0;
            this.EmployerPB.TabStop = false;
            // 
            // UCPendingEmployerAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EmployerPanel);
            this.Name = "UCPendingEmployerAcc";
            this.Size = new System.Drawing.Size(1050, 111);
            this.EmployerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EmployerPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomPanel EmployerPanel;
        private System.Windows.Forms.Label AgeLbl;
        private System.Windows.Forms.Label EmployerAcronymLbl;
        private System.Windows.Forms.Label SkilledWorkerLbl;
        private System.Windows.Forms.Label DateRegisteredLbl;
        private System.Windows.Forms.Label EmployerNameLbl;
        private CircularPictureBox EmployerPB;
    }
}
