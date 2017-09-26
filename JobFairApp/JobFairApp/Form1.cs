using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobFairApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void venue_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.CreateVenue createVenue = new Forms.CreateVenue();
            createVenue.VisibleChanged += delegate (object source, EventArgs args)
            {
                if (!createVenue.Visible)
                {
                    this.Show();
                }
            };
            createVenue.Show();
        }

        private void person_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.CreateCandidate createCandidate = new Forms.CreateCandidate();
            createCandidate.VisibleChanged += delegate (object source, EventArgs args)
            {
                if (!createCandidate.Visible)
                {
                    this.Show();
                }
            };
            createCandidate.Show();
        }
    }
}
