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

namespace SystemPeso.UserControls
{
    public partial class UserControlDays : UserControl
    {
        String connString = "server=localhost;user id=root;database=db_calendar;sslmode=none;";

        public static string static_day;
        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }

        public void days(int numday)
        {
            DaysLbl.Text = numday + "";
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            static_day = DaysLbl.Text;
            timer1.Start();
            EventsForm eventsForm = new EventsForm();
            eventsForm.Show();
        }


        private void displayEvent()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(connString);
                conn.Open();
                String sql = $"SELECT * FROM tbl_calendar where date = {CalendarForm.static_month}/{DaysLbl.Text}/{CalendarForm.static_year} LIMIT 1";
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                //cmd.Parameters.AddWithValue("date", CalendarForm.static_year + "-" + CalendarForm.static_month + "-" + DaysLbl.Text);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    EventLbl.Text = reader["event"].ToString();
                }

                reader.Dispose();
                cmd.Dispose();
                conn.Close();
            }
            catch (Exception e) {
              MessageBox.Show (e.ToString());
            }
         }
          
        private void timer1_Tick(object sender, EventArgs e)
        {
            displayEvent();
        }
    }
}
