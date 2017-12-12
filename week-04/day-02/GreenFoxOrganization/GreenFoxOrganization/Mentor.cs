namespace GreenFoxOrganization
{
    public class Mentor : Person
    {
        public string Level { get; set; }

        public Mentor(string name, int age, string gender, string level) : base(name, age, gender)
        {
            Level = level;
        }

        public Mentor()
        {
            Name = "Jane Doe";
            Age = 30;
            Gender = "female";
            Level = "intermediate";
        }

        public override void Introduce()
        {
            System.Console.WriteLine("Hi, I'm {0}, a {1} year old {2} {3} mentor.", Name, Age, Gender, Level);
        }

        public override void GetGoal()
        {
            System.Console.WriteLine("Educate brilliant junior software developers.");
        }
    }
}