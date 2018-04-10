using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLayer
{
    public class Teacher
    {

        TeacherDBAccess t = new TeacherDBAccess();

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DOB { get; set; }
        public string CurrentAddress{ get; set; }
        public string PermanentAddress { get; set; }
        public string Nationality { get; set; }
        public string Marital { get; set; }
        public string Religion { get; set; }
        public string BG{ get; set; }
        public float Salary { get; set; }
        public string Email{ get; set; }
        public string Phone{ get; set; }
        public string Password { get; set; }
        public float SSC{ get; set; }
        public float HSC{ get; set; }
        public float UnderGraduate{ get; set; }
        public float Graduate{ get; set; }
        public int SIX{ get; set; }
        public int SEVEN{ get; set; }
        public int EIGHT { get; set; }
        public int NINE { get; set; }
        public int TEN { get; set; }
        public string TeacherID{ get; set; }
        public byte[] IMAGE{ get; set; }
        public string Subject { get; set; }
        public string Department { get; set; }

        public void AddTeacher()
        {
            t.AddTeacher(FirstName,LastName,DOB,CurrentAddress,PermanentAddress,Nationality,Marital,Religion,
                BG,Salary,Email,Phone,Password,SSC,HSC,UnderGraduate,Graduate,SIX,SEVEN,EIGHT,NINE,TEN,IMAGE,Subject,Department);
        }
        public int GetLastID()
        {
            return t.GetLastID();
        }

        public void UpdateTeacher(string TID)
        {
            t.UpdateTeacher(FirstName, LastName, DOB, CurrentAddress, PermanentAddress, Nationality, Marital, Religion,
                BG, Salary, Email, Phone, Password, SSC, HSC, UnderGraduate, Graduate, SIX, SEVEN, EIGHT, NINE, 
                TEN, IMAGE,Subject
            , TID,Department);
        }

        public void DeleteTeacher(string Id)
        {
            t.DeleteTeacher(Id);
        }

        public List<object> SearchTeacher(string Id)
        {
            return t.SearchTeacher(Id);
        }

        public List<object> ShowDetails()
        {
            return t.ShowDetails();
        }

        public List<Object> getClassList(string i)
        {
            return t.getClassList(i);
        }
        public byte[] GetPhoto(string i)
        {
            return t.GetPhoto(i);
        }

        public bool CheckUser(string uid, string pass)
        {
            return t.CheckUser(uid, pass);
        }
        public bool CheckUser(string uid )
        {
            return t.CheckUser(uid);
        }
        public string GetEmail(string i)
        {
            return t.GetEmail(i);
        }
        public void UpdatePassword(string i, string pas)
        {
            t.UpdatePassword(i, pas);
        }

        #region Notice
        public void AddNotice(string Class, string Dept, string n,string TID)
        {
            t.AddNotice(Class,Dept,n,TID);
        }
        public void UpdateNotice(string Class, string Dept, string n,int i)
        {
            t.UpdateNotice(Class,Dept,n,i);
        }
        public void DeleteNotice(int i)
        {
            t.DeleteNotice(i);
        }
        public List<object> GetNoticeList(string TID)
        {
            return t.GetNoticeList(TID);
        }
        public List<object> GetNoticeList(string C,string D)
        {
            return t.GetNoticeList(C,D);
        }
        public int GetLastNoticeID()
        {
            return t.GetLastNoticeID();
        }

        #endregion

        public string[] GetClasses(string uid)
        {
            return t.GetClasses(uid);
        }
        public string GetDepartment(string ti)
        {
            return t.GetDepartment(ti);
        }
        public string GetSubject(string ti)
        {
            return t.GetSubject(ti);
        }
    }
}
