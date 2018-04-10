using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLayer
{
    public class Exam
    {
        ExamDataAccess da = new ExamDataAccess();
        public void AddMidTermExam(string Class, string Subject, string Department, string Date)
        {
            da.AddMidTermExam(Class, Subject, Department, Date);
        }
        public void UpdateMidTermExam(string Class, string Subject, string Department, string Date, int i)
        {
            da.UpdateMidTermExam(Class, Subject, Department, Date,i);
        }
        public int GetMidLastID()
        {
            return da.GetMidLastID();
        }
        public void DeleteMidTermExam(int i)
        {
            da.DeleteMidTermExam(i);
        }
        public List<object> GetMidList()
        {
            return da.GetMidList();
        }
        public List<object> GetFinalList()
        {
            return da.GetFinalList();
        }

        public void AddFinalTermExam(string Class, string Subject, string Department, string Date)
        {
            da.AddFinalTermExam(Class, Subject, Department, Date);
        }
        public void UpdateFinalTermExam(string Class, string Subject, string Department, string Date, int i)
        {
            da.UpdateFinalTermExam(Class, Subject, Department, Date, i);
        }
        public int GetFinalLastID()
        {
            return da.GetFinalLastID();
        }
        public void DeleteFinalTermExam(int i)
        {
            da.DeleteFinalTermExam(i);
        }
        public string[] GetStudentsByClass(string Class, string dept)
        {
            return da.GetStudentsByClass(Class, dept);
        }
        public void UploadMarks(string si,string Sub, float mw, float mm, float fw, float fm)
        {
            da.UploadMarks(si,Sub, mw, mm, fw, fm);
        }
        public List<object> GetMidMarksList(string i)
        {
            return da.GetMidMarksList(i);
        }
        public string GetMidWrittenMark(string Sid, string Sub)
        {
            return da.GetMidWrittenMark(Sid, Sub);
        }
        public string GetMidMcqMark(string Sid, string Sub)
        {
            return da.GetMidMcqMark(Sid, Sub);
        }
        public string GetFinalWrittenMark(string Sid, string Sub)
        {
            return da.GetFinalWrittenMark(Sid, Sub);
        }
        public string GetFinalMcqMark(string Sid, string Sub)
        {
            return da.GetFinalMcqMark(Sid, Sub);
        }
    }
}
