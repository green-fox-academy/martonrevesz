using System;

namespace GreenFoxOrganization
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public Person(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public Person()
        {
            Name = "Jane Doe";
            Age = 30;
            Gender = "female";
        }

        public virtual void Introduce()
        {
            Console.WriteLine("Hi, I'm {0}, a {1} year old {2}.", Name, Age, Gender);
        }

        public virtual void GetGoal()
        {
            Console.WriteLine("My goal is: Live for the moment!");
        }
    }
}