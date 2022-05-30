namespace Lib;

public static class Fractions
{
    public static bool IsPrime(int num)
    {
        for (int i = 2; i < num; i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }
        return true;
    }
    
    public static int FindCommonMultiples(int numA, int numB, int iterations)
    {
        for (int i = 1; i <= iterations; i++)
        {
            int resultA = numA * i;
            for (int j = 1; j <= iterations; j++)
            {
                int resultB = numB * j;
                if (resultB == resultA)
                {
                    return resultB;
                }
            }
        }

        return 0;
    }
}