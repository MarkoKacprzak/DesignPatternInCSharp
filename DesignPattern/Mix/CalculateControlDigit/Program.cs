using System;
using System.Collections.Generic;
using System.Linq;

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
            var digits = number.GetDigitsFromSignificant();
            var weightedDigits =
                digits.Zip(GetMultiplicativeFactors, 
                    (d, f) => d * f);
            int sum = weightedDigits.Sum();
            int result = sum % 11;
            if (result == 10)
                result = 1;

            return result;

        }

        private static IEnumerable<int> GetMultiplicativeFactors=>
            new int[]{ 1, 3, 1, 3, 1, 3, 1, 3, 1, 3, 1, 3, 1, 3, 1, 3, 1, 3 };

     
        public static void Run()
        {
            Console.WriteLine($"{CalculateControlDigitOptimization(82712476)}");
            Console.ReadLine();
        }
    }
}
