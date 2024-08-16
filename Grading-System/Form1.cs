using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace LoginPage
{
    public partial class Form1 : Form
    {
        private int failedAttempts = 0;
        private Timer timerLockout = new Timer();
        private DateTime startTime;

        

        public Form1()
        {
            InitializeComponent();
            timerLockout.Interval = 300000; // 5 minutes
            timerLockout.Tick += TimerLockout_Tick;
            txtPassword.PasswordChar = '*';
            lblIncorrectUN.Visible = false;
            lblIncorrectPass.Visible = false;
            txtUserName.TextChanged += txtUserName_TextChanged;
            txtPassword.TextChanged += txtPassword_TextChanged;
            this.KeyDown += Form1_KeyDown;
            txtUserName.Enter += txtUserName_Enter;
            txtUserName.Leave += txtUserName_Leave;
            txtPassword.Enter += txtPassword_Enter;
            txtPassword.Leave += txtPassword_Leave;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            lblExitTab.Click += lblExitTab_Click;
            lblClearField.Click += lblClearField_Click;
            lblClearField.MouseEnter += lblClearField_MouseEnter;
            Application.ApplicationExit += Application_ApplicationExit;

            if (txtPassword.Text == PlaceholderTextPass)
            {
                txtPassword.PasswordChar = '\0';
            }

            if (chkShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }

            this.Focus();
            Label focusOutLabel = new Label() { Text = "", Name = "focusOutLabel", Visible = false };
            this.Controls.Add(focusOutLabel);
            this.ActiveControl = focusOutLabel;
        }

        
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Close all program when user clicks "X" button, especially Form 1 which holds the whole thing 
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Form2 form2Instance = Application.OpenForms.OfType<Form2>().FirstOrDefault();
                if (form2Instance != null)
                {
                    Application.Exit();
                }


            }
            base.OnFormClosing(e);
        } 
         

        private const string PlaceholderTextUser = "Username";
        private const string PlaceholderTextPass = "Password";

        private bool CheckCredentials(string username, string password)
        {
            return username == "admin123" && password == "password123";
        }

        private void TimerLockout_Tick(object sender, EventArgs e)
        {
            timerLockout.Stop();
            failedAttempts = 0;
            MessageBox.Show("Lockout period has ended. You can now try to log in again.");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || username == PlaceholderTextUser || txtUserName.ForeColor == Color.Silver)
            {
                lblIncorrectUN.Visible = true;
                lblIncorrectUN.Text = "Username is blank";
            }

            if (txtUserName.Text != "admin123" && txtUserName.Text != PlaceholderTextUser)
            {
                lblIncorrectUN.Visible = true;
                lblIncorrectUN.Text = "Username is incorrect";
            }

            if (string.IsNullOrWhiteSpace(password) || password == PlaceholderTextPass || txtPassword.ForeColor == Color.Silver)
            {
                lblIncorrectPass.Visible = true;
                lblIncorrectPass.Text = "Password is blank";
            }

            if (txtPassword.Text != "password123" && txtPassword.Text != PlaceholderTextPass)
            {
                lblIncorrectPass.Visible = true;
                lblIncorrectPass.Text = "Password is incorrect";
            }


            if (CheckCredentials(username, password))
            {
                failedAttempts = 0;
                timerLockout.Stop();
                Loading loadingForm = new Loading();
                loadingForm.OnLoadingComplete += () => this.Hide();
                loadingForm.Show();
            }
            else
            {
                failedAttempts++;
                if (failedAttempts >= 7)
                {
                    timerLockout.Start();
                    startTime = DateTime.Now;
                    MessageBox.Show($"Too many failed attempts. Please try again in 5 minutes.");
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        public void txtUserName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                lblIncorrectUN.Text = "";
                lblIncorrectUN.Visible = false;
            }


        }

        public void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                lblIncorrectPass.Text = "";
                lblIncorrectPass.Visible = false;
            }

        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {   
                if (txtPassword.Text == PlaceholderTextPass)
                {
                    txtPassword.PasswordChar = '\0';

                }

                else
                {
                    txtPassword.PasswordChar = '*';

                }

                // txtPassword.PasswordChar = '*';
            }

        }

        private void lblExitTab_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblClearField_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtUserName.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text) ||
        txtUserName.Text != PlaceholderTextUser && txtPassword.Text != PlaceholderTextPass)
            {
                txtUserName.Text = null;
                txtPassword.Text = null;
                lblIncorrectUN.Visible = false;
                lblIncorrectPass.Visible = false;
                chkShowPassword.Checked = false;

                this.Focus();
                Label focusOutLabel = new Label() { Text = "", Name = "focusOutLabel", Visible = false };
                this.Controls.Add(focusOutLabel);
                this.ActiveControl = focusOutLabel;

                txtUserName_Enter(sender, e);
                txtUserName_Leave(sender, e);

                txtPassword_Enter(sender, e);
                txtPassword_Leave(sender, e);
            }

        }

        private void lblClearField_MouseEnter(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtUserName.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text) ||
                txtUserName.Text != PlaceholderTextUser && txtPassword.Text != PlaceholderTextPass)
            {
                // Change the cursor to a hand when hovering over the label
                lblClearField.Cursor = Cursors.Hand;
            }


            // Set the cursor to No if both fields are at their placeholder state
            if (txtUserName.Text == PlaceholderTextUser && txtPassword.Text == PlaceholderTextPass && chkShowPassword.Checked == false)
            {
                lblClearField.Cursor = Cursors.No;
            }
        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            if (txtUserName.Text == PlaceholderTextUser)
            {
                txtUserName.Text = "";
                txtUserName.ForeColor = Color.Black;
            }
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                txtUserName.Text = PlaceholderTextUser;
                txtUserName.ForeColor = Color.Silver;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == PlaceholderTextPass)
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
                txtPassword.PasswordChar = '*'; // Make sure the password is visible when entering

                if (chkShowPassword.Checked)
                {
                    txtPassword.PasswordChar = '\0';
                }
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = PlaceholderTextPass;
                txtPassword.ForeColor = Color.Silver;
                txtPassword.PasswordChar = '\0'; // Ensure the password is hidden when leaving
            }
        }

        private void SaveTimerState()
        {
            File.WriteAllText("timerState.txt", timerLockout.Interval.ToString());
        }

        private void LoadTimerState()
        {
            if (File.Exists("timerState.txt"))
            {
                try
                {
                    int remainingTime = int.Parse(File.ReadAllText("timerState.txt"));
                    timerLockout.Interval = remainingTime;
                    timerLockout.Start();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error loading timer state: {ex.Message}");
                }
            }
        }

        private void Application_ApplicationExit(object sender, EventArgs e)
        {
            SaveTimerState();
        }

        
    }
}