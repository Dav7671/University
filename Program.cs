using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentManager sm = new StudentManager();
            Student[] students = sm.Add(19);
            sm.Print(students);

            TeacherManager tm = new TeacherManager();
            Teacher[] teachers = tm.Add(3);
            tm.Print(teachers);
            Console.ReadKey();
            

        }
    }
}
