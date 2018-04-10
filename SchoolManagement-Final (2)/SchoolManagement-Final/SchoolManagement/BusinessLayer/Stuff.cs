using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLayer
{
    public class Stuff
    {
        StuffDBAccess stda = new StuffDBAccess();

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string dob { get; set; }
        public string CurrentAdd { get; set; }
        public string PermanentAdd { get; set; }
        public string Nationality { get; set; }
        public string Marital { get; set; }
        public string Religion { get; set; }
        public string Catagory { get; set; }
        public int Salary { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public double SSC { get; set; }
        public double HSC { get; set; }
        public double Undergraduate { get; set; }
        public double Graduate { get; set; }
        public byte[] Image { get; set; }

        public void AddStuff()
        {
            stda.AddStuff(this.Firstname,this.Lastname,this.dob,this.CurrentAdd,this.PermanentAdd,
                this.Nationality,this.Marital,this.Religion,this.Catagory,this.Salary,this.Email,this.Mobile,
                this.SSC,this.HSC,this.Undergraduate,this.Graduate,this.Image);
        }

        public void updateStuff(string id)
        {
            stda.UpdateStuff(this.Firstname, this.Lastname, this.dob, this.CurrentAdd, this.PermanentAdd,
                this.Nationality, this.Marital, this.Religion, this.Catagory, this.Salary, this.Email, this.Mobile,
                this.SSC, this.HSC, this.Undergraduate, this.Graduate, this.Image,id);
        }

        public List<object> SearchStuff(string Id)
        {
            return stda.SearchStuff(Id);
        }

        public void DeleteStuff(string id)
        {
            stda.DeleteStuff(id);
        }

        public List<object> ShowDetails()
        {
            return stda.ShowDetails();
        }

        public byte[] GetPhoto(string i)
        {
            return stda.GetPhoto(i);
        }

        public int GetLastID()
        {
            return stda.GetLastID();
        }

        public bool CheckUser(string uid)
        {
            return stda.CheckUser(uid);
        }


    }
}
