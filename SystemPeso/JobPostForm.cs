using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemPeso.UserControls;

namespace SystemPeso
{
    public partial class JobPostForm : Form
    {
        private int bordersize = 2;
        List<Panel> listPanel = new List<Panel>();
        int index;
        public JobPostForm()
        {
            InitializeComponent();
            this.Padding = new Padding(bordersize);

            UCJobPostForm.CreatePostPanel1 cp = new UCJobPostForm.CreatePostPanel1();
            addUserControl(cp);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void TitleBarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            base.WndProc(ref m);
        }

        private void JobPostForm_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }

        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized:
                    this.Padding = new Padding(0, 0, 0, 0);
                    break;
                case FormWindowState.Normal:
                    if (this.Padding.Top != bordersize)
                        this.Padding = new Padding(bordersize);
                    break;
            }
        }

        //
        

       

        private void ExitBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MaxBTN_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void MinBTN_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void DashboardBTN_Click(object sender, EventArgs e)
        {
            AdminDashForm af = new AdminDashForm();
            af.Show();
            this.Hide();
        }

        private void ApplicantsBTN_Click(object sender, EventArgs e)
        {
            ApplicantsForm af = new ApplicantsForm();
            af.Show();
            this.Hide();
        }

        private void EmployersBTN_Click(object sender, EventArgs e)
        {
            EmployersForm ef = new EmployersForm();
            ef.Show();
            this.Hide();
        }

        private void HomeownerBTN_Click(object sender, EventArgs e)
        {
            HomeownerForm hf = new HomeownerForm();
            hf.Show();
            this.Hide();
        }

        private void LogoutBTN_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void AboutUsBTN_Click(object sender, EventArgs e)
        {
            AboutUsForm Au = new AboutUsForm();
            Au.Show();
            this.Hide();
        }

        private void StatusBTN_Click(object sender, EventArgs e)
        {
            AccountStatusForm As = new AccountStatusForm();
            As.Show();
            this.Hide();
        }

  

        private void SettingsBTN_Click(object sender, EventArgs e)
        {
            SettingsForm sf = new SettingsForm();
            sf.Show();
            this.Hide();
        }
         private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            JobPostPanel.Controls.Clear();
            JobPostPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void JDBtn1_Click(object sender, EventArgs e)
        {
            UCJobPostForm.CreatePostPanel1 cp = new UCJobPostForm.CreatePostPanel1();
            addUserControl(cp);


            JDBtn1.ImageIndex = 1;
            JDBtn2.ImageIndex = JDBtn3.ImageIndex = JDSBtn4.ImageIndex = 0;
            Line1.BackColor = Line2.BackColor = Line3.BackColor = Color.FromArgb(167, 167, 167);

        }

        private void JDBtn2_Click(object sender, EventArgs e)
        {
            UCJobPostForm.CreatePostPanel2 cp = new UCJobPostForm.CreatePostPanel2();
            addUserControl(cp);

            if (JDBtn1.ImageIndex == 0 || JDBtn1.ImageIndex == 1)
            {
                JDBtn1.ImageIndex = 2;
                JDBtn2.ImageIndex = 1;
                JDBtn3.ImageIndex = JDSBtn4.ImageIndex = 0;
                Line1.BackColor = Color.FromArgb(139, 219, 129);
                Line2.BackColor = Line3.BackColor = Color.FromArgb(167, 167, 167);
            }
            
        }

        private void JDBtn3_Click(object sender, EventArgs e)
        {
            UCJobPostForm.CreatePostPanel3 cp = new UCJobPostForm.CreatePostPanel3();
            addUserControl(cp);

            if (JDBtn1.ImageIndex == 2 && JDBtn2.ImageIndex == 1 || JDBtn2.ImageIndex == 2)
            {
                JDBtn2.ImageIndex = 2;
                JDBtn3.ImageIndex = 1;
                JDSBtn4.ImageIndex = 0;
                Line2.BackColor = Color.FromArgb(139, 219, 129);
                Line3.BackColor = Color.FromArgb(167, 167, 167);
            }
            
        }

        private void JDSBtn4_Click(object sender, EventArgs e)
        {
            if (JDBtn1.ImageIndex == 2 && JDBtn2.ImageIndex == 2 && JDBtn3.ImageIndex == 1)
            {
                JDBtn3.ImageIndex = 2;
                JDSBtn4.ImageIndex = 1;
                Line3.BackColor = Color.FromArgb(139, 219, 129);
            }

        }

       
    }
    
}
