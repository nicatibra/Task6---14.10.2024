﻿namespace Task6___14._10._2024
{
    using Task6___14._10._2024.Models;

    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Nicat", "Ibrahimli", "BP217", 100);

            #region UserInputedVersion
            //Console.Write("Enter student's name: ");
            //string name = Console.ReadLine();

            //Console.Write("Enter student's surname: ");
            //string surname = Console.ReadLine();

            //Console.Write("Enter student's group: ");
            //string group = Console.ReadLine();

            //Console.Write("Enter student's point (0-100): ");
            //int point = int.Parse(Console.ReadLine());

            //Student student1 = new Student(name, surname, group, point);
            #endregion

            student1.GetInfo();
            student1.CheckGraduation();
            student1.GetDiplomDegree();
        }
    }
}
