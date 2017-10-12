using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JobFairApp.Classes;

namespace JobFairApp.Forms
{
    public partial class UserProfile : Form
    {
        //the file a recurring user's information would be in
        String loginPath = "JobFairAppData/login.txt";

        public UserProfile()
        {
            InitializeComponent();
        }

        public void LoadProfile(Person p)
        {
            
        }

        private void UserProfile_Load(object sender, EventArgs e)
        {
            //attempt to load a previous profile
            FileInfo file = new FileInfo(loginPath);
            if (file.Exists)
            {
                StreamReader reader = file.OpenText();

                String line = reader.ReadLine();

                reader.Close();

                int ID = int.Parse(line);

                Person p = new Person().FromID(ID);

                if(p.ID != MySQLUtils.NullID)
                {
                    LoadProfile(p);
                }
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Form input = new Form();
            Label label = new Label();
            label.Text = "Please enter your user ID:";
            label.Dock = DockStyle.Top;
            TextBox textBox = new TextBox();
            textBox.Dock = DockStyle.Top;

            input.Controls.Add(label);
            input.Controls.Add(textBox);

            input.ShowDialog();

            Person p = new Person().FromID(int.Parse(textBox.Text));
        }

        private void newUserButton_Click(object sender, EventArgs e)
        {
            Form subForm = new Form();
            PersonControl personControl = new PersonControl();
            personControl.PersonValidated += delegate (object source, EventArgs args)
            {
                subForm.DialogResult = DialogResult.OK;
                subForm.Hide();
            };
            personControl.Location = new Point(0,0);
            subForm.Size = personControl.Size;
            subForm.Controls.Add(personControl);


            DialogResult result = subForm.ShowDialog();

            if(result == DialogResult.OK)
            {
                LoadProfile(personControl.Person);
            }
        }
    }//class(UserProfile)
}//namespace
