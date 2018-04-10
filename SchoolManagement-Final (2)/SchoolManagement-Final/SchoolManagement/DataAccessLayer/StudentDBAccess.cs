using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class StudentDBAccess
    {
        StudentDBDataContext sdba = new StudentDBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Taha\Downloads\Compressed\SchoolManagement-Final (2)\SchoolManagement-Final\SchoolManagement\DataAccessLayer\SchoolDataBase.mdf;Integrated Security=True;Connect Timeout=30");
        
        
        public void AddStudent(string First_name, string Last_name, int Class, int Roll, string Program, string Father_name,
            string Mother_name, string Dob, string Blood_group, string Mobile, string Email, string Address, string Password,byte[] Image)
        {
            StudentTable st = new StudentTable();
            st.Id = GetLastID() + 1;
            st.sid = "S-" + Convert.ToString(GetLastID()+1);
            st.first_name = First_name;
            st.last_name = Last_name;
            st.@class = Class;
            st.roll = Roll;
            st.program = Program;
            st.father_name = Father_name;
            st.mother_name = Mother_name;
            st.dob = Convert.ToDateTime(Dob);
            st.blood_group = Blood_group;
            st.mobile = Mobile;
            st.email = Email;
            st.address = Address;
            st.password = Password;
            st.image = Image;

            sdba.StudentTables.InsertOnSubmit(st);
            sdba.SubmitChanges();
        }
        public int GetLastID()
        {
            try
            {
                var x = from a in sdba.StudentTables orderby a.Id descending select new { a.Id };
                return x.FirstOrDefault().Id;
            }
            catch (Exception ec) { return 3000; }
        }

        public void UpdateStudent(string First_name, string Last_name, int Class, int Roll, string Program, string Father_name,
            string Mother_name, string Dob, string Blood_group, string Mobile, string Email, string Address, string Password, byte[] Image,string Id)
        {
            var s = sdba.StudentTables.Where(w => w.sid == Id).FirstOrDefault();

            s.first_name = First_name;
            s.last_name = Last_name;
            s.@class = Class;
            s.roll = Roll;
            s.program = Program;
            s.father_name = Father_name;
            s.mother_name = Mother_name;
            s.dob = Convert.ToDateTime(Dob);
            s.blood_group = Blood_group;
            s.mobile = Mobile;
            s.email = Email;
            s.address = Address;
            s.password = Password;
            s.image = Image;



            sdba.SubmitChanges();

        }

        public void DeleteStudent(string Id)
        {
            var s = sdba.StudentTables.Where(w => w.sid == Id).FirstOrDefault();
            sdba.StudentTables.DeleteOnSubmit(s);
            sdba.SubmitChanges();
        }

        public List<object> SearchStudent(string Id)
        {
            var x = sdba.StudentTables.Where(a => a.sid == Id);
            List<object> o = new List<object>();
            o.AddRange(x.ToList());
            return o;
        }

        public List<object> ShowDetails()
        {
            var x = from a in sdba.StudentTables select new { a.sid,a.first_name,a.last_name,a.@class,a.roll,a.program,
            a.father_name,a.mother_name,a.dob,a.blood_group,a.mobile,a.email,a.address,a.password};
            List<object> o = new List<object>();
            o.AddRange(x.ToList());
            return o;
        }
        public byte[] GetPhoto(string i)
        {
            var x = sdba.StudentTables.Where(a => a.sid == i).FirstOrDefault();
            return (byte[])x.image.ToArray();
        }

        public string[] GetIDs(int ClassName)
        {
            var x = from a in sdba.StudentTables where a.@class == ClassName select new { a.sid };
            List<string> o = new List<string>();
            foreach (var x1 in x)
            {
                o.Add(x1.sid.ToString());
            }
            string[] arr = o.ToArray();
            return arr;
        }

        public bool CheckUser(string uid, string pass)
        {
            bool status = false;
            foreach (StudentTable st in sdba.StudentTables)
            {
                if (st.sid == uid && st.password == pass) { status = true; break; }
            }
            return status;
        }

        public bool CheckUser(string uid)
        {
            bool status = false;
            foreach (StudentTable st in sdba.StudentTables)
            {
                if (st.sid == uid) { status = true; break; }
            }
            return status;
        }

        public string GetEmail(string i)
        {
            var x = from a in sdba.StudentTables where a.sid == i select new { a.email };
            return x.FirstOrDefault().email;
        }

        public void UpdatePassword(string i, string pas)
        {
            var x = sdba.StudentTables.Where(a => a.sid == i).FirstOrDefault();
            x.password = pas;
            sdba.SubmitChanges();
        }

        public string[] GetStudentsByClass(int Class)
        {
            var x = from a in sdba.StudentTables where a.@class == Class select new { a.sid };
            List<string> o = new List<string>();
            foreach (var x1 in x)
            {
                o.Add(x1.sid.ToString());
            }
            string[] arr = o.ToArray();
            return arr;
        }
        public string GetName(string i)
        {
            var x = sdba.StudentTables.Where(a => a.sid == i).FirstOrDefault();
            return x.first_name + " " + x.last_name;
        }

        public string GetDepartment(string i)
        {
            var x = sdba.StudentTables.Where(a => a.sid == i).FirstOrDefault();
            return x.program.ToString() ;
        }
        public string GetClassName(string i)
        {
            var x = sdba.StudentTables.Where(a => a.sid == i).FirstOrDefault();
            return x.@class.ToString();
        }

    }
}
