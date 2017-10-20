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
                double startTime = timeToDouble(tbStartTime.Text);
                double endTime = timeToDouble(tbStartTime.Text);
                if (rb15Mins.Checked) //15 minutes selected
                    length = 15;
                else if (rb20Mins.Checked)
                    length = 20;
                else if (rb30Mins.Checked)
                    length = 30;
                if (!cbBreak.Checked)
                {
                    for(double i=startTime; i<endTime; i += length)
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
        double timeToDouble(string time)
        {
            //The -48 is to account for ASCII values
            return (time[0]-48) * 600 + (time[1]-48) * 60 + (time[3]-48)*10 + (time[4]-48) + (time[6]-48)*.1 + (time[7]-48)*.01;
        }
        /* ***TO DO***
        string doubleToTime(double number)
        {

        }
        */
    }
}
