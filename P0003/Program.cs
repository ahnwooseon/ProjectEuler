// foreach (long i in PrimeFactors(13_195))
// {
//     Console.WriteLine(i);
// }

long n = 600_851_475_143;
Console.WriteLine($"{PrimeFactors(n).Last()}");

IEnumerable<long> PrimeFactors(long n)
{
    for (int i = 3; i <= Math.Sqrt(n); i = i + 2)
    {
        if (n % i == 0 && IsPrimeNumber(i))
        {
            yield return i;
        }
    }
}

bool IsPrimeNumber(int n)
{
    for (int i = 2; i <= Math.Sqrt(n); i++)
    {
        if (n % i == 0)
        {
            return false;
        }
    }

    return true;
}
