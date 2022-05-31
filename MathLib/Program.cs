// See https://aka.ms/new-console-template for more information

using Lib;

var leastPrime = Factors.LeastCommonMultiple(10, 24);

foreach (KeyValuePair<string, int> pair in leastPrime)
{
    Console.WriteLine($"{pair.Key}: {pair.Value}");
}