using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachersAndStudents
{
    public class Student
    {
        public void Learn()
        {
            Console.WriteLine("I learn very hard.");
        }

        public void Question(Teacher teacher)
        {
            teacher.Answer();
        }
    }
}
