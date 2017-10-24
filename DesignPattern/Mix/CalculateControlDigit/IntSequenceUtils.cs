using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.Mix.CalculateControlDigit
{
    static class IntSequenceUtils
    {
        public static IEnumerable<int> AddWeights(this IEnumerable<int> values,
            IEnumerable<int> factors)
        {
            return values.Zip(factors, (d, f) => d * f);
        }
    }
}
