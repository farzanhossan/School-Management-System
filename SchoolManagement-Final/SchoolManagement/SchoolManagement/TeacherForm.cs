using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace SchoolManagement
{
    public partial class TeacherForm : Form
    {
        string uid, pass;
        LoginForm lo;
        public TeacherForm(string uid,string pass,LoginForm l)
        {
            lo = l;
            this.uid = uid; this.pass = pass;
            InitializeComponent();

            this.FormClosing += new FormClosingEventHandler(this.AdminForm_FormClosing);

            coursePanel.Visible = false;
            noticePanel.Visible = false;
            settingsPanel.Visible = false;

        }

          
        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                dynamic mboxResult = MessageBox.Show("Are you sure you want to exit?", "School Management System", MessageBoxButtons.YesNo);
                if (mboxResult == DialogResult.No)
                {
                    e.Cancel = true;
                }

                else if (mboxResult == DialogResult.Yes)
                {
                    e.Cancel = false;
                    lo.Show();
                }
            }
        }

        private void coursePicBox_Click(object sender, EventArgs e)
        {
            Teacher t = new Teacher();
            string[] sss = t.GetClasses(uid);
            foreach (string s in sss)
            {
                if (s != null) { classComboBox.Items.Add(s); }
            }
            coursePanel.Visible = true;

            coursePanel.BringToFront();

            noticePanel.Visible = false;
            settingsPanel.Visible = false;
        }

        private void libPicBox_Click(object sender, EventArgs e)
        {
            coursePanel.Visible = true;


            noticePanel.Visible = false;
            settingsPanel.Visible = false;
        }

        private void noticePicBox_Click(object sender, EventArgs e)
        {
            Teacher t = new Teacher();
            string[] sss = t.GetClasses(uid);
            foreach (string s in sss) { if (s != null) { noticeClass.Items.Add(s); } }
            noticeData.DataSource = t.GetNoticeList(uid);
            coursePanel.Visible = true;
            noticePanel.Visible = true;

            noticePanel.BringToFront();

            settingsPanel.Visible = false;
        }


        private void settings_Click(object sender, EventArgs e)
        {
            coursePanel.Visible = true;
            noticePanel.Visible = true;
            settingsPanel.Visible = true;

            settingsPanel.BringToFront();
        }



        /// Working On Mouse in Picture Box

        private void coursePicBox_MouseDown(object sender, MouseEventArgs e)
        {
            coursePicBox.BorderStyle = BorderStyle.Fixed3D;
        }

        private void coursePicBox_MouseUp(object sender, MouseEventArgs e)
        {
            coursePicBox.BorderStyle = BorderStyle.FixedSingle;
        }


        private void noticePicBox_MouseUp(object sender, MouseEventArgs e)
        {
            noticePicBox.BorderStyle = BorderStyle.FixedSingle;
        }

        private void noticePicBox_MouseDown(object sender, MouseEventArgs e)
        {
            noticePicBox.BorderStyle = BorderStyle.Fixed3D;

        }


        private void coursePicBox_MouseHover(object sender, EventArgs e)
        {
            coursePicBox.BorderStyle = BorderStyle.FixedSingle;
            coursePicBox.BackColor = Color.White;
        }

        private void coursePicBox_MouseLeave(object sender, EventArgs e)
        {
            coursePicBox.BorderStyle = BorderStyle.FixedSingle;
            coursePicBox.BackColor = Color.Silver;
        }

        

        

        private void noticePicBox_MouseHover(object sender, EventArgs e)
        {
            noticePicBox.BorderStyle = BorderStyle.FixedSingle;
            noticePicBox.BackColor = Color.White;
        }

        private void noticePicBox_MouseLeave(object sender, EventArgs e)
        {
            noticePicBox.BorderStyle = BorderStyle.FixedSingle;
            noticePicBox.BackColor = Color.Silver;
        }


        private void settings_MouseHover(object sender, EventArgs e)
        {
            settings.BorderStyle = BorderStyle.FixedSingle;
            settings.BackColor = Color.White;
        }

        private void settings_MouseLeave(object sender, EventArgs e)
        {
            settings.BorderStyle = BorderStyle.FixedSingle;
            settings.BackColor = Color.Silver;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        #region Notice

        private void noticeSend_Click(object sender, EventArgs e)
        {
            Teacher t = new Teacher();
            t.AddNotice(noticeClass.Text, noticeDept.Text, noticeTextBox.Text,uid);
            MessageBox.Show("New Notice Sent.");
            noticeTextBox.Text = noticeClass.Text = noticeDept.Text = "";
            noticeData.DataSource = t.GetNoticeList(uid);
        }

        int noticeId;
        private void noticeData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            noticeId = Convert.ToInt32(noticeData.CurrentRow.Cells[3].Value.ToString());
            noticeClass.Text = noticeData.CurrentRow.Cells[0].Value.ToString();
            noticeDept.Text = noticeData.CurrentRow.Cells[1].Value.ToString();
            noticeTextBox.Text = noticeData.CurrentRow.Cells[2].Value.ToString();
        }

        private void noticeUpdate_Click(object sender, EventArgs e)
        {
            Teacher t = new Teacher();
            t.UpdateNotice(noticeClass.Text, noticeDept.Text, noticeTextBox.Text, noticeId);
            MessageBox.Show(" Notice Updated.");
            noticeTextBox.Text = noticeClass.Text = noticeDept.Text = "";
            noticeData.DataSource = t.GetNoticeList(uid);
        }

        private void noticeDelete_Click(object sender, EventArgs e)
        {
            Teacher t = new Teacher();
            t.DeleteNotice(noticeId);
            MessageBox.Show(" Notice Deleted.");
            noticeTextBox.Text = noticeClass.Text = noticeDept.Text = "";
            noticeData.DataSource = t.GetNoticeList(uid);
        }
        #endregion

        private void resultOK_Click(object sender, EventArgs e)
        {
            Teacher t = new Teacher();
            Exam ex = new Exam();
            string[] sss = ex.GetStudentsByClass(classComboBox.Text, t.GetDepartment(uid));
            foreach (string s in sss)
            {
                if (s != null) { rollComboBox.Items.Add(s); }
            }
            //rollComboBox.SelectedIndex = 0;
        }

        string stuId;
        private void rollComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            stuId = rollComboBox.Text;
            Student s = new Student();
            stuName.Text = s.GetName(stuId);
            Exam ex = new Exam();
            marksData.DataSource = ex.GetMidMarksList(stuId);
            try
            {
                writtenExamText.Text = marksData.Rows[0].Cells[0].Value.ToString();
                mcqExamText.Text = marksData.Rows[0].Cells[1].Value.ToString();
            }
            catch(Exception ec)
            {
                writtenExamText.Text =
                mcqExamText.Text = "";
            }
            

            try
            {
                finalWrittenExamText.Text = marksData2.Rows[0].Cells[0].Value.ToString();
                finalMcqExamText.Text = marksData2.Rows[0].Cells[1].Value.ToString();
            }
            catch (Exception ec)
            {
                finalWrittenExamText.Text =
                finalMcqExamText.Text = "";
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Teacher ad = new Teacher();

            if (ad.CheckUser(uid, oldpassword.Text))
            {
                if (newpassword.Text != "")
                {
                    ad.UpdatePassword(uid, newpassword.Text);
                    MessageBox.Show("Password Changed Successfully.");
                    newpassword.Text = oldpassword.Text = "";
                }
                else
                {
                    MessageBox.Show("Fill the New Password Field");
                }

            }
            else
            {
                MessageBox.Show("Failed...Old Password Didn't Match.");
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            coursePanel.Visible = false;
            noticePanel.Visible = false;
            settingsPanel.Visible = false;
        }

        private void logoPicBox_Click(object sender, EventArgs e)
        {
            coursePanel.Visible = false;
            noticePanel.Visible = false;
            settingsPanel.Visible = false;
        }

        private void saveCourseBtn_Click(object sender, EventArgs e)
        {
            float mw, mm, fw, fm;
            if (writtenExamText.Text == "") { mw = 0f; } else { mw = float.Parse(writtenExamText.Text); }
            if (mcqExamText.Text == "") { mm = 0f; } else { mm = float.Parse(mcqExamText.Text); }
            if (finalWrittenExamText.Text == "") { fw = 0f; } else { fw = float.Parse(finalWrittenExamText.Text); }
            if (finalMcqExamText.Text == "") { fm = 0f; } else { fm = float.Parse(finalMcqExamText.Text); }
            Exam ex = new Exam();
            Teacher t = new Teacher();
            ex.UploadMarks(stuId,t.GetSubject(uid), mw, mm, fw, fm);
            MessageBox.Show("Marks Uploaded.");
          
            writtenExamText.Text = mcqExamText.Text = finalMcqExamText.Text = finalWrittenExamText.Text = "";
        }



    }
}
