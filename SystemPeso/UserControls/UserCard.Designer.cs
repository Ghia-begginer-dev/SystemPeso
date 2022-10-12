using System.ComponentModel;

namespace SystemPeso.UserControls
{
    partial class UserCard
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.StatusChip = new Guna.UI2.WinForms.Guna2Chip();
            this.LblName = new System.Windows.Forms.Label();
            this.LblInfo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(29, 19);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(83, 83);
            this.guna2CirclePictureBox1.TabIndex = 2;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // StatusChip
            // 
            this.StatusChip.AutoRoundedCorners = true;
            this.StatusChip.BorderRadius = 15;
            this.StatusChip.BorderThickness = 0;
            this.StatusChip.FillColor = System.Drawing.Color.Salmon;
            this.StatusChip.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.StatusChip.ForeColor = System.Drawing.Color.White;
            this.StatusChip.IsClosable = false;
            this.StatusChip.Location = new System.Drawing.Point(752, 45);
            this.StatusChip.Name = "StatusChip";
            this.StatusChip.Size = new System.Drawing.Size(110, 32);
            this.StatusChip.TabIndex = 4;
            this.StatusChip.Text = "Pending";
            // 
            // LblName
            // 
            this.LblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(118, 31);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(164, 37);
            this.LblName.TabIndex = 6;
            this.LblName.Text = "label1";
            // 
            // LblInfo
            // 
            this.LblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInfo.Location = new System.Drawing.Point(122, 68);
            this.LblInfo.Name = "LblInfo";
            this.LblInfo.Size = new System.Drawing.Size(66, 23);
            this.LblInfo.TabIndex = 7;
            this.LblInfo.Text = "label2";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(393, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(393, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
            // 
            // UserCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblInfo);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.StatusChip);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Name = "UserCard";
            this.Size = new System.Drawing.Size(908, 122);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblInfo;
        private System.Windows.Forms.Label label3;

        private Guna.UI2.WinForms.Guna2Chip StatusChip;

        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;

        #endregion
    }
}