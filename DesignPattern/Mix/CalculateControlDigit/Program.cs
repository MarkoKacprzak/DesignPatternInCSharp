using System;

namespace DesignPattern.Mix.CalculateControlDigit
{
    class Program
    {

        static int CalculateControlDigit(long number)
        {

            int sum = 0;
            int pos = 1;

            do
            {

                int digit = (int)(number % 10);

                if (pos % 2 ==0)
                    sum += 3 * digit;
                else
                    sum += digit;

                number /= 10;
                pos++;

            }
            while (number > 0);

            int result = sum % 11;
            if (result == 10)
                result = 1;

            return result;

        }

        public static void Run()
        {
            Console.WriteLine($"{CalculateControlDigit(82712476)}");
            Console.ReadLine();
        }
    }
}
