Console.WriteLine($"{SumOfMultiples(3, 1000) + SumOfMultiples(5, 1000) - SumOfMultiples(15, 1000)}");

int SumOfMultiples(int n, int exclusiveUpperLimit)
{
    int biggestFactor = (exclusiveUpperLimit - 1) / n;

    return n * biggestFactor * (biggestFactor + 1) / 2;
}
