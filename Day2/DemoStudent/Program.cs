using System;

namespace DemoStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            Student john = new Student();
            john.Name = "John";
            john.Age = 20;
            john.GPA = 7.5;
            john.PrintInfo();
        }
    }
}