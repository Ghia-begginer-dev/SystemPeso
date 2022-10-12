using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

        public static string static_day;
        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        public void days(int numday)
        {
            DaysLbl.Text = numday + "";
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            static_day = DaysLbl.Text;
            EventsForm eventsForm = new EventsForm();
            eventsForm.Show();
        }


        private void displayEvent()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(Module.mydbConnection);
                conn.Open();
                String sql = $"SELECT * FROM tbl_calendar where Date = {CalendarForm.static_year}-{CalendarForm.static_month}-{DaysLbl.Text} LIMIT 1";
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                MySqlDataReader reader = cmd.ExecuteReader();
                
                string Evnt = "Event:";
                if (reader.Read())
                {
                    Evnt = reader["Event"].ToString();
                    Debug.WriteLine(reader["Event"].ToString());
                }

                EventLbl.Text = Evnt;

                reader.Dispose();
                cmd.Dispose();
                conn.Close();
            }
            catch (Exception e) {
              MessageBox.Show (e.ToString());
            }
            
            //Debug.WriteLine($"SELECT * FROM tbl_calendar where Date = {CalendarForm.static_year}-{CalendarForm.static_month}-{DaysLbl.Text} LIMIT 1");
         }
          
        private void timer1_Tick(object sender, EventArgs e)
        {
            displayEvent();
        }
    }
}
