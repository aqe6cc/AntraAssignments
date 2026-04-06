using System;
using System.Collections.Generic;
static int[] FindPrimesInRange(int start, int end)
{
    List<int> primes = new List<int>();
    for (int i = start; i <= end; i++)
    {
        if (i < 2) continue;
        bool isPrime = true;
        for (int j = 2; j <= Math.Sqrt(i); j++)
        {
            if (i % j == 0)
            {
                isPrime = false;
                break;
            }
        }
        if (isPrime)
            primes.Add(i);
    }
    return primes.ToArray();
}
Console.WriteLine(string.Join(", ", FindPrimesInRange(1, 10)));