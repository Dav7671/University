using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class TeacherManager
    {
        public TeacherManager()
        {
        }

        public Teacher[] Add(int countOfTeachers)
        {
            Random rnd = new Random();
            Teacher[] teachers = new Teacher[countOfTeachers];
            for (int i = 0; i < teachers.Length; i++)
            {
                teachers[i] = new Teacher($"Specialty{i}", rnd.Next(25, 63));
            }
            return teachers;
        }
        public void Print(Teacher[] teachers)
        {
            for (int i = 0; i < teachers.Length; i++)
            {
                Console.WriteLine($"Teacher{i}  {teachers[i]._specialty} {teachers[i]._age} years old ");
            }
        }
    }
}
    
  
