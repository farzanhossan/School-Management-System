using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLayer
{
    public class Student
    {
        StudentDBAccess sda = new StudentDBAccess();
     
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public int Class { get; set; }
        public int Roll { get; set; }
        public string Program { get; set; }
        public string Father_name { get; set; }
        public string Mother_name { get; set; }
        public string Dob { get; set; }
        public string Blood_group { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public byte[] Image { get; set; }

        public void AddStudent()
        {
            sda.AddStudent(this.First_name,this.Last_name,this.Class,this.Roll,this.Program,this.Father_name,this.Mother_name,this.Dob,this.Blood_group,
                this.Mobile,this.Email,this.Address,this.Password,this.Image);
        }

        public void updateStudent(string id)
        {
            sda.UpdateStudent(this.First_name, this.Last_name, this.Class, this.Roll, this.Program, this.Father_name, this.Mother_name, this.Dob, this.Blood_group,
                this.Mobile, this.Email, this.Address, this.Password, this.Image,id);
        }

        public void deleteStudent(string id)
        {
            sda.DeleteStudent(id);
        }
        
        public int GetLastID()
        {
            return sda.GetLastID();
        }
        public List<object> SearchStudent(string Id)
        {
            return sda.SearchStudent(Id);
        }
        public List<object> ShowDetails()
        {
            return sda.ShowDetails();
        }
        public byte[] GetPhoto(string i)
        {
            return sda.GetPhoto(i);
        }

        public bool CheckUser(string uid, string pass)
        {
            return sda.CheckUser(uid, pass);
        }

        public bool CheckUser(string uid)
        {
            return sda.CheckUser(uid);
        }

        public void UpdatePassword(string i, string pas)
        {
             sda.UpdatePassword(i, pas);
        }

        public string GetEmail(string i)
        {
            return sda.GetEmail(i);
        }

        public string[] GetStudentsByClass(int Class)
        {
            return sda.GetStudentsByClass(Class);
        }
        public string GetName(string i)
        {
            return sda.GetName(i);
        }
        public string GetDepartment(string i)
        {
            return sda.GetDepartment(i);
        }
        public string GetClassName(string i)
        {
            return sda.GetClassName(i);
        }
    }
}
