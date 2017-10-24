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
        /// <summary>
        /// CalculateControlDigit method works 
        /// by taking the digits of the number starting with the least significant one, 
        /// then adding weights to each of the digits while weights are numbers 1, 3, 1, 3 in turn.
        /// Then it sums the weighted digits up and takes modulo 11 of the result.
        /// If the modular result is 10, it is replaced with value 1. The result obtained in that way is returned as
        /// the control digit
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static int CalculateControlDigitOptimization(long number)
        {
            var sum = 
                number
                .GetDigitsFromSignificant()
                .AddWeights(GetMultiplicativeFactors)
                .Sum();
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
