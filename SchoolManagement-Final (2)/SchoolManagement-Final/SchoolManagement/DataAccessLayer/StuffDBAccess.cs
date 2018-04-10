using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class StuffDBAccess
    {
        StuffDataContext sdba = new StuffDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Taha\Downloads\Compressed\SchoolManagement-Final (2)\SchoolManagement-Final\SchoolManagement\DataAccessLayer\SchoolDataBase.mdf;Integrated Security=True;Connect Timeout=30");
        public int GetLastID()
        {
            try
            {
                var x = from a in sdba.StuffTables orderby a.Id descending select new { a.Id };
                return x.FirstOrDefault().Id;
            }
            catch (Exception ec) { return 2000; }
        }

        public void AddStuff(string firstname,string lastname,string dob,string currentAdd,string permanentAdd,
            string nationality,string marital,string religion,string catagory,int salary,string email,
            string mobile,double ssc,double hsc,double undergraduate,double graduate,byte[] image)
        {
            StuffTable st = new StuffTable();
            st.Id = GetLastID() + 1;
            st.stid = "ST-" + Convert.ToString(GetLastID() + 1);

            st.firstname = firstname;
            st.lastname = lastname;
            st.dob = Convert.ToDateTime(dob);
            st.currentadd = currentAdd;
            st.permanentadd = permanentAdd;
            st.nationality = nationality;
            st.marital = marital;
            st.religion = religion;
            st.catagory = catagory;
            st.salary = salary;
            st.email = email;
            st.mobile = mobile;
            st.ssc = ssc;
            st.hsc = hsc;
            st.undergraduate = undergraduate;
            st.graduate = graduate;
            st.image = image;

            sdba.StuffTables.InsertOnSubmit(st);
            sdba.SubmitChanges();
        }

        public void UpdateStuff(string firstname, string lastname, string dob, string currentAdd, string permanentAdd,
            string nationality, string marital, string religion, string catagory, int salary, string email,
            string mobile, double ssc, double hsc, double undergraduate, double graduate, byte[] image,string stid)
        {
            var s = sdba.StuffTables.Where(w => w.stid == stid).FirstOrDefault();
            s.firstname = firstname;
            s.lastname = lastname;
            s.dob = Convert.ToDateTime(dob);
            s.currentadd = currentAdd;
            s.permanentadd = permanentAdd;
            s.nationality = nationality;
            s.marital = marital;
            s.religion = religion;
            s.catagory = catagory;
            s.salary = salary;
            s.email = email;
            s.mobile = mobile;
            s.ssc = ssc;
            s.hsc = hsc;
            s.undergraduate = undergraduate;
            s.graduate = graduate;
            s.image = image;

            sdba.SubmitChanges();
        }

        public List<object> SearchStuff(string Id)
        {
            var x = sdba.StuffTables.Where(a => a.stid == Id);
            List<object> o = new List<object>();
            o.AddRange(x.ToList());
            return o;
        }

        public void DeleteStuff(string Id)
        {
            var s = sdba.StuffTables.Where(w => w.stid == Id).FirstOrDefault();
            sdba.StuffTables.DeleteOnSubmit(s);
            sdba.SubmitChanges();
        }
        public List<object> ShowDetails()
        {
            var x = from a in sdba.StuffTables
                    select new
                    {
                        a.stid,a.firstname, a.lastname, a.dob, a.currentadd, a.permanentadd, a.nationality, a.marital,
                        a.religion,a.catagory,a.salary,a.email,a.mobile,a.ssc,a.hsc,a.undergraduate,a.graduate
                    };
            List<object> o = new List<object>();
            o.AddRange(x.ToList());
            return o;
        }


        public byte[] GetPhoto(string i)
        {
            var x = sdba.StuffTables.Where(a => a.stid == i).FirstOrDefault();
            return (byte[])x.image.ToArray();
        }

        public bool CheckUser(string uid)
        {
            bool status = false;
            foreach (StuffTable st in sdba.StuffTables)
            {
                if (st.stid == uid) { status = true; break; }
            }
            return status;
        }

    }
}
