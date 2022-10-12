using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemPeso
{
    public partial class EmailForm : Form
    {
        public EmailForm()
        {
            InitializeComponent();
        }

        private void ExitBTN_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void SendBTN_Click(object sender, EventArgs e)
        {
            SmtpClient Client = new SmtpClient()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential()
                {
                    UserName = "SystemPeso@gmail.com",
                    Password = "sswzabrkeujfhcrw"
                }


            };

            System.Net.Mail.Attachment attachment;
            attachment = new System.Net.Mail.Attachment(LocationLbl.Text);
            

            MailAddress FromEmail = new MailAddress("SystemPeso@gmail.com", "summer smith");
            MailAddress toEmail = new MailAddress(EmailTB.Text, "Someone");
            MailMessage Message = new MailMessage()
            {
                From = FromEmail,
                Subject = SubjectTB.Text,
                Body = MessageTB.Text,
                Attachments = { attachment }

            };


            Message.To.Add(toEmail);
            Client.SendCompleted += Client_SendCompleted;
            Client.SendMailAsync(Message);

        }

        private void Client_SendCompleted(object sender, AsyncCompletedEventArgs e)
        {
           if(e.Error != null)
            {
                MessageBox.Show("Error Happening \n" + e.Error.Message, "Error");
                return;
            }
            MessageBox.Show("Sent Successfully", "Done");
        }

        private void AttachmentLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.ShowDialog();
            LocationLbl.Text = openFileDialog1.FileName;
        }
    }
}
