using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemPeso
{
    public partial class EmployerProfile : Form
    {
        public EmployerProfile()
        {
            InitializeComponent();
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

        private void JobPostBTN_Click(object sender, EventArgs e)
        {
            JobPostForm jf = new JobPostForm();
            jf.Show();
            this.Hide();
        }

        private void StatusBTN_Click(object sender, EventArgs e)
        {
            AccountStatusForm As = new AccountStatusForm();
            As.Show();
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

        private void SettingsBTN_Click(object sender, EventArgs e)
        {
            SettingsForm sf = new SettingsForm();
            sf.Show();
            this.Hide();
        }
    }
}
