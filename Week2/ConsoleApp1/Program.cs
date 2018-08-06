
using System;

class Program
{
    public static int Fibonacci(int n)
    {
        int a = 0;
        int b = 1;
      
        for (int i = 0; i < n; i++)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }
        return a;
    }

    static void Main()
    {
        Console.WriteLine("Enter highest sequence itteration to find fibonacci numbers: ");

        int length = int.Parse(Console.ReadLine());
        for (int i = 0; i < length; i++)
        {
            Console.WriteLine(Fibonacci(i));
        }
    }
}

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter highest range within to find prime numbers: ");

            int length = int.Parse(Console.ReadLine());

            bool isPrime = true;



            Console.WriteLine("Prime Numbers : ");
            for (int i = 2; i <= length; i++)
            {
                for (int j = 2; j <= length; j++)
                {

                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }

                }
                if (isPrime)
                {
                    Console.Write("\t" + i);
                }
                isPrime = true;
            }
            Console.ReadKey();
        }
    }
}