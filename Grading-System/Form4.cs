using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPage
{
    public partial class Form4 : Form
    {
       
        public Form4()
        {
            InitializeComponent();

        }
   
        
        // should close app upon clicking "X" 
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Close all program when user clicks "X" button, especially Form 1 which holds the whole thing 
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Form1 form1Instance = Application.OpenForms.OfType<Form1>().FirstOrDefault();
                if (form1Instance != null)
                {
                    // form1Instance.Close();
                    Application.Exit();

                }
            }
            base.OnFormClosing(e);
        }
         

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void lblBackAboutUs_Click(object sender, EventArgs e)
        {

            Form2 DashBoard = new Form2();
            DashBoard.Show();
            this.Hide();
        }

        private void pbDiamante_Click(object sender, EventArgs e)
        {
            // Process.Start("https://www.facebook.com/actief.casp/");

            Process.Start("https://web.facebook.com/bianca.diamante.359");
        }

        private void lblNameUI_Click(object sender, EventArgs e)
        {

        }
    }
}
