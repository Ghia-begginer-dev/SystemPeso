using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SystemPeso.UCJobPostForm
{
    public partial class CreatePostPanel1 : UserControl
    {
        MySqlConnection cn;
        MySqlCommand cm;
        MySqlDataReader dr;

        public CreatePostPanel1()
        {
            InitializeComponent();

            cn = new MySqlConnection(Module.mydbConnection);
        }
    }
}
