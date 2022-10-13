using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemPeso.UserControls;
using System.Diagnostics;
using SystemPeso.ChatBot.Windows;

namespace SystemPeso
{
    public partial class AdminDashForm : Form
    {
       
        private int bordersize = 1;
        private Size formSize;
        public AdminDashForm()
        {
            InitializeComponent();
            this.Padding = new Padding(bordersize);
            this.BackColor = Color.FromArgb(103, 59, 183);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
            const int SC_RESTORE = 0xF120; //Restore form (Before)
            const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
            const int resizeAreaSize = 10;
            #region Form Resize
            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1; //Represents the client area of the window
            const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
            const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
            const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
            const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
            const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
            const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right
            ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>
            if (m.Msg == WM_NCHITTEST)
            { //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
                {
                    if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                        Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          
                        if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            if (m.Msg == WM_SYSCOMMAND)
            {
                int wParam = (m.WParam.ToInt32() & 0xFFF0);
                if (wParam == SC_MINIMIZE)
                    formSize = this.ClientSize;
                if (wParam == SC_RESTORE)
                    this.Size = formSize;
            }
            base.WndProc(ref m);
        }

        private void AdminDashForm_Resize(object sender, EventArgs e)
        {
            AdjustFom();
        }

        private void AdjustFom()
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

        private void ExitBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MaxBTN_Click_1(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                formSize = this.ClientSize;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.Size = formSize;
            }

        }

        private void MinBTN_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void JobPostBTN_Click(object sender, EventArgs e)
        {
            JobPostForm jf = new JobPostForm();
            jf.Show();
            this.Hide();
        }

        private void StatusBTN_Click(object sender, EventArgs e)
        {
             AccountStatusForm sf = new AccountStatusForm();
            sf.Show();
            this.Hide();
        }

        private void AboutUsBTN_Click(object sender, EventArgs e)
        {
            AboutUsForm Au = new AboutUsForm();
            Au.Show();
            this.Hide();
        }

        private void LogoutBTN_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void CalendarBTN_Click(object sender, EventArgs e)
        {
            CalendarForm cf = new CalendarForm();
            cf.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            StatusLbl.Text = DateTime.Now.ToString("T");
        }

        private void DigitalClock_Paint(object sender, PaintEventArgs e)
        {
            timer1.Start();
        }

        private void DatePanel_Paint(object sender, PaintEventArgs e)
        {
            TodayDateLbl.Text = DateTime.Now.ToLongDateString();
        }

        private void MSWordBTN_Click(object sender, EventArgs e)
        {
            Process.Start("winword");
        }

        private void MSExcelBTN_Click(object sender, EventArgs e)
        {
            Process.Start("excel");
        }

        private void MSPowerpointBTN_Click(object sender, EventArgs e)
        {
            Process.Start("POWERPNT.exe");
        }

        private void CalcuBTN_Click(object sender, EventArgs e)
        {
            Process.Start("calc");
        }

        private void AddApplicantsBTN_Click(object sender, EventArgs e)
        {
            AddApplicants1NSRP Aa = new AddApplicants1NSRP();
            Aa.Show();
            this.Hide();
        }

        private void AddEmloyerBTN_Click(object sender, EventArgs e)
        {
            AddEmployer1NSRP Ae = new AddEmployer1NSRP();
            Ae.Show();
            this.Hide();
        }

        private void AddHomeownerBTN_Click(object sender, EventArgs e)
        {
            AddHomeowner Ah = new AddHomeowner();
            Ah.Show();
            this.Hide();
        }

        private void NewApplicantsBTN_Click(object sender, EventArgs e)
        {
            PendingApprovalPanel pa = new PendingApprovalPanel();
            pa.Show();
            this.Hide();
        }

        private void NoOfApplicantsLbl_Click(object sender, EventArgs e)
        {
            PendingApprovalPanel pa = new PendingApprovalPanel();
            pa.Show();
            this.Hide();
        }

        private void NewEmployersBTN_Click(object sender, EventArgs e)
        {
            PendingApprovalPanel pa = new PendingApprovalPanel();
            pa.Show();
            this.Hide();
        }

        private void NewEmployersNoLbl_Click(object sender, EventArgs e)
        {
            PendingApprovalPanel pa = new PendingApprovalPanel();
            pa.Show();
            this.Hide();
        }

        private void JobPostPostedBTN_Click(object sender, EventArgs e)
        {
            JobPostPosted jp = new JobPostPosted();
            jp.Show();
            this.Hide();
        }

        private void NoOfJobPostLbl_Click(object sender, EventArgs e)
        {
            JobPostPosted jp = new JobPostPosted();
            jp.Show();
            this.Hide();
        }

        private void AboutUsBTN_Click_1(object sender, EventArgs e)
        {
            AboutUsForm ab = new AboutUsForm();
            ab.Show();
            this.Hide();

        }

        private void SettingsBTN_Click(object sender, EventArgs e)
        {
            SettingsForm sf = new SettingsForm();
            sf.Show();
            this.Hide();
        }

        private void AdminDashForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            /*
             * <summary>
             * Instantiates and shows new WPF ChatBot Window
             * </summary>
             */
            ChatbotWindow window = new ChatbotWindow();
            window.Show();
        }
    }
}
