namespace Lib;

public static class Fractions
{
    public static float Percent(float num)
    {
        return (num / 100) * 100;
    }
    
    public static float Percent(float numerator, float denominator)
    {
        if (numerator > denominator)
        {
            return float.NaN;
        }
        
        return (numerator / denominator) * 100;
    }
    public static (int, int) SimplifyFraction(int numerator, int denominator)
    {
        int[] num = Factors.ProductOfPrimes(numerator);
        int[] den = Factors.ProductOfPrimes(denominator);
        
        return CancelOutPrimes(num, den);
    }

    private static (int, int) CancelOutPrimes(int[] num, int[] den)
    {
        for (int i = 0; i < num.Length; i++)
        {
            for (int j = 0; j < den.Length; j++)
            {
                if (num[i] == den[j])
                {
                    num = num.Where((source, index) => index != i).ToArray();
                    den = den.Where((source, index) => index != j).ToArray();
                    i = 0;
                }
            }
        }

        return (num.Multiply(), den.Multiply());
    }

    // TODO fractionLowestTerms = 2 fractions
    public static (int, int) FractionLowestTerms((int, int) fractionA, (int, int) fractionB)
    {
        (int, int) fractionToBeSimplified = (fractionA.Item1 * fractionB.Item1, fractionA.Item2 * fractionB.Item2);
        
        return SimplifyFraction(fractionToBeSimplified.Item1, fractionToBeSimplified.Item2);
    }
    public static (int, int) IncreaseFractionByMultiplication((int, int) fractionA, int multipliedBy)
    {
        return (fractionA.Item1 * multipliedBy, fractionA.Item2 * multipliedBy);
    }

    public static (int, int) AddFractions((int, int) fractionA, (int, int) fractionB)
    {
        int leastCommonMultiple = Factors.LeastCommonMultiple(fractionA.Item2, fractionB.Item2);

        int timesDividedByFractionA = leastCommonMultiple / fractionA.Item2;
        int timesDividedByFractionB = leastCommonMultiple / fractionB.Item2;

        int timesDivisionA = timesDividedByFractionA * fractionA.Item1;
        int timesDivisionB = timesDividedByFractionB * fractionB.Item1;

        return (timesDivisionA + timesDivisionB, leastCommonMultiple);
    }
    
    public static (int, int) SubtractFractions((int, int) fractionA, (int, int) fractionB)
    {
        int leastCommonMultiple = Factors.LeastCommonMultiple(fractionA.Item2, fractionB.Item2);

        int timesDividedByFractionA = leastCommonMultiple / fractionA.Item2;
        int timesDividedByFractionB = leastCommonMultiple / fractionB.Item2;

        int timesDivisionA = timesDividedByFractionA * fractionA.Item1;
        int timesDivisionB = timesDividedByFractionB * fractionB.Item1;

        return (timesDivisionA - timesDivisionB, leastCommonMultiple);
    }
    
    public static float? Division(float numerator, float denominator)
    {
        if (denominator == 0)
        {
            return null;
        }
        return numerator / denominator;
    }

    public static int Multiply(this int[] arr)
    {
        int value = 1;

        for (int i = 0; i < arr.Length; i++)
        {
            value *= arr[i];
        }

        return value;
    }

    public static string Beautify(this (int, int) fraction)
    {
        return $"{fraction.Item1}\n----\n{fraction.Item2}";
    }
}