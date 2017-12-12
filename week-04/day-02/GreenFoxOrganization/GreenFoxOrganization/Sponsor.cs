namespace GreenFoxOrganization
{
    public class Sponsor : Person
    {
        public string Company { get; set; }
        public int HiredStudents { get; set; }

        public Sponsor()
        {
            Name = "Jane Doe";
            Age = 30;
            Gender = "female";
            Company = "Google";
            HiredStudents = 0;
        }

        public Sponsor(string name, int age, string gender, string company) : base(name, age, gender)
        {
            this.Company = company;
            HiredStudents = 0;
        }

        public override void Introduce()
        {
            System.Console.WriteLine("Hi, I'm {0}, a {1} year old {2} who represents {3} and hired {4} students so far.", Name, Age, Gender, Company, HiredStudents);
        }

        public override void GetGoal()
        {
            System.Console.WriteLine("Hire brilliant junior software developers.");
        }

        public void Hire()
        {
            HiredStudents++;
        }
    }
}