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
    public partial class StudentForm : Form
    {
        string uid, pass;
        LoginForm lo;
        public StudentForm(string i,string p,LoginForm l)
        {
            uid = i; pass = p;
            lo = l;
            InitializeComponent();

            this.FormClosing += new FormClosingEventHandler(this.AdminForm_FormClosing);

            coursePanel.Visible = false;
            noticePanel.Visible = false;
            passwordPanel.Visible = false;

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

        private void coursesResult_Click(object sender, EventArgs e)
        {
            coursePanel.Visible = true;

            coursePanel.BringToFront();

            noticePanel.Visible = false;
            passwordPanel.Visible = false;

        }

        private void library_Click(object sender, EventArgs e)
        {
            coursePanel.Visible = true;
            noticePanel.Visible = false;
            passwordPanel.Visible = false;
        }

        private void notice_Click(object sender, EventArgs e)
        {
            Teacher t = new Teacher();
            Student s = new Student();
            noticeData.DataSource = t.GetNoticeList(s.GetClassName(uid),s.GetDepartment(uid));
            coursePanel.Visible = true;
            noticePanel.Visible = true;

            noticePanel.BringToFront();
            passwordPanel.Visible = false;

        }

        private void settings_Click(object sender, EventArgs e)
        {
            coursePanel.Visible = true;
            noticePanel.Visible = true;
            passwordPanel.Visible = true;
            passwordPanel.BringToFront();

        }


        /// Working On Mouse in Picture Box

        private void coursesResult_MouseHover(object sender, EventArgs e)
        {
            coursesResult.BorderStyle = BorderStyle.FixedSingle;
            coursesResult.BackColor = Color.White;
        }

        private void coursesResult_MouseLeave(object sender, EventArgs e)
        {
            coursesResult.BorderStyle = BorderStyle.FixedSingle;
            coursesResult.BackColor = Color.Silver;
        }


        private void notice_MouseHover(object sender, EventArgs e)
        {
            notice.BorderStyle = BorderStyle.FixedSingle;
            notice.BackColor = Color.White;
        }

        private void notice_MouseLeave(object sender, EventArgs e)
        {
            notice.BorderStyle = BorderStyle.FixedSingle;
            notice.BackColor = Color.Silver;
        }


        private void coursesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            courseNameLbl.Text = coursesComboBox.Text;
            Exam ex = new Exam();
            midWrittenMarkLbl.Text = ex.GetMidWrittenMark(uid, coursesComboBox.Text);
            midMcqMarkLbl.Text = ex.GetMidMcqMark(uid, coursesComboBox.Text);
            finalWrittenMarkLbl.Text = ex.GetFinalWrittenMark(uid, coursesComboBox.Text);
            finalMcqMarkLbl.Text = ex.GetFinalMcqMark(uid, coursesComboBox.Text);

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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void logoPicBox_Click(object sender, EventArgs e)
        {
            coursePanel.Visible = false;
            noticePanel.Visible = false;
            passwordPanel.Visible = false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Student ad = new Student();

            if (ad.CheckUser(uid,oldpassword.Text))
            {
                if (newpassword.Text != "")
                {
                    ad.UpdatePassword(uid,newpassword.Text);
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
            passwordPanel.Visible = false;
        }

        private void noticeData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            richTextBox1.Text = noticeData.CurrentRow.Cells[2].Value.ToString();
        }


       
    }
}
