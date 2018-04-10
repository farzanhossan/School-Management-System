using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class TeacherDBAccess
    {
        TeacherDBDataContext sdba = new TeacherDBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Taha\Downloads\Compressed\SchoolManagement-Final (2)\SchoolManagement-Final\SchoolManagement\DataAccessLayer\SchoolDataBase.mdf;Integrated Security=True;Connect Timeout=30");        
        
        public void AddTeacher(string firstname,string lastname,string dob,string currentadd,string permanentadd,
            string nationality,string marital,string religion,string blood,float salary,string email,string mobile,
            string password,float ssc,float hsc,float undergraduate,float graduate,int six,int seven,int eight,int nine,
            int ten,byte[] image,string SUB,string Dept)
        {
            TeacherTable t = new TeacherTable();
            t.Id = GetLastID() + 1;
            t.tid = "T-" + Convert.ToString(GetLastID() + 1);
            t.subject = SUB;
            t.department = Dept;
            t.firstname = firstname;
            t.lastname = lastname;
            t.dob = Convert.ToDateTime(dob);
            t.currentadd = currentadd;
            t.permanent = permanentadd;
            t.nationality = nationality;
            t.marital = marital;
            t.religion = religion;
            t.blood = blood;
            t.salary = salary;
            t.email = email;
            t.mobile = mobile;
            t.password = password;
            t.ssc = ssc;
            t.hsc = hsc;
            t.undergraduate = undergraduate;
            t.graduate = graduate;
            t._6 = six;
            t._7 = seven;
            t._8 = eight;
            t._9 = nine;
            t._10 = ten;
            t.image = image;

            sdba.TeacherTables.InsertOnSubmit(t);
            sdba.SubmitChanges();
        }
        public int GetLastID()
        {
            try
            {
                var x = from a in sdba.TeacherTables orderby a.Id descending select new { a.Id };
                return x.FirstOrDefault().Id;
            }
            catch (Exception ec) { return 1000; }
        }

        public void UpdateTeacher(string firstname, string lastname, string dob, string currentadd, string permanentadd,
            string nationality, string marital, string religion, string blood, float salary, string email, string mobile,
            string password, float ssc, float hsc, float undergraduate, float graduate, int six, int seven, int eight, int nine,
            int ten, byte[] image,string SUB, String Id,string Dept)
        {
            var t = sdba.TeacherTables.Where(w => w.tid == Id).FirstOrDefault();
            t.subject = SUB;
            t.department = Dept;
            t.firstname = firstname;
            t.lastname = lastname;
            t.dob = Convert.ToDateTime(dob);
            t.currentadd = currentadd;
            t.permanent = permanentadd;
            t.nationality = nationality;
            t.marital = marital;
            t.religion = religion;
            t.blood = blood;
            t.salary = salary;
            t.email = email;
            t.mobile = mobile;
            t.password = password;
            t.ssc = ssc;
            t.hsc = hsc;
            t.undergraduate = undergraduate;
            t.graduate = graduate;
            t._6 = six;
            t._7 = seven;
            t._8 = eight;
            t._9 = nine;
            t._10 = ten;
            t.image = image;



            sdba.SubmitChanges();

        }

        public void DeleteTeacher(string Id)
        {
            var s = sdba.TeacherTables.Where(w => w.tid == Id).FirstOrDefault();
            sdba.TeacherTables.DeleteOnSubmit(s);
            sdba.SubmitChanges();
        }

        public List<object> SearchTeacher(string Id)
        {
            var x = sdba.TeacherTables.Where(a => a.tid == Id);
            List<object> o = new List<object>();
            o.AddRange(x.ToList());
            return o;
        }

        public List<object> ShowDetails()
        {
            var x = from t in sdba.TeacherTables
                    select new
                    {
                        t.firstname,
                        t.lastname,
                        t.dob,
                        t.currentadd,
                        t.permanent,
                        t.nationality,
                        t.marital,
                        t.religion,
                        t.blood,
                        t.salary,
                        t.email ,
                        t.mobile,
                        t.password ,
                        t.ssc,
                        t.hsc,
                        t.undergraduate,
                        t.graduate,
                        t.subject,
                        t.department
                    };
            List<object> o = new List<object>();
            o.AddRange(x.ToList());
            return o;
        }

        public List<Object> getClassList(string i)
        {
            var x = from t in sdba.TeacherTables where t.tid==i
                    select new
                    {
                        t._6,
                        t._7,
                        t._8,
                        t._9,
                        t._10

                    };
             List<object> o = new List<object>();
            o.AddRange(x.ToList());
             return o;
        }
        public byte[] GetPhoto(string i)
        {
            var x = sdba.TeacherTables.Where(a => a.tid == i).FirstOrDefault();
            return (byte[])x.image.ToArray();
        }

        public bool CheckUser(string uid, string pass)
        {
            bool status = false;
            foreach (TeacherTable st in sdba.TeacherTables)
            {
                if (st.tid == uid && st.password == pass) { status = true; break; }
            }
            return status;
        }
        public bool CheckUser(string uid)
        {
            bool status = false;
            foreach (TeacherTable st in sdba.TeacherTables)
            {
                if (st.tid == uid ) { status = true; break; }
            }
            return status;
        }
        public string GetEmail(string i)
        {
            var x = from a in sdba.TeacherTables where a.tid==i select new { a.email};
            return x.FirstOrDefault().email;
        }
        public void UpdatePassword(string i,string pas)
        {
            var x = sdba.TeacherTables.Where(a => a.tid == i).FirstOrDefault();
            x.password = pas;
            sdba.SubmitChanges();
        }

        #region Notice

        public void AddNotice(string Class, string Dept, string n,string TID)
        {
            NoticeTable nt = new NoticeTable();
            nt.@class = Class;
            nt.tid = TID;
            nt.Id = GetLastNoticeID() + 1;
            nt.department = Dept;
            nt.notice = n;
            sdba.NoticeTables.InsertOnSubmit(nt);
            sdba.SubmitChanges();
        }
        public void UpdateNotice(string Class, string Dept, string n,int i)
        {
            var nt = sdba.NoticeTables.Where(a => a.Id == i).FirstOrDefault();
            nt.@class = Class;
            nt.department = Dept;
            nt.notice = n;
            sdba.SubmitChanges();
        }
        public void DeleteNotice(int i)
        {
            var nt = sdba.NoticeTables.Where(a => a.Id == i).FirstOrDefault();
            sdba.NoticeTables.DeleteOnSubmit(nt);
            sdba.SubmitChanges();
        }
        public List<object> GetNoticeList(string TID)
        {
            var x = from a in sdba.NoticeTables orderby a.Id descending where a.tid==TID select new { a.@class, a.department, a.notice ,a.Id};
            List<object> o = new List<object>();
            o.AddRange(x.ToList());
            return o;
        }
        public List<object> GetNoticeList(string Class,string Dept)
        {
            var x = from a in sdba.NoticeTables orderby a.Id descending where a.@class == Class && a.department==Dept select new { a.@class, a.department, a.notice, a.Id };
            List<object> o = new List<object>();
            o.AddRange(x.ToList());
            return o;
        }
        public int GetLastNoticeID()
        {
            try
            {
                var x = from a in sdba.NoticeTables orderby a.Id descending select new { a.Id };
                return x.FirstOrDefault().Id;
            }
            catch (Exception ec) { return 0; }
        }

        #endregion

        public string[] GetClasses(string uid)
        {
            var x = from a in sdba.TeacherTables where a.tid == uid select a;
            string[] arr = new string[5];
            int i=0;
            foreach (var x1 in x)
            {
                if (x1._6 == 1) { arr[i] = "6"; i++; }
                if (x1._7 == 1) { arr[i] = "7"; i++; }
                if (x1._8 == 1) { arr[i] = "8"; i++; }
                if (x1._9 == 1) { arr[i] = "9"; i++; }
                if (x1._10 == 1) { arr[i] = "10"; i++; }
            }
            return arr;
        }
        public string GetDepartment(string ti)
        {
            var x = sdba.TeacherTables.Where(a => a.tid == ti).FirstOrDefault();
            return x.department;
        }
        public string GetSubject(string ti)
        {
            var x = sdba.TeacherTables.Where(a => a.tid == ti).FirstOrDefault();
            return x.subject;
        }
    }
}
