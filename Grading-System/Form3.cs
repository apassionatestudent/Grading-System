using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LoginPage
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
            timer1.Interval = 20; 
            timer1.Tick += timer1_Tick;
        }

        public int ProgressBarValue
        {
            get { return prbBar.Value; }
        }

        public event Action OnLoadingComplete; 
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (prbBar.Value < 100)
            {
                prbBar.Value += 1;
                lblPercentage.Text = prbBar.Value.ToString() + "%";
            }
            else
            {

                OnLoadingComplete?.Invoke();
                this.Close();
                timer1.Stop();

                if (prbBar.Value == 100)
                {
                    Form2 dashboardForm = new Form2();
                    dashboardForm.Show();
                }
            }
        }

        private void lblLoading_Click(object sender, EventArgs e)
        {

        }
    }
}
