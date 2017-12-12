namespace GreenFoxOrganization
{
    public class Student : Person
    {
        public string PreviousOrganization { get; set; }
        public int SkippedDays { get; set; }

        public Student(string name, int age, string gender, string previousOrganization) : base(name, age, gender)
        {
            PreviousOrganization = previousOrganization;
            SkippedDays = 0;
        }

        public Student() : base()
        {
            PreviousOrganization = "The School of Life";
            SkippedDays = 0;
        }


        public override void Introduce()
        {
            System.Console.WriteLine("Hi, I'm {0}, a {1} year old {2} from {3} \n" +
                "who skipped {4} days from the course already.", Name, Age, Gender, PreviousOrganization, SkippedDays  );             
        }

        public override void GetGoal()
        {
            System.Console.WriteLine("Be a junior software developer.");
        }
        public void SkipDays(int numberOfDays)
        {
            SkippedDays += numberOfDays;
        }
    }
}