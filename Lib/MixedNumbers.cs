using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public static class MixedNumbers
    { 
        public static dynamic ConvertImproperFractionToMixedNum((int, int) fraction)
        {
            if (fraction.Item1 < fraction.Item2)
            {
                return Fractions.SimplifyFraction(fraction.Item1, fraction.Item2);
            }
            return (fraction.Item1/fraction.Item2, (fraction.Item1 - (fraction.Item1 / fraction.Item2) * fraction.Item2, fraction.Item2));
        }

        public static dynamic PointInDistance((int, int) fractionA, (int, int) fractionB, (int, int) point)
        {
            var distance = Fractions.AddFractions(fractionA, fractionB);

            return (distance.Item1 * point.Item1, distance.Item2 * point.Item2);
        }
    }
}
