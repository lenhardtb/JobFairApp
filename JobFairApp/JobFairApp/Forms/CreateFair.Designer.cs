namespace JobFairApp.Forms
{
    partial class CreateFair
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.venuesComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addVenueButton = new System.Windows.Forms.Button();
            this.venuesListBox = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(79, 13);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(138, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.Location = new System.Drawing.Point(79, 40);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 77);
            this.textBox1.TabIndex = 2;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(13, 40);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.descriptionLabel.TabIndex = 3;
            this.descriptionLabel.Text = "Description";
            // 
            // venuesComboBox
            // 
            this.venuesComboBox.FormattingEnabled = true;
            this.venuesComboBox.Location = new System.Drawing.Point(6, 19);
            this.venuesComboBox.Name = "venuesComboBox";
            this.venuesComboBox.Size = new System.Drawing.Size(121, 21);
            this.venuesComboBox.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.venuesListBox);
            this.groupBox1.Controls.Add(this.addVenueButton);
            this.groupBox1.Controls.Add(this.venuesComboBox);
            this.groupBox1.Location = new System.Drawing.Point(16, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 144);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Venue";
            // 
            // addVenueButton
            // 
            this.addVenueButton.Location = new System.Drawing.Point(134, 19);
            this.addVenueButton.Name = "addVenueButton";
            this.addVenueButton.Size = new System.Drawing.Size(61, 23);
            this.addVenueButton.TabIndex = 5;
            this.addVenueButton.Text = "Add";
            this.addVenueButton.UseVisualStyleBackColor = true;
            this.addVenueButton.Click += new System.EventHandler(this.addVenueButton_Click);
            // 
            // venuesListBox
            // 
            this.venuesListBox.FormattingEnabled = true;
            this.venuesListBox.Location = new System.Drawing.Point(7, 47);
            this.venuesListBox.Name = "venuesListBox";
            this.venuesListBox.Size = new System.Drawing.Size(188, 82);
            this.venuesListBox.TabIndex = 6;
            // 
            // CreateFair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 288);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "CreateFair";
            this.Text = "CreateFair";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.ComboBox venuesComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox venuesListBox;
        private System.Windows.Forms.Button addVenueButton;
    }
}