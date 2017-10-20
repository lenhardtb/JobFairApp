using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobFairApp.Forms
{
    public partial class CreateInterviewTimes : Form
    {
        int length;
        public CreateInterviewTimes()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool haveBreaks = cbBreak.Checked;
            //Also have checks for a day and job fair being selected...possibly formatting too
            if (rb15Mins.Checked || rb20Mins.Checked || rb30Mins.Checked)
                MessageBox.Show("Please Select An Amount Of Time.", "Please Select A Time");
            else if(haveBreaks && (tbStartTime.Text=="" || tbEndTime.Text=="" || tbBreakStart.Text=="" || tbBreakEnd.Text==""))
                MessageBox.Show("Please Fill In All Textboxes.", "Please Fill in All Textboxes");
            else if(tbStartTime.Text=="" || tbEndTime.Text=="")
                MessageBox.Show("Please Fill In All Textboxes.", "Please Fill in All Textboxes");
            else
            {
                int length=0; //Minutes of the interview
                int startTime = timeToInt(tbStartTime.Text);
                int endTime = timeToInt(tbStartTime.Text);
                if (rb15Mins.Checked) //15 minutes selected the extra hundred is due to the conversion from minutes to miliseconds
                    length = 15*100;
                else if (rb20Mins.Checked)
                    length = 20*100;
                else if (rb30Mins.Checked)
                    length = 30*100;
                if (!cbBreak.Checked)
                {
                    for(int i=startTime; i<endTime; i += length)
                    {
                        if (startTime <= endTime - length)
                        {
                            //Send the startTime and the startTime+length through to the TimeSlots table (also day and job fair)
                        }
                    }
                }
            }
        }
        //Convert to and from time to double
        //Assuming the correct format for time (hh:mm:ss)
        int timeToInt(string time)
        {
            //The -48 is to account for ASCII values
            return (time[0]-48) * 60000 + (time[1]-48) * 6000 + (time[3]-48)*1000 + (time[4]-48)*100 + (time[6]-48)*10 + (time[7]-48);
        }
        // ***TO DO***
        // Order of multiples: 60000, 6000, 1000, 100, 10, 1
        string doubleToTime(int number)
        {
            string time="";
            //For the tens digit of hours
            time += number%60000;
            number -= number % 60000 * 60000;
            //For the hours
            time += number % 6000;
            number -= number % 6000 * 6000;
            time += ":"; //The first colon in time
            //For the tens digit of minutes
            time += number % 1000;
            number -= number % 1000 * 1000;
            //For the minutes
            time += number % 100;
            number -= number % 100 * 100;
            time += ":"; //The second colon in time
            //For the seconds
            time += number % 10;
            number -= number % 10 * 10;
            //For the milliseconds
            time += number;
            return time;
        }
    }
}
