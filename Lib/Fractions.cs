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
        return (1, 1);
    }
    
    // TODO IncreaseFractionByMultiplication = 2 fractions
    public static (int, int) IncreaseFractionByMultiplication((int, int) fractionA, int multipliedBy)
    {
        return (1, 1);
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