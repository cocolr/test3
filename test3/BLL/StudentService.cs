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

        public void RegisterSudent(string sno, string sname,string sex,DateTime birthtime,string cno)
        {
            Student x = new Student();
            x.sno = sno;
            x.sname = sname;
            x.sex = sex;
            x.birthtime = birthtime;
            x.state = "就读";
            x.cno = cno;
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
    }
}
