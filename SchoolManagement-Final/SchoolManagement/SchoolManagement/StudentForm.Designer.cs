namespace SchoolManagement
{
    partial class StudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoPicBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.settings = new System.Windows.Forms.PictureBox();
            this.notice = new System.Windows.Forms.PictureBox();
            this.coursesResult = new System.Windows.Forms.PictureBox();
            this.coursePanel = new System.Windows.Forms.Panel();
            this.noticePanel = new System.Windows.Forms.Panel();
            this.passwordPanel = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.oldpassword = new System.Windows.Forms.TextBox();
            this.newpassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.noticeData = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.finalMcqMarkLbl = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.finalWrittenMarkLbl = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.finalTotalMarkLbl = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.midMcqMarkLbl = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.midWrittenMarkLbl = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.midTotalMarkLbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.fullMarkLbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.courseNameLbl = new System.Windows.Forms.Label();
            this.coursesComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesResult)).BeginInit();
            this.coursePanel.SuspendLayout();
            this.noticePanel.SuspendLayout();
            this.passwordPanel.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noticeData)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.logoPicBox);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.settings);
            this.panel1.Controls.Add(this.notice);
            this.panel1.Controls.Add(this.coursesResult);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 100);
            this.panel1.TabIndex = 0;
            // 
            // logoPicBox
            // 
            this.logoPicBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.logoPicBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPicBox.Image")));
            this.logoPicBox.Location = new System.Drawing.Point(3, 3);
            this.logoPicBox.Name = "logoPicBox";
            this.logoPicBox.Size = new System.Drawing.Size(139, 93);
            this.logoPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPicBox.TabIndex = 6;
            this.logoPicBox.TabStop = false;
            this.logoPicBox.Click += new System.EventHandler(this.logoPicBox_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(759, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 69);
            this.button1.TabIndex = 3;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // settings
            // 
            this.settings.BackColor = System.Drawing.Color.Silver;
            this.settings.Image = ((System.Drawing.Image)(resources.GetObject("settings.Image")));
            this.settings.Location = new System.Drawing.Point(422, 12);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(77, 69);
            this.settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.settings.TabIndex = 2;
            this.settings.TabStop = false;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            this.settings.MouseLeave += new System.EventHandler(this.settings_MouseLeave);
            this.settings.MouseHover += new System.EventHandler(this.settings_MouseHover);
            // 
            // notice
            // 
            this.notice.BackColor = System.Drawing.Color.Silver;
            this.notice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.notice.Image = ((System.Drawing.Image)(resources.GetObject("notice.Image")));
            this.notice.Location = new System.Drawing.Point(305, 12);
            this.notice.Name = "notice";
            this.notice.Size = new System.Drawing.Size(82, 69);
            this.notice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.notice.TabIndex = 1;
            this.notice.TabStop = false;
            this.notice.Click += new System.EventHandler(this.notice_Click);
            this.notice.MouseLeave += new System.EventHandler(this.notice_MouseLeave);
            this.notice.MouseHover += new System.EventHandler(this.notice_MouseHover);
            // 
            // coursesResult
            // 
            this.coursesResult.BackColor = System.Drawing.Color.Silver;
            this.coursesResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.coursesResult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.coursesResult.Image = ((System.Drawing.Image)(resources.GetObject("coursesResult.Image")));
            this.coursesResult.Location = new System.Drawing.Point(198, 12);
            this.coursesResult.Name = "coursesResult";
            this.coursesResult.Size = new System.Drawing.Size(82, 69);
            this.coursesResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coursesResult.TabIndex = 1;
            this.coursesResult.TabStop = false;
            this.coursesResult.Click += new System.EventHandler(this.coursesResult_Click);
            this.coursesResult.MouseLeave += new System.EventHandler(this.coursesResult_MouseLeave);
            this.coursesResult.MouseHover += new System.EventHandler(this.coursesResult_MouseHover);
            // 
            // coursePanel
            // 
            this.coursePanel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.coursePanel.Controls.Add(this.noticePanel);
            this.coursePanel.Controls.Add(this.panel2);
            this.coursePanel.Controls.Add(this.coursesComboBox);
            this.coursePanel.Controls.Add(this.label6);
            this.coursePanel.Controls.Add(this.label1);
            this.coursePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.coursePanel.Location = new System.Drawing.Point(0, 100);
            this.coursePanel.Name = "coursePanel";
            this.coursePanel.Size = new System.Drawing.Size(865, 519);
            this.coursePanel.TabIndex = 1;
            // 
            // noticePanel
            // 
            this.noticePanel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.noticePanel.Controls.Add(this.passwordPanel);
            this.noticePanel.Controls.Add(this.label2);
            this.noticePanel.Controls.Add(this.label7);
            this.noticePanel.Controls.Add(this.richTextBox1);
            this.noticePanel.Controls.Add(this.noticeData);
            this.noticePanel.Controls.Add(this.label4);
            this.noticePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noticePanel.Location = new System.Drawing.Point(0, 0);
            this.noticePanel.Name = "noticePanel";
            this.noticePanel.Size = new System.Drawing.Size(865, 519);
            this.noticePanel.TabIndex = 12;
            // 
            // passwordPanel
            // 
            this.passwordPanel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.passwordPanel.Controls.Add(this.panel9);
            this.passwordPanel.Controls.Add(this.label29);
            this.passwordPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordPanel.Location = new System.Drawing.Point(0, 0);
            this.passwordPanel.Name = "passwordPanel";
            this.passwordPanel.Size = new System.Drawing.Size(865, 519);
            this.passwordPanel.TabIndex = 3;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel9.Controls.Add(this.backButton);
            this.panel9.Controls.Add(this.saveButton);
            this.panel9.Controls.Add(this.oldpassword);
            this.panel9.Controls.Add(this.newpassword);
            this.panel9.Controls.Add(this.label5);
            this.panel9.Controls.Add(this.label28);
            this.panel9.Location = new System.Drawing.Point(42, 91);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(780, 337);
            this.panel9.TabIndex = 7;
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(234, 206);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(97, 32);
            this.backButton.TabIndex = 10;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(482, 206);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(97, 32);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // oldpassword
            // 
            this.oldpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldpassword.Location = new System.Drawing.Point(342, 59);
            this.oldpassword.Name = "oldpassword";
            this.oldpassword.Size = new System.Drawing.Size(237, 26);
            this.oldpassword.TabIndex = 9;
            // 
            // newpassword
            // 
            this.newpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newpassword.Location = new System.Drawing.Point(342, 120);
            this.newpassword.Name = "newpassword";
            this.newpassword.Size = new System.Drawing.Size(237, 26);
            this.newpassword.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(185, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "New Password :";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(194, 59);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(137, 24);
            this.label28.TabIndex = 6;
            this.label28.Text = "Old Password :";
            // 
            // label29
            // 
            this.label29.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(0, 4);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(865, 31);
            this.label29.TabIndex = 6;
            this.label29.Text = "      Password Setting";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(438, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Notice Open Here :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Select a Notice to Open";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.richTextBox1.Location = new System.Drawing.Point(441, 105);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(389, 262);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // noticeData
            // 
            this.noticeData.AllowUserToAddRows = false;
            this.noticeData.AllowUserToDeleteRows = false;
            this.noticeData.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.noticeData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.noticeData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.noticeData.Location = new System.Drawing.Point(28, 105);
            this.noticeData.Name = "noticeData";
            this.noticeData.ReadOnly = true;
            this.noticeData.Size = new System.Drawing.Size(345, 210);
            this.noticeData.TabIndex = 8;
            this.noticeData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.noticeData_CellClick);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(887, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "      Notice";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(50, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(785, 426);
            this.panel2.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.finalMcqMarkLbl);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.finalWrittenMarkLbl);
            this.panel5.Controls.Add(this.label16);
            this.panel5.Controls.Add(this.finalTotalMarkLbl);
            this.panel5.Controls.Add(this.label18);
            this.panel5.Location = new System.Drawing.Point(14, 276);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(754, 136);
            this.panel5.TabIndex = 1;
            // 
            // finalMcqMarkLbl
            // 
            this.finalMcqMarkLbl.AutoSize = true;
            this.finalMcqMarkLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalMcqMarkLbl.Location = new System.Drawing.Point(650, 87);
            this.finalMcqMarkLbl.Name = "finalMcqMarkLbl";
            this.finalMcqMarkLbl.Size = new System.Drawing.Size(0, 20);
            this.finalMcqMarkLbl.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(19, 84);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(493, 23);
            this.label14.TabIndex = 4;
            this.label14.Text = "MCQ Exam (Total : 40; Pass : 12)";
            // 
            // finalWrittenMarkLbl
            // 
            this.finalWrittenMarkLbl.AutoSize = true;
            this.finalWrittenMarkLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalWrittenMarkLbl.Location = new System.Drawing.Point(650, 51);
            this.finalWrittenMarkLbl.Name = "finalWrittenMarkLbl";
            this.finalWrittenMarkLbl.Size = new System.Drawing.Size(0, 20);
            this.finalWrittenMarkLbl.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(19, 48);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(493, 23);
            this.label16.TabIndex = 2;
            this.label16.Text = "Written Exam (Total : 60; Pass : 20)";
            // 
            // finalTotalMarkLbl
            // 
            this.finalTotalMarkLbl.AutoSize = true;
            this.finalTotalMarkLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalTotalMarkLbl.Location = new System.Drawing.Point(650, 3);
            this.finalTotalMarkLbl.Name = "finalTotalMarkLbl";
            this.finalTotalMarkLbl.Size = new System.Drawing.Size(0, 20);
            this.finalTotalMarkLbl.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label18.Dock = System.Windows.Forms.DockStyle.Top;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(0, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(752, 25);
            this.label18.TabIndex = 0;
            this.label18.Text = "          Final Result ( Total Mark : 100; Passing Mark : 33 )";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.midMcqMarkLbl);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.midWrittenMarkLbl);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.midTotalMarkLbl);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Location = new System.Drawing.Point(14, 115);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(754, 136);
            this.panel4.TabIndex = 1;
            // 
            // midMcqMarkLbl
            // 
            this.midMcqMarkLbl.AutoSize = true;
            this.midMcqMarkLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.midMcqMarkLbl.Location = new System.Drawing.Point(650, 87);
            this.midMcqMarkLbl.Name = "midMcqMarkLbl";
            this.midMcqMarkLbl.Size = new System.Drawing.Size(0, 20);
            this.midMcqMarkLbl.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(19, 84);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(493, 23);
            this.label13.TabIndex = 4;
            this.label13.Text = "MCQ Exam (Total : 40; Pass : 12)";
            // 
            // midWrittenMarkLbl
            // 
            this.midWrittenMarkLbl.AutoSize = true;
            this.midWrittenMarkLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.midWrittenMarkLbl.Location = new System.Drawing.Point(650, 51);
            this.midWrittenMarkLbl.Name = "midWrittenMarkLbl";
            this.midWrittenMarkLbl.Size = new System.Drawing.Size(0, 20);
            this.midWrittenMarkLbl.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(19, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(493, 23);
            this.label11.TabIndex = 2;
            this.label11.Text = "Written Exam (Total : 60; Pass : 20)";
            // 
            // midTotalMarkLbl
            // 
            this.midTotalMarkLbl.AutoSize = true;
            this.midTotalMarkLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.midTotalMarkLbl.Location = new System.Drawing.Point(650, 3);
            this.midTotalMarkLbl.Name = "midTotalMarkLbl";
            this.midTotalMarkLbl.Size = new System.Drawing.Size(0, 20);
            this.midTotalMarkLbl.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(752, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "          Midterm Result ( Total Mark : 100; Passing Mark : 33 )";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.fullMarkLbl);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.courseNameLbl);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(783, 100);
            this.panel3.TabIndex = 0;
            // 
            // fullMarkLbl
            // 
            this.fullMarkLbl.AutoSize = true;
            this.fullMarkLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullMarkLbl.Location = new System.Drawing.Point(664, 51);
            this.fullMarkLbl.Name = "fullMarkLbl";
            this.fullMarkLbl.Size = new System.Drawing.Size(0, 20);
            this.fullMarkLbl.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Total Mark : 100; Passing Mark : 33";
            // 
            // courseNameLbl
            // 
            this.courseNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseNameLbl.Location = new System.Drawing.Point(34, 0);
            this.courseNameLbl.Name = "courseNameLbl";
            this.courseNameLbl.Size = new System.Drawing.Size(480, 23);
            this.courseNameLbl.TabIndex = 0;
            // 
            // coursesComboBox
            // 
            this.coursesComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursesComboBox.FormattingEnabled = true;
            this.coursesComboBox.Items.AddRange(new object[] {
            "Bangla",
            "English",
            "Math",
            "Physics"});
            this.coursesComboBox.Location = new System.Drawing.Point(142, 43);
            this.coursesComboBox.Name = "coursesComboBox";
            this.coursesComboBox.Size = new System.Drawing.Size(422, 28);
            this.coursesComboBox.Sorted = true;
            this.coursesComboBox.TabIndex = 4;
            this.coursesComboBox.Text = "Select Course";
            this.coursesComboBox.SelectedIndexChanged += new System.EventHandler(this.coursesComboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(46, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "Courses :";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(874, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "        Courses And Results";
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 619);
            this.Controls.Add(this.coursePanel);
            this.Controls.Add(this.panel1);
            this.Name = "StudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesResult)).EndInit();
            this.coursePanel.ResumeLayout(false);
            this.coursePanel.PerformLayout();
            this.noticePanel.ResumeLayout(false);
            this.noticePanel.PerformLayout();
            this.passwordPanel.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noticeData)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox notice;
        private System.Windows.Forms.PictureBox coursesResult;
        private System.Windows.Forms.Panel coursePanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label courseNameLbl;
        private System.Windows.Forms.ComboBox coursesComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label midTotalMarkLbl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label finalMcqMarkLbl;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label finalWrittenMarkLbl;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label finalTotalMarkLbl;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label midMcqMarkLbl;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label midWrittenMarkLbl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label fullMarkLbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox settings;
        private System.Windows.Forms.PictureBox logoPicBox;
        private System.Windows.Forms.Panel noticePanel;
        private System.Windows.Forms.Panel passwordPanel;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox oldpassword;
        private System.Windows.Forms.TextBox newpassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataGridView noticeData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}