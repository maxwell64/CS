using System;
using System.Collections.Generic;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            int test = 25;
            List<int> primes = new List<int>(listPrimes(test));
            foreach (int v in primes) Console.WriteLine(v);
        }
        static bool isPrime(int n)
        {
            for (int i = 2;i < n;i ++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        static List<int> listPrimes(int n)
        {
            List<int> primes = new List<int>();
            for (int i = 2;i <= n;i ++)
            {
                if (isPrime(i)) primes.Add(i);
            }
            return primes;
        }
    }
}
