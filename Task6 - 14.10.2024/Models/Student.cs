namespace Task6___14._10._2024.Models
{
    class Student
    {
        public string Name;
        public string Surname;
        public string Group;
        public int Point;
        public bool IsGraduated;

        public Student(string name, string surname, string group, int point)
        {
            Name = name;
            Surname = surname;
            Group = group;
            Point = point;

            if (point < 65)
            {
                IsGraduated = false;
            }
            else
            {
                IsGraduated = true;
            }
        }

        public void GetInfo()
        {
            Console.WriteLine($"Name: {Name}\nSurname: {Surname}\nGroup: {Group}\nPoint: {Point}\nGraduated: {IsGraduated}");
        }

        public void CheckGraduation()
        {
            if (IsGraduated == false)
            {
                Console.WriteLine($"{Name} did not graduate.");
            }
            else
            {
                Console.WriteLine($"{Name} graduated.");
            }
        }

        public void GetDiplomDegree()
        {
            if (Point < 65)
            {
                Console.WriteLine($"{Name} did not get any diploma.");
            }
            else if (Point >= 65 && Point < 80)
            {
                Console.WriteLine($"{Name} got Ordinary diploma.");
            }
            else if (Point >= 80 && Point < 90)
            {
                Console.WriteLine($"{Name} got Honor diploma.");
            }
            else
            {
                Console.WriteLine($"{Name} got High Honor diploma.");
            }
        }
    }
}
