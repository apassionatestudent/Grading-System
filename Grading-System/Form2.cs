using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Printing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Windows.Forms;
using System.CodeDom;
using System.Net;
using System.Runtime.Remoting.Channels;
using System.Collections.ObjectModel;

namespace LoginPage
{
    public partial class Form2 : Form
    {
        DataTable studentTable = new DataTable("studentTable");
        // DataTable rankingTable = new DataTable();

        DataTable dgvGradingPrelim = new DataTable("dgvGradingPrelim");
        DataTable dgvGradingMidterm = new DataTable("dgvGradingMidterm");
        DataTable dgvGradingFinal = new DataTable("dgvGradingFinal");

        int index;

        public Form2()
        {
            InitializeComponent();

            pnlStudents.Visible = false;
            pnlGrading.Visible = false;
            pnlContacts.Visible = false;

            dgvRanking.Visible = false;

            dgvMidTerm.Visible = false;
            dgvFinalTerm.Visible = false;

            pnlGradingTab.Controls.Add(txtQuizScore);
            pnlGradingTab.Controls.Add(txtLabScore);
            pnlGradingTab.Controls.Add(txtSeatworkScore);
            pnlGradingTab.Controls.Add(txtAttendanceScore);

            pnlGradingTab.Controls.Add(lblQuizScore);
            pnlGradingTab.Controls.Add(lblLabScore);
            pnlGradingTab.Controls.Add(lblSeatworkScore);
            pnlGradingTab.Controls.Add(lblAttendanceScore);

            pnlGradingTab.Controls.Add(btnPrelim);
            pnlGradingTab.Controls.Add(btnMidterm);
            pnlGradingTab.Controls.Add(btnFinals);

            dgvPrelim.DefaultCellStyle.BackColor = Color.Khaki;
            dgvMidTerm.DefaultCellStyle.BackColor = Color.PaleGreen;
            dgvFinalTerm.DefaultCellStyle.BackColor = Color.Salmon;

            txtQuizScore.TextChanged += txtQuizScore_TextChanged;
            txtLabScore.TextChanged += txtLabScore_TextChanged;
            txtSeatworkScore.TextChanged += txtSeatworkScore_TextChanged;
            txtAttendanceScore.TextChanged += txtAttendanceScore_TextChanged;

            dgvMidTerm.CellClick += dgvMidTerm_CellClick;
            txtLabScoreMid.TextChanged += txtLabScoreMid_TextChanged;
            txtQuizScoreMid.TextChanged += txtQuizScoreMid_TextChanged;
            txtPracticalExamScoreMid.TextChanged += txtPracticalExamScoreMid_TextChanged;

            dgvFinalTerm.CellClick += dgvFinalTerm_CellClick;
            txtLabScoreFinal.TextChanged += txtLabScoreFinal_TextChanged;
            txtQuizScoreFinal.TextChanged += txtQuizScoreFinal_TextChanged;
            txtProjectScoreFinal.TextChanged += txtProjectScoreFinal_TextChanged;

            studentTable.Columns.Add("ID", Type.GetType("System.Int32"));
            studentTable.Columns.Add("Name", Type.GetType("System.String"));
            studentTable.Columns.Add("Age", Type.GetType("System.Int32"));
            studentTable.Columns.Add("Address", Type.GetType("System.String"));
            studentTable.Columns.Add("Overall Grade", Type.GetType("System.Double"));

            studentTable.Rows.Add(1, "John", 18, "Cebu City");
            studentTable.Rows.Add(2, "Juliet", 18, "Cebu City");
            studentTable.Rows.Add(3, "Romeo", 19, "Lapu-Lapu");
            studentTable.Rows.Add(4, "Heinrich", 18, "Berlin");
            studentTable.Rows.Add(5, "Eric", 18, "Dresden");
            studentTable.Rows.Add(6, "David", 18, "Scotland");
            studentTable.Rows.Add(7, "Gushken", 18, "Warsaw");
            studentTable.Rows.Add(8, "Vladimir", 18, "Stalingrad");
            studentTable.Rows.Add(9, "Jose", 18, "Madrid");
            studentTable.Rows.Add(10, "Dexter", 18, "USA");

            // Contacts 
            lblCOE.Click += lblCOE_Click;
            pbCOE.Click += pbCOE_Click;
            lblCCS.Click += lblCCS_Click;
            pbCCS.Click += pbCCS_Click; 
        }

        private void TxtLabScoreMid_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void TxtLabScore_Enter(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void TxtQuizScore_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Close all program when user clicks "X" button, especially Form 1 which holds the whole thing 
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Form1 form1Instance = Application.OpenForms.OfType<Form1>().FirstOrDefault();
                if (form1Instance != null)
                {
                    form1Instance.Close();
                    Application.Exit();
                }
            }
            base.OnFormClosing(e);
        }

        // Home Starts 
        private void lblHome_Click(object sender, EventArgs e)
        {
            Font newFont = new Font("Arial", 16, FontStyle.Bold);
            Font defFont = new Font("Microsoft Sans Serif", (int)16.2, FontStyle.Regular);


            lblHome.ForeColor = Color.Blue;
            lblHome.Font = newFont;

            lblStudents.Font = defFont; lblGrading.Font = defFont; lblContact.Font = defFont;
            lblStudents.ForeColor = Color.Black;
            lblGrading.ForeColor = Color.Black;
            lblContact.ForeColor = Color.Black;


            pnlHome.Visible = true;
            pnlStudents.Visible = false; 
            pnlGrading.Visible = false; 
            pnlContacts.Visible = false;
        }
        // Home Ends 

        // Students Starts 
        private void lblStudents_Click(object sender, EventArgs e)
        {
            Font newFont = new Font("Arial", 16, FontStyle.Bold);
            Font defFont = new Font("Microsoft Sans Serif", (int)16.2, FontStyle.Regular);

            lblStudents.ForeColor = Color.Blue;
            lblStudents.Font = newFont;

            lblContact.Font = defFont; lblHome.Font = defFont; lblGrading.Font = defFont;
            lblHome.ForeColor = Color.Black;
            lblGrading.ForeColor = Color.Black;
            lblContact.ForeColor = Color.Black;

            pnlHome.Visible = false;
            pnlStudents.Visible = true;
            pnlGrading.Visible = false;
            pnlContacts.Visible = false;

            int newWidth = (int)(this.ClientSize.Width * 0.85);
            int newHeight = (int)(this.ClientSize.Height * 1);

            int pnlWidth = (int)(this.ClientSize.Width * 0.3); // 40% of the form's width
            int pnlHeight = (int)(this.ClientSize.Height * 0.8); // 80% of the form's height

            int margin = (int)(this.ClientSize.Width * 0.50);

            int pnlStudentsInfoPositionX = newWidth - pnlWidth - margin; // Position X
            int pnlStudentsInfoPositionY = (this.ClientSize.Height - pnlHeight) / 2; // Position Y to center vertically

            // Set the location and size of dgvStudents

            pnlStudentsInfo.Location = new Point(pnlStudentsInfoPositionX, pnlStudentsInfoPositionY);
            pnlStudentsInfo.Size = new Size(pnlWidth, pnlHeight);

            Grading(sender, e); 
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                // prevent same ID to be added, should be unique 
                foreach (DataGridViewRow row in dgvStudents.Rows)
                {
                    if (row.Cells["ID"].Value.ToString() == txtID.Text)
                    {
                        MessageBox.Show("The ID number is already in use. Please enter a different ID.", "ID Already Exists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Check if any of the text boxes are empty
                if (string.IsNullOrWhiteSpace(txtID.Text) || string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtAge.Text) || string.IsNullOrWhiteSpace(txtAddress.Text))
                {
                    throw new ArgumentException("There's no input to be added.");
                }
                bool isValidID = int.TryParse(txtID.Text, out _); 
                bool isValidAge = int.TryParse(txtAge.Text, out _);

                if (!isValidID && !isValidAge)
                {
                    throw new ArgumentException("Both ID and age are not valid. Please make sure they\'re numeric.");
                }

                if (!isValidID)
                {
                    throw new ArgumentException("Invalid ID number. Please make sure it\'s numeric.");
                }

                if (!isValidAge)
                {
                    throw new ArgumentException("Invalid Age number. Please make sure it\'s numeric.");
                }

                studentTable.Rows.Add(txtID.Text, txtName.Text, txtAge.Text, txtAddress.Text, OverallGrade = 6);
                dgvGradingPrelim.Rows.Add(txtID.Text, txtName.Text, QuizScore, AttendanceScore, LabScore, SeatWorkScore, PrelimGrade = 0);
                dgvGradingMidterm.Rows.Add(txtID.Text, txtName.Text, LabScore, QuizScore, PracticalExam, MidtermGrade = 0);
                dgvGradingFinal.Rows.Add(txtID.Text, txtName.Text, LabScore, QuizScore, ProjectScore, FinalGrade = 0);

                txtRank.Text = string.Empty;
                txtPrelimGrade.Text = string.Empty;
                txtMidtermGrade.Text = string.Empty;
                txtFinalGrade.Text = string.Empty;
                txtOverallGrade.Text = string.Empty;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtID.Text = string.Empty;
            txtName.Text = string.Empty;
            txtAge.Text = string.Empty;
            txtAddress.Text = string.Empty;

            txtRank.Text = string.Empty;
            txtPrelimGrade.Text = string.Empty;
            txtMidtermGrade.Text = string.Empty;
            txtFinalGrade.Text = string.Empty;
            txtOverallGrade.Text = string.Empty;
        }

        private int FindStudentRank(string studentName)
        {
            // Iterate over the rows of dgvRanking to find the student's rank
            foreach (DataGridViewRow row in dgvRanking.Rows)
            {
                if (row.Cells["StudentName"].Value.ToString() == studentName)
                {
                    // Return the rank of the student
                    return row.Index + 1; // Assuming the rank is determined by the row index + 1
                }
            }
            // Return a default value if the student is not found
            return -1;
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked column is not the first column and if the row index is valid
            if (e.ColumnIndex == 0 || e.RowIndex < 0) // Assuming the first column is used for row headers
            {
                return; // Exit the method if the condition is met
            }

            

            try
            {
                index = e.RowIndex;
                if (index < 0) // Check if the row index is valid
                {
                    MessageBox.Show("Invalid row index. You can\'t select the whole row.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Exit the method if the index is invalid
                }
                DataGridViewRow row = dgvStudents.Rows[index];
                DataGridViewRow PrelimGradeData = dgvPrelim.Rows[index];
                DataGridViewRow MidtermGradeData = dgvMidTerm.Rows[index];
                DataGridViewRow FinalGradeData = dgvFinalTerm.Rows[index];

                txtID.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                txtAge.Text = row.Cells[2].Value.ToString();
                txtAddress.Text = row.Cells[3].Value.ToString();
                
                txtPrelimGrade.Text = PrelimGradeData.Cells[6].Value.ToString();
                txtMidtermGrade.Text = MidtermGradeData.Cells[5].Value.ToString();
                txtFinalGrade.Text = FinalGradeData.Cells[5].Value.ToString(); 
                txtOverallGrade.Text = row.Cells[4].Value.ToString();

                string studentName = dgvStudents.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                RankGrades(sender, e);
                int studentRank = FindStudentRank(studentName);
                txtRank.Text = studentRank.ToString();

            }
            catch (System.ArgumentOutOfRangeException ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if any of the text boxes are empty
                if (string.IsNullOrWhiteSpace(txtID.Text) || string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtAge.Text) || string.IsNullOrWhiteSpace(txtAddress.Text))
                {
                    throw new ArgumentException("There's no input/s to be updated into a specific row.");
                }

                foreach (DataGridViewRow rowID in dgvStudents.Rows)
                {
                    if (rowID.Cells["ID"].Value.ToString() != txtID.Text)
                    {
                        
                        if (rowID.Cells["ID"].Value.ToString() == txtID.Text || rowID.Cells["Name"].Value.ToString() == txtName.Text)
                        {   

                            foreach (DataGridViewRow row in dgvStudents.Rows)
                            {
                                if (row.Cells["ID"].Value.ToString() == txtID.Text)
                                {
                                    MessageBox.Show("Invalid update, ID number must not be the same!", "ID Already Exist", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                
                            }
                        }
                    }
                }

                bool isValidID = int.TryParse(txtID.Text, out _);
                bool isValidAge = int.TryParse(txtAge.Text, out _);

                if (!isValidID && !isValidAge)
                {
                    throw new ArgumentException("Both ID and age are not valid. Please make sure they\'re numeric.");
                }

                if (!isValidID)
                {
                    throw new ArgumentException("Invalid ID number. Please make sure it\'s numeric.");
                }

                if (!isValidAge)
                {
                    throw new ArgumentException("Invalid Age number. Please make sure it\'s numeric.");
                }

                DataGridViewRow newData = dgvStudents.Rows[index];
                newData.Cells[0].Value = txtID.Text;
                newData.Cells[1].Value = txtName.Text;
                newData.Cells[2].Value = txtAge.Text;
                newData.Cells[3].Value = txtAddress.Text;

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (System.FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtID.Text = string.Empty;
            txtName.Text = string.Empty;
            txtAge.Text = string.Empty;
            txtAddress.Text = string.Empty;

            txtRank.Text = string.Empty;
            txtPrelimGrade.Text = string.Empty;
            txtMidtermGrade.Text = string.Empty;
            txtFinalGrade.Text = string.Empty;  
            txtOverallGrade.Text = string.Empty;

            int selectedIndex = dgvStudents.CurrentRow.Index;
            dgvStudents.Rows.RemoveAt(selectedIndex);

            foreach (DataGridViewRow row in dgvPrelim.Rows)
            {
                // Check if the index matches
                if (row.Index == selectedIndex)
                {
                    // This is the matching row
                    dgvPrelim.Rows.RemoveAt(row.Index);
                    break;
                }
            }

            foreach (DataGridViewRow row in dgvMidTerm.Rows)
            {
                if (row.Index == selectedIndex)
                {
                    dgvMidTerm.Rows.RemoveAt(row.Index);
                    break;
                }
            }

            foreach (DataGridViewRow row in dgvFinalTerm.Rows)
            {
                if (row.Index == selectedIndex)
                {
                    dgvFinalTerm.Rows.RemoveAt(row.Index);
                    break;
                }
            }
            
        }

        private void btnStudentTable_Click(object sender, EventArgs e)
        {
            dgvStudents.Visible = true;
            dgvRanking.Visible = false;

            txtName.Enabled = true;
            txtID.Enabled = true;
            txtAge.Enabled = true;
            txtAddress.Enabled = true;

            btnInsert.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnNew.Enabled = true;
        }

        private void btnRanking_Click(object sender, EventArgs e)
        {
            dgvRanking.Visible = true;
            dgvStudents.Visible = false;

            txtName.Enabled = false;
            txtID.Enabled = false;
            txtAge.Enabled = false;
            txtAddress.Enabled = false; 

            btnInsert.Enabled = false;
            btnUpdate.Enabled = false; 
            btnDelete.Enabled = false;  
            btnNew.Enabled = false;

            RankGrades(sender, e);
        }

        private void RankGrades(object sender, EventArgs e)
        {
            var sortedGrades = dgvStudents.Rows.Cast<DataGridViewRow>()
            .OrderBy(row => row.Cells["Overall Grade"].Value); // Corrected to ascending order

            var rankings = sortedGrades.Select((row, index) => new { Row = row, Rank = index + 1 });

            dgvRanking.DataSource = rankings.Select(r => new { StudentName = r.Row.Cells["Name"].Value, Rank = r.Rank }).ToList();
        }

        // Students Ends


        // Grading Starts 
        private void lblGrading_Click(object sender, EventArgs e)
        {

            Font newFont = new Font("Arial", 16, FontStyle.Bold);
            Font defFont = new Font("Microsoft Sans Serif", (int)16.2, FontStyle.Regular);

            lblGrading.ForeColor = Color.Blue;
            lblGrading.Font = newFont;

            lblStudents.Font = defFont; lblHome.Font = defFont; lblContact.Font = defFont;
            lblHome.ForeColor = Color.Black;
            lblStudents.ForeColor = Color.Black;
            lblContact.ForeColor = Color.Black;

            pnlHome.Visible = false;
            pnlStudents.Visible = false;
            pnlGrading.Visible = true;
            pnlContacts.Visible = false;

            int newWidth = (int)(this.ClientSize.Width * 0.85);
            int newHeight = (int)(this.ClientSize.Height * 1);

            int pnlWidth = (int)(this.ClientSize.Width * 0.3); // 40% of the form's width
            int pnlHeight = (int)(this.ClientSize.Height * 0.8); // 80% of the form's height

            int margin = (int)(this.ClientSize.Width * 0.50);


            int pnlGradingTabPositionX = newWidth - pnlWidth - margin; // Position X
            int pnlGradingTabPositionY = (this.ClientSize.Height - pnlHeight) / 2; // Position Y to center vertically

            pnlGradingTab.Location = new Point(pnlGradingTabPositionX, pnlGradingTabPositionY);
            pnlGradingTab.Size = new Size(pnlWidth, pnlHeight);

        }
        double QuizScore = 0;
        double AttendanceScore = 0;
        double LabScore = 0;
        double SeatWorkScore = 0;

        double PracticalExam = 0;
        double ProjectScore = 0;

        double PrelimGrade = 0;
        double MidtermGrade = 0;
        double FinalGrade = 0;

        double rawGrade = 0;
        double upperBoundGrade = 5.0;
        double lowerBoundGrade = 1.0;
        double upperBoundPercentage = 100.0;
        double OverallGrade = 0;

        Random random = new Random();
        private double GenerateRandomDouble(double minValue, double maxValue)
        {
            return random.NextDouble() * (maxValue - minValue) + minValue;
        }
        private void CollectData(object sender, EventArgs e)
        {
            
            foreach (DataGridViewRow row in dgvStudents.Rows)
            {
                // Accessing the value in column 1
                var ID = row.Cells[0].Value;

                // Accessing the value in column 2
                var name = row.Cells[1].Value;

                bool studentExists = false;
                foreach (DataGridViewRow existingRow in dgvStudents.Rows)
                {
                    if (existingRow.Cells[0].Value == ID && existingRow.Cells[1].Value == name)
                    {
                        studentExists = true;
                        break; // Exit the loop once the student is found
                    }
                }

                // Add the new row only if the student does not exist
                if (!studentExists)
                {
                    int QuizScore = random.Next(60, 101); 
                    int AttendanceScore = random.Next(60, 101);  
                    int LabScore = random.Next(60, 101);  
                    int SeatWorkScore = random.Next(60, 101); 
                    int PracticalExam = random.Next(60, 101);  
                    int ProjectScore = random.Next(60, 101);

                    
                    double rawPrelimGrade = QuizScore * 0.4 + LabScore * 0.5 + SeatWorkScore * 0.05 + AttendanceScore * 0.05;
                    double rawMidtermGrade = LabScore * 0.5 + QuizScore * 0.2 + PracticalExam * 0.3;
                    double rawFinalGrade = LabScore * 0.5 + QuizScore * 0.3 + ProjectScore * 0.2;

                    PrelimGrade = Math.Round((upperBoundGrade - lowerBoundGrade) * (1 - rawPrelimGrade / upperBoundPercentage) + lowerBoundGrade, 2, MidpointRounding.AwayFromZero);
                    MidtermGrade = Math.Round((upperBoundGrade - lowerBoundGrade) * (1 - rawMidtermGrade / upperBoundPercentage) + lowerBoundGrade, 2, MidpointRounding.AwayFromZero);
                    FinalGrade = Math.Round((upperBoundGrade - lowerBoundGrade) * (1 - rawFinalGrade / upperBoundPercentage) + lowerBoundGrade, 2, MidpointRounding.AwayFromZero);
                    OverallGrade = Math.Round(PrelimGrade * 0.2 + MidtermGrade * 0.4 + FinalGrade * 0.4, 2, MidpointRounding.AwayFromZero);

                    dgvGradingPrelim.Rows.Add(ID, name, QuizScore, AttendanceScore, LabScore, SeatWorkScore, PrelimGrade);
                    dgvGradingMidterm.Rows.Add(ID, name, LabScore, QuizScore, PracticalExam, MidtermGrade);
                    dgvGradingFinal.Rows.Add(ID, name, LabScore, QuizScore, ProjectScore, FinalGrade);
                    row.Cells[4].Value = OverallGrade; 
                    
                }
            }
        }

        private void Grading(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvStudents.Rows[index];

            DataGridViewRow rowPrelim = dgvPrelim.Rows[index];
            DataGridViewRow rowMidterm = dgvMidTerm.Rows[index];
            DataGridViewRow rowFinal = dgvFinalTerm.Rows[index];

            rowPrelim.Cells[6].Value = PrelimGrade;
            rowMidterm.Cells[5].Value = MidtermGrade;
            rowFinal.Cells[5].Value = FinalGrade;

            OverallGrade = Math.Round(PrelimGrade * 0.2 + MidtermGrade * 0.4 + FinalGrade * 0.4, 2, MidpointRounding.AwayFromZero);

            row.Cells[4].Value = OverallGrade;

            txtID.Text = row.Cells[0].Value.ToString();
            txtName.Text = row.Cells[1].Value.ToString();
            txtAge.Text = row.Cells[2].Value.ToString();
            txtAddress.Text = row.Cells[3].Value.ToString();

            txtPrelimGrade.Text = rowPrelim.Cells[6].Value.ToString();
            txtMidtermGrade.Text = rowMidterm.Cells[5].Value.ToString();
            txtFinalGrade.Text = rowFinal.Cells[5].Value.ToString();
            txtOverallGrade.Text = row.Cells[4].Value.ToString();

            string studentName = dgvStudents.Rows[index].Cells["Name"].Value.ToString();
            RankGrades(sender, e);
            int studentRank = FindStudentRank(studentName);
            txtRank.Text = studentRank.ToString();
        }


        // *** PRELIM *** 
        private void btnPrelim_Click(object sender, EventArgs e)
        {
            dgvPrelim.Visible = true;
            dgvMidTerm.Visible = false;
            dgvFinalTerm.Visible = false;

            txtQuizScore.Enabled = true;
            txtLabScore.Enabled = true;
            txtSeatworkScore.Enabled = true;
            txtAttendanceScore.Enabled = true;

            btnCalculatePrelim.Enabled = true;
            btnClearPrelim.Enabled = true;

            btnCalculatePrelim.BackColor = Color.PaleGreen;
            btnClearPrelim.BackColor = Color.Tomato;

            btnCalculateMidterm.Enabled = false;
            btnClearMidterm.Enabled = false;

            btnCalculateFinal.Enabled = false;
            btnClearFinal.Enabled = false;

            txtQuizScore.BackColor = SystemColors.Window; // Assuming you're using Windows Forms
            txtLabScore.BackColor = SystemColors.Window;
            txtSeatworkScore.BackColor = SystemColors.Window;
            txtAttendanceScore.BackColor = SystemColors.Window;

            txtQuizScore.Cursor = Cursors.IBeam;
            txtLabScore.Cursor = Cursors.IBeam;
            txtSeatworkScore.Cursor = Cursors.IBeam;
            txtAttendanceScore.Cursor = Cursors.IBeam;

            // Set the Enabled property to false, BackColor to Gray, and Cursor to No for the disabled text boxes
            txtLabScoreMid.Enabled = false;
            txtQuizScoreMid.Enabled = false;
            txtPracticalExamScoreMid.Enabled = false;
            txtLabScoreFinal.Enabled = false; 
            txtQuizScoreFinal.Enabled = false; 
            txtProjectScoreFinal.Enabled = false;

            btnCalculateMidterm.BackColor = Color.Gray;
            btnClearMidterm.BackColor = Color.Gray;
            btnCalculateFinal.BackColor = Color.Gray;
            btnClearFinal.BackColor = Color.Gray;

            txtLabScoreMid.BackColor = Color.Gray;
            txtQuizScoreMid.BackColor = Color.Gray;
            txtPracticalExamScoreMid.BackColor = Color.Gray;
            txtLabScoreFinal.BackColor = Color.Gray; 
            txtQuizScoreFinal.BackColor = Color.Gray; 
            txtProjectScoreFinal.BackColor = Color.Gray;

        }

        private void btnCalculatePrelim_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvPrelim.Rows[index];
            try
            {
                rawGrade = Convert.ToDouble(txtQuizScore.Text) * 0.4 + Convert.ToDouble(txtLabScore.Text) * 0.5 +
                           Convert.ToDouble(txtSeatworkScore.Text) * 0.05 + Convert.ToDouble(txtAttendanceScore.Text) * 0.05;

                PrelimGrade = (upperBoundGrade - lowerBoundGrade) * (1 - rawGrade / upperBoundPercentage) + lowerBoundGrade;
                PrelimGrade = Math.Round(PrelimGrade, 2);

                row.Cells[6].Value = PrelimGrade.ToString();

                // PrelimGrade = (upperBoundGrade - lowerBoundGrade) * (1 - rawGrade / upperBoundPercentage) + lowerBoundGrade;

                // row.Cells[6].Value = PrelimGrade.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Please select a student!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Grading(sender, e);
        }
        private void btnClearPrelim_Click(object sender, EventArgs e)
        {
            txtQuizScore.Text = null;
            txtLabScore.Text = null;
            txtSeatworkScore.Text = null; 
            txtAttendanceScore.Text = null;
        }

        private void dgvPrelim_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                index = e.RowIndex;
                if (index >= 0 && index < dgvPrelim.Rows.Count) // Ensure the row exists
                {
                    DataGridViewRow row = dgvPrelim.Rows[index];
                    if (row != null)
                    {
                        txtQuizScore.Text = row.Cells[2]?.Value?.ToString() ?? "N/A";
                        txtLabScore.Text = row.Cells[3]?.Value?.ToString() ?? "N/A";
                        txtSeatworkScore.Text = row.Cells[4]?.Value?.ToString() ?? "N/A";
                        txtAttendanceScore.Text = row.Cells[5]?.Value?.ToString() ?? "N/A";
                        PrelimGrade = 0;
                    }
                    else
                    {
                        MessageBox.Show("The selected row does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid row index. You can\'t select the whole table.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (System.ArgumentOutOfRangeException ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        private bool _isMessageBoxShown = false; // Declare this field at the class level

        private void txtQuizScore_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txtQuizScore.Text, out double quizScore))
            {
                // Check if the parsed value is within the allowed range
                if (quizScore >= 0 && quizScore <= 100)
                {
                    DataGridViewRow row = dgvPrelim.Rows[index];
                    row.Cells[2].Value = quizScore;
                    _isMessageBoxShown = false;
                }
                else
                {
                    // If the value is outside the allowed range, show a message box
                    if (!_isMessageBoxShown)
                    {
                        string errMessage = "Error";
                        string errTitle = "Invalid Input. It shouldn't be a negative or beyond 100."; ;
                        MessageBox.Show(errTitle, errMessage, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        DataGridViewRow row = dgvPrelim.Rows[index];
                        txtQuizScore.Text = row.Cells[2]?.Value?.ToString() ?? "N/A";
                        _isMessageBoxShown = true; // Prevent showing the message box again until the next input attempt
                    }
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(txtQuizScore.Text) && !_isMessageBoxShown)
                {
                    string errMessage = "Error";
                    string errTitle = "Please enter a valid number for the quiz score.";
                    MessageBox.Show(errTitle, errMessage, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataGridViewRow row = dgvPrelim.Rows[index];
                    txtQuizScore.Text = row.Cells[2]?.Value?.ToString() ?? "N/A";
                    _isMessageBoxShown = true; // Prevent showing the message box again until the next input attempt
                }
            }
        }


        private void txtLabScore_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txtLabScore.Text, out double labScore))
            {
                if (labScore >= 0 && labScore <= 100)
                {
                    DataGridViewRow row = dgvPrelim.Rows[index];
                    row.Cells[3].Value = labScore;
                    _isMessageBoxShown = false;
                }
                else
                {
                    if (!_isMessageBoxShown)
                    {
                        string errMessage = "Error";
                        string errTitle = "Invalid Input. It shouldn't be a negative or beyond 100.";
                        MessageBox.Show(errTitle, errMessage, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        DataGridViewRow row = dgvPrelim.Rows[index];
                        txtLabScore.Text = row.Cells[3]?.Value?.ToString() ?? "N/A";
                        _isMessageBoxShown = true; // Prevent showing the message box again until the next input attempt
                    }
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(txtLabScore.Text) && !_isMessageBoxShown)
                {
                    string errMessage = "Error";
                    string errTitle = "Please enter a valid number for the lab score.";
                    MessageBox.Show(errTitle, errMessage, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataGridViewRow row = dgvPrelim.Rows[index];
                    txtLabScore.Text = row.Cells[3]?.Value?.ToString() ?? "N/A";
                    _isMessageBoxShown = true; // Prevent showing the message box again until the next input attempt
                }
            }
        }

        private void txtSeatworkScore_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txtSeatworkScore.Text, out double seatWorkScore))
            {
                if (seatWorkScore >= 0 && seatWorkScore <= 100)
                {
                    DataGridViewRow row = dgvPrelim.Rows[index];
                    row.Cells[4].Value = seatWorkScore;
                    _isMessageBoxShown = false;
                    rawGrade += Convert.ToDouble(txtSeatworkScore.Text) * 0.05;
                    PrelimGrade = (upperBoundGrade - lowerBoundGrade) * (1 - rawGrade / upperBoundPercentage) + lowerBoundGrade;
                }
                else
                {
                    if (!_isMessageBoxShown)
                    {
                        string errMessage = "Error";
                        string errTitle = "Invalid Input. It shouldn't be a negative or beyond 100.";
                        MessageBox.Show(errTitle, errMessage, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        DataGridViewRow row = dgvPrelim.Rows[index];
                        txtSeatworkScore.Text = row.Cells[4]?.Value?.ToString() ?? "N/A";
                        _isMessageBoxShown = true; // Prevent showing the message box again until the next input attempt
                    }
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(txtSeatworkScore.Text) && _isMessageBoxShown)
                {
                    string errMessage = "Error";
                    string errTitle = "Please enter a valid number for the seatwork score.";
                    MessageBox.Show(errTitle, errMessage, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataGridViewRow row = dgvPrelim.Rows[index];
                    txtSeatworkScore.Text = row.Cells[4]?.Value?.ToString() ?? "N/A";
                    _isMessageBoxShown = true; // Prevent showing the message box again until the next input attempt
                }
            }
        }

        private void txtAttendanceScore_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txtAttendanceScore.Text, out double attendanceScore))
            {
                // Check if the parsed value is within the allowed range
                if (attendanceScore >= 0 && attendanceScore <= 100)
                {
                    DataGridViewRow row = dgvPrelim.Rows[index];
                    row.Cells[5].Value = attendanceScore;
                    _isMessageBoxShown = false;
                    // SummonPrelimGrade(sender, new DataGridViewCellEventArgs(-1, -1));
                }
                else
                {
                    // If the value is outside the allowed range, show a message box
                    if (!_isMessageBoxShown)
                    {
                        string errMessage = "Error";
                        string errTitle = "Invalid Input. It shouldn't be a negative or beyond 100."; 
                        MessageBox.Show(errTitle, errMessage, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        DataGridViewRow row = dgvPrelim.Rows[index];
                        txtAttendanceScore.Text = row.Cells[5]?.Value?.ToString() ?? "N/A";
                        _isMessageBoxShown = true; // Prevent showing the message box again until the next input attempt
                    }
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(txtAttendanceScore.Text) && !_isMessageBoxShown)
                {
                    string errMessage = "Error";
                    string errTitle = "Please enter a valid number for the attendance score.";
                    MessageBox.Show(errTitle, errMessage, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataGridViewRow row = dgvPrelim.Rows[index];
                    txtAttendanceScore.Text = row.Cells[5]?.Value?.ToString() ?? "N/A";
                    _isMessageBoxShown = true; // Prevent showing the message box again until the next input attempt
                }
            }
        }


        // *** MIDTERM ***

        private void btnMidterm_Click(object sender, EventArgs e)
        {
            dgvPrelim.Visible = false;
            dgvMidTerm.Visible = true;
            dgvFinalTerm.Visible = false;

            txtLabScoreMid.Enabled = true;
            txtQuizScoreMid.Enabled = true;
            txtPracticalExamScoreMid.Enabled = true;

            btnCalculateMidterm.Enabled = true;
            btnClearMidterm.Enabled = true;

            btnCalculatePrelim.Enabled = false;
            btnClearPrelim.Enabled = false;

            btnCalculateFinal.Enabled = false;
            btnClearFinal.Enabled = false;

            btnCalculateMidterm.BackColor = Color.PaleGreen;
            btnClearMidterm.BackColor = Color.Tomato;

            txtLabScoreMid.BackColor = SystemColors.Window;
            txtQuizScoreMid.BackColor = SystemColors.Window;
            txtPracticalExamScoreMid.BackColor = SystemColors.Window;

            txtLabScoreMid.Cursor = Cursors.IBeam;
            txtQuizScoreMid.Cursor = Cursors.IBeam;
            txtPracticalExamScoreMid.Cursor = Cursors.IBeam;

            // Disabled text boxes with BackColor of Gray and Cursor of No
            txtQuizScore.Enabled = false;
            txtLabScore.Enabled = false;
            txtSeatworkScore.Enabled = false;
            txtAttendanceScore.Enabled = false;

            btnCalculatePrelim.BackColor = Color.Gray;
            btnClearPrelim.BackColor = Color.Gray;
            btnCalculateFinal.BackColor = Color.Gray;
            btnClearFinal.BackColor = Color.Gray;

            txtQuizScore.BackColor = Color.Gray;
            txtLabScore.BackColor = Color.Gray;
            txtSeatworkScore.BackColor = Color.Gray;
            txtAttendanceScore.BackColor = Color.Gray;

            // Final term text boxes are disabled, so they follow the disabled pattern
            txtLabScoreFinal.Enabled = false;
            txtQuizScoreFinal.Enabled = false;
            txtProjectScoreFinal.Enabled = false;

            txtLabScoreFinal.BackColor = Color.Gray;
            txtQuizScoreFinal.BackColor = Color.Gray;
            txtProjectScoreFinal.BackColor = Color.Gray;

        }

        private void btnCalculateMidterm_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvMidTerm.Rows[index];
            try
            {
                rawGrade = Convert.ToDouble(txtLabScoreMid.Text) * 0.5 + Convert.ToDouble(txtQuizScoreMid.Text) * 0.2 +
                           Convert.ToDouble(txtPracticalExamScoreMid.Text) * 0.3;
                MidtermGrade = (upperBoundGrade - lowerBoundGrade) * (1 - rawGrade / upperBoundPercentage) + lowerBoundGrade;
                MidtermGrade = Math.Round(MidtermGrade, 2);


                row.Cells[5].Value = MidtermGrade.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("No input/s to be calculated!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Grading(sender, e);
        }

        private void btnClearMidterm_Click(object sender, EventArgs e)
        {
            txtLabScoreMid.Text = null; 
            txtQuizScoreMid.Text = null;
            txtPracticalExamScoreMid.Text = null;
        }

        private void dgvMidTerm_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                index = e.RowIndex;
                if (index >= 0 && index < dgvMidTerm.Rows.Count) // Ensure the row exists
                {
                    DataGridViewRow row = dgvMidTerm.Rows[index];
                    if (row != null)
                    {
                        txtLabScoreMid.Text = row.Cells[2]?.Value?.ToString() ?? "N/A";
                        txtQuizScoreMid.Text = row.Cells[3]?.Value?.ToString() ?? "N/A";
                        txtPracticalExamScoreMid.Text = row.Cells[4]?.Value?.ToString() ?? "N/A";

                        MidtermGrade = 0;
                    }
                    else
                    {
                        MessageBox.Show("The selected row does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid row index. You can\'t select the whole table.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (System.ArgumentOutOfRangeException ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtLabScoreMid_TextChanged(object sender, EventArgs e)
        {

            if (double.TryParse(txtLabScoreMid.Text, out double labScoreMid))
            {
                if (labScoreMid >= 0 && labScoreMid <= 100)
                {
                    DataGridViewRow row = dgvMidTerm.Rows[index];
                    row.Cells[2].Value = labScoreMid;
                    _isMessageBoxShown = false;
                }
                else
                {
                    if (!_isMessageBoxShown)
                    {
                        string errMessage = "Error";
                        string errTitle = "Invalid Input. It shouldn't be a negative or beyond 100.";
                        MessageBox.Show(errTitle, errMessage, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        DataGridViewRow row = dgvMidTerm.Rows[index];
                        txtLabScoreMid.Text = row.Cells[2]?.Value?.ToString() ?? "N/A";
                        _isMessageBoxShown = true; // Prevent showing the message box again until the next input attempt
                    }
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(txtLabScoreMid.Text) && !_isMessageBoxShown)
                {
                    string errMessage = "Error";
                    string errTitle = "Please enter a valid number for the score.";
                    MessageBox.Show(errTitle, errMessage, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataGridViewRow row = dgvMidTerm.Rows[index];
                    txtLabScoreMid.Text = row.Cells[2]?.Value?.ToString() ?? "N/A";
                    _isMessageBoxShown = true; // Prevent showing the message box again until the next input attempt
                }
            }
        }

        private void txtQuizScoreMid_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txtQuizScoreMid.Text, out double QuizScoreMid))
            {
                // Check if the parsed value is within the allowed range
                if (QuizScoreMid >= 0 && QuizScoreMid <= 100)
                {
                    DataGridViewRow row = dgvMidTerm.Rows[index];
                    row.Cells[3].Value = QuizScoreMid;
                    _isMessageBoxShown = false;
                }
                else
                {
                    // If the value is outside the allowed range, show a message box
                    if (!_isMessageBoxShown)
                    {
                        string errMessage = "Error";
                        string errTitle = "Invalid Input. It shouldn't be a negative or beyond 100.";
                        MessageBox.Show(errTitle, errMessage, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        DataGridViewRow row = dgvMidTerm.Rows[index];
                        txtQuizScoreMid.Text = row.Cells[3]?.Value?.ToString() ?? "N/A";
                        _isMessageBoxShown = true; // Prevent showing the message box again until the next input attempt
                    }
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(txtQuizScoreMid.Text) && !_isMessageBoxShown)
                {
                    string errMessage = "Error";
                    string errTitle = "Please enter a valid number for the score.";
                    MessageBox.Show(errTitle, errMessage, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataGridViewRow row = dgvMidTerm.Rows[index];
                    txtQuizScoreMid.Text = row.Cells[3]?.Value?.ToString() ?? "N/A";
                    _isMessageBoxShown = true; // Prevent showing the message box again until the next input attempt
                }
            }
        }

        private void txtPracticalExamScoreMid_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txtPracticalExamScoreMid.Text, out double PracticalExamScoreMid))
            {
                // Check if the parsed value is within the allowed range
                if (PracticalExamScoreMid >= 0 && PracticalExamScoreMid <= 100)
                {
                    DataGridViewRow row = dgvMidTerm.Rows[index];
                    row.Cells[4].Value = PracticalExamScoreMid;
                    _isMessageBoxShown = false;
                }
                else
                {
                    // If the value is outside the allowed range, show a message box
                    if (!_isMessageBoxShown)
                    {
                        string errTitle = "Error";
                        string errMessage = "Invalid Input. It shouldn't be a negative or beyond 100.";
                        MessageBox.Show(errMessage, errTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        DataGridViewRow row = dgvMidTerm.Rows[index];
                        txtPracticalExamScoreMid.Text = row.Cells[4]?.Value?.ToString() ?? "N/A";
                        _isMessageBoxShown = true; // Prevent showing the message box again until the next input attempt
                    }
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(txtPracticalExamScoreMid.Text) && !_isMessageBoxShown)
                {
                    string errTitle = "Error!";
                    string errMessage = "Please enter a valid number.";
                    MessageBox.Show(errMessage, errTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataGridViewRow row = dgvMidTerm.Rows[index];
                    txtPracticalExamScoreMid.Text = row.Cells[4]?.Value?.ToString() ?? "N/A";
                    _isMessageBoxShown = true; // Prevent showing the message box again until the next input attempt
                }
            }
        }


        // *** FINALS *** 
        private void btnFinals_Click(object sender, EventArgs e)
        {
            dgvPrelim.Visible = false;
            dgvMidTerm.Visible = false;
            dgvFinalTerm.Visible = true;

            txtLabScoreFinal.Enabled = true;
            txtQuizScoreFinal.Enabled = true;
            txtProjectScoreFinal.Enabled = true;

            btnCalculateFinal.Enabled = true;
            btnClearFinal.Enabled = true;

            btnCalculatePrelim.Enabled = false;
            btnClearPrelim.Enabled = false;

            btnCalculateMidterm.Enabled = false;
            btnClearMidterm.Enabled = false;

            btnCalculateFinal.BackColor = Color.PaleGreen;
            btnClearFinal.BackColor = Color.Tomato;

            txtLabScoreFinal.BackColor = SystemColors.Window;
            txtQuizScoreFinal.BackColor = SystemColors.Window;
            txtProjectScoreFinal.BackColor = SystemColors.Window;

            txtLabScoreFinal.Cursor = Cursors.IBeam;
            txtQuizScoreFinal.Cursor = Cursors.IBeam;
            txtProjectScoreFinal.Cursor = Cursors.IBeam;

            // Disabled text boxes with BackColor of Gray and Cursor of No
            txtQuizScore.Enabled = false;
            txtLabScore.Enabled = false;
            txtSeatworkScore.Enabled = false;
            txtAttendanceScore.Enabled = false;

            btnCalculateMidterm.BackColor = Color.Gray;
            btnClearMidterm.BackColor = Color.Gray;
            btnCalculatePrelim.BackColor = Color.Gray;
            btnClearPrelim.BackColor = Color.Gray;

            txtQuizScore.BackColor = Color.Gray;
            txtLabScore.BackColor = Color.Gray;
            txtSeatworkScore.BackColor = Color.Gray;
            txtAttendanceScore.BackColor = Color.Gray;

            // Mid-term text boxes are disabled, so they follow the disabled pattern
            txtLabScoreMid.Enabled = false;
            txtQuizScoreMid.Enabled = false;
            txtPracticalExamScoreMid.Enabled = false;

            txtLabScoreMid.BackColor = Color.Gray;
            txtQuizScoreMid.BackColor = Color.Gray;
            txtPracticalExamScoreMid.BackColor = Color.Gray;
        }

        private void btnCalculateFinal_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvFinalTerm.Rows[index];
            try
            {
                rawGrade = Convert.ToDouble(txtLabScoreFinal.Text) * 0.5 + Convert.ToDouble(txtQuizScoreFinal.Text) * 0.3 +
                           Convert.ToDouble(txtProjectScoreFinal.Text) * 0.2;
                FinalGrade = (upperBoundGrade - lowerBoundGrade) * (1 - rawGrade / upperBoundPercentage) + lowerBoundGrade;
                FinalGrade = Math.Round(FinalGrade, 2);

                row.Cells[5].Value = FinalGrade.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("No input/s to be calculated!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Grading(sender, e);
        }

        private void btnClearFinal_Click(object sender, EventArgs e)
        {
            txtLabScoreFinal.Text = null; 
            txtQuizScoreFinal.Text = null;
            txtProjectScoreFinal.Text = null;
        }

        private void dgvFinalTerm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                index = e.RowIndex;
                if (index >= 0 && index < dgvFinalTerm.Rows.Count) // Ensure the row exists
                {
                    DataGridViewRow row = dgvFinalTerm.Rows[index];
                    if (row != null)
                    {
                        txtLabScoreFinal.Text = row.Cells[2]?.Value?.ToString() ?? "N/A";
                        txtQuizScoreFinal.Text = row.Cells[3]?.Value?.ToString() ?? "N/A";
                        txtProjectScoreFinal.Text = row.Cells[4]?.Value?.ToString() ?? "N/A";
                    }
                    else
                    {
                        MessageBox.Show("The selected row does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid row index. You can\'t select the whole table.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (System.ArgumentOutOfRangeException ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        private void txtLabScoreFinal_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txtLabScoreFinal.Text, out double LabScoreFinal))
            {
                // Check if the parsed value is within the allowed range
                if (LabScoreFinal >= 0 && LabScoreFinal <= 100)
                {
                    DataGridViewRow row = dgvFinalTerm.Rows[index];
                    row.Cells[2].Value = LabScoreFinal;
                    _isMessageBoxShown = false;
                }
                else
                {
                    // If the value is outside the allowed range, show a message box
                    if (!_isMessageBoxShown)
                    {
                        string errMessage = "Error";
                        string errTitle = "Invalid Input. It shouldn't be a negative or beyond 100.";
                        MessageBox.Show(errTitle, errMessage, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        DataGridViewRow row = dgvFinalTerm.Rows[index];
                        txtLabScoreFinal.Text = row.Cells[2]?.Value?.ToString() ?? "N/A";
                        _isMessageBoxShown = true; // Prevent showing the message box again until the next input attempt
                    }
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(txtLabScoreFinal.Text) && !_isMessageBoxShown)
                {
                    string errMessage = "Error";
                    string errTitle = "Please enter a valid number for the score.";
                    MessageBox.Show(errTitle, errMessage, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataGridViewRow row = dgvFinalTerm.Rows[index];
                    txtLabScoreFinal.Text = row.Cells[2]?.Value?.ToString() ?? "N/A";
                    _isMessageBoxShown = true; // Prevent showing the message box again until the next input attempt
                }
            }
        }

        private void txtQuizScoreFinal_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txtQuizScoreFinal.Text, out double QuizScoreFinal))
            {
                // Check if the parsed value is within the allowed range
                if (QuizScoreFinal >= 0 && QuizScoreFinal <= 100)
                {
                    DataGridViewRow row = dgvFinalTerm.Rows[index];
                    row.Cells[3].Value = QuizScoreFinal;
                    _isMessageBoxShown = false;
                }
                else
                {
                    // If the value is outside the allowed range, show a message box
                    if (!_isMessageBoxShown)
                    {
                        string errMessage = "Error";
                        string errTitle = "Invalid Input. It shouldn't be a negative or beyond 100.";
                        MessageBox.Show(errTitle, errMessage, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        DataGridViewRow row = dgvFinalTerm.Rows[index];
                        txtQuizScoreFinal.Text = row.Cells[3]?.Value?.ToString() ?? "N/A";
                        _isMessageBoxShown = true; // Prevent showing the message box again until the next input attempt
                    }
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(txtQuizScoreFinal.Text) && !_isMessageBoxShown)
                {
                    string errMessage = "Error";
                    string errTitle = "Please enter a valid number for score.";
                    MessageBox.Show(errTitle, errMessage, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataGridViewRow row = dgvFinalTerm.Rows[index];
                    txtQuizScoreFinal.Text = row.Cells[3]?.Value?.ToString() ?? "N/A";
                    _isMessageBoxShown = true; // Prevent showing the message box again until the next input attempt
                }
            }
        }

        private void txtProjectScoreFinal_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txtProjectScoreFinal.Text, out double ProjectScoreFinal))
            {
                // Check if the parsed value is within the allowed range
                if (ProjectScoreFinal >= 0 && ProjectScoreFinal <= 100)
                {
                    DataGridViewRow row = dgvFinalTerm.Rows[index];
                    row.Cells[4].Value = ProjectScoreFinal;
                    _isMessageBoxShown = false;
                }
                else
                {
                    // If the value is outside the allowed range, show a message box
                    if (!_isMessageBoxShown)
                    {
                        string errMessage = "Error";
                        string errTitle = "Invalid Input. It shouldn't be a negative or beyond 100.";
                        MessageBox.Show(errTitle, errMessage, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        DataGridViewRow row = dgvFinalTerm.Rows[index];
                        txtProjectScoreFinal.Text = row.Cells[4]?.Value?.ToString() ?? "N/A";
                        _isMessageBoxShown = true; // Prevent showing the message box again until the next input attempt
                    }
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(txtProjectScoreFinal.Text) && !_isMessageBoxShown)
                {
                    string errMessage = "Error";
                    string errTitle = "Please enter a valid number for the score.";
                    MessageBox.Show(errTitle, errMessage, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataGridViewRow row = dgvFinalTerm.Rows[index];
                    txtProjectScoreFinal.Text = row.Cells[4]?.Value?.ToString() ?? "N/A";
                    _isMessageBoxShown = true; // Prevent showing the message box again until the next input attempt
                }
            }
        }

        // Grading Ends


        // Contact Starts 
        private void lblContact_Click(object sender, EventArgs e)
        {

            Font newFont = new Font("Arial", 16, FontStyle.Bold);
            Font defFont = new Font("Microsoft Sans Serif", (int)16.2, FontStyle.Regular);

            lblContact.ForeColor = Color.Blue;
            lblContact.Font = newFont;

            lblStudents.Font = defFont; lblHome.Font = defFont; lblGrading.Font = defFont;
            lblHome.ForeColor = Color.Black;
            lblGrading.ForeColor = Color.Black;
            lblStudents.ForeColor = Color.Black;

            pnlHome.Visible = false;
            pnlStudents.Visible = false;
            pnlGrading.Visible = false;
            pnlContacts.Visible = true;
        }

        private void lblCOE_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/actief.casp/");
        }

        private void pbCOE_Click(object sender, EventArgs e)
        {
            lblCOE_Click(sender, e);
        }


        // Contact Ends 

        // About Us Starts 

        private void lblAboutUs_Click(object sender, EventArgs e)
        {
            this.Hide(); 

            Form4 AboutUs = new Form4();
            AboutUs.Show();

        }

        // About Us Ends 

        private void Form2_Load(object sender, EventArgs e)
        {
            // pnlStudentsInfo.BackColor = Color.FromArgb(128, 52, 67, 203);

            int newWidth = (int)(this.ClientSize.Width * 0.85);
            int newHeight = (int)(this.ClientSize.Height * 1);

            pnlHome.Size = new Size(newWidth, newHeight);
            pnlHome.Location = new Point(this.ClientSize.Width - pnlHome.Width, 0);

            pnlStudents.Size = new Size(newWidth, newHeight);
            pnlStudents.Location = new Point(this.ClientSize.Width - pnlStudents.Width, 0);

            pnlGrading.Size = new Size(newWidth, newHeight);
            pnlGrading.Location = new Point(this.ClientSize.Width - pnlGrading.Width, 0);

            pnlContacts.Size = new Size(newWidth, newHeight);
            pnlContacts.Location = new Point(this.ClientSize.Width  - pnlContacts.Width, 0);


            // Students Section Starts 

            // Calculate the width and height for dgvStudents
            int dgvStudentsWidth = (int)(this.ClientSize.Width * 0.4); // 40% of the form's width
            int dgvStudentsHeight = (int)(this.ClientSize.Height * 0.8); // 80% of the form's height

            // Calculate the position for dgvStudents
            int margin = (int)(newWidth * 0.1); // 10% margin to the right
            int dgvStudentsPositionX = newWidth - dgvStudentsWidth - margin; // Position X
            int dgvStudentsPositionY = (this.ClientSize.Height - dgvStudentsHeight) / 2; // Position Y to center vertically

            // Set the location and size of dgvStudents
            dgvStudents.Location = new Point(dgvStudentsPositionX, dgvStudentsPositionY);
            dgvStudents.Size = new Size(dgvStudentsWidth, dgvStudentsHeight);

            // Reuse code from dgvStudents 
            dgvRanking.Location = new Point(dgvStudentsPositionX, dgvStudentsPositionY);
            dgvRanking.Size = new Size(dgvStudentsWidth, dgvStudentsHeight);


            dgvStudents.DataSource = studentTable;

            // Grading Section Starts

            // *** PRELIM *** 

            dgvPrelim.DataSource = dgvGradingPrelim;
            // bs.DataSource = dgvGradingStudentsTable;

            // Calculate the width and height for dgvStudents
            int dgvGradingPrelimWidth = (int)(this.ClientSize.Width * 0.4); // 40% of the form's width
            int dgvGradingPrelimHeight = (int)(this.ClientSize.Height * 0.8); // 80% of the form's height

            // Calculate the position for dgvStudents
            int dgvGradingPrelimPositionX = newWidth - dgvGradingPrelimWidth - margin; // Position X
            int dgvGradingPrelimPositionY = (this.ClientSize.Height - dgvGradingPrelimHeight) / 2; // Position Y to center vertically

            // Set the location and size of dgvStudents
            dgvPrelim.Location = new Point(dgvGradingPrelimPositionX, dgvGradingPrelimPositionY);
            dgvPrelim.Size = new Size(dgvGradingPrelimWidth, dgvGradingPrelimHeight);

            
            dgvGradingPrelim.Columns.Add("ID", Type.GetType("System.Int32"));
            dgvGradingPrelim.Columns.Add("Name", Type.GetType("System.String"));
            dgvGradingPrelim.Columns.Add("Quiz", Type.GetType("System.Double"));
            dgvGradingPrelim.Columns.Add("Laboratory", Type.GetType("System.Double"));
            dgvGradingPrelim.Columns.Add("Seatwork", Type.GetType("System.Double"));
            dgvGradingPrelim.Columns.Add("Attendance", Type.GetType("System.Double"));
            dgvGradingPrelim.Columns.Add("Grade", Type.GetType("System.Double"));


            // *** MID-TERM ***

            dgvMidTerm.DataSource = dgvGradingMidterm;

            // Calculate the width and height for dgvStudents
            int dgvGradingMidtermWidth = (int)(this.ClientSize.Width * 0.4); // 40% of the form's width
            int dgvGradingMidtermHeight = (int)(this.ClientSize.Height * 0.8); // 80% of the form's height

            // Calculate the position for dgvStudents
            int dgvGradingMidtermPositionX = newWidth - dgvGradingMidtermWidth - margin; // Position X
            int dgvGradingMidtermPositionY = (this.ClientSize.Height - dgvGradingMidtermHeight) / 2; // Position Y to center vertically

            // Set the location and size of dgvStudents
            dgvMidTerm.Location = new Point(dgvGradingMidtermPositionX, dgvGradingMidtermPositionY);
            dgvMidTerm.Size = new Size(dgvGradingMidtermWidth, dgvGradingMidtermHeight);


            dgvGradingMidterm.Columns.Add("ID", Type.GetType("System.Int32"));
            dgvGradingMidterm.Columns.Add("Name", Type.GetType("System.String"));
            dgvGradingMidterm.Columns.Add("Laboratory", Type.GetType("System.Double"));

            dgvGradingMidterm.Columns.Add("Quiz", Type.GetType("System.Double"));
            dgvGradingMidterm.Columns.Add("Practical Exam", Type.GetType("System.Double"));
            dgvGradingMidterm.Columns.Add("Grade", Type.GetType("System.Double"));


            // *** FINAL TERM*** 
            dgvFinalTerm.DataSource = dgvGradingFinal;

            // Calculate the width and height for dgvStudents
            int dgvGradingFinalWidth = (int)(this.ClientSize.Width * 0.4); // 40% of the form's width
            int dgvGradingFinalHeight = (int)(this.ClientSize.Height * 0.8); // 80% of the form's height

            // Calculate the position for dgvStudents
            int dgvGradingFinalPositionX = newWidth - dgvGradingFinalWidth - margin; // Position X
            int dgvGradingFinalPositionY = (this.ClientSize.Height - dgvGradingFinalHeight) / 2; // Position Y to center vertically

            // Set the location and size of dgvStudents
            dgvFinalTerm.Location = new Point(dgvGradingFinalPositionX, dgvGradingFinalPositionY);
            dgvFinalTerm.Size = new Size(dgvGradingFinalWidth, dgvGradingFinalHeight);

            dgvGradingFinal.Columns.Add("ID", Type.GetType("System.Int32"));
            dgvGradingFinal.Columns.Add("Name", Type.GetType("System.String"));
            dgvGradingFinal.Columns.Add("Laboratory", Type.GetType("System.Double"));

            dgvGradingFinal.Columns.Add("Quiz", Type.GetType("System.Double"));
            dgvGradingFinal.Columns.Add("Project", Type.GetType("System.Double"));
            dgvGradingFinal.Columns.Add("Grade", Type.GetType("System.Double"));

            // Grading Section Ends

            CollectData(sender, e);
            btnPrelim_Click(sender, e);

        }

        private void lblLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Form1 LoginPage = new Form1();
                LoginPage.Show();

                this.Hide();
            }
        }

        private void lblCCS_Click(object sender, EventArgs e)
        {
            Process.Start("https://web.facebook.com/ACTIEFCCS");
        }

        private void pbCCS_Click(object sender, EventArgs e)
        {
            lblCCS_Click(sender, e);
        }

        
    }
}
