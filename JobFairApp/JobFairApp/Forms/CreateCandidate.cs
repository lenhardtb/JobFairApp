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
    public partial class CreateCandidate : Form
    {
        Candidate c;

        public CreateCandidate()
        {
            InitializeComponent();
            c = new Candidate();
            personControl.PersonValidated += Person_Validated;
        }

        public void Person_Validated(object source, EventArgs args)
        {
            c.Person = personControl.Person;

            c.Insert();
        }
    }
}
