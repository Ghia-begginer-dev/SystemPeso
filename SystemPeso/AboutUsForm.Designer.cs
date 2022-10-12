
namespace SystemPeso
{
    partial class AboutUsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutUsForm));
            this.TitleBar = new System.Windows.Forms.Panel();
            this.MinBTN = new System.Windows.Forms.Button();
            this.CloseBTN = new System.Windows.Forms.Button();
            this.TitlePageLbl = new System.Windows.Forms.Label();
            this.LogoPB = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Developer1Panel = new System.Windows.Forms.Panel();
            this.Developer1 = new System.Windows.Forms.Panel();
            this.Developer1PB = new SystemPeso.UserControls.CircularPictureBox();
            this.Header1 = new System.Windows.Forms.PictureBox();
            this.Developer2 = new System.Windows.Forms.Panel();
            this.Developer2PB = new SystemPeso.UserControls.CircularPictureBox();
            this.Header2 = new System.Windows.Forms.PictureBox();
            this.TitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPB)).BeginInit();
            this.Developer1Panel.SuspendLayout();
            this.Developer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Developer1PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Header1)).BeginInit();
            this.Developer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Developer2PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Header2)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TitleBar.Controls.Add(this.MinBTN);
            this.TitleBar.Controls.Add(this.CloseBTN);
            this.TitleBar.Controls.Add(this.TitlePageLbl);
            this.TitleBar.Controls.Add(this.LogoPB);
            this.TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(1279, 49);
            this.TitleBar.TabIndex = 0;
            this.TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            this.TitleBar.Resize += new System.EventHandler(this.TitleBar_Resize);
            // 
            // MinBTN
            // 
            this.MinBTN.FlatAppearance.BorderSize = 0;
            this.MinBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinBTN.Image = global::SystemPeso.Properties.Resources.minimize__24_;
            this.MinBTN.Location = new System.Drawing.Point(1183, 7);
            this.MinBTN.Name = "MinBTN";
            this.MinBTN.Size = new System.Drawing.Size(37, 34);
            this.MinBTN.TabIndex = 5;
            this.MinBTN.UseVisualStyleBackColor = true;
            this.MinBTN.Click += new System.EventHandler(this.MinBTN_Click);
            // 
            // CloseBTN
            // 
            this.CloseBTN.FlatAppearance.BorderSize = 0;
            this.CloseBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBTN.Image = global::SystemPeso.Properties.Resources.cancel__black_16_;
            this.CloseBTN.Location = new System.Drawing.Point(1226, 7);
            this.CloseBTN.Name = "CloseBTN";
            this.CloseBTN.Size = new System.Drawing.Size(37, 34);
            this.CloseBTN.TabIndex = 4;
            this.CloseBTN.UseVisualStyleBackColor = true;
            this.CloseBTN.Click += new System.EventHandler(this.CloseBTN_Click);
            // 
            // TitlePageLbl
            // 
            this.TitlePageLbl.AutoSize = true;
            this.TitlePageLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitlePageLbl.Location = new System.Drawing.Point(50, 13);
            this.TitlePageLbl.Name = "TitlePageLbl";
            this.TitlePageLbl.Size = new System.Drawing.Size(76, 19);
            this.TitlePageLbl.TabIndex = 3;
            this.TitlePageLbl.Text = "About Us\r\n";
            // 
            // LogoPB
            // 
            this.LogoPB.Image = ((System.Drawing.Image)(resources.GetObject("LogoPB.Image")));
            this.LogoPB.ImageRotate = 0F;
            this.LogoPB.Location = new System.Drawing.Point(12, 9);
            this.LogoPB.Name = "LogoPB";
            this.LogoPB.Size = new System.Drawing.Size(40, 37);
            this.LogoPB.TabIndex = 0;
            this.LogoPB.TabStop = false;
            // 
            // Developer1Panel
            // 
            this.Developer1Panel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Developer1Panel.Controls.Add(this.Developer1);
            this.Developer1Panel.Controls.Add(this.Developer2);
            this.Developer1Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Developer1Panel.Location = new System.Drawing.Point(0, 49);
            this.Developer1Panel.Name = "Developer1Panel";
            this.Developer1Panel.Size = new System.Drawing.Size(1279, 669);
            this.Developer1Panel.TabIndex = 1;
            // 
            // Developer1
            // 
            this.Developer1.BackColor = System.Drawing.SystemColors.Menu;
            this.Developer1.Controls.Add(this.Developer1PB);
            this.Developer1.Controls.Add(this.Header1);
            this.Developer1.Location = new System.Drawing.Point(93, 18);
            this.Developer1.Name = "Developer1";
            this.Developer1.Size = new System.Drawing.Size(458, 612);
            this.Developer1.TabIndex = 0;
            // 
            // Developer1PB
            // 
            this.Developer1PB.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.Developer1PB.BorderColor = System.Drawing.Color.RoyalBlue;
            this.Developer1PB.BorderColor2 = System.Drawing.Color.HotPink;
            this.Developer1PB.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.Developer1PB.BorderSize = 2;
            this.Developer1PB.GradientAngle = 50F;
            this.Developer1PB.Image = ((System.Drawing.Image)(resources.GetObject("Developer1PB.Image")));
            this.Developer1PB.Location = new System.Drawing.Point(26, 113);
            this.Developer1PB.Name = "Developer1PB";
            this.Developer1PB.Size = new System.Drawing.Size(137, 137);
            this.Developer1PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Developer1PB.TabIndex = 1;
            this.Developer1PB.TabStop = false;
            // 
            // Header1
            // 
            this.Header1.Image = ((System.Drawing.Image)(resources.GetObject("Header1.Image")));
            this.Header1.Location = new System.Drawing.Point(3, 3);
            this.Header1.Name = "Header1";
            this.Header1.Size = new System.Drawing.Size(452, 202);
            this.Header1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Header1.TabIndex = 0;
            this.Header1.TabStop = false;
            // 
            // Developer2
            // 
            this.Developer2.BackColor = System.Drawing.SystemColors.Menu;
            this.Developer2.Controls.Add(this.Developer2PB);
            this.Developer2.Controls.Add(this.Header2);
            this.Developer2.Location = new System.Drawing.Point(726, 18);
            this.Developer2.Name = "Developer2";
            this.Developer2.Size = new System.Drawing.Size(458, 612);
            this.Developer2.TabIndex = 1;
            // 
            // Developer2PB
            // 
            this.Developer2PB.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.Developer2PB.BorderColor = System.Drawing.Color.RoyalBlue;
            this.Developer2PB.BorderColor2 = System.Drawing.Color.HotPink;
            this.Developer2PB.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.Developer2PB.BorderSize = 2;
            this.Developer2PB.GradientAngle = 50F;
            this.Developer2PB.Location = new System.Drawing.Point(33, 113);
            this.Developer2PB.Name = "Developer2PB";
            this.Developer2PB.Size = new System.Drawing.Size(137, 137);
            this.Developer2PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Developer2PB.TabIndex = 1;
            this.Developer2PB.TabStop = false;
            // 
            // Header2
            // 
            this.Header2.Image = ((System.Drawing.Image)(resources.GetObject("Header2.Image")));
            this.Header2.Location = new System.Drawing.Point(3, 3);
            this.Header2.Name = "Header2";
            this.Header2.Size = new System.Drawing.Size(452, 202);
            this.Header2.TabIndex = 0;
            this.Header2.TabStop = false;
            // 
            // AboutUsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1279, 718);
            this.Controls.Add(this.Developer1Panel);
            this.Controls.Add(this.TitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AboutUsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AboutUsForm";
            this.TitleBar.ResumeLayout(false);
            this.TitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPB)).EndInit();
            this.Developer1Panel.ResumeLayout(false);
            this.Developer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Developer1PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Header1)).EndInit();
            this.Developer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Developer2PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Header2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TitleBar;
        private Guna.UI2.WinForms.Guna2PictureBox LogoPB;
        private System.Windows.Forms.Label TitlePageLbl;
        private System.Windows.Forms.Button MinBTN;
        private System.Windows.Forms.Button CloseBTN;
        private System.Windows.Forms.Panel Developer1Panel;
        private System.Windows.Forms.Panel Developer1;
        private UserControls.CircularPictureBox Developer1PB;
        private System.Windows.Forms.PictureBox Header1;
        private System.Windows.Forms.Panel Developer2;
        private UserControls.CircularPictureBox Developer2PB;
        private System.Windows.Forms.PictureBox Header2;
    }
}