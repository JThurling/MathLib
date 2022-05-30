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

    // TODO correct Algorithm
    public static int FindCommonMultiples(int numA, int numB, int iterations)
    {
        int i = 1;
        while (i < iterations)
        {
            int resultA = numA * i;
            int resultB = numB * i;
            if (resultA == resultB)
            {
                return resultA;
            }
            i++;
        }

        return 0;
    }
}