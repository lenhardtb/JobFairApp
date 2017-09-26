namespace JobFairApp.Forms
{
    partial class CreateVenue
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
            this.submitButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.longDescriptionContainer = new System.Windows.Forms.GroupBox();
            this.shortDescriptionBox = new System.Windows.Forms.TextBox();
            this.longDescriptionBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.longDescriptionContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // submitButton
            // 
            this.submitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.submitButton.Location = new System.Drawing.Point(18, 269);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(134, 26);
            this.submitButton.TabIndex = 1;
            this.submitButton.Text = "Finish";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // backButton
            // 
            this.backButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.backButton.Location = new System.Drawing.Point(158, 269);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 26);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.shortDescriptionBox);
            this.groupBox1.Location = new System.Drawing.Point(15, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Description";
            // 
            // longDescriptionContainer
            // 
            this.longDescriptionContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.longDescriptionContainer.Controls.Add(this.longDescriptionBox);
            this.longDescriptionContainer.Location = new System.Drawing.Point(15, 155);
            this.longDescriptionContainer.Name = "longDescriptionContainer";
            this.longDescriptionContainer.Size = new System.Drawing.Size(221, 100);
            this.longDescriptionContainer.TabIndex = 4;
            this.longDescriptionContainer.TabStop = false;
            this.longDescriptionContainer.Text = "(Optional) In-Depth Description";
            // 
            // shortDescriptionBox
            // 
            this.shortDescriptionBox.AcceptsReturn = true;
            this.shortDescriptionBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shortDescriptionBox.Location = new System.Drawing.Point(3, 16);
            this.shortDescriptionBox.MaxLength = 255;
            this.shortDescriptionBox.Multiline = true;
            this.shortDescriptionBox.Name = "shortDescriptionBox";
            this.shortDescriptionBox.Size = new System.Drawing.Size(215, 81);
            this.shortDescriptionBox.TabIndex = 0;
            // 
            // longDescriptionBox
            // 
            this.longDescriptionBox.AcceptsReturn = true;
            this.longDescriptionBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.longDescriptionBox.Location = new System.Drawing.Point(3, 16);
            this.longDescriptionBox.MaxLength = 3000;
            this.longDescriptionBox.Multiline = true;
            this.longDescriptionBox.Name = "longDescriptionBox";
            this.longDescriptionBox.Size = new System.Drawing.Size(215, 81);
            this.longDescriptionBox.TabIndex = 1;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(66, 17);
            this.nameBox.MaxLength = 50;
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 5;
            // 
            // CreateVenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 307);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.longDescriptionContainer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.label1);
            this.Name = "CreateVenue";
            this.Text = "Add a Venue to Database";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.longDescriptionContainer.ResumeLayout(false);
            this.longDescriptionContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox shortDescriptionBox;
        private System.Windows.Forms.GroupBox longDescriptionContainer;
        private System.Windows.Forms.TextBox longDescriptionBox;
        private System.Windows.Forms.TextBox nameBox;
    }
}