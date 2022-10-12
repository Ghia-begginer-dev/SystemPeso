using System;
using System.Drawing;
using System.Windows.Forms;

namespace SystemPeso.UserControls
{
    public partial class UserCard : UserControl
    {
        public UserCard()
        {
            InitializeComponent();
        }

        public void SetName(string name)
        {
            LblName.Text = name;
        }

        public void SetApproved(bool approved)
        {
            StatusChip.Text = approved ? "Approved" : "Pending";
            StatusChip.FillColor = approved ? Color.SeaGreen : Color.Tomato;
        }

        public void setInfo(params string[] info)
        {
            foreach (var s in info)
            {
                LblInfo.Text += s;
            }
        }

    }
}