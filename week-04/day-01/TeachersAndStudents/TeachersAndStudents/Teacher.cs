using System;

namespace TeachersAndStudents
{
    public class Teacher
    {
        public void Answer()
        {
            Console.WriteLine("Read the documentation.");
        }
        public void Teach(Student student)
        {
            student.Learn();
        }
    }
}