using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ExamDataAccess
    {
        ExamDBDataContext eda = new ExamDBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\farza\Desktop\Final\SchoolManagement-Final\SchoolManagement\DataAccessLayer\SchoolDataBase.mdf;Integrated Security=True;Connect Timeout=30");
        public void AddMidTermExam(string Class,string Subject,string Department,string Date)
        {
            MidTermTable mt = new MidTermTable();
            mt.Id = GetMidLastID() + 1;
            mt.@class = Class;
            mt.subject = Subject;
            mt.department = Department;
            mt.date = Convert.ToDateTime(Date);
            eda.MidTermTables.InsertOnSubmit(mt);
            eda.SubmitChanges();
            StudentDBAccess s = new StudentDBAccess();
            string[] ss = s.GetIDs(Int32.Parse(Class));
            MidTermMarksTable mks = new MidTermMarksTable();
            foreach (string o in ss)
            {
                mks.examId = GetMidLastID() ;
                mks.stuId = o;
                mks.subject = Subject;
                eda.MidTermMarksTables.InsertOnSubmit(mks);
                eda.SubmitChanges();
            }
            
        }
        public void UpdateMidTermExam(string Class, string Subject, string Department, string Date,int i)
        {
            var mt = eda.MidTermTables.Where(a=> a.Id==i).FirstOrDefault();
            mt.@class = Class;
            mt.subject = Subject;
            mt.department = Department;
            mt.date = Convert.ToDateTime(Date);
            eda.SubmitChanges();
        }
        public int GetMidLastID()
        {
            try
            {
                var x = from a in eda.MidTermTables orderby a.Id descending select new { a.Id };
                return x.FirstOrDefault().Id;
            }
            catch (Exception ec) { return 0; }
        }
        public void DeleteMidTermExam(int i)
        {
            var x = from a in eda.MidTermTables where a.Id == i select a;
            eda.MidTermTables.DeleteAllOnSubmit(x);
            var x1 = from a in eda.MidTermMarksTables where a.examId == i select a;
            eda.MidTermMarksTables.DeleteAllOnSubmit(x1);
            eda.SubmitChanges();
        }
        public List<object> GetMidList()
        {
            var x = from a in eda.MidTermTables select a;
            List<object> o = new List<object>();
            o.AddRange(x.ToList());
            return o;
        }
        public List<object> GetFinalList()
        {
            var x = from a in eda.FinalTermTables select a;
            List<object> o = new List<object>();
            o.AddRange(x.ToList());
            return o;
        }

        public void AddFinalTermExam(string Class, string Subject, string Department, string Date)
        {
            FinalTermTable mt = new FinalTermTable();
            mt.Id = GetFinalLastID() + 1;
            mt.@class = Class;
            mt.subject = Subject;
            mt.department = Department;
            mt.date = Convert.ToDateTime(Date);
            eda.FinalTermTables.InsertOnSubmit(mt);
            eda.SubmitChanges();
            StudentDBAccess s = new StudentDBAccess();
            string[] ss = s.GetIDs(Int32.Parse(Class));
            FinalTermMarksTable mks = new FinalTermMarksTable();
            foreach (string o in ss)
            {
                mks.examId = GetFinalLastID() + 1;
                mks.stuId = o;
                mks.subject = Subject;
                eda.FinalTermMarksTables.InsertOnSubmit(mks);
                eda.SubmitChanges();
            }
        }
        public void UpdateFinalTermExam(string Class, string Subject, string Department, string Date, int i)
        {
            var mt = eda.FinalTermTables.Where(a => a.Id == i).FirstOrDefault();
            mt.@class = Class;
            mt.subject = Subject;
            mt.department = Department;
            mt.date = Convert.ToDateTime(Date);
            eda.SubmitChanges();
        }
        public int GetFinalLastID()
        {
            try
            {
                var x = from a in eda.FinalTermTables orderby a.Id descending select new { a.Id };
                return x.FirstOrDefault().Id;
            }
            catch (Exception ec) { return 0; }
        }
        public void DeleteFinalTermExam(int i)
        {
            var x = from a in eda.FinalTermTables where a.Id == i select a;
            eda.FinalTermTables.DeleteAllOnSubmit(x);
            var x1 = from a in eda.FinalTermMarksTables where a.examId == i select a;
            eda.FinalTermMarksTables.DeleteAllOnSubmit(x1);
            eda.SubmitChanges();
        }

        public string[] GetStudentsByClass(string Class,string dept)
        {
            var x = from b in eda.MidTermTables
                    join a in eda.MidTermMarksTables 
                    on b.Id equals a.examId
                    where b.@class==Class && b.department==dept 
                    select new {a.stuId,b.@class,b.department};
            List<string> o = new List<string>();
            foreach (var x1 in x)
            {
                o.Add(x1.stuId.ToString());
                if (x1.@class == Class && x1.department == dept) {  }
            }
            string[] arr = o.ToArray();
            return arr;
        }
        public void UploadMarks(string si,string Sub,float mw, float mm, float fw, float fm)
        {
            var mt = eda.MidTermMarksTables.Where(a => a.stuId == si && a.subject==Sub).FirstOrDefault();
            mt.written = mw;
            mt.mcq = mm;
            
            var ft = eda.FinalTermMarksTables.Where(a => a.stuId == si && a.subject==Sub).FirstOrDefault();
            if (ft != null)
            {
                ft.written = fw;
                ft.mcq = fm;
                
            }
            eda.SubmitChanges();
        }
        public List<object> GetMidMarksList(string i)
        {
            var x = from a in eda.MidTermMarksTables where a.stuId == i select new { a.written, a.mcq };
            List<object> o = new List<object>();
            o.AddRange(x.ToList());
            return o;
        }
        public List<object> GetFinalMarksList(string i)
        {
            var x = from a in eda.FinalTermMarksTables where a.stuId == i select new { a.written, a.mcq };
            List<object> o = new List<object>();
            o.AddRange(x.ToList());
            return o;
        }

        public string GetMidWrittenMark(string Sid, string Sub)
        {
            var x = eda.MidTermMarksTables.Where(a => a.stuId == Sid && a.subject == Sub).FirstOrDefault();
            if (x != null) { return x.written.ToString(); } else { return ""; }
        }
        public string GetMidMcqMark(string Sid, string Sub)
        {
            var x = eda.MidTermMarksTables.Where(a => a.stuId == Sid && a.subject == Sub).FirstOrDefault();
            if (x != null) {  return x.mcq.ToString(); } else { return ""; } 
        }
        public string GetFinalWrittenMark(string Sid, string Sub)
        {
            var x = eda.FinalTermMarksTables.Where(a => a.stuId == Sid && a.subject == Sub).FirstOrDefault();
            if (x != null) { return x.written.ToString(); } else { return ""; } 
        }
        public string GetFinalMcqMark(string Sid, string Sub)
        {
            var x = eda.FinalTermMarksTables.Where(a => a.stuId == Sid && a.subject == Sub).FirstOrDefault();
            if (x != null) { return  x.mcq.ToString(); } else { return ""; }
        }

    }
}
