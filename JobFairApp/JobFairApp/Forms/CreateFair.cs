using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JobFairApp.Classes;
namespace JobFairApp.Forms
{
    public partial class CreateFair : Form
    {
        /*
         * This has almost no actual functionality lol
         */

        private JobFair fair;
        private Dictionary<String, int> venues;
        public CreateFair()
        {
            InitializeComponent();
            venues = new Dictionary<String, int>();
        }

        private void addVenueButton_Click(object sender, EventArgs e)
        {
            //get value in combo box
            //add it and the id to the venues dictionary

            //that match will later be used to simply pair this fair's id with all the venues here
        }
    }
}
