using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test3.Model;

namespace test3.BLL
{
    class StudentService
    {
        public static StudentService defaultInstance = new StudentService();
        Model1 db = new Model1();

        public void RegisterSudent(string sno, string sname,string sex,DateTime birthtime,string cname)
        {
            Student x = new Student();
            x.sno = sno;
            x.sname = sname;
            x.sex = sex;
            x.birthtime = birthtime;
            x.state = "就读";
            x.cname = cname;
            db.Student.Add(x);
            db.SaveChanges();
        }

        public void AddClass(string cno, string name, string master, DateTime entertime)
        {
            Class _class = new Class();
            _class.cno = cno;
            _class.name = name;
            _class.master = master;
            _class.entertime = entertime;
            db.Class.Add(_class);

            db.SaveChanges();
        }

        public void ChangeClass(string cno,string name, string master, DateTime entertime)
        {
            Class _class = db.Class.SingleOrDefault(x => x.cno == cno);
            if (_class == null)
                throw new Exception("该条班级记录不存在");
            _class.name = name;
            _class.master = master;
            _class.entertime = entertime;

            db.SaveChanges();
        }

        public Student findSudentBysno(string sno)
        {
            return db.Student.SingleOrDefault(x => x.sno == sno);
        }

        public void UnregisterStudent(string sno, string state)
        {
            Student x = db.Student.SingleOrDefault(s => s.sno == sno);
            if (x != null)
            {
                x.state = state;
                db.SaveChanges();
            }
        }

        public void StuChangeclass(string sno, string cname)
        {
            Student x = db.Student.SingleOrDefault(s => s.sno == sno);
            if (x != null)
            {
                x.cname = cname;
                db.SaveChanges();
            }
        }
        
    }
}
