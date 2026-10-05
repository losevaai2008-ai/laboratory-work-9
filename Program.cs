using System;

namespace SolutionApp1
{
    public class PrimeChecker
    {
        public bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            int boundary = (int)Math.Floor(Math.Sqrt(number));
            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PrimeChecker checker = new PrimeChecker();
            int testNumber = 17;

            if (checker.IsPrime(testNumber))
                Console.WriteLine($"Число {testNumber} — ПРОСТОЕ.");
            else
                Console.WriteLine($"Число {testNumber} — СОСТАВНОЕ.");
        }
    }
}
