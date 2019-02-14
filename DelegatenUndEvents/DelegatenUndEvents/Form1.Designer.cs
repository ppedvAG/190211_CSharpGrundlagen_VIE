namespace DelegatenUndEvents
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
            this.buttonKlickMich = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonKlickMich
            // 
            this.buttonKlickMich.Location = new System.Drawing.Point(121, 28);
            this.buttonKlickMich.Name = "buttonKlickMich";
            this.buttonKlickMich.Size = new System.Drawing.Size(238, 48);
            this.buttonKlickMich.TabIndex = 0;
            this.buttonKlickMich.Text = "Klick mich !";
            this.buttonKlickMich.UseVisualStyleBackColor = true;
            this.buttonKlickMich.Click += new System.EventHandler(this.buttonKlickMich_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(392, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 125);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonKlickMich);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonKlickMich;
        private System.Windows.Forms.Button button1;
    }
}

