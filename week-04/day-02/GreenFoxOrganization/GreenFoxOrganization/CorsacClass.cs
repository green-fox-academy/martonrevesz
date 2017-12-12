using System.Collections.Generic;

namespace GreenFoxOrganization
{
    public class CorsacClass
    { 
        public string ClassName { get; set; }
        public List<Student> Students { get; set; }
        public List<Mentor> Mentors { get; set; }

        public CorsacClass(string className)
        {
            ClassName = className;
            Students = new List<Student>();
            Mentors = new List<Mentor>();
        }

        public void AddStudent(Student student)
        {
            if (!Students.Contains(student))
            {
                Students.Add(student);
            }
        }
        public void AddMentor(Mentor mentor)
        {
            if (!Mentors.Contains(mentor))
            {
                Mentors.Add(mentor);
            }
        }

        public void Info()
        {
            System.Console.WriteLine("Corsac {0} class has {1} students and {2} mentors.", ClassName, Students.Count, Mentors.Count);
        }
    }
}