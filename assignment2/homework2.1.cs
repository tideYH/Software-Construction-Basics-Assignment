using System;
using System.Numerics;

namespace Assignment2
{
    class PrimeFactorOutput
    {
        static bool isPrime(int num)
        {
            if (num < 2) { return false; }

            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static void main(string[] args)
        {
            int a = 100;
            Console.WriteLine("数字素数因子是： {0}");
            for (int i = 2; i <= a; i++)
            {
                while (a % i == 0)
                {
                    if (isPrime(i))
                        Console.Write($"{i}, ");
                    a /= i;
                }
            }
        }

    }
}
