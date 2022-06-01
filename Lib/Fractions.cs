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
    
    //TODO simplifyFractionImplementation
    public static (int, int) SimplifyFraction(int numerator, int denominator)
    {
        return (1, 1);
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
}