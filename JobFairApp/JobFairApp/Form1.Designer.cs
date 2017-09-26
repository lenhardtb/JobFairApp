namespace JobFairApp
{
    partial class Form1
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
            this.person_btn = new System.Windows.Forms.Button();
            this.venue_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // person_btn
            // 
            this.person_btn.Location = new System.Drawing.Point(12, 53);
            this.person_btn.Name = "person_btn";
            this.person_btn.Size = new System.Drawing.Size(104, 23);
            this.person_btn.TabIndex = 3;
            this.person_btn.Text = "Create Person";
            this.person_btn.UseVisualStyleBackColor = true;
            this.person_btn.Click += new System.EventHandler(this.person_btn_Click);
            // 
            // venue_btn
            // 
            this.venue_btn.Location = new System.Drawing.Point(12, 24);
            this.venue_btn.Name = "venue_btn";
            this.venue_btn.Size = new System.Drawing.Size(104, 23);
            this.venue_btn.TabIndex = 2;
            this.venue_btn.Text = "Create Venue";
            this.venue_btn.UseVisualStyleBackColor = true;
            this.venue_btn.Click += new System.EventHandler(this.venue_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 334);
            this.Controls.Add(this.person_btn);
            this.Controls.Add(this.venue_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button person_btn;
        private System.Windows.Forms.Button venue_btn;
    }
}

