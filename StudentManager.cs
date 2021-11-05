using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class StudentManager
    {
        public Student[] Add(int countOfStudents)
        {
            Random rnd = new Random();
            Student[] students = new Student[countOfStudents];
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Student($"Student{i}", rnd.Next(18, 20));
            }
            return students;
        }
        public void Print(Student[] students)
        {
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"{students[i]._name} {students[i]._age} years old");
            }
        }
    }
}
