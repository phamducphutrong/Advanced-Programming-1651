using System;

namespace HomeWork01_fix
{
    class Program
    {
        const int COKE = 1;
        const int WATER = 2;
        const int TEA = 3;
        const double COKE_PRICE = 2;
        const double WATER_PRICE = 1;
        const double TEA_PRICE = 1.5;
        static void Main(string[] args)
        {
            while(true)
            {
            PrintDrinkMenu();
            int drinkChoice = GetDrinkChoice();
            int nDrinks = GetNumberOfDrink();
            double payment = GetPayment(drinkChoice, nDrinks);
            PayBill(payment);
            }
        }
        static void PrintDrinkMenu()
        {
            Console.WriteLine("1. Coke ($2.0)");
            Console.WriteLine("2. Water ($1.0)");
            Console.WriteLine("3. Tea ($1.5)");
        }
        static int GetDrinkChoice()
        {
            Console.WriteLine("Choose your drink: ");
            int drinkChoice = 0;
            while(!ValidateChoice(drinkChoice))
            {
                drinkChoice = int.Parse(Console.ReadLine());
                if(!ValidateChoice(drinkChoice))
                {
                    Console.Write("Invalid choice. Please choose again: ");
                }
            }
            return drinkChoice;
        }
        static bool ValidateChoice(int drinkChoice)
        {
            if(drinkChoice < 1 || drinkChoice > 3) return false;

            return true;
        }
        static int GetNumberOfDrink()
        {
            Console.WriteLine("Number  of drinks: ");
            int nDrinks = 0;
            while(!ValidateNumberOfDrinks(nDrinks))
            {
            nDrinks = Convert.ToInt32(Console.ReadLine());
            if(!ValidateNumberOfDrinks(nDrinks))
                {
                    Console.Write("Invalid number of drinks. Please choose again: ");
                }
            }
            return nDrinks;
        }
        static bool ValidateNumberOfDrinks(int nDrinks)
        {
            if(nDrinks < 1 || nDrinks > 5) return false;

            return true;
        }
        static double GetPayment(int drinkChoice, int nDrinks)
        {
            double payment = 0;
            switch (drinkChoice)
            {
                case COKE:
                    payment = COKE_PRICE * nDrinks;
                    break;
                case WATER:
                    payment = WATER_PRICE * nDrinks;
                    break;
                case TEA:
                    payment = TEA_PRICE * nDrinks;
                    break;    
                default:
                    break;
            }
            return payment;
        }
        static void PayBill(double payment)
        {
            Console.WriteLine("Payment: $" + payment);
            bool notEnough = true;
            while(notEnough)
            {
                double coin = GetCoin();
                payment = CheckPayment(coin, payment);
                notEnough = payment > 0;
            }
        }
        static double GetCoin()
        {
            bool invalid = true;
            double coin = 0;
            while(invalid)
            {
                Console.Write("Insert coin: ");
                coin = double.Parse(Console.ReadLine());
                invalid = coin != 1 && coin != 2 && coin != 5 && coin != 10;
                if (invalid) Console.WriteLine("Invalid coin. Please insert again.");
            }
            return coin;
        }
        static double CheckPayment(double coin, double payment)
        {
            double change = coin - payment;
            if(change == 0)
            {
                Console.WriteLine("No change");
            }
            else if (change > 0)
            {
                Console.WriteLine("Change: $" + change);
            }
            else
            {
                Console.WriteLine("Thieu: " + (-change));
            }
            return -change;
        }
    }
}