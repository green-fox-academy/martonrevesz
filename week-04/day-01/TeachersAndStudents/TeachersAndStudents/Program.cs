using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachersAndStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            var teacher = new Teacher();
            var student = new Student();
            teacher.Teach(student);
            student.Question(teacher);
            Console.ReadLine();
        }
    }
}
