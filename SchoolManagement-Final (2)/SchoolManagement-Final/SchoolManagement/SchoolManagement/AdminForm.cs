using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace SchoolManagement
{
    public partial class AdminForm : Form
    {
        private static int studentBtnCounter = 0;
        private static int teacherBtnCounter = 0;
        private static int stuffBtnCounter = 0;
        private static int examBtnCounter = 0;

        List<Panel> studentPanelList = new List<Panel>();
        string uid, pass;
        LoginForm lo;
        public AdminForm(string i, string p, LoginForm l)
        {
            uid = i; pass = p;
            lo = l;

            InitializeComponent();

            this.FormClosing += new FormClosingEventHandler(this.AdminForm_FormClosing);

            //Student Button
            showStudentBtn.Visible = false;
            deleteStudentBtn.Visible = false;
            updateStudentBtn.Visible = false;
            insertStudentBtn.Visible = false;

            //Student Panel
            studentInsertPanel.Visible = false;
            stUpPanel.Visible = false;
            stDeletePanel.Visible = false;
            stShowPanel.Visible = false;


            //Teacher Button
            showTeacherBtn.Visible = false;
            deleteTeacherBtn.Visible = false;
            updateTeacherBtn.Visible = false;
            insertTeacherBtn.Visible = false;

            //Teacher Panel
            tInsertPanel.Visible = false;
            tUpdatePanel.Visible = false;
            td7.Visible = false;
            tShowPanel.Visible = false;

            // Stuff Button
            insertStuffbtn.Visible = false;
            updateStuffBtn.Visible = false;
            deleteStuffBtn.Visible = false;
            showStuffBtn.Visible = false;

            // Stuff Panel
            stuffInsertPanel.Visible = false;
            stuffUpPanel.Visible = false;
            stuffDeletePanel.Visible = false;
            stuffShowPanel.Visible = false;

            // Exam Button
            midButton.Visible = false;
            finalButton.Visible = false;

            //Exam Panel
            midPanel.Visible = false;
            finalPanel.Visible = false;

            settingPanel.Visible = false;

            searchPanel.Visible = true;

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

        private void AdminForm_Load(object sender, EventArgs e)
        {
            studentPanelList.Add(studentInsertPanel);
            studentPanelList.Add(stUpPanel);
            studentPanelList.Add(stDeletePanel);
            studentPanelList.Add(stShowPanel);
        }

        private void studentButton_Click(object sender, EventArgs e)
        {
            if (studentBtnCounter == 0)
            {
                insertStudentBtn.Visible=true;
                updateStudentBtn.Visible = true;
                deleteStudentBtn.Visible = true;
                showStudentBtn.Visible = true;
                studentBtnCounter = 1;
            }

            else
            {
                showStudentBtn.Visible = false;
                deleteStudentBtn.Visible = false;
                updateStudentBtn.Visible = false;
                insertStudentBtn.Visible = false;
                studentBtnCounter = 0;
            }

            //Student Panel
            studentInsertPanel.Visible = false;
            stUpPanel.Visible = false;
            stDeletePanel.Visible = false;
            stShowPanel.Visible = false;


            //teacher
            showTeacherBtn.Visible = false;
            deleteTeacherBtn.Visible = false;
            updateTeacherBtn.Visible = false;
            insertTeacherBtn.Visible = false;
            teacherBtnCounter = 0;

            //Stuff
            insertStuffbtn.Visible = false;
            updateStuffBtn.Visible = false;
            deleteStuffBtn.Visible = false;
            showStuffBtn.Visible = false;
            stuffBtnCounter = 0;

            //Exam
            midButton.Visible = false;
            finalButton.Visible = false;

            examBtnCounter = 0;

        }

        private void teacherButton_Click(object sender, EventArgs e)
        {
            if (teacherBtnCounter == 0)
            {
                insertTeacherBtn.Visible = true;
                updateTeacherBtn.Visible = true;
                deleteTeacherBtn.Visible = true;
                showTeacherBtn.Visible = true;
                teacherBtnCounter = 1;
            }

            else
            {
                showTeacherBtn.Visible = false;
                deleteTeacherBtn.Visible = false;
                updateTeacherBtn.Visible = false;
                insertTeacherBtn.Visible = false;
                teacherBtnCounter = 0;
            }

            //student
            showStudentBtn.Visible = false;
            deleteStudentBtn.Visible = false;
            updateStudentBtn.Visible = false;
            insertStudentBtn.Visible = false;
            studentBtnCounter = 0;

            //Student Panel
            studentInsertPanel.Visible = false;
            stUpPanel.Visible = false;
            stDeletePanel.Visible = false;
            stShowPanel.Visible = false;


            // Stuff
            insertStuffbtn.Visible = false;
            updateStuffBtn.Visible = false;
            deleteStuffBtn.Visible = false;
            showStuffBtn.Visible = false;
            studentBtnCounter = 0;

            //Exam
            midButton.Visible = false;
            finalButton.Visible = false;

            examBtnCounter = 0;

        }

        private void stuffButton_Click(object sender, EventArgs e)
        {
            if (stuffBtnCounter == 0)
            {
                insertStuffbtn.Visible = true;
                updateStuffBtn.Visible = true;
                deleteStuffBtn.Visible = true;
                showStuffBtn.Visible = true;
                stuffBtnCounter = 1;
            }
            else
            {
                insertStuffbtn.Visible = false;
                updateStuffBtn.Visible = false;
                deleteStuffBtn.Visible = false;
                showStuffBtn.Visible = false;
                stuffBtnCounter = 0;
            }

            //Student 
            showStudentBtn.Visible = false;
            deleteStudentBtn.Visible = false;
            updateStudentBtn.Visible = false;
            insertStudentBtn.Visible = false;
            studentBtnCounter = 0;

            //Student Panel
            studentInsertPanel.Visible = false;
            stUpPanel.Visible = false;
            stDeletePanel.Visible = false;
            stShowPanel.Visible = false;


            //teacher
            showTeacherBtn.Visible = false;
            deleteTeacherBtn.Visible = false;
            updateTeacherBtn.Visible = false;
            insertTeacherBtn.Visible = false;

            // Exam
            midButton.Visible = false;
            finalButton.Visible = false;

            examBtnCounter = 0;


            teacherBtnCounter = 0;

        }

        private void examButton_Click(object sender, EventArgs e)
        {
            if(examBtnCounter==0)
            {
                midButton.Visible = true;
                finalButton.Visible = true;
                examBtnCounter = 1;
            }
            else
            {
                midButton.Visible = false;
                finalButton.Visible = false;
                examBtnCounter = 0;
            }

            //student
            showStudentBtn.Visible = false;
            deleteStudentBtn.Visible = false;
            updateStudentBtn.Visible = false;
            insertStudentBtn.Visible = false;
            studentBtnCounter = 0;

            //Student Panel
            studentInsertPanel.Visible = false;
            stUpPanel.Visible = false;
            stDeletePanel.Visible = false;
            stShowPanel.Visible = false;


            // Stuff
            insertStuffbtn.Visible = false;
            updateStuffBtn.Visible = false;
            deleteStuffBtn.Visible = false;
            showStuffBtn.Visible = false;
            studentBtnCounter = 0;

            //teacher
            showTeacherBtn.Visible = false;
            deleteTeacherBtn.Visible = false;
            updateTeacherBtn.Visible = false;
            insertTeacherBtn.Visible = false;
            teacherBtnCounter = 0;

        }

        /// Student Button With Panel

        private void insertStudentBtn_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            stdIdtxt.Text = "S-" + (s.GetLastID() + 1).ToString();

            firstnameTxt.Text = lastNameTxt.Text = classTxt.Text =
            rollTxt.Text = programTxt.Text = fatherTxt.Text = motherTxt.Text = dobTxt.Text = bloodTxt.Text = mobileTxt.Text =
            emailTxt.Text = addressTxt.Text = passwordTxt.Text = "";
            stdPicBox.Image = null;

            studentInsertPanel.Visible = true;

            studentPanelList[0].BringToFront();

            stUpPanel.Visible = false;
            stDeletePanel.Visible = false;
            stShowPanel.Visible = false;

            tInsertPanel.Visible = false; //
            tUpdatePanel.Visible = false; //   Teacher Panel
            td7.Visible = false; //
            tShowPanel.Visible = false;   //

            stuffInsertPanel.Visible = false; //
            stuffUpPanel.Visible = false;     //  Stuff Panel
            stuffDeletePanel.Visible = false;  //
            stuffShowPanel.Visible = false;    //
            settingPanel.Visible = false;
            searchPanel.Visible = false;

            midPanel.Visible = false;
            finalPanel.Visible = false;

        }

        private void updateStudentBtn_Click(object sender, EventArgs e)
        {
            suId.Text=suFirstname.Text = suLastname.Text = suClass.Text =
             suRoll.Text = suProgram.Text = suFather.Text = suMother.Text = suDob.Text = suBlood.Text = suMobile.Text =
             suEmail.Text = suAddress.Text = suPassword.Text = "";
            suImage.Image = null;

            stUpPanel.Visible = true;
            studentInsertPanel.Visible = true;

            studentPanelList[1].BringToFront();

            stDeletePanel.Visible = false;
            stShowPanel.Visible = false;

            tInsertPanel.Visible = false; //
            tUpdatePanel.Visible = false; //   Teacher Panel
            td7.Visible = false; //
            tShowPanel.Visible = false;   //

            stuffInsertPanel.Visible = false; //
            stuffUpPanel.Visible = false;     //  Stuff Panel
            stuffDeletePanel.Visible = false;  //
            stuffShowPanel.Visible = false;    //
            settingPanel.Visible = false;
            searchPanel.Visible = false;

            midPanel.Visible = false;
            finalPanel.Visible = false;

        }

        private void deleteStudentBtn_Click(object sender, EventArgs e)
        {
            sdId.Text = sdFirstname.Text = sdLastname.Text = sdClass.Text = sdRoll.Text = sdProgram.Text = sdFather.Text = sdMother.Text = sdDob.Text =
                sdBlood.Text = sdMobile.Text = sdEmail.Text = sdAddress.Text = "";
            sdImage.Image = null;

            stDeletePanel.Visible = true;
            studentInsertPanel.Visible = true;
            stUpPanel.Visible = true;

            studentPanelList[2].BringToFront();
            stShowPanel.Visible = false;

            tInsertPanel.Visible = false; //
            tUpdatePanel.Visible = false; //   Teacher Panel
            td7.Visible = false; //
            tShowPanel.Visible = false;   //

            stuffInsertPanel.Visible = false; //
            stuffUpPanel.Visible = false;     //  Stuff Panel
            stuffDeletePanel.Visible = false;  //
            stuffShowPanel.Visible = false;    //

            settingPanel.Visible = false;
            searchPanel.Visible = false;

            midPanel.Visible = false;
            finalPanel.Visible = false;

        }

        private void showStudentBtn_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            stdShowdataGridView.DataSource = s.ShowDetails();

            stShowPanel.Visible = true;
            studentInsertPanel.Visible = true;
            stUpPanel.Visible = true;
            stDeletePanel.Visible = true;

            studentPanelList[3].BringToFront();

            tInsertPanel.Visible = false; //
            tUpdatePanel.Visible = false; //   Teacher Panel
            td7.Visible = false; //
            tShowPanel.Visible = false;   //

            stuffInsertPanel.Visible = false; //
            stuffUpPanel.Visible = false;     //  Stuff Panel
            stuffDeletePanel.Visible = false;  //
            stuffShowPanel.Visible = false;    //
            settingPanel.Visible = false;
            searchPanel.Visible = false;

            midPanel.Visible = false;
            finalPanel.Visible = false;

        }

        /// Teacher Button With Panel

        private void insertTeacherBtn_Click(object sender, EventArgs e)
        {
            Teacher t = new Teacher();
            tiId.Text = "T-" + (t.GetLastID() + 1).ToString();

            tiImage.Image = null;
            tiFirstname.Text = tiLastname.Text = tiDob.Text = tiCurrentadd.Text = tiPermenentadd.Text = tiNationality.Text =
            tiMarital.Text = tiReligion.Text = tiBlood.Text = tiSalary.Text = tiEmail.Text = tiMobile.Text = tiPassword.Text =
            tiSSC.Text = tiHSC.Text = tiUndergraduate.Text = tiDept.Text = tiSubject.Text = tiGraduate.Text = "";
            ti6.Checked = ti7.Checked = ti8.Checked = ti9.Checked = ti10.Checked = false;

            stShowPanel.Visible = true;         //
            studentInsertPanel.Visible = true;  // Student Panel
            stUpPanel.Visible = true;           //
            stDeletePanel.Visible = true;       //


            tInsertPanel.Visible = true;

            tInsertPanel.BringToFront();

            tUpdatePanel.Visible = false;
            td7.Visible = false;
            tShowPanel.Visible = false;

            stuffInsertPanel.Visible = false; //
            stuffUpPanel.Visible = false;     //  Stuff Panel
            stuffDeletePanel.Visible = false;  //
            stuffShowPanel.Visible = false;    //

            settingPanel.Visible = false;
            searchPanel.Visible = false;

            midPanel.Visible = false;
            finalPanel.Visible = false;
        }

        private void updateTeacherBtn_Click(object sender, EventArgs e)
        {
            tuImage.Image = null;
            tuId.Text=tuFirstname.Text = tuLastname.Text = tuDob.Text = tuCurrentadd.Text = tuPermanentadd.Text = tuNationality.Text =
            tuMarital.Text = tuReligion.Text = tuBlood.Text = tuSalary.Text = tuEmail.Text = tuMobile.Text = tuPassword.Text =
            tuSSC.Text = tuHSC.Text = tuUndergraduate.Text = tuSubject.Text = tuDept.Text = tuGraduate.Text = "";
            tu6.Checked = tu7.Checked = tu8.Checked = tu9.Checked = tu10.Checked = false;

            stShowPanel.Visible = true;         //
            studentInsertPanel.Visible = true;  // Student Panel
            stUpPanel.Visible = true;           //
            stDeletePanel.Visible = true;       //

            tInsertPanel.Visible = true;
            tUpdatePanel.Visible = true;

            tUpdatePanel.BringToFront();

            td7.Visible = false;
            tShowPanel.Visible = false;

            stuffInsertPanel.Visible = false; //
            stuffUpPanel.Visible = false;     //  Stuff Panel
            stuffDeletePanel.Visible = false;  //
            stuffShowPanel.Visible = false;    //
            settingPanel.Visible = false;
            searchPanel.Visible = false;

            midPanel.Visible = false;
            finalPanel.Visible = false;
        }

        private void deleteTeacherBtn_Click(object sender, EventArgs e)
        {
                 tdFirstname.Text =
                 tdLastname.Text =
                 tdDob.Text =
                 tdCurrentadd.Text =
                 tdPermanentadd.Text =
                 tdNationality.Text =
                 tdMarital.Text =
                 tdReligion.Text =
                 tdBlood.Text =
                 tdSalary.Text =
                 tdEmail.Text =
                 tdDept.Text =
                 tdMobile.Text =
                 tdSSC.Text =
                 tdHSC.Text =
                 tdUndergraduate.Text =
                 tdGraduate.Text =
                 tdSubject.Text = "";
                 tdId.Text = "";
                 tdImage.Image = null;
                 td6.Checked = td_7.Checked = td8.Checked = td9.Checked = td10.Checked = false;


            stShowPanel.Visible = true;         //
            studentInsertPanel.Visible = true;  // Student Panel
            stUpPanel.Visible = true;           //
            stDeletePanel.Visible = true;       //

            tInsertPanel.Visible = true;
            tUpdatePanel.Visible = true;
            td7.Visible = true;

            td7.BringToFront();

            tShowPanel.Visible = false;

            stuffInsertPanel.Visible = false; //
            stuffUpPanel.Visible = false;     //  Stuff Panel
            stuffDeletePanel.Visible = false;  //
            stuffShowPanel.Visible = false;    //
            settingPanel.Visible = false;
            searchPanel.Visible = false;

            midPanel.Visible = false;
            finalPanel.Visible = false;
        }

        private void showTeacherBtn_Click(object sender, EventArgs e)
        {
            Teacher t = new Teacher();
            tShowData.DataSource = t.ShowDetails();
            stShowPanel.Visible = true;         //
            studentInsertPanel.Visible = true;  // Student Panel
            stUpPanel.Visible = true;           //
            stDeletePanel.Visible = true;       //

            tInsertPanel.Visible = true;
            tUpdatePanel.Visible = true;
            td7.Visible = true;
            tShowPanel.Visible = true;

            tShowPanel.BringToFront();

            stuffInsertPanel.Visible = false; //
            stuffUpPanel.Visible = false;     //  Stuff Panel
            stuffDeletePanel.Visible = false;  //
            stuffShowPanel.Visible = false;    //
            settingPanel.Visible = false;
            searchPanel.Visible = false;

            midPanel.Visible = false;
            finalPanel.Visible = false;
        }

        ///Stuff Button With Panel
        private void insertStuffbtn_Click(object sender, EventArgs e)
        {
            Stuff t = new Stuff();
            stiId.Text = "ST-" + (t.GetLastID() + 1).ToString();

            stShowPanel.Visible = true;         //
            studentInsertPanel.Visible = true;  // Student Panel
            stUpPanel.Visible = true;           //
            stDeletePanel.Visible = true;       //

            tInsertPanel.Visible = true;     //
            tUpdatePanel.Visible = true;     // Teacher Panel
            td7.Visible = true;     //
            tShowPanel.Visible = true;       //

            stuffInsertPanel.Visible = true;

            stuffInsertPanel.BringToFront();

            stuffUpPanel.Visible = false;
            stuffDeletePanel.Visible = false;
            stuffShowPanel.Visible = false;
            settingPanel.Visible = false;
            searchPanel.Visible = false;

            midPanel.Visible = false;
            finalPanel.Visible = false;
        }

        private void updateStuffBtn_Click(object sender, EventArgs e)
        {
            stShowPanel.Visible = true;        //
            studentInsertPanel.Visible = true;  // Student Panel
            stUpPanel.Visible = true;           //
            stDeletePanel.Visible = true;       //

            tInsertPanel.Visible = true;     //
            tUpdatePanel.Visible = true;     // Teacher Panel
            td7.Visible = true;     //
            tShowPanel.Visible = true;       //

            stuffInsertPanel.Visible = true;
            stuffUpPanel.Visible = true;

            stuffUpPanel.BringToFront();

            stuffDeletePanel.Visible = false;
            stuffShowPanel.Visible = false;
            settingPanel.Visible = false;
            searchPanel.Visible = false;

            midPanel.Visible = false;
            finalPanel.Visible = false;
        }

        private void deleteStuffBtn_Click(object sender, EventArgs e)
        {
            stShowPanel.Visible = true;        //
            studentInsertPanel.Visible = true;  // Student Panel
            stUpPanel.Visible = true;           //
            stDeletePanel.Visible = true;       //

            tInsertPanel.Visible = true;     //
            tUpdatePanel.Visible = true;     // Teacher Panel
            td7.Visible = true;     //
            tShowPanel.Visible = true;       //

            stuffInsertPanel.Visible = true;
            stuffUpPanel.Visible = true;
            stuffDeletePanel.Visible = true;

            stuffDeletePanel.BringToFront();

            stuffShowPanel.Visible = false;
            settingPanel.Visible = false;
            searchPanel.Visible = false;

            midPanel.Visible = false;
            finalPanel.Visible = false;
        }

        private void showStuffBtn_Click(object sender, EventArgs e)
        {

            //Teacher t = new Teacher();
            //tShowData.DataSource = t.ShowDetails();

            Stuff st = new Stuff();
            stsdataGridView.DataSource = st.ShowDetails();

            studentInsertPanel.Visible = true;  //
            stUpPanel.Visible = true;           // Student Panel
            stDeletePanel.Visible = true;       //
            stShowPanel.Visible = true;        //

            tInsertPanel.Visible = true;     //
            tUpdatePanel.Visible = true;     // Teacher Panel
            td7.Visible = true;     //
            tShowPanel.Visible = true;       //

            stuffInsertPanel.Visible = true;
            stuffUpPanel.Visible = true;
            stuffDeletePanel.Visible = true;
            stuffShowPanel.Visible = true;

            stuffShowPanel.BringToFront();
            settingPanel.Visible = false;
            searchPanel.Visible = false;
            midPanel.Visible = false;
            finalPanel.Visible = false;


        }

        private void settings_Click(object sender, EventArgs e)
        {
            studentInsertPanel.Visible = true;  //
            stUpPanel.Visible = true;           // Student Panel
            stDeletePanel.Visible = true;       //
            stShowPanel.Visible = true;        //

            tInsertPanel.Visible = true;     //
            tUpdatePanel.Visible = true;     // Teacher Panel
            td7.Visible = true;     //
            tShowPanel.Visible = true;       //

            stuffInsertPanel.Visible = true;
            stuffUpPanel.Visible = true;
            stuffDeletePanel.Visible = true;
            stuffShowPanel.Visible = true;
            settingPanel.Visible = true;

            settingPanel.BringToFront();
            searchPanel.Visible = false;

            midPanel.Visible = false;
            finalPanel.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            studentInsertPanel.Visible = true;  //
            stUpPanel.Visible = true;           // Student Panel
            stDeletePanel.Visible = true;       //
            stShowPanel.Visible = true;        //

            tInsertPanel.Visible = true;     //
            tUpdatePanel.Visible = true;     // Teacher Panel
            td7.Visible = true;     //
            tShowPanel.Visible = true;       //

            stuffInsertPanel.Visible = true;
            stuffUpPanel.Visible = true;
            stuffDeletePanel.Visible = true;
            stuffShowPanel.Visible = true;
            settingPanel.Visible = true;
            searchPanel.Visible = true;

            settingPanel.BringToFront();
            midPanel.Visible = false;
            finalPanel.Visible = false;

            ///Main Work
            ///

            if (searchPersonCheck.Text.Contains("S-"))
            {
                Student stu = new Student();
                if (stu.CheckUser(searchPersonCheck.Text))
                {
                    searchPerson.Text = "STUDENT";
                    searchdataGridView1.DataSource = stu.SearchStudent(searchPersonCheck.Text);
                    searchImage.Image = byteArrayToImage(stu.GetPhoto(searchPersonCheck.Text));
                    spFirstname.Text = searchdataGridView1.Rows[0].Cells[1].Value.ToString();
                    spLastname.Text= searchdataGridView1.Rows[0].Cells[2].Value.ToString();
                    spMobile.Text= searchdataGridView1.Rows[0].Cells[10].Value.ToString();
                    spEmail.Text= searchdataGridView1.Rows[0].Cells[11].Value.ToString();
                    spAddress.Text= searchdataGridView1.Rows[0].Cells[12].Value.ToString();


                }
                else
                {
                    MessageBox.Show("Wrong user id.");
                }

            }

            else if (searchPersonCheck.Text.Contains("ST-"))
            {
                Stuff stu = new Stuff();
                if (stu.CheckUser(searchPersonCheck.Text))
                {
                    searchPerson.Text = "STUFF";
                    searchdataGridView1.DataSource = stu.SearchStuff(searchPersonCheck.Text);
                    searchImage.Image = byteArrayToImage(stu.GetPhoto(searchPersonCheck.Text));
                    spFirstname.Text = searchdataGridView1.Rows[0].Cells[1].Value.ToString();
                    spLastname.Text = searchdataGridView1.Rows[0].Cells[2].Value.ToString();
                    spMobile.Text = searchdataGridView1.Rows[0].Cells[12].Value.ToString();
                    spEmail.Text = searchdataGridView1.Rows[0].Cells[11].Value.ToString();
                    spAddress.Text = searchdataGridView1.Rows[0].Cells[4].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Wrong user id.");
                }

            }

            else if (searchPersonCheck.Text.Contains("T-"))
            {
                Teacher stu = new Teacher();
                if (stu.CheckUser(searchPersonCheck.Text))
                {
                    searchPerson.Text = "TEACHER";
                    searchdataGridView1.DataSource = stu.SearchTeacher(searchPersonCheck.Text);
                    searchImage.Image = byteArrayToImage(stu.GetPhoto(searchPersonCheck.Text));
                    spFirstname.Text = searchdataGridView1.Rows[0].Cells[1].Value.ToString();
                    spLastname.Text = searchdataGridView1.Rows[0].Cells[2].Value.ToString();
                    spMobile.Text = searchdataGridView1.Rows[0].Cells[12].Value.ToString();
                    spEmail.Text = searchdataGridView1.Rows[0].Cells[11].Value.ToString();
                    spAddress.Text = searchdataGridView1.Rows[0].Cells[4].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Wrong user id.");
                }

            }




            else
            {
                MessageBox.Show("Invaid Id");
            }





        }

        private void midButton_Click(object sender, EventArgs e)
        {
            Exam ex = new Exam();
            midTermData.DataSource = ex.GetMidList();
            studentInsertPanel.Visible = true;  //
            stUpPanel.Visible = true;           // Student Panel
            stDeletePanel.Visible = true;       //
            stShowPanel.Visible = true;        //

            tInsertPanel.Visible = true;     //
            tUpdatePanel.Visible = true;     // Teacher Panel
            td7.Visible = true;     //
            tShowPanel.Visible = true;       //

            stuffInsertPanel.Visible = true;
            stuffUpPanel.Visible = true;
            stuffDeletePanel.Visible = true;
            stuffShowPanel.Visible = true;
            settingPanel.Visible = true;
            searchPanel.Visible = true;
            midPanel.Visible = true;

            midPanel.BringToFront();
            finalPanel.Visible = false;
        }

        private void finalButton_Click(object sender, EventArgs e)
        {
            Exam ex = new Exam();
            finalTermData.DataSource = ex.GetFinalList();
            studentInsertPanel.Visible = true;  //
            stUpPanel.Visible = true;           // Student Panel
            stDeletePanel.Visible = true;       //
            stShowPanel.Visible = true;        //

            tInsertPanel.Visible = true;     //
            tUpdatePanel.Visible = true;     // Teacher Panel
            td7.Visible = true;     //
            tShowPanel.Visible = true;       //

            stuffInsertPanel.Visible = true;
            stuffUpPanel.Visible = true;
            stuffDeletePanel.Visible = true;
            stuffShowPanel.Visible = true;
            settingPanel.Visible = true;
            searchPanel.Visible = true;
            midPanel.Visible = true;
            finalPanel.Visible = true;

            finalPanel.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
          
        }

        // Image Binary
        public static byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        
        // Student Insert Form
        
        private void stInsertBrowseBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog op = new OpenFileDialog();
                op.Multiselect = false;
                op.Filter = "JPG Files (*.JPG)|*.jpg";
                op.Title = "Select Image";
                if (op.ShowDialog() == DialogResult.OK)
                {
                    stdPicBox.ImageLocation = op.FileName.ToString();
                }
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }

        // Student Insert Save Button
        private void insertStudentSave_Click(object sender, EventArgs e)
        {
            Student st = new Student();
            st.Image = imageToByteArray(stdPicBox.Image);
            st.First_name = firstnameTxt.Text;
            st.Last_name = lastNameTxt.Text;
            st.Class = Convert.ToInt32(classTxt.Text);
            st.Roll = Convert.ToInt32(rollTxt.Text);
            st.Program = programTxt.Text;
            st.Father_name = fatherTxt.Text;
            st.Mother_name = motherTxt.Text;
            st.Dob = dobTxt.Text;
            st.Blood_group = bloodTxt.Text;
            st.Mobile = mobileTxt.Text;
            st.Email = emailTxt.Text;
            st.Address = addressTxt.Text;
            st.Password = passwordTxt.Text;

            st.AddStudent();
            MessageBox.Show("Student Information Inserted Successfully");
            firstnameTxt.Text = lastNameTxt.Text = classTxt.Text =
            rollTxt.Text = programTxt.Text = fatherTxt.Text = motherTxt.Text = dobTxt.Text = bloodTxt.Text = mobileTxt.Text =
            emailTxt.Text = addressTxt.Text = passwordTxt.Text = "";
            stdPicBox.Image = null;
            stdIdtxt.Text = "S-" + (st.GetLastID() + 1).ToString();
        }


        // Student Update Form
        private void stUpSaveBtn_Click(object sender, EventArgs e)
        {
            Student st = new Student();

            st.Image = imageToByteArray(suImage.Image);
            st.First_name = suFirstname.Text;
            st.Last_name = suLastname.Text;
            st.Class = Convert.ToInt32(suClass.Text);
            st.Roll = Convert.ToInt32(suRoll.Text);
            st.Program = suProgram.Text;
            st.Father_name = suFather.Text;
            st.Mother_name = suMother.Text;
            st.Dob = suDob.Text;
            st.Blood_group = suBlood.Text;
            st.Mobile = suMobile.Text;
            st.Email = suEmail.Text;
            st.Address = suAddress.Text;
            st.Password = suPassword.Text;

            st.updateStudent(suId.Text);
            MessageBox.Show("Student Information Updated Successfully");
            suFirstname.Text = suLastname.Text = suClass.Text =
             suRoll.Text = suProgram.Text = suFather.Text = suMother.Text = suDob.Text = suBlood.Text = suMobile.Text =
             suEmail.Text = suAddress.Text = suPassword.Text = "";
            suImage.Image = null;

        }

        private void suBrowseBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog op = new OpenFileDialog();
                op.Multiselect = false;
                op.Filter = "JPG Files (*.JPG)|*.jpg";
                op.Title = "Select Image";
                if (op.ShowDialog() == DialogResult.OK)
                {
                    suImage.ImageLocation = op.FileName.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Delete Form

        private void stDeleteBtn_Click(object sender, EventArgs e)
        {
            if (sdFirstname.Text != "")
            {
                Student st = new Student();
                st.deleteStudent(sdId.Text);

                MessageBox.Show("Student Information Deleted successfully");

                sdId.Text = sdFirstname.Text = sdLastname.Text = sdClass.Text = sdRoll.Text = sdProgram.Text = sdFather.Text = sdMother.Text = sdDob.Text =
                sdBlood.Text = sdMobile.Text = sdEmail.Text = sdAddress.Text = "";
                sdImage.Image = null;
            }
            else { MessageBox.Show("Select a Student Details First."); }


        }

        // Search Button

        private void stSearchBtn_Click(object sender, EventArgs e)
        {

            try
            {
                Student s = new Student();

                StdDeletedataGridView.DataSource = s.SearchStudent(sdId.Text);
                sdFirstname.Text = StdDeletedataGridView.Rows[0].Cells[1].Value.ToString();
                sdLastname.Text = StdDeletedataGridView.Rows[0].Cells[2].Value.ToString();
                sdClass.Text = StdDeletedataGridView.Rows[0].Cells[3].Value.ToString();
                sdRoll.Text = StdDeletedataGridView.Rows[0].Cells[4].Value.ToString();
                sdProgram.Text = StdDeletedataGridView.Rows[0].Cells[5].Value.ToString();
                sdFather.Text = StdDeletedataGridView.Rows[0].Cells[6].Value.ToString();
                sdMother.Text = StdDeletedataGridView.Rows[0].Cells[7].Value.ToString();
                sdDob.Text = StdDeletedataGridView.Rows[0].Cells[8].Value.ToString();
                sdBlood.Text = StdDeletedataGridView.Rows[0].Cells[9].Value.ToString();
                sdMobile.Text = StdDeletedataGridView.Rows[0].Cells[10].Value.ToString();
                sdEmail.Text = StdDeletedataGridView.Rows[0].Cells[11].Value.ToString();
                sdAddress.Text = StdDeletedataGridView.Rows[0].Cells[12].Value.ToString();
                sdImage.Image = byteArrayToImage(s.GetPhoto(sdId.Text));

                

            }
            catch (Exception ec) { MessageBox.Show("Student ID not Found."); }

        }

        private void stUpSearchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Student s = new Student();
                studentUpdateDataGrid.DataSource = s.SearchStudent(suId.Text);
                suFirstname.Text = studentUpdateDataGrid.Rows[0].Cells[1].Value.ToString();
                suLastname.Text = studentUpdateDataGrid.Rows[0].Cells[2].Value.ToString();
                suClass.Text = studentUpdateDataGrid.Rows[0].Cells[3].Value.ToString();
                suRoll.Text = studentUpdateDataGrid.Rows[0].Cells[4].Value.ToString();
                suProgram.Text = studentUpdateDataGrid.Rows[0].Cells[5].Value.ToString();
                suFather.Text = studentUpdateDataGrid.Rows[0].Cells[6].Value.ToString();
                suMother.Text = studentUpdateDataGrid.Rows[0].Cells[7].Value.ToString();
                suDob.Text = studentUpdateDataGrid.Rows[0].Cells[8].Value.ToString();
                suBlood.Text = studentUpdateDataGrid.Rows[0].Cells[9].Value.ToString();
                suMobile.Text = studentUpdateDataGrid.Rows[0].Cells[10].Value.ToString();
                suEmail.Text = studentUpdateDataGrid.Rows[0].Cells[11].Value.ToString();
                suAddress.Text = studentUpdateDataGrid.Rows[0].Cells[12].Value.ToString();
                suPassword.Text = studentUpdateDataGrid.Rows[0].Cells[13].Value.ToString();
                suImage.Image = byteArrayToImage(s.GetPhoto(suId.Text));
                
            }
            catch (Exception ec) { MessageBox.Show("Student ID not Found."); }
        }

        private void tiBrowseBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog op = new OpenFileDialog();
                op.Multiselect = false;
                op.Filter = "JPG Files (*.JPG)|*.jpg";
                op.Title = "Select Image";
                if (op.ShowDialog() == DialogResult.OK)
                {
                    tiImage.ImageLocation = op.FileName.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tiSaveBtn_Click(object sender, EventArgs e)
        {
            Teacher t = new Teacher();
            try
            {
                t.Subject = tiSubject.Text;
                t.IMAGE = imageToByteArray(tiImage.Image);
                t.FirstName = tiFirstname.Text;
                t.LastName = tiLastname.Text;
                t.DOB = tiDob.Text;
                t.CurrentAddress = tiCurrentadd.Text;
                t.PermanentAddress = tiPermenentadd.Text;
                t.Nationality = tiNationality.Text;
                t.Marital = tiMarital.Text;
                t.Religion = tiReligion.Text;
                t.BG = tiBlood.Text;
                t.Salary = float.Parse(tiSalary.Text);
                t.Email = tiEmail.Text;
                t.Department = tiDept.Text;
                t.Phone = tiMobile.Text;
                t.Password = tiPassword.Text;
                t.SSC = float.Parse(tiSSC.Text);
                t.HSC = float.Parse(tiHSC.Text);
                t.UnderGraduate = float.Parse(tiUndergraduate.Text);
                t.Graduate = float.Parse(tiGraduate.Text);
                if (ti6.Checked == true) { t.SIX = 1; } else { t.SIX = 0; }
                if (ti7.Checked == true) { t.SEVEN = 1; } else { t.SEVEN = 0; }
                if (ti8.Checked == true) { t.EIGHT = 1; } else { t.EIGHT = 0; }
                if (ti9.Checked == true) { t.NINE = 1; } else { t.NINE = 0; }
                if (ti10.Checked == true) { t.TEN = 1; } else { t.TEN = 0; }

                t.AddTeacher();
                MessageBox.Show("Teacher Information Inserted Successfully");

                tiImage.Image = null;
                tiFirstname.Text = tiLastname.Text = tiDob.Text = tiCurrentadd.Text = tiPermenentadd.Text = tiNationality.Text =
                tiMarital.Text = tiReligion.Text = tiBlood.Text = tiSalary.Text = tiEmail.Text = tiMobile.Text = tiPassword.Text =
                tiSSC.Text = tiHSC.Text = tiUndergraduate.Text = tiDept.Text = tiSubject.Text = tiGraduate.Text = "";
                ti6.Checked = ti7.Checked = ti8.Checked = ti9.Checked = ti10.Checked = false;

                tiId.Text = "T-" + (t.GetLastID() + 1).ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Fill All the Information");
            }
            

        }

        private void tuSearchBtn_Click(object sender, EventArgs e)
        {
            Teacher t = new Teacher();
            tudataGridView.DataSource = t.SearchTeacher(tuId.Text);
            tUCDataGrid.DataSource = t.getClassList(tuId.Text);

            try
            {
                tuFirstname.Text = tudataGridView.Rows[0].Cells[1].Value.ToString();
                tuLastname.Text = tudataGridView.Rows[0].Cells[2].Value.ToString();
                tuDob.Text = tudataGridView.Rows[0].Cells[3].Value.ToString();
                tuCurrentadd.Text = tudataGridView.Rows[0].Cells[4].Value.ToString();
                tuPermanentadd.Text = tudataGridView.Rows[0].Cells[5].Value.ToString();
                tuNationality.Text = tudataGridView.Rows[0].Cells[6].Value.ToString();
                tuMarital.Text = tudataGridView.Rows[0].Cells[7].Value.ToString();
                tuReligion.Text = tudataGridView.Rows[0].Cells[8].Value.ToString();
                tuBlood.Text = tudataGridView.Rows[0].Cells[9].Value.ToString();
                tuSalary.Text = tudataGridView.Rows[0].Cells[10].Value.ToString();
                tuEmail.Text = tudataGridView.Rows[0].Cells[11].Value.ToString();
                tuMobile.Text = tudataGridView.Rows[0].Cells[12].Value.ToString();
                tuPassword.Text = tudataGridView.Rows[0].Cells[13].Value.ToString();
                tuSSC.Text = tudataGridView.Rows[0].Cells[14].Value.ToString();
                tuHSC.Text = tudataGridView.Rows[0].Cells[15].Value.ToString();
                tuUndergraduate.Text = tudataGridView.Rows[0].Cells[16].Value.ToString();
                tuGraduate.Text = tudataGridView.Rows[0].Cells[17].Value.ToString();
                tuSubject.Text = tudataGridView.Rows[0].Cells[18].Value.ToString();
                tuDept.Text = tudataGridView.Rows[0].Cells[19].Value.ToString();
                if (Convert.ToInt32(tUCDataGrid.Rows[0].Cells[0].Value.ToString()) == 1)
                {
                    tu6.Checked = true;
                }
                else { tu6.Checked = false; }

                if (Convert.ToInt32(tUCDataGrid.Rows[0].Cells[1].Value.ToString()) == 1)
                {
                    tu7.Checked = true;
                }
                else { tu7.Checked = false; }

                if (Convert.ToInt32(tUCDataGrid.Rows[0].Cells[2].Value.ToString()) == 1)
                {
                    tu8.Checked = true;
                }
                else { tu8.Checked = false; }
                if (Convert.ToInt32(tUCDataGrid.Rows[0].Cells[3].Value.ToString()) == 1)
                {
                    tu9.Checked = true;
                }
                else { tu9.Checked = false; }
                if (Convert.ToInt32(tUCDataGrid.Rows[0].Cells[4].Value.ToString()) == 1)
                {
                    tu10.Checked = true;
                }
                else { tu10.Checked = false; }

                tuImage.Image = byteArrayToImage(t.GetPhoto(tuId.Text));
            }
            catch(Exception ex) {
                MessageBox.Show("Error");
            }

        }

        private void tuBrowseBtn_Click(object sender, EventArgs e)
        {

            try
            {
                OpenFileDialog op = new OpenFileDialog();
                op.Multiselect = false;
                op.Filter = "JPG Files (*.JPG)|*.jpg";
                op.Title = "Select Image";
                if (op.ShowDialog() == DialogResult.OK)
                {
                    tuImage.ImageLocation = op.FileName.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tuSaveBtn_Click(object sender, EventArgs e)
        {
            Teacher t = new Teacher();
            
                t.Subject = tuSubject.Text;
                t.IMAGE = imageToByteArray(tuImage.Image);
                t.FirstName = tuFirstname.Text;
                t.LastName = tuLastname.Text;
                t.DOB = tuDob.Text;
                t.CurrentAddress = tuCurrentadd.Text;
                t.PermanentAddress = tuPermanentadd.Text;
                t.Nationality = tuNationality.Text;
                t.Marital = tuMarital.Text;
                t.Religion = tuReligion.Text;
                t.BG = tuBlood.Text;
                t.Salary = float.Parse(tuSalary.Text);
            t.Department = tuDept.Text;
                t.Email = tuEmail.Text;
                t.Phone = tuMobile.Text;
                t.Password = tuPassword.Text;
                t.SSC = float.Parse(tuSSC.Text);
                t.HSC = float.Parse(tuHSC.Text);
                t.UnderGraduate = float.Parse(tuUndergraduate.Text);
                t.Graduate = float.Parse(tuGraduate.Text);
                if (tu6.Checked == true) { t.SIX = 1; } else { t.SIX = 0; }
                if (tu7.Checked == true) { t.SEVEN = 1; } else { t.SEVEN = 0; }
                if (tu8.Checked == true) { t.EIGHT = 1; } else { t.EIGHT = 0; }
                if (tu9.Checked == true) { t.NINE = 1; } else { t.NINE = 0; }
                if (tu10.Checked == true) { t.TEN = 1; } else { t.TEN = 0; }

                t.UpdateTeacher(tuId.Text);
                MessageBox.Show("Teacher Information Updated Successfully");

                tuImage.Image = null;
                tuFirstname.Text = tuLastname.Text = tuDob.Text = tuCurrentadd.Text = tuPermanentadd.Text = tuNationality.Text =
                tuMarital.Text = tuReligion.Text = tuBlood.Text = tuSalary.Text = tuEmail.Text = tuMobile.Text = tuPassword.Text =
                tuSSC.Text = tuHSC.Text = tuUndergraduate.Text = tuSubject.Text =tuDept.Text= tuGraduate.Text = "";
                tu6.Checked = tu7.Checked = tu8.Checked = tu9.Checked = tu10.Checked = false;
        }

        private void tdSearchButton_Click(object sender, EventArgs e)
        {
            Teacher t = new Teacher();
            tdDataGridView1.DataSource = t.SearchTeacher(tuId.Text);
            tdDataGridView2.DataSource = t.getClassList(tuId.Text);

            try
            {
                tdFirstname.Text = tdDataGridView1.Rows[0].Cells[1].Value.ToString();
                tdLastname.Text = tdDataGridView1.Rows[0].Cells[2].Value.ToString();
                tdDob.Text = tdDataGridView1.Rows[0].Cells[3].Value.ToString();
                tdCurrentadd.Text = tdDataGridView1.Rows[0].Cells[4].Value.ToString();
                tdPermanentadd.Text = tdDataGridView1.Rows[0].Cells[5].Value.ToString();
                tdNationality.Text = tdDataGridView1.Rows[0].Cells[6].Value.ToString();
                tdMarital.Text = tdDataGridView1.Rows[0].Cells[7].Value.ToString();
                tdReligion.Text = tdDataGridView1.Rows[0].Cells[8].Value.ToString();
                tdBlood.Text = tdDataGridView1.Rows[0].Cells[9].Value.ToString();
                tdSalary.Text = tdDataGridView1.Rows[0].Cells[10].Value.ToString();
                tdEmail.Text = tdDataGridView1.Rows[0].Cells[11].Value.ToString();
                tdMobile.Text = tdDataGridView1.Rows[0].Cells[12].Value.ToString();
                tdSSC.Text = tdDataGridView1.Rows[0].Cells[14].Value.ToString();
                tdHSC.Text = tdDataGridView1.Rows[0].Cells[15].Value.ToString();
                tdUndergraduate.Text = tdDataGridView1.Rows[0].Cells[16].Value.ToString();
                tdGraduate.Text = tdDataGridView1.Rows[0].Cells[17].Value.ToString();
                tdSubject.Text = tdDataGridView1.Rows[0].Cells[18].Value.ToString();
                tdDept.Text = tdDataGridView1.Rows[0].Cells[19].Value.ToString();
                if (Convert.ToInt32(tdDataGridView2.Rows[0].Cells[0].Value.ToString()) == 1)
                {
                    td6.Checked = true;
                }
                else { td6.Checked = false; }

                if (Convert.ToInt32(tdDataGridView2.Rows[0].Cells[1].Value.ToString()) == 1)
                {
                    td_7.Checked = true;
                }
                else { td_7.Checked = false; }

                if (Convert.ToInt32(tdDataGridView2.Rows[0].Cells[2].Value.ToString()) == 1)
                {
                    td8.Checked = true;
                }
                else { td8.Checked = false; }
                if (Convert.ToInt32(tdDataGridView2.Rows[0].Cells[3].Value.ToString()) == 1)
                {
                    td9.Checked = true;
                }
                else { td9.Checked = false; }
                if (Convert.ToInt32(tdDataGridView2.Rows[0].Cells[4].Value.ToString()) == 1)
                {
                    td10.Checked = true;
                }
                else { td10.Checked = false; }

                tdImage.Image = byteArrayToImage(t.GetPhoto(tdId.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void tdDeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Teacher t = new Teacher();
                t.DeleteTeacher(tdId.Text);
                MessageBox.Show("Teacher Information Deleted.");
                tdFirstname.Text =
                 tdLastname.Text =
                 tdDob.Text =
                 tdCurrentadd.Text =
                 tdPermanentadd.Text =
                 tdNationality.Text =
                 tdMarital.Text =
                 tdReligion.Text =
                 tdBlood.Text =
                 tdSalary.Text =
                 tdEmail.Text =
                 tdDept.Text=
                 tdMobile.Text =
                 tdSSC.Text =
                 tdHSC.Text =
                 tdUndergraduate.Text =
                 tdGraduate.Text =
                 tdSubject.Text = "";
                tdId.Text = "";
                tdImage.Image = null;
                td6.Checked = td_7.Checked = td8.Checked = td9.Checked = td10.Checked = false;
            }
            catch (Exception ec) { MessageBox.Show("Enter a valid ID."); }
        }

        //exam
        private void midTermDone_Click(object sender, EventArgs e)
        {
            Exam ex = new Exam();
            ex.AddMidTermExam(midtermClass.Text, midTermSubject.Text, midTermDept.Text, midTermDate.Text);
            MessageBox.Show(" Mid Term Exam Scheduled .");
            midtermClass.Text = midTermDate.Text = midTermDept.Text = midTermSubject.Text = "";
            midTermData.DataSource = ex.GetMidList();
        }

        int midId;
        private void midTermData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            midId = Convert.ToInt32(midTermData.CurrentRow.Cells[0].Value.ToString());
            midtermClass.Text = midTermData.CurrentRow.Cells[1].Value.ToString();
            midTermSubject.Text = midTermData.CurrentRow.Cells[2].Value.ToString();
            midTermDept.Text = midTermData.CurrentRow.Cells[3].Value.ToString();
            midTermDate.Text = midTermData.CurrentRow.Cells[4].Value.ToString();
        }

        private void finalTermDone_Click(object sender, EventArgs e)
        {
            Exam ex = new Exam();
            ex.AddFinalTermExam(finalTermClass.Text, finalTermSubject.Text, finalTermDept.Text, finalTermDate.Text);
            MessageBox.Show(" Final Term Exam Scheduled .");
            finalTermClass.Text = finalTermDate.Text = finalTermDept.Text = finalTermSubject.Text = "";
            finalTermData.DataSource = ex.GetFinalList();
        }

        int finalId;
        private void finalTermData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            finalId = Convert.ToInt32(finalTermData.CurrentRow.Cells[0].Value.ToString());
            finalTermClass.Text = finalTermData.CurrentRow.Cells[1].Value.ToString();
            finalTermSubject.Text = finalTermData.CurrentRow.Cells[2].Value.ToString();
            finalTermDept.Text = finalTermData.CurrentRow.Cells[3].Value.ToString();
            finalTermDate.Text = finalTermData.CurrentRow.Cells[4].Value.ToString();
        }

        private void finalUpdate_Click(object sender, EventArgs e)
        {
            Exam ex = new Exam();
            ex.UpdateFinalTermExam(finalTermClass.Text, finalTermSubject.Text, finalTermDept.Text, finalTermDate.Text,finalId);
            MessageBox.Show(" Final Term Exam Schedule Updated .");
            finalTermClass.Text = finalTermDate.Text = finalTermDept.Text = finalTermSubject.Text = "";
            finalTermData.DataSource = ex.GetFinalList();
        }

        private void finalDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Exam ex = new Exam();
                ex.DeleteFinalTermExam(finalId);
                finalTermData.DataSource = ex.GetFinalList();
                finalTermClass.Text = finalTermDate.Text = finalTermDept.Text = finalTermSubject.Text = "";
            }
            catch (Exception ec) { }
        }

        private void midUpdate_Click(object sender, EventArgs e)
        {
            Exam ex = new Exam();
            ex.UpdateMidTermExam(midtermClass.Text, midTermSubject.Text, midTermDept.Text, midTermDate.Text,midId);
            MessageBox.Show(" Mid Term Exam Schedule Updated .");
            midtermClass.Text = midTermDate.Text = midTermDept.Text = midTermSubject.Text = "";
            midTermData.DataSource = ex.GetMidList();
        }

       

        private void midDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Exam ex = new Exam();
                ex.DeleteMidTermExam(midId);
                midtermClass.Text = midTermDate.Text = midTermDept.Text = midTermSubject.Text = "";
                midTermData.DataSource = ex.GetMidList();
            }
            catch (Exception ec) { }
        }

       

        // Stuff Insert Save Button
        private void stiSaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Stuff st = new Stuff();
                st.Image = imageToByteArray(stiImage.Image);
                st.Firstname = stiFirstname.Text;
                st.Lastname = stiLastname.Text;
                st.dob = stiDob.Text;
                st.CurrentAdd = stiCurrentadd.Text;
                st.PermanentAdd = stiPermanentadd.Text;
                st.Nationality = stiNationality.Text;
                st.Marital = stiMarital.Text;
                st.Religion = stiReligion.Text;
                st.Catagory = stiCatagory.Text;
                st.Salary = Convert.ToInt32(stiSalary.Text);
                st.Email = stiEmail.Text;
                st.Mobile = stiMobile.Text;
                st.SSC = float.Parse(stiSSC.Text);
                st.HSC = float.Parse(stiHSC.Text);
                st.Undergraduate = float.Parse(stiUndergraduate.Text);
                st.Graduate = float.Parse(stiGraduate.Text);


                st.AddStuff();
                MessageBox.Show("Stuff Information Inserted Successfully");
                stiFirstname.Text =
                stiLastname.Text =
                stiDob.Text =
                stiCurrentadd.Text =
                stiPermanentadd.Text =
                stiNationality.Text =
                stiMarital.Text =
                stiReligion.Text =
                stiCatagory.Text =
                stiSalary.Text =
                stiEmail.Text =
                stiMobile.Text =
                stiSSC.Text =
                stiHSC.Text =
                stiUndergraduate.Text =
                stiGraduate.Text = "";
                stiImage.Image = null;
                stiId.Text = "ST-" + (st.GetLastID() + 1).ToString();
            }
            catch(Exception ec)
            {
                MessageBox.Show("Fill All The Blanks");
            }
           
        }

        private void stuBrowseBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog op = new OpenFileDialog();
                op.Multiselect = false;
                op.Filter = "JPG Files (*.JPG)|*.jpg";
                op.Title = "Select Image";
                if (op.ShowDialog() == DialogResult.OK)
                {
                    stuImage.ImageLocation = op.FileName.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void stuSearchBtn_Click(object sender, EventArgs e)
        {
            Stuff s = new Stuff();
            try
            {
                studataGridView.DataSource = s.SearchStuff(stuId.Text);
                stuFirstname.Text = studataGridView.Rows[0].Cells[1].Value.ToString();
                stuLastname.Text = studataGridView.Rows[0].Cells[2].Value.ToString();
                stuDob.Text = studataGridView.Rows[0].Cells[3].Value.ToString();
                stuCurrentadd.Text = studataGridView.Rows[0].Cells[4].Value.ToString();
                stuPermanentadd.Text = studataGridView.Rows[0].Cells[5].Value.ToString();
                stuNationality.Text = studataGridView.Rows[0].Cells[6].Value.ToString();
                stuMarital.Text = studataGridView.Rows[0].Cells[7].Value.ToString();
                stuReligion.Text = studataGridView.Rows[0].Cells[8].Value.ToString();
                stuCatagory.Text = studataGridView.Rows[0].Cells[9].Value.ToString();
                stuSalary.Text = studataGridView.Rows[0].Cells[10].Value.ToString();
                stuEmail.Text = studataGridView.Rows[0].Cells[11].Value.ToString();
                stuMobile.Text = studataGridView.Rows[0].Cells[12].Value.ToString();
                stuSSC.Text = studataGridView.Rows[0].Cells[13].Value.ToString();
                stuHSC.Text = studataGridView.Rows[0].Cells[14].Value.ToString();
                stuUndergraduate.Text = studataGridView.Rows[0].Cells[15].Value.ToString();
                stuGraduate.Text = studataGridView.Rows[0].Cells[16].Value.ToString();

                stuImage.Image = byteArrayToImage(s.GetPhoto(stuId.Text));
            }
            catch(Exception ec)
            {
                MessageBox.Show("Error");
            }
            
        }

        private void stuSaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Stuff st = new Stuff();
                st.Image = imageToByteArray(stuImage.Image);
                st.Firstname = stuFirstname.Text;
                st.Lastname = stuLastname.Text;
                st.dob = stuDob.Text;
                st.CurrentAdd = stuCurrentadd.Text;
                st.PermanentAdd = stuPermanentadd.Text;
                st.Nationality = stuNationality.Text;
                st.Marital = stuMarital.Text;
                st.Religion = stuReligion.Text;
                st.Catagory = stuCatagory.Text;
                st.Salary = Convert.ToInt32(stuSalary.Text);
                st.Email = stuEmail.Text;
                st.Mobile = stuMobile.Text;
                st.SSC = float.Parse(stuSSC.Text);
                st.HSC = float.Parse(stuHSC.Text);
                st.Undergraduate = float.Parse(stuUndergraduate.Text);
                st.Graduate = float.Parse(stuGraduate.Text);


                st.updateStuff(stuId.Text);
                MessageBox.Show("Stuff Information Upadated Successfully");
                stuFirstname.Text =
                stuLastname.Text =
                stuDob.Text =
                stuCurrentadd.Text =
                stuPermanentadd.Text =
                stuNationality.Text =
                stuMarital.Text =
                stuReligion.Text =
                stuCatagory.Text =
                stuSalary.Text =
                stuEmail.Text =
                stuMobile.Text =
                stuSSC.Text =
                stuHSC.Text =
                stuUndergraduate.Text =
                stuGraduate.Text = "";
                stuImage.Image = null;
                stuId.Text = "";
                //stuId.Text = "ST-" + (st.GetLastID() + 1).ToString();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Fill All The Blanks");
            }
        }

        private void stdSearchBtn_Click(object sender, EventArgs e)
        {
            Stuff s = new Stuff();
            try
            {
                stddataGridView.DataSource = s.SearchStuff(stdId.Text);
                stdFirstname.Text = stddataGridView.Rows[0].Cells[1].Value.ToString();
                stdLastname.Text = stddataGridView.Rows[0].Cells[2].Value.ToString();
                stdDob.Text = stddataGridView.Rows[0].Cells[3].Value.ToString();
                stdCurrentadd.Text = stddataGridView.Rows[0].Cells[4].Value.ToString();
                stdPermanentadd.Text = stddataGridView.Rows[0].Cells[5].Value.ToString();
                stdNationality.Text = stddataGridView.Rows[0].Cells[6].Value.ToString();
                stdMarital.Text = stddataGridView.Rows[0].Cells[7].Value.ToString();
                stdReligion.Text = stddataGridView.Rows[0].Cells[8].Value.ToString();
                stdCatagory.Text = stddataGridView.Rows[0].Cells[9].Value.ToString();
                stdSalary.Text = stddataGridView.Rows[0].Cells[10].Value.ToString();
                stdEmail.Text = stddataGridView.Rows[0].Cells[11].Value.ToString();
                stdMobile.Text = stddataGridView.Rows[0].Cells[12].Value.ToString();
                stdSSC.Text = stddataGridView.Rows[0].Cells[13].Value.ToString();
                stdHSC.Text = stddataGridView.Rows[0].Cells[14].Value.ToString();
                stdUndergraduate.Text = stddataGridView.Rows[0].Cells[15].Value.ToString();
                stdGraduate.Text = stddataGridView.Rows[0].Cells[16].Value.ToString();

                stdImage.Image = byteArrayToImage(s.GetPhoto(stdId.Text));
            }
            catch (Exception ec)
            {
                MessageBox.Show("Error");
            }
        }

        private void stdDeleteBtn_Click(object sender, EventArgs e)
        {
            Stuff st = new Stuff();
            try
            {
                st.DeleteStuff(stdId.Text);
                MessageBox.Show("Stuff Info Deleted");
                stdFirstname.Text =
                stdLastname.Text =
                stdDob.Text =
                stdCurrentadd.Text =
                stdPermanentadd.Text =
                stdNationality.Text =
                stdMarital.Text =
                stdReligion.Text =
                stdCatagory.Text =
                stdSalary.Text =
                stdEmail.Text =
                stdMobile.Text =
                stdSSC.Text =
                stdHSC.Text =
                stdUndergraduate.Text =
                stdGraduate.Text = "";
                stdImage.Image = null;
            }
            catch(Exception ec)
            {
                MessageBox.Show("Enter A valid Id");
            }
        }
        //passwor settings
        private void psSaveBtn_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
           
               if (ad.CheckPassword(psoldps.Text))
             {
                    if(psnewps.Text!="")
                {
                    ad.UpdateSettingsPassword(psoldps.Text, psnewps.Text);
                    MessageBox.Show("Password Changed Successfully.");
                    psoldps.Text = psnewps.Text = "";
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

        private void psBackBtn_Click(object sender, EventArgs e)
        {
            stShowPanel.Visible = false;         //
            studentInsertPanel.Visible = false;  // Student Panel
            stUpPanel.Visible = false;           //
            stDeletePanel.Visible = false;       //

            tInsertPanel.Visible = false;        //
            tUpdatePanel.Visible = false;        //Teacher Panel
            td7.Visible = false;                 //
            tShowPanel.Visible = false;          //

            stuffInsertPanel.Visible = false; //
            stuffUpPanel.Visible = false;     //  Stuff Panel
            stuffDeletePanel.Visible = false;  //
            stuffShowPanel.Visible = false;    //

            settingPanel.Visible = false;
            searchPanel.Visible = false;
            midPanel.Visible = false;
            finalPanel.Visible = false;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            stShowPanel.Visible = false;         //
            studentInsertPanel.Visible = false;  // Student Panel
            stUpPanel.Visible = false;           //
            stDeletePanel.Visible = false;       //

            tInsertPanel.Visible = false;        //
            tUpdatePanel.Visible = false;        //Teacher Panel
            td7.Visible = false;                 //
            tShowPanel.Visible = false;          //

            stuffInsertPanel.Visible = false; //
            stuffUpPanel.Visible = false;     //  Stuff Panel
            stuffDeletePanel.Visible = false;  //
            stuffShowPanel.Visible = false;    //

            settingPanel.Visible = false;
            searchPanel.Visible = false;
            midPanel.Visible = false;
            finalPanel.Visible = false;
        }

        private void stiBrowseBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog op = new OpenFileDialog();
                op.Multiselect = false;
                op.Filter = "JPG Files (*.JPG)|*.jpg";
                op.Title = "Select Image";
                if (op.ShowDialog() == DialogResult.OK)
                {
                    stiImage.ImageLocation = op.FileName.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

 

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) { td6.Checked = td_7.Checked = td8.Checked = td9.Checked = td10.Checked = true; }
            else { td6.Checked = td_7.Checked = td8.Checked = td9.Checked = td10.Checked = false; }
        }


        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true) { tu6.Checked = tu7.Checked = tu8.Checked = tu9.Checked = tu10.Checked = true; }
            else { tu6.Checked = tu7.Checked = tu8.Checked = tu9.Checked = tu10.Checked = false; }
        }

 

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true) { ti6.Checked = ti7.Checked = ti8.Checked = ti9.Checked = ti10.Checked = true; }
            else { ti6.Checked = ti7.Checked = ti8.Checked = ti9.Checked = ti10.Checked = false; }

        }


       
       
    }
}
