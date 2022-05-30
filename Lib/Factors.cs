namespace Lib;

public static class Factors
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

    public static int[] ProductOfPrimes(int num)
    {
        List<int> primes = new List<int>();

        var finalPrime = FindPrimes(primes, num);
        
        primes.Add(finalPrime);
        
        return primes.ToArray();
    }

    private static int FindPrimes(List<int> primes, int num)
    {
        bool isDivisible = false;
        int i = 2;
        int prime = 1;
        int division = 0;
        while (!isDivisible)
        {
            if (num % i == 0)
            {
                prime = i;
                isDivisible = true;
                division = num / prime;
            }
            else
            {
                i++;
            }
        }
        
        primes.Add(prime);
        if (!IsPrime(division)) return FindPrimes(primes, division);
        return division;
    }

    public static string Beautify(this int[] arr)
    {
        string value = "";
        foreach (var i in arr)
        {
            value += $" {i}";
        }
        return value.Trim();
    }
}