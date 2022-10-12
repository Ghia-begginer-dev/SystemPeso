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
using SystemPeso.UserControls;

namespace SystemPeso
{
    public partial class EventsForm : Form
    {
        //create a connectionstring
        String connString = "server=localhost;user id=root;database=db_calendar;sslmode=none";
        public EventsForm()
        {
            InitializeComponent();
        }

        private void EventsForm_Load(object sender, EventArgs e)
        {
            DateTxt.Text = CalendarForm.static_year +"-"+CalendarForm.static_month+"-"+ UserControlDays.static_day ;

        }
      
        private void SaveBTN_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            String sql = "INSERT INTO tbl_calendar(event,date)values(@Event,@Date)";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("event",EventTxt.Text);
            cmd.Parameters.AddWithValue("date", DateTxt.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Saved");
            cmd.Dispose();
            conn.Close();
            
            MessageBox.Show("Saved");
        }
    }
}
