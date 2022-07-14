using System;

namespace AutoSellingTicket
{
    class Program
    {
        const double ADULT_TICKET_PRICE = 2;
        const double CHILDREN_TICKET_PRICE = 2;
        static void Main(string[] args)
        {
            while(true)
            {
            PrintTicketMenu();
            int movieChoice = GetMovieChoice();
            int nAdultTickets = GetNumberOfAdultTicket();
            int nChildrenTickets = GetNumberOfChildrenTicket();
            double payment = GetPayment(nAdultTickets,nChildrenTickets);
            PayBill(payment, movieChoice);
            }
        }
        static void PrintTicketMenu()
        {
            Console.WriteLine("1. Minion");
            Console.WriteLine("2. Thor 4");
            Console.WriteLine("3. Top Gun");
        }
        static int GetMovieChoice()
        {
            Console.WriteLine("Choose movie: ");
            int movieChoice = 0;
            while(!ValidateChoice(movieChoice))
            {
                movieChoice = int.Parse(Console.ReadLine());
                if(!ValidateChoice(movieChoice))
                {
                    Console.Write("Invalid choice. Please choose again: ");
                }
            }
            return movieChoice;
        }
        static bool ValidateChoice(int movieChoice)
        {
            if(movieChoice < 1 || movieChoice > 3) return false;

            return true;
        }
        static int GetNumberOfAdultTicket()
        {
            Console.WriteLine("Number  of adult tickets: ");
            int nAdultTickets = 0;
            while(!ValidateNumberOfAdultTickets(nAdultTickets))
            {
            nAdultTickets = Convert.ToInt32(Console.ReadLine());
            if(!ValidateNumberOfAdultTickets(nAdultTickets))
                {
                    Console.Write("Invalid number of adult ticket. Please choose again: ");
                }
            }
            return nAdultTickets;
        }
        static bool ValidateNumberOfAdultTickets(int nAdultTickets)
        {
            if(nAdultTickets < 1 || nAdultTickets > 5) return false;

            return true;
        }
        static int GetNumberOfChildrenTicket()
        {
            Console.WriteLine("Number  of children tickets: ");
            int nAdultTickets = 0;
            while(!ValidateNumberOfChildrenTickets(nAdultTickets))
            {
            nAdultTickets = Convert.ToInt32(Console.ReadLine());
            if(!ValidateNumberOfChildrenTickets(nAdultTickets))
                {
                    Console.Write("Invalid number of adult ticket. Please choose again: ");
                }
            }
            return nAdultTickets;
        }
        static bool ValidateNumberOfChildrenTickets(int nChildrenTickets)
        {
            if(nChildrenTickets < 1 || nChildrenTickets > 5) return false;

            return true;
        }
        static double GetPayment(int nAdultTickets, int nChildrenTickets)
        {
            double payment = 0;
            payment =  (nAdultTickets * ADULT_TICKET_PRICE) + (nChildrenTickets * CHILDREN_TICKET_PRICE);
            return payment;
        }
        static void PayBill(double payment, int movieChoice)
        {
            if (movieChoice == 1) Console.WriteLine("Selected moive: Minion");
            else if (movieChoice == 2) Console.WriteLine("Selected moive: Thor 4");
            else Console.WriteLine("Selected moive: Top Gun");
            Console.WriteLine("Your bill: $" + payment);
            bool notEnough = true;
            while(notEnough)
            {
                double coin = GetCoin();
                payment = CheckPayment(coin, payment);
                notEnough = payment > 0;
            }
            if (movieChoice == 1) Console.WriteLine("Thank you and happy watching Minion");
            else if (movieChoice == 2) Console.WriteLine("Thank you and happy watching Thor 4");
            else Console.WriteLine("Thank you and happy watching Top Gun");
        }
        static double GetCoin()
        {
            bool invalid = true;
            double coin = 0;
            while(invalid)
            {
                Console.Write("Enter your payment: ");
                coin = double.Parse(Console.ReadLine());
                invalid = coin != 1 && coin != 2 && coin != 5 && coin != 10;
                if (invalid) Console.WriteLine("Invalid money. Please insert again.");
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