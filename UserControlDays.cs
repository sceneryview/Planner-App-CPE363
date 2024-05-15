using MySql.Data.MySqlClient;
using System;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UserControlDays : UserControl
    {
        private readonly string connString = "server=localhost;user id=root;database=363db;sslmode=none";
        public static string static_day;

        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {
            // โหลดข้อมูลจากฐานข้อมูลเมื่อฟอร์มถูกโหลด
            LoadEvents();
        }

        public void days(int numday)
        {
            lbdays.Text = numday.ToString();
            displayEvent(numday);
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            static_day = lbdays.Text;
            timer1.Start();
            DailyTracker eventform = new DailyTracker();
            eventform.EventDeleted += Eventform_EventDeleted;
            eventform.Show();
            displayEvent(int.Parse(lbdays.Text));
        }
        private void Eventform_EventDeleted()
        {
            displayEvent(int.Parse(lbdays.Text));
        }
        private void LoadEvents()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    string sql = "SELECT event FROM tbl_calender ";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            StringBuilder Events = new StringBuilder();
                            while (reader.Read())
                            {
                                string eventDetail = reader["event"].ToString();
                                Events.AppendLine(eventDetail);
                            }
                           
                            
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void displayEvent(int day)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    string sql = "SELECT event FROM tbl_calender WHERE date = @date";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        string date = $"{Form1.static_year}-{Form1.static_month}-{day}";
                        cmd.Parameters.AddWithValue("@date", date);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lbevent.Text = reader["event"].ToString(); 
                            }
                            else
                            {
                                lbevent.Text = ""; // ล้างข้อมูลถ้าไม่มีเหตุการณ์
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            displayEvent(int.Parse(lbdays.Text));
        }


        private void lbevent_Click(object sender, EventArgs e)
        {

        }
    }
}
