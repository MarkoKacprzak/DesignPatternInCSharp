using System;
using System.Collections.Generic;

namespace DesignPattern.Mix.CalculateControlDigit
{
    class Program
    {

        static int CalculateControlDigit(long number)
        {

            int sum = 0;
            int factor = 1;

            do
            {

                int digit = (int)(number % 10);
                sum += factor * digit;
                factor = 4 - factor;
                number /= 10;
            }
            while (number > 0);

            int result = sum % 11;
            if (result == 10)
                result = 1;

            return result;

        }
        static int CalculateControlDigitOptimization(long number)
        {

            int sum = 0;

            var factors = GetMultiplicativeFactors().GetEnumerator();
            var weightedDigits = new List<int>();
            foreach (var digit in GetDigitsFromSignificant(number))
            {
                factors.MoveNext();
                weightedDigits.Add(factors.Current * digit);
            }
            foreach(int weightedDigit in weightedDigits)
            {
                sum += weightedDigit;
            }
            int result = sum % 11;
            if (result == 10)
                result = 1;

            return result;

        }

        private static IEnumerable<int> GetMultiplicativeFactors()
        {
            return new int[]{ 1, 3, 1, 3, 1, 3, 1, 3, 1, 3, 1, 3, 1, 3, 1, 3, 1, 3 };
        }

        private static IEnumerable<int> GetDigitsFromSignificant(long number)
        {
            var digits = new List<int>();
            do
            {

                int digit = (int)(number % 10);
                // sum += factor * digit;
                // factor = 4 - factor;
                digits.Add(digit);
                number /= 10;
            }
            while (number > 0);
            return digits;
        }

        public static void Run()
        {
            Console.WriteLine($"{CalculateControlDigitOptimization(82712476)}");
            Console.ReadLine();
        }
    }
}
