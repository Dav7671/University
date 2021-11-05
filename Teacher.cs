using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class Teacher
    {
        public Guid _id;
        public string _specialty;
        public int _age;
        public Student[] students;
        public Teacher(string specialty, int age)
        {
            _id = Guid.NewGuid();
            _specialty = specialty;
            _age = age;
        }
        
    }
}
