using System;

namespace HomeWork02
{
    class Program
    {
        const int DANANG = 1;
        const int HALONG = 2;
        const int PHUYEN = 3;
        const double DANANG_ADULT_PRICE = 100;
        const double DANANG_CHILDERN_PRICE = 50;
        const double HALONG_ADULT_PRICE = 60;
        const double HALONG_CHILDERN_PRICE = 30;
        const double PHUYEN_ADULT_PRICE = 120;
        const double PHUYEN_CHILDERN_PRICE = 80;
        const double DISCOUNT_ADULT = 50;
        const double DISCOUNT_CHILDREN = 25;
        const int YOURSELF = 1;
        static void Main(string[] args)
        {
            while(true)
            {
                PrintVacationPlace();
                int placeChoice = GetVacationPlaceChoice();
                int nAdults = GetNumberOfAdults();
                int nChildrens = GetNumberOfChildrens();
                double payment = GetPaymentWithoutDiscount(placeChoice,nAdults,nChildrens);
                double totalDiscount = GetDiscount(nAdults,nChildrens);
                double finalPayment = GetFinalPayment(payment, totalDiscount);
                PrintBill(placeChoice, payment,totalDiscount, finalPayment);
                break;
            }
        }
        static void PrintVacationPlace()
        {
            Console.WriteLine("Đa Nang ($100 for adult, $50 for children)");
            Console.WriteLine("Ha Long ($60 for adult, $30 for children)");
            Console.WriteLine("Phu Yen ($120 for adult, $80 for children)");
        }
        static int GetVacationPlaceChoice()
        {
            Console.Write("Choose vacation place: ");
            int placeChoice = 0;
            while(!ValidateChoice(placeChoice))
            {
                placeChoice = int.Parse(Console.ReadLine());
                if(!ValidateChoice(placeChoice))
                {
                    Console.Write("Invalid choice. Please enter again: ");
                }

            }
            return placeChoice;
        }
        static bool ValidateChoice(int placeChoice)
        {
            if(placeChoice < DANANG || placeChoice > PHUYEN) return false;

            return true;
        }
        static string GetPlaceName(int placeChoice)
        {
            string placeName = "";
            switch(placeChoice)
            {
                case DANANG: placeName = "Da Nang"; break;
                case HALONG: placeName = "Ha Long"; break;
                case PHUYEN: placeName = "Phu Yen"; break;
            }
            return placeName;
        }
        static int GetNumberOfAdults()
        {
            Console.Write("Number of adults: ");
            int nAdults = -1;
            while(!ValidateNumberOfAdults(nAdults))
            {
                nAdults = int.Parse(Console.ReadLine());
                if(!ValidateNumberOfAdults(nAdults))
                {
                    Console.Write("Number of adults just can be 0 or 1! Please enter again: ");
                }
            }
            return nAdults;
        }
        static bool ValidateNumberOfAdults(int nAdults)
        {
            if(nAdults < 0 || nAdults > 1) return false;

            return true;
        }
        static int GetNumberOfChildrens()
        {
            Console.Write("Number of childrens: ");
            int nChildrens = -1;
            while(!ValidateNumberOfChildrens(nChildrens))
            {
                nChildrens = int.Parse(Console.ReadLine());
                if(!ValidateNumberOfChildrens(nChildrens))
                {
                    Console.Write("Number of childrens just can be 0 to 4! Please enter again: ");
                }
            }
            return nChildrens;
        }
        static bool ValidateNumberOfChildrens(int nChildrens)
        {
            if(nChildrens < 0 || nChildrens > 4) return false;

            return true;
        }
        static double GetPaymentWithoutDiscount(int placeChoice, int nAdults, int nChildrens)
        {
            double payment = 0;
            if(placeChoice == DANANG)
            {
                payment = (YOURSELF + nAdults) * DANANG_ADULT_PRICE + nChildrens * DANANG_CHILDERN_PRICE;
            }
            else if(placeChoice == HALONG)
            {
                payment = (YOURSELF + nAdults) * HALONG_ADULT_PRICE + nChildrens * HALONG_CHILDERN_PRICE;
            }
            else
            {
                payment = (YOURSELF + nAdults) * PHUYEN_ADULT_PRICE + nChildrens * PHUYEN_CHILDERN_PRICE;
            }
            return payment;
        }
        static double GetDiscount(int nAdults, int nChildrens)
        {
            double totalDiscount = nAdults * DISCOUNT_ADULT + nChildrens * DISCOUNT_CHILDREN;
            return totalDiscount;
        }
        static double GetFinalPayment(double payment, double totalDiscount)
        {
            double finalPayment = payment - totalDiscount;
            return finalPayment;
        }
        static void PrintBill(int placeChoice, double payment, double totalDiscount, double finalPayment)
        {
            Console.WriteLine("You have chosen " + GetPlaceName(placeChoice));
            Console.WriteLine("Your total price without discount is: " + payment);
            Console.WriteLine("You have received $" + totalDiscount + " discount!");
            Console.WriteLine("You have to pay $" + finalPayment);
        }
    }
}