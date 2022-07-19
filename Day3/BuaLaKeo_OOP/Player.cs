using System;

namespace BuaLaKeo_OOP
{
    public class Player
    {
        public const int DRAW = 4;
        public const int PLAYER_WIN = 5;
        public const int COMPUTER_WIN = 6;        
        private string name;
        private int score;
        public int Score
        {
            get { return score; }
        }
        public string Name
        {
            get { return name;}
            set { name = value; }
        }
        public void PickAName()
        {
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
        }
        public int ChooseRSP()
        {
            Console.Write("Please choose (1. Rock, 2.Scissors, 3. Paper: ");
            int choice = 0;
            while (choice < 1|| choice > 3)
            {
                choice = int.Parse(Console.ReadLine());
                if(choice < 1 || choice > 3)
                {
                    Console.Write("Invalid choice. Please choose (1. Rock, 2. Scissors, 3. Paper): ");
                }
            }
            return choice;
        }
        public bool ChoosePlayAgain()
        {
            Console.Write("Do you want to play again? (y/n): ");
            string answer = Console.ReadLine();
            return answer == "y";
        }
        public void UpdateScore(int result)
        {
            if (result == PLAYER_WIN) score++;
            else if (result == COMPUTER_WIN) score--;
        }
    }
}