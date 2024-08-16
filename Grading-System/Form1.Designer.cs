namespace LoginPage
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.PictureBox pbxACTlogo;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.lblExitTab = new System.Windows.Forms.Label();
            this.lblClearField = new System.Windows.Forms.Label();
            this.lblIncorrectUN = new System.Windows.Forms.Label();
            this.lblIncorrectPass = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbPassword = new System.Windows.Forms.PictureBox();
            this.pbProfile = new System.Windows.Forms.PictureBox();
            pbxACTlogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pbxACTlogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxACTlogo
            // 
            resources.ApplyResources(pbxACTlogo, "pbxACTlogo");
            pbxACTlogo.BackColor = System.Drawing.Color.Transparent;
            pbxACTlogo.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            pbxACTlogo.Image = global::LoginPage.Properties.Resources.ACT_logo___blue___white__1_;
            pbxACTlogo.Name = "pbxACTlogo";
            pbxACTlogo.TabStop = false;
            pbxACTlogo.UseWaitCursor = true;
            // 
            // txtUserName
            // 
            resources.ApplyResources(this.txtUserName, "txtUserName");
            this.txtUserName.ForeColor = System.Drawing.Color.Silver;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Tag = "";
            this.txtUserName.Enter += new System.EventHandler(this.txtUserName_Enter);
            this.txtUserName.Leave += new System.EventHandler(this.txtUserName_Leave);
            // 
            // txtPassword
            // 
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.ForeColor = System.Drawing.Color.Silver;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // btnLogin
            // 
            resources.ApplyResources(this.btnLogin, "btnLogin");
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // chkShowPassword
            // 
            resources.ApplyResources(this.chkShowPassword, "chkShowPassword");
            this.chkShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.chkShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkShowPassword.ForeColor = System.Drawing.Color.Black;
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.UseVisualStyleBackColor = false;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // lblExitTab
            // 
            resources.ApplyResources(this.lblExitTab, "lblExitTab");
            this.lblExitTab.BackColor = System.Drawing.Color.Transparent;
            this.lblExitTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExitTab.ForeColor = System.Drawing.Color.Red;
            this.lblExitTab.Name = "lblExitTab";
            this.lblExitTab.Click += new System.EventHandler(this.lblExitTab_Click);
            // 
            // lblClearField
            // 
            resources.ApplyResources(this.lblClearField, "lblClearField");
            this.lblClearField.BackColor = System.Drawing.Color.Transparent;
            this.lblClearField.Cursor = System.Windows.Forms.Cursors.No;
            this.lblClearField.ForeColor = System.Drawing.Color.Red;
            this.lblClearField.Name = "lblClearField";
            this.lblClearField.Tag = "Username";
            this.lblClearField.Click += new System.EventHandler(this.lblClearField_Click);
            // 
            // lblIncorrectUN
            // 
            resources.ApplyResources(this.lblIncorrectUN, "lblIncorrectUN");
            this.lblIncorrectUN.ForeColor = System.Drawing.Color.Red;
            this.lblIncorrectUN.Name = "lblIncorrectUN";
            // 
            // lblIncorrectPass
            // 
            resources.ApplyResources(this.lblIncorrectPass, "lblIncorrectPass");
            this.lblIncorrectPass.ForeColor = System.Drawing.Color.Red;
            this.lblIncorrectPass.Name = "lblIncorrectPass";
            // 
            // pbPassword
            // 
            resources.ApplyResources(this.pbPassword, "pbPassword");
            this.pbPassword.BackColor = System.Drawing.Color.Transparent;
            this.pbPassword.BackgroundImage = global::LoginPage.Properties.Resources.lock_752x1024;
            this.pbPassword.Name = "pbPassword";
            this.pbPassword.TabStop = false;
            // 
            // pbProfile
            // 
            resources.ApplyResources(this.pbProfile, "pbProfile");
            this.pbProfile.BackColor = System.Drawing.Color.Transparent;
            this.pbProfile.BackgroundImage = global::LoginPage.Properties.Resources.Profile_2;
            this.pbProfile.Name = "pbProfile";
            this.pbProfile.TabStop = false;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::LoginPage.Properties.Resources.Log_In1;
            this.Controls.Add(this.lblIncorrectPass);
            this.Controls.Add(this.lblIncorrectUN);
            this.Controls.Add(this.lblClearField);
            this.Controls.Add(this.lblExitTab);
            this.Controls.Add(this.chkShowPassword);
            this.Controls.Add(this.pbPassword);
            this.Controls.Add(this.pbProfile);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(pbxACTlogo);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(pbxACTlogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox pbProfile;
        private System.Windows.Forms.PictureBox pbPassword;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.Label lblExitTab;
        private System.Windows.Forms.Label lblClearField;
        private System.Windows.Forms.Label lblIncorrectUN;
        private System.Windows.Forms.Label lblIncorrectPass;
        private System.Windows.Forms.Timer timer1;
    }
}


