using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccessLayer
{
    public class AdminDBAccess
    {
        AdminDataContext sdba = new AdminDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Taha\Downloads\Compressed\SchoolManagement-Final (2)\SchoolManagement-Final\SchoolManagement\DataAccessLayer\SchoolDataBase.mdf;Integrated Security=True;Connect Timeout=30");
        
        
        
        public void UpdatePassword(string i, string pas)
        {
            var x = sdba.AdminTables.Where(a => a.aid == i).FirstOrDefault();
            x.password = pas;
            sdba.SubmitChanges();
        }

        public void UpdateSettingsPassword(string password,string newpassword)
        {
            var x = sdba.AdminTables.Where(a => a.password == password).FirstOrDefault();
            x.password = newpassword;
            sdba.SubmitChanges();
        }

        public bool CheckPassword(string pas)
        {

            bool status = false;
            foreach (AdminTable st in sdba.AdminTables)
            {
                if (st.password == pas) { status = true; break; }
            }
            return status;

        }

        public bool CheckUser(string uid, string pass)
        {
           // Console.WriteLine(uid+" "+pass);
            bool status = false;
            foreach (AdminTable st in sdba.AdminTables)
            {
                if (st.aid == uid && st.password == pass) { status = true; break; }
            }
            return status;
        }
        public bool CheckUser(string uid)
        {
            bool status = false;
            foreach (AdminTable st in sdba.AdminTables)
            {
                if (st.aid == uid) { status = true; break; }
            }
            return status;
        }

        public string GetEmail(string i)
        {
            var x = from a in sdba.AdminTables where a.aid == i select new { a.email };
            return x.FirstOrDefault().email;
        }
    }
}
