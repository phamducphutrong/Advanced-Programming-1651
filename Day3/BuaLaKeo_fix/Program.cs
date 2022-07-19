using System;

namespace ProceduralRSP
{
    class Program
    {
        const int DRAW = 0;
        const int PLAYER_WIN = 1;
        const int COMPUTER_WIN = 2;
        const int ROCK = 1;
        const int SCISSOR = 2;
        const int PAPER = 3;

        static void Main(string[] args)
        {
            string playerName = WelcomePlayer();
            bool playing = true;
            int score = 0;
            int nGames = 0;
            while (playing)
            {
                int playerChoice = PlayerChooseRSP(playerName);
                int computerChoice = ComputerChooseRSP();
                int gameStatus = Compare(playerChoice, computerChoice, playerName);
                score = UpdateScore(gameStatus, score);
                PrintResult(gameStatus, playerName, score);
                nGames++;
                playing = PlayerChoosePlayAgain();
            }
            PrintGoodbyeMessage(playerName, score, nGames);
        }
        static string WelcomePlayer()
        {
            Console.WriteLine("Welcome to Rock, Scissors, Paper!");
            Console.Write("Please enter your name: ");
            return Console.ReadLine();
        }
        static void PrintGoodbyeMessage(string playerName, int score, int nGames)
        {
            Console.WriteLine("Thank you for playing, {0}!", playerName);
            Console.WriteLine("You won {0} scores out of {1} games.", score, nGames);
        }
        
        static int PlayerChooseRSP(string playerName)
        {
            Console.WriteLine("{0}, please choose: 1. Rock, 2. Scissors, 3. Paper", playerName);
            int choice = int.Parse(Console.ReadLine());
            while (choice < 1 || choice > 3)
            {
                Console.WriteLine("Invalid choice. Please choose: 1. Rock, 2. Scissors, 3. Paper");
                choice = int.Parse(Console.ReadLine());
            }
            return choice;
        }
        static int ComputerChooseRSP()
        {
            Random random = new Random();
            int choice = random.Next(1, 4);
            if (choice == ROCK)         Console.WriteLine("Computer chooses Rock"    );
            else if (choice == SCISSOR) Console.WriteLine("Computer chooses Scissors");
            else                        Console.WriteLine("Computer chooses Paper"   );
            return choice;
        }
        static int Compare(int playerChoice, int computerChoice, string playerName)
        {
            if (playerChoice == computerChoice) return DRAW;
            if ((playerChoice == ROCK    && computerChoice == SCISSOR) ||
                (playerChoice == SCISSOR && computerChoice == PAPER)   ||
                (playerChoice == PAPER   && computerChoice == ROCK))   return PLAYER_WIN;
         
            return COMPUTER_WIN;
        }
        static void PrintResult(int gameStatus, string playerName, int score)
        {
            if (gameStatus == DRAW)
            {
                Console.WriteLine("Draw Game!");
            }
            else if (gameStatus == PLAYER_WIN)
            {
                Console.WriteLine("Player {0} win!", playerName);
            }
            else
            {
                Console.WriteLine("Computer wins!");
            }
            Console.WriteLine("Current {0}'s score: {1}", playerName, score);
        }
        static bool PlayerChoosePlayAgain()
        {
            Console.WriteLine("Do you want to play again? (y/n)");
            string answer = Console.ReadLine();
            return answer.ToLower() == "y";
        }
        static int UpdateScore(int gameStatus, int score)
        {
            if (gameStatus == PLAYER_WIN) score++;
            else if (gameStatus == COMPUTER_WIN) score--;
            return score;
        }
    }
}