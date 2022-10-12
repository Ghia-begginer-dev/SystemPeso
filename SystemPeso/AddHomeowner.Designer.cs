
namespace SystemPeso
{
    partial class AddHomeowner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddHomeowner));
            this.TitleBarPanel = new System.Windows.Forms.Panel();
            this.TitlePageLbl = new System.Windows.Forms.Label();
            this.LogoPB = new System.Windows.Forms.PictureBox();
            this.MinBTN = new System.Windows.Forms.Button();
            this.CloseBTN = new System.Windows.Forms.Button();
            this.HomeownerPanel = new System.Windows.Forms.Panel();
            this.ConfirmBTN = new Guna.UI2.WinForms.Guna2Button();
            this.UploadIDBTN = new Guna.UI2.WinForms.Guna2Button();
            this.IdentificationLbl = new System.Windows.Forms.Label();
            this.IDPictureBoxLbl = new System.Windows.Forms.PictureBox();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.AuthenticationLbl = new System.Windows.Forms.Label();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.ProfileInfoLbl = new System.Windows.Forms.Label();
            this.UploadPhotoBTN = new Guna.UI2.WinForms.Guna2Button();
            this.HomeownerPB = new SystemPeso.UserControls.CircularPictureBox();
            this.FemaleCB = new Guna.UI2.WinForms.Guna2CheckBox();
            this.MaleCB = new Guna.UI2.WinForms.Guna2CheckBox();
            this.DateOfBirthDTP = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.HomeAddressTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.EmailTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.HomeAddressLbl = new System.Windows.Forms.Label();
            this.AgeTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.EmailLbl = new System.Windows.Forms.Label();
            this.GenderLbl = new System.Windows.Forms.Label();
            this.AgeLbl = new System.Windows.Forms.Label();
            this.DateOfBirthLbl = new System.Windows.Forms.Label();
            this.FullNameTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.FullNameLbl = new System.Windows.Forms.Label();
            this.TitleBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPB)).BeginInit();
            this.HomeownerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IDPictureBoxLbl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeownerPB)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleBarPanel
            // 
            this.TitleBarPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TitleBarPanel.Controls.Add(this.TitlePageLbl);
            this.TitleBarPanel.Controls.Add(this.LogoPB);
            this.TitleBarPanel.Controls.Add(this.MinBTN);
            this.TitleBarPanel.Controls.Add(this.CloseBTN);
            this.TitleBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBarPanel.Location = new System.Drawing.Point(0, 0);
            this.TitleBarPanel.Name = "TitleBarPanel";
            this.TitleBarPanel.Size = new System.Drawing.Size(1279, 49);
            this.TitleBarPanel.TabIndex = 0;
            this.TitleBarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBarPanel_MouseDown);
            this.TitleBarPanel.Resize += new System.EventHandler(this.TitleBarPanel_Resize);
            // 
            // TitlePageLbl
            // 
            this.TitlePageLbl.AutoSize = true;
            this.TitlePageLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitlePageLbl.Location = new System.Drawing.Point(50, 13);
            this.TitlePageLbl.Name = "TitlePageLbl";
            this.TitlePageLbl.Size = new System.Drawing.Size(196, 19);
            this.TitlePageLbl.TabIndex = 6;
            this.TitlePageLbl.Text = "Homeowner Registration";
            // 
            // LogoPB
            // 
            this.LogoPB.Image = ((System.Drawing.Image)(resources.GetObject("LogoPB.Image")));
            this.LogoPB.Location = new System.Drawing.Point(12, 7);
            this.LogoPB.Name = "LogoPB";
            this.LogoPB.Size = new System.Drawing.Size(32, 34);
            this.LogoPB.TabIndex = 5;
            this.LogoPB.TabStop = false;
            // 
            // MinBTN
            // 
            this.MinBTN.FlatAppearance.BorderSize = 0;
            this.MinBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinBTN.Image = global::SystemPeso.Properties.Resources.minimize__24_;
            this.MinBTN.Location = new System.Drawing.Point(1183, 7);
            this.MinBTN.Name = "MinBTN";
            this.MinBTN.Size = new System.Drawing.Size(37, 34);
            this.MinBTN.TabIndex = 4;
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
            this.CloseBTN.TabIndex = 1;
            this.CloseBTN.UseVisualStyleBackColor = true;
            this.CloseBTN.Click += new System.EventHandler(this.CloseBTN_Click);
            // 
            // HomeownerPanel
            // 
            this.HomeownerPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.HomeownerPanel.Controls.Add(this.ConfirmBTN);
            this.HomeownerPanel.Controls.Add(this.UploadIDBTN);
            this.HomeownerPanel.Controls.Add(this.IdentificationLbl);
            this.HomeownerPanel.Controls.Add(this.IDPictureBoxLbl);
            this.HomeownerPanel.Controls.Add(this.guna2Separator1);
            this.HomeownerPanel.Controls.Add(this.AuthenticationLbl);
            this.HomeownerPanel.Controls.Add(this.guna2VSeparator1);
            this.HomeownerPanel.Controls.Add(this.guna2Separator2);
            this.HomeownerPanel.Controls.Add(this.ProfileInfoLbl);
            this.HomeownerPanel.Controls.Add(this.UploadPhotoBTN);
            this.HomeownerPanel.Controls.Add(this.HomeownerPB);
            this.HomeownerPanel.Controls.Add(this.FemaleCB);
            this.HomeownerPanel.Controls.Add(this.MaleCB);
            this.HomeownerPanel.Controls.Add(this.DateOfBirthDTP);
            this.HomeownerPanel.Controls.Add(this.HomeAddressTB);
            this.HomeownerPanel.Controls.Add(this.EmailTB);
            this.HomeownerPanel.Controls.Add(this.HomeAddressLbl);
            this.HomeownerPanel.Controls.Add(this.AgeTB);
            this.HomeownerPanel.Controls.Add(this.EmailLbl);
            this.HomeownerPanel.Controls.Add(this.GenderLbl);
            this.HomeownerPanel.Controls.Add(this.AgeLbl);
            this.HomeownerPanel.Controls.Add(this.DateOfBirthLbl);
            this.HomeownerPanel.Controls.Add(this.FullNameTB);
            this.HomeownerPanel.Controls.Add(this.FullNameLbl);
            this.HomeownerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomeownerPanel.Location = new System.Drawing.Point(0, 49);
            this.HomeownerPanel.Name = "HomeownerPanel";
            this.HomeownerPanel.Size = new System.Drawing.Size(1279, 669);
            this.HomeownerPanel.TabIndex = 1;
            // 
            // ConfirmBTN
            // 
            this.ConfirmBTN.BorderRadius = 10;
            this.ConfirmBTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ConfirmBTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ConfirmBTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ConfirmBTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ConfirmBTN.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.ConfirmBTN.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmBTN.ForeColor = System.Drawing.Color.White;
            this.ConfirmBTN.Location = new System.Drawing.Point(1120, 613);
            this.ConfirmBTN.Name = "ConfirmBTN";
            this.ConfirmBTN.Size = new System.Drawing.Size(143, 36);
            this.ConfirmBTN.TabIndex = 186;
            this.ConfirmBTN.Text = "Confirm ";
            // 
            // UploadIDBTN
            // 
            this.UploadIDBTN.BorderRadius = 15;
            this.UploadIDBTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UploadIDBTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UploadIDBTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UploadIDBTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UploadIDBTN.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UploadIDBTN.ForeColor = System.Drawing.Color.White;
            this.UploadIDBTN.Location = new System.Drawing.Point(858, 333);
            this.UploadIDBTN.Name = "UploadIDBTN";
            this.UploadIDBTN.Size = new System.Drawing.Size(148, 36);
            this.UploadIDBTN.TabIndex = 185;
            this.UploadIDBTN.Text = "Upload ID";
            // 
            // IdentificationLbl
            // 
            this.IdentificationLbl.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdentificationLbl.Location = new System.Drawing.Point(714, 58);
            this.IdentificationLbl.Name = "IdentificationLbl";
            this.IdentificationLbl.Size = new System.Drawing.Size(117, 25);
            this.IdentificationLbl.TabIndex = 184;
            this.IdentificationLbl.Text = "IDENTIFICATION";
            this.IdentificationLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IDPictureBoxLbl
            // 
            this.IDPictureBoxLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IDPictureBoxLbl.Location = new System.Drawing.Point(717, 96);
            this.IDPictureBoxLbl.Name = "IDPictureBoxLbl";
            this.IDPictureBoxLbl.Size = new System.Drawing.Size(434, 218);
            this.IDPictureBoxLbl.TabIndex = 183;
            this.IDPictureBoxLbl.TabStop = false;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2Separator1.FillThickness = 3;
            this.guna2Separator1.Location = new System.Drawing.Point(679, 43);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(572, 12);
            this.guna2Separator1.TabIndex = 182;
            // 
            // AuthenticationLbl
            // 
            this.AuthenticationLbl.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthenticationLbl.Location = new System.Drawing.Point(679, 19);
            this.AuthenticationLbl.Name = "AuthenticationLbl";
            this.AuthenticationLbl.Size = new System.Drawing.Size(200, 21);
            this.AuthenticationLbl.TabIndex = 181;
            this.AuthenticationLbl.Text = "II. AUTHENTICATION\r\n";
            this.AuthenticationLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.Location = new System.Drawing.Point(622, 55);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 577);
            this.guna2VSeparator1.TabIndex = 180;
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.FillStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2Separator2.FillThickness = 3;
            this.guna2Separator2.Location = new System.Drawing.Point(2, 43);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(572, 12);
            this.guna2Separator2.TabIndex = 179;
            // 
            // ProfileInfoLbl
            // 
            this.ProfileInfoLbl.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileInfoLbl.Location = new System.Drawing.Point(2, 19);
            this.ProfileInfoLbl.Name = "ProfileInfoLbl";
            this.ProfileInfoLbl.Size = new System.Drawing.Size(244, 21);
            this.ProfileInfoLbl.TabIndex = 178;
            this.ProfileInfoLbl.Text = "I. PROFILE INFORAMTION";
            this.ProfileInfoLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UploadPhotoBTN
            // 
            this.UploadPhotoBTN.BorderRadius = 15;
            this.UploadPhotoBTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UploadPhotoBTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UploadPhotoBTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UploadPhotoBTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UploadPhotoBTN.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UploadPhotoBTN.ForeColor = System.Drawing.Color.White;
            this.UploadPhotoBTN.Location = new System.Drawing.Point(241, 204);
            this.UploadPhotoBTN.Name = "UploadPhotoBTN";
            this.UploadPhotoBTN.Size = new System.Drawing.Size(148, 36);
            this.UploadPhotoBTN.TabIndex = 177;
            this.UploadPhotoBTN.Text = "Upload Photo";
            // 
            // HomeownerPB
            // 
            this.HomeownerPB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HomeownerPB.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.HomeownerPB.BorderColor = System.Drawing.Color.RoyalBlue;
            this.HomeownerPB.BorderColor2 = System.Drawing.Color.HotPink;
            this.HomeownerPB.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.HomeownerPB.BorderSize = 2;
            this.HomeownerPB.GradientAngle = 50F;
            this.HomeownerPB.Location = new System.Drawing.Point(250, 76);
            this.HomeownerPB.Name = "HomeownerPB";
            this.HomeownerPB.Size = new System.Drawing.Size(122, 122);
            this.HomeownerPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HomeownerPB.TabIndex = 176;
            this.HomeownerPB.TabStop = false;
            // 
            // FemaleCB
            // 
            this.FemaleCB.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FemaleCB.CheckedState.BorderRadius = 0;
            this.FemaleCB.CheckedState.BorderThickness = 0;
            this.FemaleCB.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FemaleCB.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FemaleCB.Location = new System.Drawing.Point(239, 409);
            this.FemaleCB.Name = "FemaleCB";
            this.FemaleCB.Size = new System.Drawing.Size(76, 24);
            this.FemaleCB.TabIndex = 175;
            this.FemaleCB.Text = "Female";
            this.FemaleCB.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.FemaleCB.UncheckedState.BorderRadius = 0;
            this.FemaleCB.UncheckedState.BorderThickness = 0;
            this.FemaleCB.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // MaleCB
            // 
            this.MaleCB.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MaleCB.CheckedState.BorderRadius = 0;
            this.MaleCB.CheckedState.BorderThickness = 0;
            this.MaleCB.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MaleCB.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaleCB.Location = new System.Drawing.Point(165, 409);
            this.MaleCB.Name = "MaleCB";
            this.MaleCB.Size = new System.Drawing.Size(68, 24);
            this.MaleCB.TabIndex = 174;
            this.MaleCB.Text = "Male";
            this.MaleCB.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.MaleCB.UncheckedState.BorderRadius = 0;
            this.MaleCB.UncheckedState.BorderThickness = 0;
            this.MaleCB.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // DateOfBirthDTP
            // 
            this.DateOfBirthDTP.Checked = true;
            this.DateOfBirthDTP.CustomFormat = "mm/dd/yyyy";
            this.DateOfBirthDTP.FillColor = System.Drawing.SystemColors.InactiveCaption;
            this.DateOfBirthDTP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateOfBirthDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateOfBirthDTP.Location = new System.Drawing.Point(161, 318);
            this.DateOfBirthDTP.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateOfBirthDTP.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateOfBirthDTP.Name = "DateOfBirthDTP";
            this.DateOfBirthDTP.Size = new System.Drawing.Size(200, 25);
            this.DateOfBirthDTP.TabIndex = 173;
            this.DateOfBirthDTP.Value = new System.DateTime(2022, 9, 2, 15, 30, 42, 21);
            // 
            // HomeAddressTB
            // 
            this.HomeAddressTB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.HomeAddressTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.HomeAddressTB.DefaultText = "";
            this.HomeAddressTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.HomeAddressTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.HomeAddressTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.HomeAddressTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.HomeAddressTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.HomeAddressTB.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeAddressTB.ForeColor = System.Drawing.Color.Black;
            this.HomeAddressTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.HomeAddressTB.Location = new System.Drawing.Point(161, 495);
            this.HomeAddressTB.Name = "HomeAddressTB";
            this.HomeAddressTB.PasswordChar = '\0';
            this.HomeAddressTB.PlaceholderText = "";
            this.HomeAddressTB.SelectedText = "";
            this.HomeAddressTB.Size = new System.Drawing.Size(279, 137);
            this.HomeAddressTB.TabIndex = 172;
            // 
            // EmailTB
            // 
            this.EmailTB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.EmailTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailTB.DefaultText = "";
            this.EmailTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EmailTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EmailTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmailTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmailTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmailTB.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTB.ForeColor = System.Drawing.Color.Black;
            this.EmailTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmailTB.Location = new System.Drawing.Point(161, 448);
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.PasswordChar = '\0';
            this.EmailTB.PlaceholderText = "";
            this.EmailTB.SelectedText = "";
            this.EmailTB.Size = new System.Drawing.Size(279, 29);
            this.EmailTB.TabIndex = 171;
            // 
            // HomeAddressLbl
            // 
            this.HomeAddressLbl.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeAddressLbl.Location = new System.Drawing.Point(25, 495);
            this.HomeAddressLbl.Name = "HomeAddressLbl";
            this.HomeAddressLbl.Size = new System.Drawing.Size(120, 25);
            this.HomeAddressLbl.TabIndex = 169;
            this.HomeAddressLbl.Text = "Home Address:";
            this.HomeAddressLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AgeTB
            // 
            this.AgeTB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AgeTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AgeTB.DefaultText = "";
            this.AgeTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AgeTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AgeTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AgeTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AgeTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AgeTB.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeTB.ForeColor = System.Drawing.Color.Black;
            this.AgeTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AgeTB.Location = new System.Drawing.Point(161, 359);
            this.AgeTB.Name = "AgeTB";
            this.AgeTB.PasswordChar = '\0';
            this.AgeTB.PlaceholderText = "";
            this.AgeTB.SelectedText = "";
            this.AgeTB.Size = new System.Drawing.Size(120, 29);
            this.AgeTB.TabIndex = 170;
            // 
            // EmailLbl
            // 
            this.EmailLbl.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLbl.Location = new System.Drawing.Point(35, 452);
            this.EmailLbl.Name = "EmailLbl";
            this.EmailLbl.Size = new System.Drawing.Size(59, 25);
            this.EmailLbl.TabIndex = 168;
            this.EmailLbl.Text = "Email:";
            this.EmailLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GenderLbl
            // 
            this.GenderLbl.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderLbl.Location = new System.Drawing.Point(35, 408);
            this.GenderLbl.Name = "GenderLbl";
            this.GenderLbl.Size = new System.Drawing.Size(77, 25);
            this.GenderLbl.TabIndex = 167;
            this.GenderLbl.Text = "Gender:";
            this.GenderLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AgeLbl
            // 
            this.AgeLbl.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeLbl.Location = new System.Drawing.Point(35, 363);
            this.AgeLbl.Name = "AgeLbl";
            this.AgeLbl.Size = new System.Drawing.Size(59, 25);
            this.AgeLbl.TabIndex = 166;
            this.AgeLbl.Text = "Age:";
            this.AgeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DateOfBirthLbl
            // 
            this.DateOfBirthLbl.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateOfBirthLbl.Location = new System.Drawing.Point(35, 318);
            this.DateOfBirthLbl.Name = "DateOfBirthLbl";
            this.DateOfBirthLbl.Size = new System.Drawing.Size(101, 25);
            this.DateOfBirthLbl.TabIndex = 165;
            this.DateOfBirthLbl.Text = "Date of Birth:";
            this.DateOfBirthLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FullNameTB
            // 
            this.FullNameTB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.FullNameTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FullNameTB.DefaultText = "";
            this.FullNameTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FullNameTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FullNameTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FullNameTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FullNameTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FullNameTB.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullNameTB.ForeColor = System.Drawing.Color.Black;
            this.FullNameTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FullNameTB.Location = new System.Drawing.Point(161, 268);
            this.FullNameTB.Name = "FullNameTB";
            this.FullNameTB.PasswordChar = '\0';
            this.FullNameTB.PlaceholderText = "";
            this.FullNameTB.SelectedText = "";
            this.FullNameTB.Size = new System.Drawing.Size(432, 29);
            this.FullNameTB.TabIndex = 164;
            // 
            // FullNameLbl
            // 
            this.FullNameLbl.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullNameLbl.Location = new System.Drawing.Point(35, 268);
            this.FullNameLbl.Name = "FullNameLbl";
            this.FullNameLbl.Size = new System.Drawing.Size(101, 25);
            this.FullNameLbl.TabIndex = 163;
            this.FullNameLbl.Text = "Full Name:\r\n\r\n";
            this.FullNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddHomeowner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 718);
            this.Controls.Add(this.HomeownerPanel);
            this.Controls.Add(this.TitleBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddHomeowner";
            this.Text = "AddHomeowner";
            this.TitleBarPanel.ResumeLayout(false);
            this.TitleBarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPB)).EndInit();
            this.HomeownerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IDPictureBoxLbl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeownerPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TitleBarPanel;
        private System.Windows.Forms.Button CloseBTN;
        private System.Windows.Forms.Button MinBTN;
        private System.Windows.Forms.PictureBox LogoPB;
        private System.Windows.Forms.Label TitlePageLbl;
        private System.Windows.Forms.Panel HomeownerPanel;
        private Guna.UI2.WinForms.Guna2Button ConfirmBTN;
        private Guna.UI2.WinForms.Guna2Button UploadIDBTN;
        private System.Windows.Forms.Label IdentificationLbl;
        private System.Windows.Forms.PictureBox IDPictureBoxLbl;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label AuthenticationLbl;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private System.Windows.Forms.Label ProfileInfoLbl;
        private Guna.UI2.WinForms.Guna2Button UploadPhotoBTN;
        private UserControls.CircularPictureBox HomeownerPB;
        private Guna.UI2.WinForms.Guna2CheckBox FemaleCB;
        private Guna.UI2.WinForms.Guna2CheckBox MaleCB;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateOfBirthDTP;
        private Guna.UI2.WinForms.Guna2TextBox HomeAddressTB;
        private Guna.UI2.WinForms.Guna2TextBox EmailTB;
        private System.Windows.Forms.Label HomeAddressLbl;
        private Guna.UI2.WinForms.Guna2TextBox AgeTB;
        private System.Windows.Forms.Label EmailLbl;
        private System.Windows.Forms.Label GenderLbl;
        private System.Windows.Forms.Label AgeLbl;
        private System.Windows.Forms.Label DateOfBirthLbl;
        private Guna.UI2.WinForms.Guna2TextBox FullNameTB;
        private System.Windows.Forms.Label FullNameLbl;
    }
}