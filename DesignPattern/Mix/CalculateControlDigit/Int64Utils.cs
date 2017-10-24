using System.Collections.Generic;

namespace DesignPattern.Mix.CalculateControlDigit
{
    static class  Int64Utils
    {
        public static IEnumerable<int> GetDigitsFromSignificant(this long number)
        {
            do
            {
                yield return (int)(number % 10);
                number /= 10;
            }
            while (number > 0);
        }
    }
}
