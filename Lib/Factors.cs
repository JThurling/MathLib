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

    // TODO most common multiple -> implementation
    public static void MostCommonMultiple(int numA, int numB)
    {
        return;
    }
    
    // TODO finish implementation
    public static Dictionary<string, int> LeastCommonMultiple(int numA, int numB)
    {
        var primeFactorsA = ProductOfPrimes(numA);
        var primeFactorsB = ProductOfPrimes(numB);

        return ReturnLesserMultiple(primeFactorsA, primeFactorsB);;
    }

    private static Dictionary<string, int> ReturnLesserMultiple(int[] primeFactorsA, int[] primeFactorsB)
    {
        var dictA = GetArrValues(primeFactorsA);
        var dictB = GetArrValues(primeFactorsB);

        Dictionary<string, int> finalPrime = new Dictionary<string, int>();

        foreach (KeyValuePair<string, int> pair in dictA)
        {
            if (dictB.TryGetValue(pair.Key, out int valueB))
            {
                if (pair.Value < valueB)
                {
                    finalPrime.Add(pair.Key, valueB);
                }
                else if (pair.Value > valueB)
                {
                    finalPrime.Add(pair.Key, pair.Value);
                }
            }
            else
            {
                finalPrime.Add(pair.Key, pair.Value);
            }
        }
        
        foreach (KeyValuePair<string, int> pair in dictB)
        {
            if (finalPrime.TryGetValue(pair.Key, out int finalValue))
            {
                continue;
            }

            finalPrime.Add(pair.Key, pair.Value);
        }

        return finalPrime;
    }

    public static Dictionary<string, int> GetArrValues(int[] primeFactorsA)
    {
        Dictionary<string, int> trackingDictionaryA = new Dictionary<string, int>();

        foreach (var i in primeFactorsA)
        {
            if (!trackingDictionaryA.TryGetValue(i.ToString(), out int value))
            {
                trackingDictionaryA.Add(i.ToString(), 1);
            }
            else
            {
                trackingDictionaryA[i.ToString()]++;
            }
        }

        return trackingDictionaryA;
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