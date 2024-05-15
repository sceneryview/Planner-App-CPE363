using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int month, year; //สร้างตัวแปร
        //create a static variable => pass to another form for month and year;
        public static int static_month, static_year;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            displayDays();
        }
        private void displayDays()
        {
            DateTime now = DateTime.Now;  
            month = now.Month;
            year = now.Year;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;
            static_month = month;
            static_year = year;
            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));

            //
            for (int i =1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }
            for(int i = 1; i<= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
            
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnimg_Click(object sender, EventArgs e)
        {
            string image;
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    image = openFileDialog.FileName;
                    pictureBox1.ImageLocation = image;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("error occured!");
            }
        }

        private void btnlist_Click(object sender, EventArgs e)
        {
            var parts = textBox1.Text.Split(',');
            checkedListBox1.Items.Clear();
            checkedListBox1.Items.AddRange(parts);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            //clear container
            daycontainer.Controls.Clear();

            //decrement month to go to previous month
            month--;
            static_month = month;
            static_year = year;
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;
            DateTime now = DateTime.Now; // qwers
            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));

            //
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //clear container
            daycontainer.Controls.Clear();

            //increment month to go to next month
            month++;
            static_month = month;
            static_year = year;
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;
            DateTime now = DateTime.Now; // qwers
            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));

            //
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }
    }
}
