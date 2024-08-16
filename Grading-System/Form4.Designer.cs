namespace LoginPage
{
    partial class Form4
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
            this.lblBackAboutUs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBackAboutUs
            // 
            this.lblBackAboutUs.AutoSize = true;
            this.lblBackAboutUs.BackColor = System.Drawing.Color.Transparent;
            this.lblBackAboutUs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBackAboutUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBackAboutUs.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblBackAboutUs.Location = new System.Drawing.Point(-1, 0);
            this.lblBackAboutUs.Name = "lblBackAboutUs";
            this.lblBackAboutUs.Size = new System.Drawing.Size(89, 32);
            this.lblBackAboutUs.TabIndex = 0;
            this.lblBackAboutUs.Text = " Back";
            this.lblBackAboutUs.Click += new System.EventHandler(this.lblBackAboutUs_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LoginPage.Properties.Resources.Diamante__Bianca;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1335, 698);
            this.Controls.Add(this.lblBackAboutUs);
            this.DoubleBuffered = true;
            this.Name = "Form4";
            this.Text = "About Us";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBackAboutUs;
    }
}