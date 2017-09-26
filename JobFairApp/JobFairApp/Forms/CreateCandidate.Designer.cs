namespace JobFairApp.Forms
{
    partial class CreateCandidate
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
            this.personControl = new JobFairApp.Forms.PersonControl();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "In order to register as a candidate, \r\nyou just need a User ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // personControl
            // 
            this.personControl.Location = new System.Drawing.Point(12, 38);
            this.personControl.Name = "personControl";
            this.personControl.Size = new System.Drawing.Size(210, 322);
            this.personControl.TabIndex = 1;
            // 
            // CreateCandidate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 368);
            this.Controls.Add(this.personControl);
            this.Controls.Add(this.label1);
            this.Name = "CreateCandidate";
            this.Text = "CreateCandidate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private PersonControl personControl;
    }
}