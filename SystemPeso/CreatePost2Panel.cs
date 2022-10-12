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
    public partial class CreatePost2Panel : Form
    {
        List<Panel> listPanel = new List<Panel>();
        int index;
        public CreatePost2Panel()
        {
            InitializeComponent();
            //JobPostForm f = new JobPostForm()
        }
       
        private void Next2BTN_Click(object sender, EventArgs e)
        {

            // CreatePost3Panel frm = new CreatePost3Panel();
            // frm.TopLevel = false;
            //frm.TopMost = true;
            //JobPostForm.Controls.Add(frm);
            //frm.Show();
            //   loadform(new CreatePost3Panel());
            CreatePost3Panel frn = new CreatePost3Panel();
            frn.Show();
        }

        private void CreatePost2Panel_Load(object sender, EventArgs e)
        {
            //listPanel.Add(CreatePost3Panel);
        }
    }
}
