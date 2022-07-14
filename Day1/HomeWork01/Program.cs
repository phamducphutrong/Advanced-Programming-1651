using System;

namespace HomeWork01
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                bool exit = false;
                Console.WriteLine("May ban hang tu dong");
                Console.WriteLine("1. Coke($2)");
                Console.WriteLine("2. Water($1)");
                Console.WriteLine("3. Tea($1.5)");
                Console.WriteLine("4. Exit!");
                Console.WriteLine("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                double priceOfCoke = 2;
                double priceOfWater = 1;
                double priceOfTea = 1.5;
                switch(choice)
                {
                    case 1:
                        Console.WriteLine("You have chosen Coke!");
                        double a = ToTalPrice(priceOfCoke, Quantity());
                        Console.WriteLine("The total price you have to pay is: $" + a);
                        Calculate(EnterMoney(), a);
                        break;
                    case 2:
                        Console.WriteLine("You have chosen Water!");
                        double b = ToTalPrice(priceOfWater, Quantity());
                        Console.WriteLine("The total price you have to pay is: $" + b);
                        Calculate(EnterMoney(), b);
                        break;
                    case 3:
                        Console.WriteLine("You have chosen Tea!");
                        double c = ToTalPrice(priceOfTea, Quantity());
                        Console.WriteLine("The total price you have to pay is: $" + c);
                        Calculate(EnterMoney(), c);
                        break;
                    case 4:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Wrong choice!");
                        break;
                }
                if(exit == true)
                {
                    break;
                }
            }
        }
        static int Quantity()
        {
            Console.WriteLine("Enter you number of drink you want to buy: ");
            int quantity = Convert.ToInt32(Console.ReadLine());
            return quantity;
        }

        static double ToTalPrice(double price, int number)
        {
            double totalPrice = price * number;
            return totalPrice;
        }

        static double EnterMoney()
        {
            Console.WriteLine("Enter your money: ");
            double pay = Convert.ToInt32(Console.ReadLine());
            return pay;
        }

        static void Calculate(double pay, double totalPrice)
        {
            if(pay > 0 && (pay == 1 || pay == 2 || pay == 5 || pay == 10))
            {
                double returnMoney = pay - totalPrice;
                totalPrice = (-returnMoney);
                if(returnMoney > 0)
                {
                    Console.WriteLine("Buy successfully!");
                    Console.WriteLine("Your change is: $" + returnMoney);
                    Console.WriteLine("------------------------");
                    
                }
                else if(returnMoney < 0)
                {
                    Console.WriteLine("Buy unsuccessfully!");
                    Console.WriteLine("Your pay did not enough to buy these drink!");
                    Console.WriteLine("You need to pay additional $" + (-returnMoney) + " to complete the bill");
                    Console.WriteLine("Please continue enter cash to pay the bill!");
                    Calculate(EnterMoney(), totalPrice);
                }
                else {
                    Console.WriteLine("Buy successfully!");
                    Console.WriteLine("You have no change!");
                    Console.WriteLine("-------------------------");
                }
            }
            else
            {
                Console.WriteLine("The cash must be positive number and must be $1 or $2 or $5 or $10");
                Console.WriteLine("-------------------------------------------------------------------");
                Calculate(EnterMoney(), totalPrice);
            }
        }
    }
}