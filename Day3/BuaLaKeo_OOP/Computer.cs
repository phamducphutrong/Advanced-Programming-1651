using System;

namespace BuaLaKeo_OOP
{
    public class Computer
    {
        public const int ROCK = 1;
        public const int SCISSOR = 2;
        public const int PAPER = 3;

        public int ChooseRSP()
        {
            Random rnd = new Random();
            int choice = rnd.Next(1, 4);
            if      (choice == ROCK)    Console.WriteLine("Computer chooses Rock");
            else if (choice == SCISSOR) Console.WriteLine("Computer chooses Scissor");
            else if (choice == PAPER)   Console.WriteLine("Computer chooses Paper");
            return choice;
        }
    }
}