using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class DailyTracker : Form
    {
        //create a connection string
        String connString = "server=localhost;user id=root; database=363db; sslmode=none";
        public event Action EventDeleted;
        public DailyTracker()
        {
            InitializeComponent();
        }

        private void DailyTracker_Load(object sender, EventArgs e)
        {
            //call the static variables
            txdate.Text = Form1.static_year + "-" + Form1.static_month + "-" + UserControlDays.static_day;
            displayEvent(txdate.Text);
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("INSERT INTO tbl_calender(date,event) VALUES (@date, @event)", conn))
                    {
                        cmd.Parameters.AddWithValue("date", txdate.Text);
                        cmd.Parameters.AddWithValue("event", txevent.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Event saved successfully.");
                btnUpdate.Visible = true;
                btnDel.Visible = true;   // แสดงปุ่มอัปเดตหลังจากบันทึกข้อมูลเสร็จสิ้น
                btnsave.Visible = false; // ซ่อนปุ่มบันทึก
            }
             
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving event: {ex.Message}");
            }
        }

            private void label2_Click(object sender, EventArgs e)
        {

        }
        private void displayEvent(string date)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    string sql = "SELECT event FROM tbl_calender WHERE date = @date";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@date", date);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txevent.Text = reader["event"].ToString();
                                btnUpdate.Visible = true; // แสดงปุ่มอัปเดตหลังจากพบข้อมูลเหตุการณ์
                                btnDel.Visible = true;
                                btnsave.Visible = false; // ซ่อนปุ่มบันทึก
                            }
                            else
                            {
                                btnUpdate.Visible = false; // ซ่อนปุ่มอัปเดตหากไม่พบข้อมูลเหตุการณ์
                                btnDel.Visible = false;
                                btnsave.Visible = true; // แสดงปุ่มบันทึก
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while retrieving event: {ex.Message}");
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    string sql = "UPDATE tbl_calender SET event = @event WHERE date = @date";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@event", txevent.Text);
                        cmd.Parameters.AddWithValue("@date", txdate.Text);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Event updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No event found to update.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating event: {ex.Message}");
            }
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    string sql = "DELETE FROM tbl_calender WHERE date = @date";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@date", txdate.Text);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Event deleted successfully.");
                            txevent.Text = "";
                            btnUpdate.Visible = false; // ซ่อนปุ่มอัปเดตหลังจากลบข้อมูลเสร็จสิ้น
                            btnDel.Visible = false; // ซ่อนปุ่มลบหลังจากลบข้อมูลเสร็จสิ้น
                            btnsave.Visible = true; // แสดงปุ่มบันทึก
                        }
                        else
                        {
                            MessageBox.Show("No event found to delete.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting event: {ex.Message}");
            }
        }
    }
}
