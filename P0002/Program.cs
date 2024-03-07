// foreach (int i in Fibonacci(4_000_000))
// {
//     Console.WriteLine($"{i}");
// }

Console.WriteLine($"{Fibonacci(4_000_000).Where(x => x % 2 == 0).Sum()}");

IEnumerable<int> Fibonacci(int limit)
{
    yield return 1;
    yield return 2;

    int a = 1;
    int b = 2;
    while (a + b < limit)
    {
        int c = a + b;
        yield return c;
        a = b;
        b = c; 
    }
}
