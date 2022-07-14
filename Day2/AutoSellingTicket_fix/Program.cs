using System;

namespace MovieTicketMachine
{
    class Program
    {
        const int ADULT_PRICE = 2;
        const int CHILD_PRICE = 1;
        static void Main(string[] args)
        {
            while (true)
            {
                PrintShowingMovies();
                string movie = GetMovie();
                int nAdultTickets = GetNumberOfAdultTickets();
                int nChildrenTickets = GetNumberOfChildrenTickets();
                int payment = PrintBill(movie, nAdultTickets, nChildrenTickets);
                Pay(movie, payment);
            }
        }
        static void PrintShowingMovies()
        {
            Console.WriteLine("Showing movies:");
            Console.WriteLine("1. Minion");
            Console.WriteLine("2. Thor 4");
            Console.WriteLine("3. Top Gun");
        }
        static string GetMovie()
        {
            Console.Write("Your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            string movie = "";
            switch (choice)
            {
                case 1: movie = "Minion"; break;
                case 2: movie = "Thor 4"; break;
                case 3: movie = "Top Gun"; break;
                default: break;
            }
            return movie;
        }
        static int GetNumberOfAdultTickets()
        {
            Console.Write("Number of adult tickets: ");
            int nAdultTickets = Convert.ToInt32(Console.ReadLine());
            // Validate number of adult tickets, must be greater than 0
            return nAdultTickets;
        }
        static int GetNumberOfChildrenTickets()
        {
            Console.Write("Number of children tickets: ");
            int nChildrenTickets = Convert.ToInt32(Console.ReadLine());
            // Validate number of children tickets, must > 0
            return nChildrenTickets;
        }
        static int PrintBill(string movie, int nAdultTickets, int nChildrenTickets)
        {
            int payment = nAdultTickets * ADULT_PRICE + nChildrenTickets * CHILD_PRICE;
            Console.WriteLine("Movie selected: " + movie);
            Console.WriteLine("Number of adult tickets: " + nAdultTickets);
            Console.WriteLine("Number of children tickets: " + nChildrenTickets);
            Console.WriteLine("Your payment is: $" + payment);
            return payment;
        }
        static void Pay(string movie, int payment)
        {
            Console.Write("Enter payment amount: ");
            int amount = Convert.ToInt32(Console.ReadLine());
            // HW: validate amount, enter until enough
            int change = amount - payment;
            Console.WriteLine("Change: $" + change);
            Console.WriteLine("Enjoy your movie: " + movie);
        }
    }
}