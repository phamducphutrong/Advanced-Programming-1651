using System;

namespace HelloFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = {2,4,6,3,5};

            // Console.WriteLine("Enter x: ");
            // int x = Convert.ToInt32(Console.ReadLine());
            // int position = Search(a,x);
            // if (position == -1) Console.WriteLine("Not found");
            // else Console.WriteLine("Found at " + position);

            // int sum = SumOfArray(a);
            // Console.WriteLine("The sum of array is: " + sum);

            // Console.WriteLine("1. Calculate the sum of even number in array.");
            // Console.WriteLine("2. Calculate the sum of odd number in array.");
            // Console.WriteLine("Your Choice: ");
            // int x = Convert.ToInt32(Console.ReadLine());
            // int sum;
            // if(x == 1){
            //     sum = SumEvenOrOdd(a, true);
            //     Console.WriteLine("The sum of even number in array is: " + sum);
            // } else if(x == 2) 
            // {
            //     sum = SumEvenOrOdd(a, false);
            //     Console.WriteLine("The sum of odd number in array is: " + sum);
            // } else
            // {
            //     Console.WriteLine("The input dose not exist!");
            // }

            Console.WriteLine("1. Calculate the number of even elements in array.");
            Console.WriteLine("2. Calculate the number of odd elements in array.");
            Console.WriteLine("Your Choice: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int count;
            if(x == 1){
                count = CountElementEvenOrOdd(a, true);
                Console.WriteLine("The number of even elements in array is: " + count);
            } else if(x == 2) 
            {
                count = CountElementEvenOrOdd(a, false);
                Console.WriteLine("The number of odd elements in array is: " + count);
            } else
            {
                Console.WriteLine("The input dose not exist!");
            }
        }


        static int Search(int[] arr, int x)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == x) return i;
            }
            return -1;
        }

        // write a function to calcalate the sum of array
        static int SumOfArray(int[] arr)
        {
            int sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            return sum;
        }

        // write a function to calcalate sum of even or odd numbers in array
        static int SumEvenOrOdd(int[] arr, bool even)
        {
            int sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if(even && arr[i] % 2 == 0)
                    sum += arr[i];
                if(!even && arr[i] % 2 != 0)
                    sum += arr[i];
            }
            return sum;
        }

        // write a function to count number of even or odd elements in array
        static int CountElementEvenOrOdd(int[] arr, bool even)
        {
            int count = 0;
            for(int i = 0; i <arr.Length; i++)
            {
                if(even && arr[i] % 2 == 0)
                    count++;
                if(!even && arr[i] % 2 != 0)
                    count++;
            }
            return count;
        }
    }
}