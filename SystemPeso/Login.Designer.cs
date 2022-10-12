
namespace SystemPeso
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.UsernameTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.PasswordTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.LoginBTN = new Guna.UI2.WinForms.Guna2Button();
            this.CloseBTN = new System.Windows.Forms.Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UsernameTB
            // 
            this.UsernameTB.BorderThickness = 2;
            this.UsernameTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UsernameTB.DefaultText = "";
            this.UsernameTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UsernameTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UsernameTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsernameTB.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsernameTB.IconLeft = ((System.Drawing.Image)(resources.GetObject("UsernameTB.IconLeft")));
            this.UsernameTB.IconLeftSize = new System.Drawing.Size(30, 30);
            this.UsernameTB.Location = new System.Drawing.Point(797, 226);
            this.UsernameTB.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.UsernameTB.Name = "UsernameTB";
            this.UsernameTB.PasswordChar = '\0';
            this.UsernameTB.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.UsernameTB.PlaceholderText = "Username";
            this.UsernameTB.SelectedText = "";
            this.UsernameTB.Size = new System.Drawing.Size(384, 50);
            this.UsernameTB.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.UsernameTB.TabIndex = 10;
            this.UsernameTB.TextOffset = new System.Drawing.Point(10, 0);
            this.UsernameTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UsernameTB_KeyDown);
            // 
            // PasswordTB
            // 
            this.PasswordTB.BorderThickness = 2;
            this.PasswordTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTB.DefaultText = "";
            this.PasswordTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasswordTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasswordTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTB.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTB.IconLeftSize = new System.Drawing.Size(30, 30);
            this.PasswordTB.Location = new System.Drawing.Point(797, 324);
            this.PasswordTB.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.PasswordChar = '*';
            this.PasswordTB.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.PasswordTB.PlaceholderText = "Password";
            this.PasswordTB.SelectedText = "";
            this.PasswordTB.Size = new System.Drawing.Size(384, 50);
            this.PasswordTB.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.PasswordTB.TabIndex = 11;
            this.PasswordTB.TextOffset = new System.Drawing.Point(10, 0);
            this.PasswordTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordTB_KeyDown);
            // 
            // LoginBTN
            // 
            this.LoginBTN.BorderRadius = 20;
            this.LoginBTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LoginBTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LoginBTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LoginBTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LoginBTN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBTN.ForeColor = System.Drawing.Color.White;
            this.LoginBTN.Location = new System.Drawing.Point(824, 436);
            this.LoginBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LoginBTN.Name = "LoginBTN";
            this.LoginBTN.Size = new System.Drawing.Size(343, 55);
            this.LoginBTN.TabIndex = 12;
            this.LoginBTN.Text = "Login";
            this.LoginBTN.Click += new System.EventHandler(this.LoginBTN_Click);
            // 
            // CloseBTN
            // 
            this.CloseBTN.FlatAppearance.BorderSize = 0;
            this.CloseBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBTN.Location = new System.Drawing.Point(1164, 15);
            this.CloseBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CloseBTN.Name = "CloseBTN";
            this.CloseBTN.Size = new System.Drawing.Size(41, 28);
            this.CloseBTN.TabIndex = 13;
            this.CloseBTN.UseVisualStyleBackColor = true;
            this.CloseBTN.Click += new System.EventHandler(this.CloseBTN_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.White;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(1, -2);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(764, 624);
            this.guna2PictureBox1.TabIndex = 14;
            this.guna2PictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(928, 145);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 30);
            this.label1.TabIndex = 15;
            this.label1.Text = "Welcome!";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1221, 622);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.CloseBTN);
            this.Controls.Add(this.LoginBTN);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.UsernameTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox UsernameTB;
        private Guna.UI2.WinForms.Guna2TextBox PasswordTB;
        private Guna.UI2.WinForms.Guna2Button LoginBTN;
        private System.Windows.Forms.Button CloseBTN;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label1;
    }
}