using System.Drawing;
using System.Windows.Forms;

namespace LoginPage
{
    partial class Form2
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
            this.lblHome = new System.Windows.Forms.Label();
            this.lblStudents = new System.Windows.Forms.Label();
            this.lblGrading = new System.Windows.Forms.Label();
            this.pnlBarrier = new System.Windows.Forms.Panel();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblLogOut = new System.Windows.Forms.Label();
            this.lblAboutUs = new System.Windows.Forms.Label();
            this.pnlContacts = new System.Windows.Forms.Panel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pbGuidance = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pbSHS = new System.Windows.Forms.PictureBox();
            this.pbCBM = new System.Windows.Forms.PictureBox();
            this.pbCCS = new System.Windows.Forms.PictureBox();
            this.pbCOE = new System.Windows.Forms.PictureBox();
            this.lblRegistrar = new System.Windows.Forms.Label();
            this.lblAccounting = new System.Windows.Forms.Label();
            this.lblScholarship = new System.Windows.Forms.Label();
            this.lblGuidance = new System.Windows.Forms.Label();
            this.lblSDO = new System.Windows.Forms.Label();
            this.lblCCS = new System.Windows.Forms.Label();
            this.lblCBM = new System.Windows.Forms.Label();
            this.lblSHS = new System.Windows.Forms.Label();
            this.lblCOE = new System.Windows.Forms.Label();
            this.pnlStudents = new System.Windows.Forms.Panel();
            this.dgvRanking = new System.Windows.Forms.DataGridView();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.pnlStudentsInfo = new System.Windows.Forms.Panel();
            this.btnRanking = new System.Windows.Forms.Button();
            this.btnStudentTable = new System.Windows.Forms.Button();
            this.lblStudentInfo = new System.Windows.Forms.Label();
            this.lblOverallGrade = new System.Windows.Forms.Label();
            this.lblFinalGrade = new System.Windows.Forms.Label();
            this.lblMidtermGrade = new System.Windows.Forms.Label();
            this.lblPrelimGrade = new System.Windows.Forms.Label();
            this.lblRank = new System.Windows.Forms.Label();
            this.lblPerformanceDetails = new System.Windows.Forms.Label();
            this.txtOverallGrade = new System.Windows.Forms.TextBox();
            this.txtFinalGrade = new System.Windows.Forms.TextBox();
            this.txtMidtermGrade = new System.Windows.Forms.TextBox();
            this.txtPrelimGrade = new System.Windows.Forms.TextBox();
            this.txtRank = new System.Windows.Forms.TextBox();
            this.pnlBorderStudents = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnlGrading = new System.Windows.Forms.Panel();
            this.pnlGradingTab = new System.Windows.Forms.Panel();
            this.btnClearFinal = new System.Windows.Forms.Button();
            this.btnClearMidterm = new System.Windows.Forms.Button();
            this.btnClearPrelim = new System.Windows.Forms.Button();
            this.btnCalculateFinal = new System.Windows.Forms.Button();
            this.btnCalculateMidterm = new System.Windows.Forms.Button();
            this.btnCalculatePrelim = new System.Windows.Forms.Button();
            this.lblFinalTitle = new System.Windows.Forms.Label();
            this.lblProjectScoreFinal = new System.Windows.Forms.Label();
            this.lblQuizScoreFinal = new System.Windows.Forms.Label();
            this.lblLabScoreFinal = new System.Windows.Forms.Label();
            this.lblMidtermTitle = new System.Windows.Forms.Label();
            this.lblPracticalExamScoreMid = new System.Windows.Forms.Label();
            this.lblQuizScoreMid = new System.Windows.Forms.Label();
            this.lblLabScoreMid = new System.Windows.Forms.Label();
            this.txtProjectScoreFinal = new System.Windows.Forms.TextBox();
            this.txtQuizScoreFinal = new System.Windows.Forms.TextBox();
            this.txtLabScoreFinal = new System.Windows.Forms.TextBox();
            this.txtPracticalExamScoreMid = new System.Windows.Forms.TextBox();
            this.txtQuizScoreMid = new System.Windows.Forms.TextBox();
            this.txtLabScoreMid = new System.Windows.Forms.TextBox();
            this.btnFinals = new System.Windows.Forms.Button();
            this.pnlPrelimTitle = new System.Windows.Forms.Label();
            this.btnMidterm = new System.Windows.Forms.Button();
            this.lblAttendanceScore = new System.Windows.Forms.Label();
            this.btnPrelim = new System.Windows.Forms.Button();
            this.lblSeatworkScore = new System.Windows.Forms.Label();
            this.lblLabScore = new System.Windows.Forms.Label();
            this.lblQuizScore = new System.Windows.Forms.Label();
            this.txtAttendanceScore = new System.Windows.Forms.TextBox();
            this.txtSeatworkScore = new System.Windows.Forms.TextBox();
            this.txtLabScore = new System.Windows.Forms.TextBox();
            this.txtQuizScore = new System.Windows.Forms.TextBox();
            this.dgvFinalTerm = new System.Windows.Forms.DataGridView();
            this.dgvMidTerm = new System.Windows.Forms.DataGridView();
            this.dgvPrelim = new System.Windows.Forms.DataGridView();
            this.pnlHome = new System.Windows.Forms.Panel();
            this.pnlAdmin = new System.Windows.Forms.Panel();
            this.lblTask5 = new System.Windows.Forms.Label();
            this.lblTask4 = new System.Windows.Forms.Label();
            this.lblTask3 = new System.Windows.Forms.Label();
            this.lblTask2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblTask1 = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.pnlWhatsNew = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDescription1 = new System.Windows.Forms.Label();
            this.lblTitle3 = new System.Windows.Forms.Label();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.lblUpcomingEvents = new System.Windows.Forms.Label();
            this.form2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.form2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.form2BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.pnlContacts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuidance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSHS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCBM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCCS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCOE)).BeginInit();
            this.pnlStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRanking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.pnlStudentsInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlGrading.SuspendLayout();
            this.pnlGradingTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinalTerm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMidTerm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrelim)).BeginInit();
            this.pnlHome.SuspendLayout();
            this.pnlAdmin.SuspendLayout();
            this.pnlWhatsNew.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.form2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form2BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form2BindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.ForeColor = System.Drawing.Color.Blue;
            this.lblHome.Location = new System.Drawing.Point(80, 381);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(93, 32);
            this.lblHome.TabIndex = 0;
            this.lblHome.Text = "Home";
            this.lblHome.Click += new System.EventHandler(this.lblHome_Click);
            // 
            // lblStudents
            // 
            this.lblStudents.AutoSize = true;
            this.lblStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudents.Location = new System.Drawing.Point(79, 442);
            this.lblStudents.Name = "lblStudents";
            this.lblStudents.Size = new System.Drawing.Size(127, 32);
            this.lblStudents.TabIndex = 1;
            this.lblStudents.Text = "Students";
            this.lblStudents.Click += new System.EventHandler(this.lblStudents_Click);
            // 
            // lblGrading
            // 
            this.lblGrading.AutoSize = true;
            this.lblGrading.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblGrading.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrading.Location = new System.Drawing.Point(79, 501);
            this.lblGrading.Name = "lblGrading";
            this.lblGrading.Size = new System.Drawing.Size(116, 32);
            this.lblGrading.TabIndex = 2;
            this.lblGrading.Text = "Grading";
            this.lblGrading.Click += new System.EventHandler(this.lblGrading_Click);
            // 
            // pnlBarrier
            // 
            this.pnlBarrier.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlBarrier.Location = new System.Drawing.Point(304, -99);
            this.pnlBarrier.Name = "pnlBarrier";
            this.pnlBarrier.Size = new System.Drawing.Size(5, 3000);
            this.pnlBarrier.TabIndex = 4;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(80, 559);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(126, 32);
            this.lblContact.TabIndex = 11;
            this.lblContact.Text = "Contacts";
            this.lblContact.Click += new System.EventHandler(this.lblContact_Click);
            // 
            // lblLogOut
            // 
            this.lblLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLogOut.AutoSize = true;
            this.lblLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogOut.ForeColor = System.Drawing.Color.Red;
            this.lblLogOut.Location = new System.Drawing.Point(7, 729);
            this.lblLogOut.Name = "lblLogOut";
            this.lblLogOut.Size = new System.Drawing.Size(82, 25);
            this.lblLogOut.TabIndex = 22;
            this.lblLogOut.Text = "Log Out";
            this.lblLogOut.Click += new System.EventHandler(this.lblLogOut_Click);
            // 
            // lblAboutUs
            // 
            this.lblAboutUs.AutoSize = true;
            this.lblAboutUs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAboutUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAboutUs.Location = new System.Drawing.Point(80, 615);
            this.lblAboutUs.Name = "lblAboutUs";
            this.lblAboutUs.Size = new System.Drawing.Size(130, 32);
            this.lblAboutUs.TabIndex = 23;
            this.lblAboutUs.Text = "About Us";
            this.lblAboutUs.Click += new System.EventHandler(this.lblAboutUs_Click);
            // 
            // pnlContacts
            // 
            this.pnlContacts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlContacts.BackColor = System.Drawing.Color.Gold;
            this.pnlContacts.BackgroundImage = global::LoginPage.Properties.Resources.CONTACTS;
            this.pnlContacts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlContacts.Controls.Add(this.pictureBox8);
            this.pnlContacts.Controls.Add(this.pictureBox7);
            this.pnlContacts.Controls.Add(this.pbGuidance);
            this.pnlContacts.Controls.Add(this.pictureBox5);
            this.pnlContacts.Controls.Add(this.pictureBox4);
            this.pnlContacts.Controls.Add(this.pbSHS);
            this.pnlContacts.Controls.Add(this.pbCBM);
            this.pnlContacts.Controls.Add(this.pbCCS);
            this.pnlContacts.Controls.Add(this.pbCOE);
            this.pnlContacts.Controls.Add(this.lblRegistrar);
            this.pnlContacts.Controls.Add(this.lblAccounting);
            this.pnlContacts.Controls.Add(this.lblScholarship);
            this.pnlContacts.Controls.Add(this.lblGuidance);
            this.pnlContacts.Controls.Add(this.lblSDO);
            this.pnlContacts.Controls.Add(this.lblCCS);
            this.pnlContacts.Controls.Add(this.lblCBM);
            this.pnlContacts.Controls.Add(this.lblSHS);
            this.pnlContacts.Controls.Add(this.lblCOE);
            this.pnlContacts.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlContacts.Location = new System.Drawing.Point(192, 212);
            this.pnlContacts.Name = "pnlContacts";
            this.pnlContacts.Size = new System.Drawing.Size(1054, 675);
            this.pnlContacts.TabIndex = 3;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.BackgroundImage = global::LoginPage.Properties.Resources.lblScholarship;
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox8.ImageLocation = "";
            this.pictureBox8.Location = new System.Drawing.Point(578, 373);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(104, 89);
            this.pictureBox8.TabIndex = 27;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.BackgroundImage = global::LoginPage.Properties.Resources.lblRegistrar;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox7.ImageLocation = "";
            this.pictureBox7.Location = new System.Drawing.Point(575, 262);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(104, 89);
            this.pictureBox7.TabIndex = 26;
            this.pictureBox7.TabStop = false;
            // 
            // pbGuidance
            // 
            this.pbGuidance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbGuidance.BackColor = System.Drawing.Color.Transparent;
            this.pbGuidance.BackgroundImage = global::LoginPage.Properties.Resources.lblGuidance;
            this.pbGuidance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbGuidance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbGuidance.ImageLocation = "";
            this.pbGuidance.Location = new System.Drawing.Point(578, 139);
            this.pbGuidance.Name = "pbGuidance";
            this.pbGuidance.Size = new System.Drawing.Size(104, 89);
            this.pbGuidance.TabIndex = 25;
            this.pbGuidance.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = global::LoginPage.Properties.Resources.lblSDO;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.ImageLocation = "";
            this.pictureBox5.Location = new System.Drawing.Point(578, 41);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(104, 89);
            this.pictureBox5.TabIndex = 24;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::LoginPage.Properties.Resources.lblAccounting1;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.ImageLocation = "";
            this.pictureBox4.Location = new System.Drawing.Point(20, 467);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(104, 89);
            this.pictureBox4.TabIndex = 23;
            this.pictureBox4.TabStop = false;
            // 
            // pbSHS
            // 
            this.pbSHS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbSHS.BackColor = System.Drawing.Color.Transparent;
            this.pbSHS.BackgroundImage = global::LoginPage.Properties.Resources.lblSHS;
            this.pbSHS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbSHS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSHS.ImageLocation = "";
            this.pbSHS.Location = new System.Drawing.Point(20, 364);
            this.pbSHS.Name = "pbSHS";
            this.pbSHS.Size = new System.Drawing.Size(104, 89);
            this.pbSHS.TabIndex = 22;
            this.pbSHS.TabStop = false;
            // 
            // pbCBM
            // 
            this.pbCBM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbCBM.BackColor = System.Drawing.Color.Transparent;
            this.pbCBM.BackgroundImage = global::LoginPage.Properties.Resources.lblCBM;
            this.pbCBM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbCBM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCBM.ImageLocation = "";
            this.pbCBM.Location = new System.Drawing.Point(20, 259);
            this.pbCBM.Name = "pbCBM";
            this.pbCBM.Size = new System.Drawing.Size(104, 89);
            this.pbCBM.TabIndex = 21;
            this.pbCBM.TabStop = false;
            // 
            // pbCCS
            // 
            this.pbCCS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbCCS.BackColor = System.Drawing.Color.Transparent;
            this.pbCCS.BackgroundImage = global::LoginPage.Properties.Resources.lblCCS;
            this.pbCCS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbCCS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCCS.ImageLocation = "";
            this.pbCCS.Location = new System.Drawing.Point(20, 153);
            this.pbCCS.Name = "pbCCS";
            this.pbCCS.Size = new System.Drawing.Size(104, 89);
            this.pbCCS.TabIndex = 20;
            this.pbCCS.TabStop = false;
            this.pbCCS.Click += new System.EventHandler(this.pbCCS_Click);
            // 
            // pbCOE
            // 
            this.pbCOE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbCOE.BackColor = System.Drawing.Color.Transparent;
            this.pbCOE.BackgroundImage = global::LoginPage.Properties.Resources.lblCOE1;
            this.pbCOE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbCOE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCOE.ImageLocation = "";
            this.pbCOE.Location = new System.Drawing.Point(20, 46);
            this.pbCOE.Name = "pbCOE";
            this.pbCOE.Size = new System.Drawing.Size(104, 89);
            this.pbCOE.TabIndex = 19;
            this.pbCOE.TabStop = false;
            this.pbCOE.Click += new System.EventHandler(this.pbCOE_Click);
            // 
            // lblRegistrar
            // 
            this.lblRegistrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRegistrar.AutoSize = true;
            this.lblRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrar.Location = new System.Drawing.Point(691, 291);
            this.lblRegistrar.Name = "lblRegistrar";
            this.lblRegistrar.Size = new System.Drawing.Size(232, 22);
            this.lblRegistrar.TabIndex = 18;
            this.lblRegistrar.Text = "ACT Office of the Registrar ";
            // 
            // lblAccounting
            // 
            this.lblAccounting.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAccounting.AutoSize = true;
            this.lblAccounting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAccounting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccounting.Location = new System.Drawing.Point(131, 495);
            this.lblAccounting.Name = "lblAccounting";
            this.lblAccounting.Size = new System.Drawing.Size(198, 22);
            this.lblAccounting.TabIndex = 17;
            this.lblAccounting.Text = "ACT Accounting Office ";
            // 
            // lblScholarship
            // 
            this.lblScholarship.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblScholarship.AutoSize = true;
            this.lblScholarship.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblScholarship.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScholarship.Location = new System.Drawing.Point(688, 405);
            this.lblScholarship.Name = "lblScholarship";
            this.lblScholarship.Size = new System.Drawing.Size(203, 22);
            this.lblScholarship.TabIndex = 16;
            this.lblScholarship.Text = "ACT Scholarship Office ";
            // 
            // lblGuidance
            // 
            this.lblGuidance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGuidance.AutoSize = true;
            this.lblGuidance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblGuidance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuidance.Location = new System.Drawing.Point(688, 179);
            this.lblGuidance.Name = "lblGuidance";
            this.lblGuidance.Size = new System.Drawing.Size(181, 22);
            this.lblGuidance.TabIndex = 15;
            this.lblGuidance.Text = "Guidance ACT Page ";
            // 
            // lblSDO
            // 
            this.lblSDO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSDO.AutoSize = true;
            this.lblSDO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSDO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDO.Location = new System.Drawing.Point(688, 75);
            this.lblSDO.Name = "lblSDO";
            this.lblSDO.Size = new System.Drawing.Size(285, 22);
            this.lblSDO.TabIndex = 14;
            this.lblSDO.Text = "ACT Software Development Office";
            // 
            // lblCCS
            // 
            this.lblCCS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCCS.AutoSize = true;
            this.lblCCS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCCS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCCS.Location = new System.Drawing.Point(138, 185);
            this.lblCCS.Name = "lblCCS";
            this.lblCCS.Size = new System.Drawing.Size(297, 22);
            this.lblCCS.TabIndex = 13;
            this.lblCCS.Text = "ACT - College of Computer Studies ";
            this.lblCCS.Click += new System.EventHandler(this.lblCCS_Click);
            // 
            // lblCBM
            // 
            this.lblCBM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCBM.AutoSize = true;
            this.lblCBM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCBM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCBM.Location = new System.Drawing.Point(131, 296);
            this.lblCBM.Name = "lblCBM";
            this.lblCBM.Size = new System.Drawing.Size(370, 22);
            this.lblCBM.TabIndex = 12;
            this.lblCBM.Text = "ACT - College of Business and Management ";
            // 
            // lblSHS
            // 
            this.lblSHS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSHS.AutoSize = true;
            this.lblSHS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSHS.Location = new System.Drawing.Point(131, 397);
            this.lblSHS.Name = "lblSHS";
            this.lblSHS.Size = new System.Drawing.Size(243, 22);
            this.lblSHS.TabIndex = 11;
            this.lblSHS.Text = "ACT IEF Senior High School ";
            // 
            // lblCOE
            // 
            this.lblCOE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCOE.AutoSize = true;
            this.lblCOE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCOE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCOE.Location = new System.Drawing.Point(138, 81);
            this.lblCOE.Name = "lblCOE";
            this.lblCOE.Size = new System.Drawing.Size(234, 22);
            this.lblCOE.TabIndex = 10;
            this.lblCOE.Text = "ACT - College of Education ";
            // 
            // pnlStudents
            // 
            this.pnlStudents.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pnlStudents.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlStudents.BackColor = System.Drawing.Color.RosyBrown;
            this.pnlStudents.BackgroundImage = global::LoginPage.Properties.Resources.CONTACTS1;
            this.pnlStudents.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlStudents.Controls.Add(this.dgvRanking);
            this.pnlStudents.Controls.Add(this.dgvStudents);
            this.pnlStudents.Controls.Add(this.pnlStudentsInfo);
            this.pnlStudents.Location = new System.Drawing.Point(288, 52);
            this.pnlStudents.Name = "pnlStudents";
            this.pnlStudents.Size = new System.Drawing.Size(1025, 708);
            this.pnlStudents.TabIndex = 8;
            // 
            // dgvRanking
            // 
            this.dgvRanking.AllowUserToAddRows = false;
            this.dgvRanking.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvRanking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRanking.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRanking.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvRanking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRanking.Location = new System.Drawing.Point(479, 379);
            this.dgvRanking.Name = "dgvRanking";
            this.dgvRanking.RowHeadersWidth = 51;
            this.dgvRanking.RowTemplate.Height = 24;
            this.dgvRanking.Size = new System.Drawing.Size(511, 191);
            this.dgvRanking.TabIndex = 14;
            // 
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudents.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvStudents.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(479, 78);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.RowHeadersWidth = 51;
            this.dgvStudents.RowTemplate.Height = 24;
            this.dgvStudents.Size = new System.Drawing.Size(511, 191);
            this.dgvStudents.TabIndex = 8;
            this.dgvStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellClick);
            // 
            // pnlStudentsInfo
            // 
            this.pnlStudentsInfo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pnlStudentsInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlStudentsInfo.Controls.Add(this.btnRanking);
            this.pnlStudentsInfo.Controls.Add(this.btnStudentTable);
            this.pnlStudentsInfo.Controls.Add(this.lblStudentInfo);
            this.pnlStudentsInfo.Controls.Add(this.lblOverallGrade);
            this.pnlStudentsInfo.Controls.Add(this.lblFinalGrade);
            this.pnlStudentsInfo.Controls.Add(this.lblMidtermGrade);
            this.pnlStudentsInfo.Controls.Add(this.lblPrelimGrade);
            this.pnlStudentsInfo.Controls.Add(this.lblRank);
            this.pnlStudentsInfo.Controls.Add(this.lblPerformanceDetails);
            this.pnlStudentsInfo.Controls.Add(this.txtOverallGrade);
            this.pnlStudentsInfo.Controls.Add(this.txtFinalGrade);
            this.pnlStudentsInfo.Controls.Add(this.txtMidtermGrade);
            this.pnlStudentsInfo.Controls.Add(this.txtPrelimGrade);
            this.pnlStudentsInfo.Controls.Add(this.txtRank);
            this.pnlStudentsInfo.Controls.Add(this.pnlBorderStudents);
            this.pnlStudentsInfo.Controls.Add(this.btnUpdate);
            this.pnlStudentsInfo.Controls.Add(this.btnDelete);
            this.pnlStudentsInfo.Controls.Add(this.txtAge);
            this.pnlStudentsInfo.Controls.Add(this.lblAge);
            this.pnlStudentsInfo.Controls.Add(this.btnInsert);
            this.pnlStudentsInfo.Controls.Add(this.btnNew);
            this.pnlStudentsInfo.Controls.Add(this.txtAddress);
            this.pnlStudentsInfo.Controls.Add(this.lblAddress);
            this.pnlStudentsInfo.Controls.Add(this.txtID);
            this.pnlStudentsInfo.Controls.Add(this.lblName);
            this.pnlStudentsInfo.Controls.Add(this.txtName);
            this.pnlStudentsInfo.Controls.Add(this.lblStudentID);
            this.pnlStudentsInfo.ForeColor = System.Drawing.Color.White;
            this.pnlStudentsInfo.Location = new System.Drawing.Point(39, 32);
            this.pnlStudentsInfo.Name = "pnlStudentsInfo";
            this.pnlStudentsInfo.Size = new System.Drawing.Size(419, 633);
            this.pnlStudentsInfo.TabIndex = 13;
            // 
            // btnRanking
            // 
            this.btnRanking.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRanking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRanking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRanking.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRanking.ForeColor = System.Drawing.Color.Black;
            this.btnRanking.Location = new System.Drawing.Point(206, 595);
            this.btnRanking.Name = "btnRanking";
            this.btnRanking.Size = new System.Drawing.Size(118, 35);
            this.btnRanking.TabIndex = 26;
            this.btnRanking.Text = "Ranking";
            this.btnRanking.UseVisualStyleBackColor = false;
            this.btnRanking.Click += new System.EventHandler(this.btnRanking_Click);
            // 
            // btnStudentTable
            // 
            this.btnStudentTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStudentTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudentTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentTable.ForeColor = System.Drawing.Color.Black;
            this.btnStudentTable.Location = new System.Drawing.Point(82, 595);
            this.btnStudentTable.Name = "btnStudentTable";
            this.btnStudentTable.Size = new System.Drawing.Size(118, 35);
            this.btnStudentTable.TabIndex = 15;
            this.btnStudentTable.Text = "Students";
            this.btnStudentTable.UseVisualStyleBackColor = true;
            this.btnStudentTable.Click += new System.EventHandler(this.btnStudentTable_Click);
            // 
            // lblStudentInfo
            // 
            this.lblStudentInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblStudentInfo.AutoSize = true;
            this.lblStudentInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentInfo.ForeColor = System.Drawing.SystemColors.Window;
            this.lblStudentInfo.Location = new System.Drawing.Point(117, 14);
            this.lblStudentInfo.Name = "lblStudentInfo";
            this.lblStudentInfo.Size = new System.Drawing.Size(190, 29);
            this.lblStudentInfo.TabIndex = 25;
            this.lblStudentInfo.Text = "Student Details";
            // 
            // lblOverallGrade
            // 
            this.lblOverallGrade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOverallGrade.AutoSize = true;
            this.lblOverallGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverallGrade.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblOverallGrade.Location = new System.Drawing.Point(3, 547);
            this.lblOverallGrade.Name = "lblOverallGrade";
            this.lblOverallGrade.Size = new System.Drawing.Size(183, 29);
            this.lblOverallGrade.TabIndex = 24;
            this.lblOverallGrade.Text = "Overall Grade:";
            // 
            // lblFinalGrade
            // 
            this.lblFinalGrade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFinalGrade.AutoSize = true;
            this.lblFinalGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalGrade.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblFinalGrade.Location = new System.Drawing.Point(28, 510);
            this.lblFinalGrade.Name = "lblFinalGrade";
            this.lblFinalGrade.Size = new System.Drawing.Size(157, 29);
            this.lblFinalGrade.TabIndex = 23;
            this.lblFinalGrade.Text = "Final Grade:";
            // 
            // lblMidtermGrade
            // 
            this.lblMidtermGrade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMidtermGrade.AutoSize = true;
            this.lblMidtermGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMidtermGrade.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMidtermGrade.Location = new System.Drawing.Point(-8, 467);
            this.lblMidtermGrade.Name = "lblMidtermGrade";
            this.lblMidtermGrade.Size = new System.Drawing.Size(194, 29);
            this.lblMidtermGrade.TabIndex = 22;
            this.lblMidtermGrade.Text = "Midterm Grade:";
            // 
            // lblPrelimGrade
            // 
            this.lblPrelimGrade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrelimGrade.AutoSize = true;
            this.lblPrelimGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrelimGrade.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPrelimGrade.Location = new System.Drawing.Point(13, 431);
            this.lblPrelimGrade.Name = "lblPrelimGrade";
            this.lblPrelimGrade.Size = new System.Drawing.Size(175, 29);
            this.lblPrelimGrade.TabIndex = 21;
            this.lblPrelimGrade.Text = "Prelim Grade:";
            // 
            // lblRank
            // 
            this.lblRank.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRank.AutoSize = true;
            this.lblRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRank.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblRank.Location = new System.Drawing.Point(109, 390);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(79, 29);
            this.lblRank.TabIndex = 20;
            this.lblRank.Text = "Rank:";
            // 
            // lblPerformanceDetails
            // 
            this.lblPerformanceDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPerformanceDetails.AutoSize = true;
            this.lblPerformanceDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerformanceDetails.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPerformanceDetails.Location = new System.Drawing.Point(81, 355);
            this.lblPerformanceDetails.Name = "lblPerformanceDetails";
            this.lblPerformanceDetails.Size = new System.Drawing.Size(250, 29);
            this.lblPerformanceDetails.TabIndex = 19;
            this.lblPerformanceDetails.Text = "Performance Details";
            // 
            // txtOverallGrade
            // 
            this.txtOverallGrade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOverallGrade.Enabled = false;
            this.txtOverallGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOverallGrade.Location = new System.Drawing.Point(207, 547);
            this.txtOverallGrade.Name = "txtOverallGrade";
            this.txtOverallGrade.Size = new System.Drawing.Size(142, 34);
            this.txtOverallGrade.TabIndex = 18;
            // 
            // txtFinalGrade
            // 
            this.txtFinalGrade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFinalGrade.Enabled = false;
            this.txtFinalGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinalGrade.Location = new System.Drawing.Point(207, 507);
            this.txtFinalGrade.Name = "txtFinalGrade";
            this.txtFinalGrade.Size = new System.Drawing.Size(142, 34);
            this.txtFinalGrade.TabIndex = 17;
            // 
            // txtMidtermGrade
            // 
            this.txtMidtermGrade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMidtermGrade.Enabled = false;
            this.txtMidtermGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMidtermGrade.Location = new System.Drawing.Point(207, 467);
            this.txtMidtermGrade.Name = "txtMidtermGrade";
            this.txtMidtermGrade.Size = new System.Drawing.Size(142, 34);
            this.txtMidtermGrade.TabIndex = 16;
            // 
            // txtPrelimGrade
            // 
            this.txtPrelimGrade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrelimGrade.Enabled = false;
            this.txtPrelimGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrelimGrade.Location = new System.Drawing.Point(207, 427);
            this.txtPrelimGrade.Name = "txtPrelimGrade";
            this.txtPrelimGrade.Size = new System.Drawing.Size(142, 34);
            this.txtPrelimGrade.TabIndex = 15;
            // 
            // txtRank
            // 
            this.txtRank.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRank.Enabled = false;
            this.txtRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRank.Location = new System.Drawing.Point(207, 387);
            this.txtRank.Name = "txtRank";
            this.txtRank.Size = new System.Drawing.Size(142, 34);
            this.txtRank.TabIndex = 14;
            // 
            // pnlBorderStudents
            // 
            this.pnlBorderStudents.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBorderStudents.BackColor = System.Drawing.Color.White;
            this.pnlBorderStudents.Location = new System.Drawing.Point(33, 327);
            this.pnlBorderStudents.Name = "pnlBorderStudents";
            this.pnlBorderStudents.Size = new System.Drawing.Size(348, 13);
            this.pnlBorderStudents.TabIndex = 13;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUpdate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(90, 264);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(111, 41);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDelete.BackColor = System.Drawing.Color.Salmon;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(220, 264);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(111, 41);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtAge
            // 
            this.txtAge.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(192, 131);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(142, 34);
            this.txtAge.TabIndex = 6;
            // 
            // lblAge
            // 
            this.lblAge.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.ForeColor = System.Drawing.SystemColors.Window;
            this.lblAge.Location = new System.Drawing.Point(127, 131);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(59, 29);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Age";
            // 
            // btnInsert
            // 
            this.btnInsert.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnInsert.BackColor = System.Drawing.Color.PaleGreen;
            this.btnInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.Black;
            this.btnInsert.Location = new System.Drawing.Point(90, 217);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(111, 41);
            this.btnInsert.TabIndex = 9;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.Black;
            this.btnNew.Location = new System.Drawing.Point(220, 217);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(111, 41);
            this.btnNew.TabIndex = 10;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(192, 172);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(142, 34);
            this.txtAddress.TabIndex = 7;
            // 
            // lblAddress
            // 
            this.lblAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.SystemColors.Window;
            this.lblAddress.Location = new System.Drawing.Point(77, 174);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(109, 29);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Address";
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(192, 51);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(142, 34);
            this.txtID.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.Window;
            this.lblName.Location = new System.Drawing.Point(104, 96);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(82, 29);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(192, 91);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(142, 34);
            this.txtName.TabIndex = 5;
            // 
            // lblStudentID
            // 
            this.lblStudentID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID.ForeColor = System.Drawing.SystemColors.Window;
            this.lblStudentID.Location = new System.Drawing.Point(148, 54);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(38, 29);
            this.lblStudentID.TabIndex = 0;
            this.lblStudentID.Text = "ID";
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImage = global::LoginPage.Properties.Resources.CCS_Logo_revised__1_;
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLogo.Location = new System.Drawing.Point(12, 174);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(279, 190);
            this.pbLogo.TabIndex = 5;
            this.pbLogo.TabStop = false;
            // 
            // pnlGrading
            // 
            this.pnlGrading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlGrading.BackColor = System.Drawing.Color.Tomato;
            this.pnlGrading.BackgroundImage = global::LoginPage.Properties.Resources.New_Grading;
            this.pnlGrading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlGrading.Controls.Add(this.pnlGradingTab);
            this.pnlGrading.Controls.Add(this.dgvFinalTerm);
            this.pnlGrading.Controls.Add(this.dgvMidTerm);
            this.pnlGrading.Controls.Add(this.dgvPrelim);
            this.pnlGrading.Location = new System.Drawing.Point(239, 109);
            this.pnlGrading.Name = "pnlGrading";
            this.pnlGrading.Size = new System.Drawing.Size(1018, 746);
            this.pnlGrading.TabIndex = 9;
            // 
            // pnlGradingTab
            // 
            this.pnlGradingTab.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlGradingTab.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pnlGradingTab.Controls.Add(this.btnClearFinal);
            this.pnlGradingTab.Controls.Add(this.btnClearMidterm);
            this.pnlGradingTab.Controls.Add(this.btnClearPrelim);
            this.pnlGradingTab.Controls.Add(this.btnCalculateFinal);
            this.pnlGradingTab.Controls.Add(this.btnCalculateMidterm);
            this.pnlGradingTab.Controls.Add(this.btnCalculatePrelim);
            this.pnlGradingTab.Controls.Add(this.lblFinalTitle);
            this.pnlGradingTab.Controls.Add(this.lblProjectScoreFinal);
            this.pnlGradingTab.Controls.Add(this.lblQuizScoreFinal);
            this.pnlGradingTab.Controls.Add(this.lblLabScoreFinal);
            this.pnlGradingTab.Controls.Add(this.lblMidtermTitle);
            this.pnlGradingTab.Controls.Add(this.lblPracticalExamScoreMid);
            this.pnlGradingTab.Controls.Add(this.lblQuizScoreMid);
            this.pnlGradingTab.Controls.Add(this.lblLabScoreMid);
            this.pnlGradingTab.Controls.Add(this.txtProjectScoreFinal);
            this.pnlGradingTab.Controls.Add(this.txtQuizScoreFinal);
            this.pnlGradingTab.Controls.Add(this.txtLabScoreFinal);
            this.pnlGradingTab.Controls.Add(this.txtPracticalExamScoreMid);
            this.pnlGradingTab.Controls.Add(this.txtQuizScoreMid);
            this.pnlGradingTab.Controls.Add(this.txtLabScoreMid);
            this.pnlGradingTab.Controls.Add(this.btnFinals);
            this.pnlGradingTab.Controls.Add(this.pnlPrelimTitle);
            this.pnlGradingTab.Controls.Add(this.btnMidterm);
            this.pnlGradingTab.Controls.Add(this.lblAttendanceScore);
            this.pnlGradingTab.Controls.Add(this.btnPrelim);
            this.pnlGradingTab.Controls.Add(this.lblSeatworkScore);
            this.pnlGradingTab.Controls.Add(this.lblLabScore);
            this.pnlGradingTab.Controls.Add(this.lblQuizScore);
            this.pnlGradingTab.Controls.Add(this.txtAttendanceScore);
            this.pnlGradingTab.Controls.Add(this.txtSeatworkScore);
            this.pnlGradingTab.Controls.Add(this.txtLabScore);
            this.pnlGradingTab.Controls.Add(this.txtQuizScore);
            this.pnlGradingTab.Location = new System.Drawing.Point(4, 3);
            this.pnlGradingTab.Name = "pnlGradingTab";
            this.pnlGradingTab.Size = new System.Drawing.Size(418, 570);
            this.pnlGradingTab.TabIndex = 3;
            // 
            // btnClearFinal
            // 
            this.btnClearFinal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClearFinal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFinal.Location = new System.Drawing.Point(280, 479);
            this.btnClearFinal.Name = "btnClearFinal";
            this.btnClearFinal.Size = new System.Drawing.Size(112, 31);
            this.btnClearFinal.TabIndex = 27;
            this.btnClearFinal.Text = "Clear";
            this.btnClearFinal.UseVisualStyleBackColor = true;
            this.btnClearFinal.Click += new System.EventHandler(this.btnClearFinal_Click);
            // 
            // btnClearMidterm
            // 
            this.btnClearMidterm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClearMidterm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearMidterm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearMidterm.Location = new System.Drawing.Point(279, 330);
            this.btnClearMidterm.Name = "btnClearMidterm";
            this.btnClearMidterm.Size = new System.Drawing.Size(112, 31);
            this.btnClearMidterm.TabIndex = 26;
            this.btnClearMidterm.Text = "Clear";
            this.btnClearMidterm.UseVisualStyleBackColor = true;
            this.btnClearMidterm.Click += new System.EventHandler(this.btnClearMidterm_Click);
            // 
            // btnClearPrelim
            // 
            this.btnClearPrelim.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClearPrelim.BackColor = System.Drawing.Color.Tomato;
            this.btnClearPrelim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearPrelim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearPrelim.Location = new System.Drawing.Point(279, 178);
            this.btnClearPrelim.Name = "btnClearPrelim";
            this.btnClearPrelim.Size = new System.Drawing.Size(112, 31);
            this.btnClearPrelim.TabIndex = 25;
            this.btnClearPrelim.Text = "Clear";
            this.btnClearPrelim.UseVisualStyleBackColor = false;
            this.btnClearPrelim.Click += new System.EventHandler(this.btnClearPrelim_Click);
            // 
            // btnCalculateFinal
            // 
            this.btnCalculateFinal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCalculateFinal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculateFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateFinal.Location = new System.Drawing.Point(160, 480);
            this.btnCalculateFinal.Name = "btnCalculateFinal";
            this.btnCalculateFinal.Size = new System.Drawing.Size(112, 31);
            this.btnCalculateFinal.TabIndex = 24;
            this.btnCalculateFinal.Text = "Calculate";
            this.btnCalculateFinal.UseVisualStyleBackColor = true;
            this.btnCalculateFinal.Click += new System.EventHandler(this.btnCalculateFinal_Click);
            // 
            // btnCalculateMidterm
            // 
            this.btnCalculateMidterm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCalculateMidterm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculateMidterm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateMidterm.Location = new System.Drawing.Point(162, 330);
            this.btnCalculateMidterm.Name = "btnCalculateMidterm";
            this.btnCalculateMidterm.Size = new System.Drawing.Size(112, 31);
            this.btnCalculateMidterm.TabIndex = 23;
            this.btnCalculateMidterm.Text = "Calculate";
            this.btnCalculateMidterm.UseVisualStyleBackColor = true;
            this.btnCalculateMidterm.Click += new System.EventHandler(this.btnCalculateMidterm_Click);
            // 
            // btnCalculatePrelim
            // 
            this.btnCalculatePrelim.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCalculatePrelim.BackColor = System.Drawing.Color.PaleGreen;
            this.btnCalculatePrelim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculatePrelim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculatePrelim.Location = new System.Drawing.Point(158, 178);
            this.btnCalculatePrelim.Name = "btnCalculatePrelim";
            this.btnCalculatePrelim.Size = new System.Drawing.Size(112, 31);
            this.btnCalculatePrelim.TabIndex = 4;
            this.btnCalculatePrelim.Text = "Calculate";
            this.btnCalculatePrelim.UseVisualStyleBackColor = false;
            this.btnCalculatePrelim.Click += new System.EventHandler(this.btnCalculatePrelim_Click);
            // 
            // lblFinalTitle
            // 
            this.lblFinalTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFinalTitle.AutoSize = true;
            this.lblFinalTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalTitle.Location = new System.Drawing.Point(35, 403);
            this.lblFinalTitle.Name = "lblFinalTitle";
            this.lblFinalTitle.Size = new System.Drawing.Size(82, 32);
            this.lblFinalTitle.TabIndex = 22;
            this.lblFinalTitle.Text = "Final";
            this.lblFinalTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblProjectScoreFinal
            // 
            this.lblProjectScoreFinal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblProjectScoreFinal.AutoSize = true;
            this.lblProjectScoreFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectScoreFinal.Location = new System.Drawing.Point(187, 444);
            this.lblProjectScoreFinal.Name = "lblProjectScoreFinal";
            this.lblProjectScoreFinal.Size = new System.Drawing.Size(95, 29);
            this.lblProjectScoreFinal.TabIndex = 21;
            this.lblProjectScoreFinal.Text = "Project:";
            // 
            // lblQuizScoreFinal
            // 
            this.lblQuizScoreFinal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblQuizScoreFinal.AutoSize = true;
            this.lblQuizScoreFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuizScoreFinal.Location = new System.Drawing.Point(217, 404);
            this.lblQuizScoreFinal.Name = "lblQuizScoreFinal";
            this.lblQuizScoreFinal.Size = new System.Drawing.Size(68, 29);
            this.lblQuizScoreFinal.TabIndex = 20;
            this.lblQuizScoreFinal.Text = "Quiz:";
            // 
            // lblLabScoreFinal
            // 
            this.lblLabScoreFinal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblLabScoreFinal.AutoSize = true;
            this.lblLabScoreFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabScoreFinal.Location = new System.Drawing.Point(152, 362);
            this.lblLabScoreFinal.Name = "lblLabScoreFinal";
            this.lblLabScoreFinal.Size = new System.Drawing.Size(133, 29);
            this.lblLabScoreFinal.TabIndex = 19;
            this.lblLabScoreFinal.Text = "Laboratory:";
            // 
            // lblMidtermTitle
            // 
            this.lblMidtermTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMidtermTitle.AutoSize = true;
            this.lblMidtermTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMidtermTitle.Location = new System.Drawing.Point(35, 256);
            this.lblMidtermTitle.Name = "lblMidtermTitle";
            this.lblMidtermTitle.Size = new System.Drawing.Size(123, 32);
            this.lblMidtermTitle.TabIndex = 18;
            this.lblMidtermTitle.Text = "Midterm";
            this.lblMidtermTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPracticalExamScoreMid
            // 
            this.lblPracticalExamScoreMid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPracticalExamScoreMid.AutoSize = true;
            this.lblPracticalExamScoreMid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPracticalExamScoreMid.Location = new System.Drawing.Point(97, 299);
            this.lblPracticalExamScoreMid.Name = "lblPracticalExamScoreMid";
            this.lblPracticalExamScoreMid.Size = new System.Drawing.Size(177, 29);
            this.lblPracticalExamScoreMid.TabIndex = 17;
            this.lblPracticalExamScoreMid.Text = "Practical Exam:";
            // 
            // lblQuizScoreMid
            // 
            this.lblQuizScoreMid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblQuizScoreMid.AutoSize = true;
            this.lblQuizScoreMid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuizScoreMid.Location = new System.Drawing.Point(217, 256);
            this.lblQuizScoreMid.Name = "lblQuizScoreMid";
            this.lblQuizScoreMid.Size = new System.Drawing.Size(68, 29);
            this.lblQuizScoreMid.TabIndex = 16;
            this.lblQuizScoreMid.Text = "Quiz:";
            // 
            // lblLabScoreMid
            // 
            this.lblLabScoreMid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLabScoreMid.AutoSize = true;
            this.lblLabScoreMid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabScoreMid.Location = new System.Drawing.Point(152, 218);
            this.lblLabScoreMid.Name = "lblLabScoreMid";
            this.lblLabScoreMid.Size = new System.Drawing.Size(133, 29);
            this.lblLabScoreMid.TabIndex = 15;
            this.lblLabScoreMid.Text = "Laboratory:";
            // 
            // txtProjectScoreFinal
            // 
            this.txtProjectScoreFinal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtProjectScoreFinal.Cursor = System.Windows.Forms.Cursors.No;
            this.txtProjectScoreFinal.Enabled = false;
            this.txtProjectScoreFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProjectScoreFinal.Location = new System.Drawing.Point(291, 441);
            this.txtProjectScoreFinal.Name = "txtProjectScoreFinal";
            this.txtProjectScoreFinal.Size = new System.Drawing.Size(100, 34);
            this.txtProjectScoreFinal.TabIndex = 14;
            this.txtProjectScoreFinal.TextChanged += new System.EventHandler(this.txtProjectScoreFinal_TextChanged);
            // 
            // txtQuizScoreFinal
            // 
            this.txtQuizScoreFinal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtQuizScoreFinal.Cursor = System.Windows.Forms.Cursors.No;
            this.txtQuizScoreFinal.Enabled = false;
            this.txtQuizScoreFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuizScoreFinal.Location = new System.Drawing.Point(291, 401);
            this.txtQuizScoreFinal.Name = "txtQuizScoreFinal";
            this.txtQuizScoreFinal.Size = new System.Drawing.Size(100, 34);
            this.txtQuizScoreFinal.TabIndex = 13;
            this.txtQuizScoreFinal.TextChanged += new System.EventHandler(this.txtQuizScoreFinal_TextChanged);
            // 
            // txtLabScoreFinal
            // 
            this.txtLabScoreFinal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtLabScoreFinal.Cursor = System.Windows.Forms.Cursors.No;
            this.txtLabScoreFinal.Enabled = false;
            this.txtLabScoreFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLabScoreFinal.Location = new System.Drawing.Point(291, 361);
            this.txtLabScoreFinal.Name = "txtLabScoreFinal";
            this.txtLabScoreFinal.Size = new System.Drawing.Size(100, 34);
            this.txtLabScoreFinal.TabIndex = 12;
            this.txtLabScoreFinal.TextChanged += new System.EventHandler(this.txtLabScoreFinal_TextChanged);
            // 
            // txtPracticalExamScoreMid
            // 
            this.txtPracticalExamScoreMid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPracticalExamScoreMid.Cursor = System.Windows.Forms.Cursors.No;
            this.txtPracticalExamScoreMid.Enabled = false;
            this.txtPracticalExamScoreMid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPracticalExamScoreMid.Location = new System.Drawing.Point(291, 293);
            this.txtPracticalExamScoreMid.Name = "txtPracticalExamScoreMid";
            this.txtPracticalExamScoreMid.Size = new System.Drawing.Size(100, 34);
            this.txtPracticalExamScoreMid.TabIndex = 11;
            this.txtPracticalExamScoreMid.TextChanged += new System.EventHandler(this.txtPracticalExamScoreMid_TextChanged);
            // 
            // txtQuizScoreMid
            // 
            this.txtQuizScoreMid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtQuizScoreMid.Cursor = System.Windows.Forms.Cursors.No;
            this.txtQuizScoreMid.Enabled = false;
            this.txtQuizScoreMid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuizScoreMid.Location = new System.Drawing.Point(291, 253);
            this.txtQuizScoreMid.Name = "txtQuizScoreMid";
            this.txtQuizScoreMid.Size = new System.Drawing.Size(100, 34);
            this.txtQuizScoreMid.TabIndex = 10;
            this.txtQuizScoreMid.TextChanged += new System.EventHandler(this.txtQuizScoreMid_TextChanged);
            // 
            // txtLabScoreMid
            // 
            this.txtLabScoreMid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLabScoreMid.Cursor = System.Windows.Forms.Cursors.No;
            this.txtLabScoreMid.Enabled = false;
            this.txtLabScoreMid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLabScoreMid.Location = new System.Drawing.Point(291, 213);
            this.txtLabScoreMid.Name = "txtLabScoreMid";
            this.txtLabScoreMid.Size = new System.Drawing.Size(100, 34);
            this.txtLabScoreMid.TabIndex = 9;
            this.txtLabScoreMid.TextChanged += new System.EventHandler(this.txtLabScoreMid_TextChanged);
            // 
            // btnFinals
            // 
            this.btnFinals.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnFinals.BackColor = System.Drawing.Color.Salmon;
            this.btnFinals.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinals.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinals.Location = new System.Drawing.Point(275, 531);
            this.btnFinals.Name = "btnFinals";
            this.btnFinals.Size = new System.Drawing.Size(104, 36);
            this.btnFinals.TabIndex = 8;
            this.btnFinals.Text = "Finals";
            this.btnFinals.UseVisualStyleBackColor = false;
            this.btnFinals.Click += new System.EventHandler(this.btnFinals_Click);
            // 
            // pnlPrelimTitle
            // 
            this.pnlPrelimTitle.AutoSize = true;
            this.pnlPrelimTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlPrelimTitle.Location = new System.Drawing.Point(35, 90);
            this.pnlPrelimTitle.Name = "pnlPrelimTitle";
            this.pnlPrelimTitle.Size = new System.Drawing.Size(101, 32);
            this.pnlPrelimTitle.TabIndex = 8;
            this.pnlPrelimTitle.Text = "Prelim";
            this.pnlPrelimTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnMidterm
            // 
            this.btnMidterm.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnMidterm.BackColor = System.Drawing.Color.PaleGreen;
            this.btnMidterm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMidterm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMidterm.Location = new System.Drawing.Point(151, 531);
            this.btnMidterm.Name = "btnMidterm";
            this.btnMidterm.Size = new System.Drawing.Size(118, 34);
            this.btnMidterm.TabIndex = 7;
            this.btnMidterm.Text = "Midterm";
            this.btnMidterm.UseVisualStyleBackColor = false;
            this.btnMidterm.Click += new System.EventHandler(this.btnMidterm_Click);
            // 
            // lblAttendanceScore
            // 
            this.lblAttendanceScore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAttendanceScore.AutoSize = true;
            this.lblAttendanceScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttendanceScore.Location = new System.Drawing.Point(146, 144);
            this.lblAttendanceScore.Name = "lblAttendanceScore";
            this.lblAttendanceScore.Size = new System.Drawing.Size(139, 29);
            this.lblAttendanceScore.TabIndex = 7;
            this.lblAttendanceScore.Text = "Attendance:";
            // 
            // btnPrelim
            // 
            this.btnPrelim.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPrelim.BackColor = System.Drawing.Color.Khaki;
            this.btnPrelim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrelim.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrelim.Location = new System.Drawing.Point(41, 530);
            this.btnPrelim.Name = "btnPrelim";
            this.btnPrelim.Size = new System.Drawing.Size(104, 37);
            this.btnPrelim.TabIndex = 6;
            this.btnPrelim.Text = "Prelim";
            this.btnPrelim.UseVisualStyleBackColor = false;
            this.btnPrelim.Click += new System.EventHandler(this.btnPrelim_Click);
            // 
            // lblSeatworkScore
            // 
            this.lblSeatworkScore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSeatworkScore.AutoSize = true;
            this.lblSeatworkScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeatworkScore.Location = new System.Drawing.Point(165, 103);
            this.lblSeatworkScore.Name = "lblSeatworkScore";
            this.lblSeatworkScore.Size = new System.Drawing.Size(120, 29);
            this.lblSeatworkScore.TabIndex = 6;
            this.lblSeatworkScore.Text = "Seatwork:";
            // 
            // lblLabScore
            // 
            this.lblLabScore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLabScore.AutoSize = true;
            this.lblLabScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabScore.Location = new System.Drawing.Point(152, 58);
            this.lblLabScore.Name = "lblLabScore";
            this.lblLabScore.Size = new System.Drawing.Size(133, 29);
            this.lblLabScore.TabIndex = 5;
            this.lblLabScore.Text = "Laboratory:";
            // 
            // lblQuizScore
            // 
            this.lblQuizScore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblQuizScore.AutoSize = true;
            this.lblQuizScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuizScore.Location = new System.Drawing.Point(217, 23);
            this.lblQuizScore.Name = "lblQuizScore";
            this.lblQuizScore.Size = new System.Drawing.Size(68, 29);
            this.lblQuizScore.TabIndex = 4;
            this.lblQuizScore.Text = "Quiz:";
            // 
            // txtAttendanceScore
            // 
            this.txtAttendanceScore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAttendanceScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAttendanceScore.Location = new System.Drawing.Point(291, 141);
            this.txtAttendanceScore.Name = "txtAttendanceScore";
            this.txtAttendanceScore.Size = new System.Drawing.Size(100, 34);
            this.txtAttendanceScore.TabIndex = 3;
            this.txtAttendanceScore.TextChanged += new System.EventHandler(this.txtAttendanceScore_TextChanged);
            // 
            // txtSeatworkScore
            // 
            this.txtSeatworkScore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSeatworkScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeatworkScore.Location = new System.Drawing.Point(291, 100);
            this.txtSeatworkScore.Name = "txtSeatworkScore";
            this.txtSeatworkScore.Size = new System.Drawing.Size(100, 34);
            this.txtSeatworkScore.TabIndex = 2;
            this.txtSeatworkScore.TextChanged += new System.EventHandler(this.txtSeatworkScore_TextChanged);
            // 
            // txtLabScore
            // 
            this.txtLabScore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtLabScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLabScore.Location = new System.Drawing.Point(291, 58);
            this.txtLabScore.Name = "txtLabScore";
            this.txtLabScore.Size = new System.Drawing.Size(100, 34);
            this.txtLabScore.TabIndex = 1;
            this.txtLabScore.TextChanged += new System.EventHandler(this.txtLabScore_TextChanged);
            // 
            // txtQuizScore
            // 
            this.txtQuizScore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtQuizScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuizScore.Location = new System.Drawing.Point(291, 18);
            this.txtQuizScore.Name = "txtQuizScore";
            this.txtQuizScore.Size = new System.Drawing.Size(100, 34);
            this.txtQuizScore.TabIndex = 0;
            this.txtQuizScore.TextChanged += new System.EventHandler(this.txtQuizScore_TextChanged);
            // 
            // dgvFinalTerm
            // 
            this.dgvFinalTerm.AllowUserToAddRows = false;
            this.dgvFinalTerm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvFinalTerm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFinalTerm.BackgroundColor = System.Drawing.Color.Salmon;
            this.dgvFinalTerm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFinalTerm.Location = new System.Drawing.Point(428, 421);
            this.dgvFinalTerm.Name = "dgvFinalTerm";
            this.dgvFinalTerm.ReadOnly = true;
            this.dgvFinalTerm.RowHeadersWidth = 51;
            this.dgvFinalTerm.RowTemplate.Height = 24;
            this.dgvFinalTerm.ShowCellErrors = false;
            this.dgvFinalTerm.Size = new System.Drawing.Size(579, 150);
            this.dgvFinalTerm.TabIndex = 2;
            // 
            // dgvMidTerm
            // 
            this.dgvMidTerm.AllowUserToAddRows = false;
            this.dgvMidTerm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvMidTerm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMidTerm.BackgroundColor = System.Drawing.Color.PaleGreen;
            this.dgvMidTerm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMidTerm.Location = new System.Drawing.Point(428, 239);
            this.dgvMidTerm.Name = "dgvMidTerm";
            this.dgvMidTerm.ReadOnly = true;
            this.dgvMidTerm.RowHeadersWidth = 51;
            this.dgvMidTerm.RowTemplate.Height = 24;
            this.dgvMidTerm.ShowCellErrors = false;
            this.dgvMidTerm.Size = new System.Drawing.Size(579, 150);
            this.dgvMidTerm.TabIndex = 1;
            // 
            // dgvPrelim
            // 
            this.dgvPrelim.AllowUserToAddRows = false;
            this.dgvPrelim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvPrelim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrelim.BackgroundColor = System.Drawing.Color.Khaki;
            this.dgvPrelim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrelim.Location = new System.Drawing.Point(428, 50);
            this.dgvPrelim.Name = "dgvPrelim";
            this.dgvPrelim.ReadOnly = true;
            this.dgvPrelim.RowHeadersWidth = 51;
            this.dgvPrelim.RowTemplate.Height = 24;
            this.dgvPrelim.ShowCellErrors = false;
            this.dgvPrelim.Size = new System.Drawing.Size(579, 150);
            this.dgvPrelim.TabIndex = 0;
            this.dgvPrelim.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrelim_CellClick);
            // 
            // pnlHome
            // 
            this.pnlHome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlHome.BackColor = System.Drawing.Color.DimGray;
            this.pnlHome.BackgroundImage = global::LoginPage.Properties.Resources.Blue_Black_Simple_Technology_Linktree_Background1;
            this.pnlHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlHome.Controls.Add(this.pnlAdmin);
            this.pnlHome.Controls.Add(this.pnlWhatsNew);
            this.pnlHome.Location = new System.Drawing.Point(337, 4);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(1039, 771);
            this.pnlHome.TabIndex = 7;
            // 
            // pnlAdmin
            // 
            this.pnlAdmin.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pnlAdmin.BackColor = System.Drawing.Color.White;
            this.pnlAdmin.Controls.Add(this.lblTask5);
            this.pnlAdmin.Controls.Add(this.lblTask4);
            this.pnlAdmin.Controls.Add(this.lblTask3);
            this.pnlAdmin.Controls.Add(this.lblTask2);
            this.pnlAdmin.Controls.Add(this.label14);
            this.pnlAdmin.Controls.Add(this.lblTask1);
            this.pnlAdmin.Controls.Add(this.lblWelcome);
            this.pnlAdmin.Controls.Add(this.label15);
            this.pnlAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlAdmin.Location = new System.Drawing.Point(511, 206);
            this.pnlAdmin.Name = "pnlAdmin";
            this.pnlAdmin.Size = new System.Drawing.Size(482, 467);
            this.pnlAdmin.TabIndex = 10;
            // 
            // lblTask5
            // 
            this.lblTask5.AutoSize = true;
            this.lblTask5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTask5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTask5.Location = new System.Drawing.Point(68, 340);
            this.lblTask5.Name = "lblTask5";
            this.lblTask5.Size = new System.Drawing.Size(349, 20);
            this.lblTask5.TabIndex = 14;
            this.lblTask5.Text = "- Calculate the overall grade for each student.";
            // 
            // lblTask4
            // 
            this.lblTask4.AutoSize = true;
            this.lblTask4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTask4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTask4.Location = new System.Drawing.Point(69, 306);
            this.lblTask4.Name = "lblTask4";
            this.lblTask4.Size = new System.Drawing.Size(216, 20);
            this.lblTask4.TabIndex = 13;
            this.lblTask4.Text = "- Grade Students for Finals.";
            // 
            // lblTask3
            // 
            this.lblTask3.AutoSize = true;
            this.lblTask3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTask3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTask3.Location = new System.Drawing.Point(68, 273);
            this.lblTask3.Name = "lblTask3";
            this.lblTask3.Size = new System.Drawing.Size(232, 20);
            this.lblTask3.TabIndex = 12;
            this.lblTask3.Text = "- Grade Students for Midterm.";
            // 
            // lblTask2
            // 
            this.lblTask2.AutoSize = true;
            this.lblTask2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTask2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTask2.Location = new System.Drawing.Point(68, 244);
            this.lblTask2.Name = "lblTask2";
            this.lblTask2.Size = new System.Drawing.Size(217, 20);
            this.lblTask2.TabIndex = 11;
            this.lblTask2.Text = "- Grade students for Prelim.";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(21, 158);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(103, 32);
            this.label14.TabIndex = 10;
            this.label14.Text = "Tasks:";
            // 
            // lblTask1
            // 
            this.lblTask1.AutoSize = true;
            this.lblTask1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTask1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTask1.Location = new System.Drawing.Point(68, 210);
            this.lblTask1.Name = "lblTask1";
            this.lblTask1.Size = new System.Drawing.Size(199, 20);
            this.lblTask1.TabIndex = 6;
            this.lblTask1.Text = "- Prepare a cup of coffee.";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(72, 87);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(290, 20);
            this.lblWelcome.TabIndex = 4;
            this.lblWelcome.Text = "Welcome back to the grading system!";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(21, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(188, 32);
            this.label15.TabIndex = 0;
            this.label15.Text = "Hello Admin!";
            // 
            // pnlWhatsNew
            // 
            this.pnlWhatsNew.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pnlWhatsNew.BackColor = System.Drawing.Color.White;
            this.pnlWhatsNew.Controls.Add(this.label5);
            this.pnlWhatsNew.Controls.Add(this.label4);
            this.pnlWhatsNew.Controls.Add(this.label3);
            this.pnlWhatsNew.Controls.Add(this.label2);
            this.pnlWhatsNew.Controls.Add(this.label1);
            this.pnlWhatsNew.Controls.Add(this.lblDescription1);
            this.pnlWhatsNew.Controls.Add(this.lblTitle3);
            this.pnlWhatsNew.Controls.Add(this.lblTitle2);
            this.pnlWhatsNew.Controls.Add(this.lblTitle1);
            this.pnlWhatsNew.Controls.Add(this.lblUpcomingEvents);
            this.pnlWhatsNew.Location = new System.Drawing.Point(36, 208);
            this.pnlWhatsNew.Name = "pnlWhatsNew";
            this.pnlWhatsNew.Size = new System.Drawing.Size(443, 467);
            this.pnlWhatsNew.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(73, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "May 30, 2024";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(298, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "4th year stuents\' graduation ceremony.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Location = new System.Drawing.Point(73, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Event for the College of Computer Sciences.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "May 21, 2024";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Finals exam is around the corner!";
            // 
            // lblDescription1
            // 
            this.lblDescription1.AutoSize = true;
            this.lblDescription1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDescription1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription1.Location = new System.Drawing.Point(73, 120);
            this.lblDescription1.Name = "lblDescription1";
            this.lblDescription1.Size = new System.Drawing.Size(108, 20);
            this.lblDescription1.TabIndex = 4;
            this.lblDescription1.Text = "May 15, 2024";
            // 
            // lblTitle3
            // 
            this.lblTitle3.AutoSize = true;
            this.lblTitle3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTitle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle3.Location = new System.Drawing.Point(57, 350);
            this.lblTitle3.Name = "lblTitle3";
            this.lblTitle3.Size = new System.Drawing.Size(157, 29);
            this.lblTitle3.TabIndex = 3;
            this.lblTitle3.Text = "- Graduation";
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTitle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle2.Location = new System.Drawing.Point(58, 225);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(239, 29);
            this.lblTitle2.TabIndex = 2;
            this.lblTitle2.Text = "- Culmination Event";
            // 
            // lblTitle1
            // 
            this.lblTitle1.AutoSize = true;
            this.lblTitle1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTitle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle1.Location = new System.Drawing.Point(57, 79);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(171, 29);
            this.lblTitle1.TabIndex = 1;
            this.lblTitle1.Text = "- Finals Exam";
            // 
            // lblUpcomingEvents
            // 
            this.lblUpcomingEvents.AutoSize = true;
            this.lblUpcomingEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpcomingEvents.Location = new System.Drawing.Point(21, 19);
            this.lblUpcomingEvents.Name = "lblUpcomingEvents";
            this.lblUpcomingEvents.Size = new System.Drawing.Size(260, 32);
            this.lblUpcomingEvents.TabIndex = 0;
            this.lblUpcomingEvents.Text = "Upcoming Events:";
            // 
            // form2BindingSource
            // 
            this.form2BindingSource.DataSource = typeof(LoginPage.Form2);
            // 
            // form2BindingSource1
            // 
            this.form2BindingSource1.DataSource = typeof(LoginPage.Form2);
            // 
            // form2BindingSource2
            // 
            this.form2BindingSource2.DataSource = typeof(LoginPage.Form2);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 763);
            this.Controls.Add(this.pnlStudents);
            this.Controls.Add(this.lblAboutUs);
            this.Controls.Add(this.lblLogOut);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.pnlBarrier);
            this.Controls.Add(this.lblGrading);
            this.Controls.Add(this.lblStudents);
            this.Controls.Add(this.lblHome);
            this.Controls.Add(this.pnlGrading);
            this.Controls.Add(this.pnlHome);
            this.Controls.Add(this.pnlContacts);
            this.Name = "Form2";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.pnlContacts.ResumeLayout(false);
            this.pnlContacts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuidance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSHS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCBM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCCS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCOE)).EndInit();
            this.pnlStudents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRanking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.pnlStudentsInfo.ResumeLayout(false);
            this.pnlStudentsInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlGrading.ResumeLayout(false);
            this.pnlGradingTab.ResumeLayout(false);
            this.pnlGradingTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinalTerm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMidTerm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrelim)).EndInit();
            this.pnlHome.ResumeLayout(false);
            this.pnlAdmin.ResumeLayout(false);
            this.pnlAdmin.PerformLayout();
            this.pnlWhatsNew.ResumeLayout(false);
            this.pnlWhatsNew.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.form2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form2BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form2BindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblHome;
        private Label lblStudents;
        private Label lblGrading;
        private Panel pnlBarrier;
        private PictureBox pbLogo;
        private Panel pnlHome;
        private Panel pnlStudents;
        private Panel pnlGrading;
        private Label lblContact;
        private DataGridView dgvPrelim;
        private BindingSource form2BindingSource2;
        private BindingSource form2BindingSource;
        private BindingSource form2BindingSource1;
        private Label lblAddress;
        private Label lblAge;
        private Label lblName;
        private Label lblStudentID;
        private DataGridView dgvStudents;
        private TextBox txtAddress;
        private TextBox txtAge;
        private TextBox txtName;
        private TextBox txtID;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnNew;
        private Button btnInsert;
        private Label lblLogOut;
        private Label lblAboutUs;
        private DataGridView dgvFinalTerm;
        private DataGridView dgvMidTerm;
        private Panel pnlContacts;
        private Label lblRegistrar;
        private Label lblAccounting;
        private Label lblScholarship;
        private Label lblGuidance;
        private Label lblSDO;
        private Label lblCCS;
        private Label lblCBM;
        private Label lblSHS;
        private Label lblCOE;
        private Panel pnlGradingTab;
        private Button btnFinals;
        private Button btnMidterm;
        private Button btnPrelim;
        private Label pnlPrelimTitle;
        private Label lblAttendanceScore;
        private Label lblSeatworkScore;
        private Label lblLabScore;
        private Label lblQuizScore;
        private TextBox txtAttendanceScore;
        private TextBox txtSeatworkScore;
        private TextBox txtLabScore;
        private TextBox txtQuizScore;
        private TextBox txtLabScoreMid;
        private TextBox txtProjectScoreFinal;
        private TextBox txtQuizScoreFinal;
        private TextBox txtLabScoreFinal;
        private TextBox txtPracticalExamScoreMid;
        private TextBox txtQuizScoreMid;
        private Label lblPracticalExamScoreMid;
        private Label lblQuizScoreMid;
        private Label lblLabScoreMid;
        private Label lblLabScoreFinal;
        private Label lblMidtermTitle;
        private Label lblProjectScoreFinal;
        private Label lblQuizScoreFinal;
        private Label lblFinalTitle;
        private Panel pnlStudentsInfo;
        private TextBox txtMidtermGrade;
        private TextBox txtPrelimGrade;
        private TextBox txtRank;
        private Panel pnlBorderStudents;
        private Label lblOverallGrade;
        private Label lblFinalGrade;
        private Label lblMidtermGrade;
        private Label lblPrelimGrade;
        private Label lblRank;
        private Label lblPerformanceDetails;
        private TextBox txtOverallGrade;
        private TextBox txtFinalGrade;
        private Label lblStudentInfo;
        private Button btnCalculateFinal;
        private Button btnCalculateMidterm;
        private Button btnCalculatePrelim;
        private Button btnClearMidterm;
        private Button btnClearPrelim;
        private Button btnClearFinal;
        private DataGridView dgvRanking;
        private Button btnStudentTable;
        private Button btnRanking;
        private Panel pnlWhatsNew;
        private Label lblDescription1;
        private Label lblTitle3;
        private Label lblTitle2;
        private Label lblTitle1;
        private Label lblUpcomingEvents;
        private Label label2;
        private Label label1;
        private Panel pnlAdmin;
        private Label lblTask1;
        private Label lblWelcome;
        private Label label15;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label14;
        private Label lblTask5;
        private Label lblTask4;
        private Label lblTask3;
        private Label lblTask2;
        private PictureBox pbCOE;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
        private PictureBox pbGuidance;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pbSHS;
        private PictureBox pbCBM;
        private PictureBox pbCCS;
    }
}