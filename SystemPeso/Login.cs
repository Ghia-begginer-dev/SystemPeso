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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void CloseBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginBTN_Click(object sender, EventArgs e)
        {
            if (UsernameTB.Text == "" || PasswordTB.Text == "")
            {
                MessageBox.Show("Missing Information. Try Again!");
            }
            else if (UsernameTB.Text == "Admin" || PasswordTB.Text == "Admin")
            {
                try
                {
                    MessageBox.Show("Login Successful");
                    AdminDashForm ed = new AdminDashForm();
                    ed.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void UsernameTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) PasswordTB.Focus();
        }

        private void PasswordTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) LoginBTN.PerformClick();
        }
    }
    }

