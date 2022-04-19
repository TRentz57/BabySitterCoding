using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class BabySitter : Form
    {
         string startTime = "5:00 PM";
         string endTime = "4:00 AM";
         string midnight = "12:00 AM";
        int startToBed = 12;
        int bedToMidnight = 8;
        int midnightToEnd = 16; 
       
        public BabySitter()
        {   
          
            InitializeComponent();
            textBox1.Text =  "H:MM AM/PM";
            textBox3.Text = "H:MM AM/PM";
            textBox2.Text = "H:MM AM/PM";
            StartTimeDate.Text = "MM/DD/YYYY";
            EndTimeDate.Text = "MM/DD/YYYY";
            BedTimeDate.Text = "MM/DD/YYYY";
        }

        public void button1_Click(object sender, EventArgs e)
        {
           
            Calculations();
            
        }
        public void Calculations()
        {
            TimeSpan hoursWorkedToBedTime;
            TimeSpan hoursWorkedBedTimeToMidnight;
            TimeSpan hoursWorkedMidnightToEndTime;
            int finalHours;
            string finalHours2;
            DateTime time1 = Convert.ToDateTime(textBox1.Text);
            textBox1.Text = time1.ToString("t");
            DateTime time2 = Convert.ToDateTime(textBox3.Text);
            textBox3.Text = time2.ToString("t");
            DateTime time3 = Convert.ToDateTime(textBox2.Text);
            textBox2.Text = time3.ToString("t");
            DateTime date1 = Convert.ToDateTime(StartTimeDate.Text);
            StartTimeDate.Text = date1.ToString("d");
            DateTime date2 = Convert.ToDateTime(EndTimeDate.Text);
            EndTimeDate.Text = date2.ToString("d");
            DateTime date3 = Convert.ToDateTime(BedTimeDate.Text);
           BedTimeDate.Text = date3.ToString("d");
            string FullStartTime = StartTimeDate.Text +" "+  textBox1.Text;
            string FullEndTime = date2.ToString("d") + " " + time2.ToString("t");
            string FullBedTime = date3.ToString("d") + " " + time3.ToString("t");
            DateTime FullStartTimeConvert = Convert.ToDateTime(FullStartTime);
            DateTime FullEndTimeConvert = Convert.ToDateTime(FullEndTime);
            DateTime FullBedTimeConvert = Convert.ToDateTime(FullBedTime);
            DateTime startTime1 = Convert.ToDateTime(startTime);
            DateTime endTime1 = Convert.ToDateTime(endTime);
            DateTime midNight1 = Convert.ToDateTime(midnight);
            string startTime1DateTime = date1.ToString("d") +" "+ startTime1.ToString("t");
            string endTime1DateTime = date2.ToString("d") + " " + endTime1.ToString("t");
            string midnight1DateTime = date1.AddDays(1).ToString("d") + " " + midNight1.ToString("t");
            DateTime FullStartTime1Convert = Convert.ToDateTime(startTime1DateTime);
            DateTime FullEndTime1Convert = Convert.ToDateTime(endTime1DateTime);
            DateTime FullMidnightConvert = Convert.ToDateTime(midnight1DateTime);

            if (FullStartTimeConvert < FullEndTimeConvert && FullStartTimeConvert >= FullStartTime1Convert && FullEndTimeConvert <= FullEndTime1Convert && FullEndTimeConvert >= FullMidnightConvert)
            {
                hoursWorkedToBedTime = FullBedTimeConvert - FullStartTimeConvert;
                hoursWorkedBedTimeToMidnight = FullMidnightConvert - FullBedTimeConvert;
                hoursWorkedMidnightToEndTime = FullEndTimeConvert - FullMidnightConvert;
                finalHours = (hoursWorkedToBedTime.Hours * startToBed) + (hoursWorkedBedTimeToMidnight.Hours * bedToMidnight) + (hoursWorkedMidnightToEndTime.Hours * midnightToEnd);
                //finalPay = finalHours * startToBed;
                finalHours2 = finalHours.ToString();
                
                label1.Text = "$" + finalHours2 + ".00";
            }
            else if(FullStartTimeConvert < FullEndTimeConvert && FullStartTimeConvert >= FullStartTime1Convert && FullEndTimeConvert >= FullEndTime1Convert && FullEndTimeConvert <= FullMidnightConvert)
            {
                hoursWorkedToBedTime = FullBedTimeConvert - FullStartTimeConvert;
                TimeSpan hoursWorkedBedtimeToEnd = FullEndTimeConvert - FullBedTimeConvert;
                finalHours = (hoursWorkedToBedTime.Hours * startToBed) + (hoursWorkedBedtimeToEnd.Hours * bedToMidnight);
                finalHours2 = finalHours.ToString();
                label1.Text = "$" + finalHours2 + ".00";
                
            }
            else if(FullStartTimeConvert > FullEndTimeConvert || FullStartTimeConvert < FullStartTime1Convert || FullEndTimeConvert > FullEndTime1Convert)
            {
                hoursWorkedLbl.Text = "Check your times make sure start time is after 5:00 PM, End Time cant be before start time, and end time cant be after 4:00 AM";
            }
        }
    }
}
