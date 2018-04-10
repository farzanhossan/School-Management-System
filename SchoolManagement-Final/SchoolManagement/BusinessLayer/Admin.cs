using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLayer
{
    public class Admin
    {
        AdminDBAccess ad = new AdminDBAccess();


        public void UpdatePassword(string i, string pas)
        {
            ad.UpdatePassword(i, pas);
        }

        public void UpdateSettingsPassword(string password, string newpassword)
        {
            ad.UpdateSettingsPassword(password,newpassword);
        }

        public string GetEmail(string i)
        {
            return ad.GetEmail(i);
        }
        public bool CheckUser(string uid)
        {
            return ad.CheckUser(uid);
        }

        public bool CheckUser(string uid, string pass)
        {
            
            return ad.CheckUser(uid, pass);
        }

        public bool CheckPassword(string pas)
        {
            return ad.CheckPassword(pas);

        }


    }
}
