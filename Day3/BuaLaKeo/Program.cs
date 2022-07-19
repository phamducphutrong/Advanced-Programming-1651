using System;

namespace BuaLaKeo
{
    class Program
    {
        const int WIN = 1;
        const int DRAW = 0;
        const int LOSE = -1;
        const int ROCK = 1;
        const int SCISSOR = 2;
        const int PAPER = 3;
        static void Main(String[] args)
        {
            bool playing = true;
            while(playing)
            {
                Console.WriteLine("Hello player :D");
                int playerChoice = GetPlayerOptionChoice();
                int machineChoice = GetMachineOptionChoice();
                int gameStatus = Compare(playerChoice, machineChoice);
                playing = PrintResult(playerChoice, machineChoice, gameStatus, playing);
            }
            Console.WriteLine("Goodbye!");
        }
        static int GetPlayerOptionChoice()
        {
            Console.WriteLine("Please choose one of following options");
            Console.WriteLine("1. Rock");
            Console.WriteLine("2. Scissor");
            Console.WriteLine("3. Paper");
            Console.Write("Your choice: ");
            int playerChoice = 0;
            while(!ValidateChoice(playerChoice))
            {
                playerChoice = int.Parse(Console.ReadLine());
                if(!ValidateChoice(playerChoice)) Console.Write("Invalid Choice! Please choose again: ");
            }
            
            return playerChoice;
        }
        static bool ValidateChoice(int playerChoice)
        {
            if(playerChoice < ROCK || playerChoice > PAPER) return false;

            return true;
        }
        static int GetMachineOptionChoice()
        {
            Random rnd = new Random();
            int machineChoice = rnd.Next(ROCK,PAPER+1);
            return machineChoice;
        }
        static int Compare(int playerChoice, int machineChoice)
        {
            if (playerChoice == machineChoice) return DRAW;
            if((playerChoice == ROCK && machineChoice == SCISSOR) || (playerChoice == SCISSOR && machineChoice == PAPER) || (playerChoice == PAPER && machineChoice == ROCK)) return WIN;
            return LOSE;
        }
        static bool PrintResult(int playerChoice,int machineChoice, int gameStatus, bool playing)
        {
            switch(playerChoice)
            {
                case 1: Console.WriteLine("Your choice is Rock"); break;
                case 2: Console.WriteLine("Your choice is Scissor"); break;
                case 3: Console.WriteLine("Your choice is Paper"); break;
            }
            switch(machineChoice)
            {
                case 1: Console.WriteLine("Machine choice is Rock"); break;
                case 2: Console.WriteLine("Machine choice is Scissor"); break;
                case 3: Console.WriteLine("Machine choice is Paper"); break;
            }
            switch(gameStatus)
            {
                case WIN: Console.WriteLine("You won"); break;
                case DRAW: Console.WriteLine("Draw"); break;
                case LOSE: Console.WriteLine("You lose"); break;
            }
            Console.WriteLine("Do you want to play again?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");
            int playAgain = int.Parse(Console.ReadLine());
            switch(playAgain)
            {
                case 1: playing = true; break;
                case 2: playing = false; break;
            }
            return playing;
        }
    }
}