namespace JobFairApp.Forms
{
    partial class UserProfile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.personControl1 = new JobFairApp.Forms.PersonControl();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(114, 12);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Log In";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(33, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "New User";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.newUserButton_Click);
            // 
            // personControl1
            // 
            this.personControl1.Location = new System.Drawing.Point(13, 50);
            this.personControl1.Name = "personControl1";
            this.personControl1.Size = new System.Drawing.Size(199, 322);
            this.personControl1.TabIndex = 2;
            // 
            // UserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 376);
            this.Controls.Add(this.personControl1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.loginButton);
            this.Name = "UserProfile";
            this.Text = "UserProfile";
            this.Load += new System.EventHandler(this.UserProfile_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button button2;
        private PersonControl personControl1;
    }
}