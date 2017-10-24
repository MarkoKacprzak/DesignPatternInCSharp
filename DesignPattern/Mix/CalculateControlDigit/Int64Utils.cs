using System.Collections.Generic;

namespace DesignPattern.Mix.CalculateControlDigit
{
    static class  Int64Utils
    {
        public static IEnumerable<int> GetDigitsFromSignificant(this long number)
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
    }
}
