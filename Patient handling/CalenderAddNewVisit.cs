﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patient_handling
{
    public partial class CalenderAddNewVisit : Form
    {
        int month, year;
        public CalenderAddNewVisit()
        {
            InitializeComponent();
        }

        public static string static_month, static_year;
        
        private void CalenderAddNewVisit_Load(object sender, EventArgs e)
        {

            DisplayDay();



        }
        public void DisplayMonthCalendar()
        {
            dayContainer.Controls.Clear();



            string Monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);

            label_date.Text = Monthname + " " + year;
            DateTime startOfTheMonth = new DateTime(year, month, 1);

            int day = DateTime.DaysInMonth(year, month);

            int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d"));


            for (int i = 0; i < dayOfTheWeek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                dayContainer.Controls.Add(ucblank);

            }

            for (int i = 1; i < day + 1; i++)
            {
                UserControlday ucday = new UserControlday();
                ucday.Day(i); 
                dayContainer.Controls.Add(ucday);
            }
            static_month = month.ToString();
            static_year = year.ToString();

        }
        private void DisplayDay()
        {
            DateTime now = DateTime.Now;

            year = now.Year;
            month = now.Month;

            DisplayMonthCalendar();


        }

        private void button_next_Click(object sender, EventArgs e)
        {

            if (month == 12)
            {
                month = 1;
                year++;
            }
            else 
            {
                month++;
       
            }

            DisplayMonthCalendar();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button_previous_Click(object sender, EventArgs e)
        {

            if (month == 1)
            {
                month = 12;
                year--;
            }
            else
            {
                month--;

            }



            DisplayMonthCalendar();



        }

        private void label_date_Click(object sender, EventArgs e)
        {

        }
    }
}
