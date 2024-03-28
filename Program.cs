
class Program
{
    static void Main()
    {
        Parallel.ForEach(Enumerable.Range(1, 100000000), num =>
        {
            Fibonacci(Math.Min(num, 15000));
        });
    }

    static int Fibonacci(int n)
    {
        if (n <= 1)
            return n;
        else
            return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}