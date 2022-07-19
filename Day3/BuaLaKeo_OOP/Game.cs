using System;

namespace BuaLaKeo_OOP
{
    public class Game
    {
        public const int ROCK = 1;
        public const int SCISSOR = 2;
        public const int PAPER = 3;
        public const int DRAW = 4;
        public const int PLAYER_WIN = 5;
        public const int COMPUTER_WIN = 6;
        private Player player;
        private Computer computer;
        private int nGames;
        public Game()
        {
            player = new Player();
            computer = new Computer();
            nGames = 0;
        }
        public void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to Rock, Scissors, Paper!");
            player.PickAName();
        }
        public void PrintGoodbyeMessage()
        {
            Console.WriteLine("Thank {0} for playing", player.Name);
            Console.WriteLine("Your final score is {0}", player.Score);
            Console.WriteLine("Total number of games played: {0}", nGames);
        }
        public int CompareResult(int playerChoice, int computerChoice)
        {
            if (playerChoice == computerChoice) return DRAW;
            if ((playerChoice == ROCK && computerChoice == SCISSOR) ||
               (playerChoice == SCISSOR && computerChoice == PAPER)||
               (playerChoice == PAPER && computerChoice == ROCK)) return PLAYER_WIN;
            return COMPUTER_WIN;
        }
        public void PrintResult(int result)
        {
            if (result == DRAW) Console.WriteLine("It's a draw!");
            else if (result == PLAYER_WIN) Console.WriteLine("{0} win!", player.Name);
            else if (result == COMPUTER_WIN) Console.WriteLine("Computer wins!");

            Console.WriteLine("{0}'s score: {1}", player.Name , player.Score);
        }
        public void Play()
        {
            PrintWelcomeMessage();
            bool playing = true;
            while(playing)
            {
                int playerChoice = player.ChooseRSP();
                int computerChoice = computer.ChooseRSP();
                int result = CompareResult(playerChoice, computerChoice);
                PrintResult(result);
                player.UpdateScore(result);
                nGames++;
                playing = player.ChoosePlayAgain();
            }
            PrintGoodbyeMessage();
        }
    }
}