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
using System.Net;
using System.Net.Mail;

namespace SchoolManagement
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            forgetPanel.Visible = false;
            loginPanel.Visible = false;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clickBtn_Click(object sender, EventArgs e)
        {
            lid.Text = lpassword.Text = "";

            loginPanel.Visible = false;

            forgetPanel.BringToFront();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            forgotID.Text = "";
            loginPanel.Visible = true;
            loginPanel.BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            forgetPanel.Visible = true;
            loginPanel.Visible = true;

            loginPanel.BringToFront();

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (lid.Text.Contains("A-"))
            {
                Admin a = new Admin();


                if (a.CheckUser(lid.Text, lpassword.Text))
                {
                    AdminForm af = new AdminForm(lid.Text, lpassword.Text, this);
                    af.Show();
                    this.Hide();
                    lid.Text = lpassword.Text = "";
                }
                else
                {
                    MessageBox.Show("wrong user id or password");
                }

            }

            else if (lid.Text.Contains("S-"))
            {
                Student stu = new Student();
                if (stu.CheckUser(lid.Text, lpassword.Text))
                {
                    StudentForm s = new StudentForm(lid.Text,lpassword.Text,this);
                    s.Show();
                    this.Hide();
                    lid.Text = lpassword.Text = "";
                }
                else
                {
                    MessageBox.Show("wrong user id or password");
                }

            }

            else if (lid.Text.Contains("T-"))
            {
                Teacher t = new Teacher();
                if (t.CheckUser(lid.Text, lpassword.Text))
                {
                    TeacherForm s = new TeacherForm(lid.Text, lpassword.Text,this);
                    s.Show();
                    this.Hide();
                    lid.Text = lpassword.Text = "";
                }
                else
                {
                    MessageBox.Show("wrong user id or password");
                }

            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (forgotID.Text.Contains("A-"))
            {
                try
                {
                    Admin s = new Admin();
                    if (s.CheckUser(forgotID.Text))
                    {
                        var client = new SmtpClient("smtp.gmail.com", 587)
                        {
                            Credentials = new NetworkCredential("earnstationshaikat4@gmail.com", "Sh@ikat96"),
                            EnableSsl = true
                        };
                        Random r = new Random();
                        string p = r.Next(1000, 10000).ToString();
                        s.UpdatePassword(forgotID.Text, p);
                        client.Send("earnstationshaikat4@gmail.com", s.GetEmail(forgotID.Text), "New Password",
                                    "Your New Password is : " + p + "\nNow You Can Login to your System with New Password.");
                        MessageBox.Show("A new Password is sent to your e-mail address. \nCheck Mail and Login");
                    }
                }
                catch (Exception ec) { MessageBox.Show("Error."); }
            }

            else if (forgotID.Text.Contains("T-"))
            {
                try
                {
                    Teacher s = new Teacher();
                    if (s.CheckUser(forgotID.Text))
                    {
                        var client = new SmtpClient("smtp.gmail.com", 587)
                        {
                            Credentials = new NetworkCredential("earnstationshaikat4@gmail.com", "Sh@ikat96"),
                            EnableSsl = true
                        };
                        Random r = new Random();
                        string p = r.Next(1000, 10000).ToString();
                        s.UpdatePassword(forgotID.Text, p);
                        client.Send("earnstationshaikat4@gmail.com", s.GetEmail(forgotID.Text), "New Password",
                                    "Your New Password is : " + p + "\nNow You Can Login to your System with New Password.");
                        MessageBox.Show("A new Password is sent to your e-mail address. \nCheck Mail and Login");
                    }
                }
                catch (Exception ec) { MessageBox.Show("Error."); }
            }
            else if (forgotID.Text.Contains("S-"))
            {
                try
                {
                    Student t = new Student();
                    if (t.CheckUser(forgotID.Text))
                    {
                        var client = new SmtpClient("smtp.gmail.com", 587)
                        {
                            Credentials = new NetworkCredential("earnstationshaikat4@gmail.com", "Sh@ikat96"),
                            EnableSsl = true
                        };
                        Random r = new Random();
                        string p = r.Next(1000, 10000).ToString();
                        t.UpdatePassword(forgotID.Text, p);
                        client.Send("earnstationshaikat4@gmail.com", t.GetEmail(forgotID.Text), "New Password",
                                    "Your New Password is : " + p + "\nNow You Can Login to your System with New Password.");
                        MessageBox.Show("A new Password is sent to your e-mail address. \nCheck Mail and Login");
                    }
                }
                catch (Exception ec) { MessageBox.Show("Error."); }
            }

            else
            {
                MessageBox.Show("Error 2");
            }
        }
    }
}
