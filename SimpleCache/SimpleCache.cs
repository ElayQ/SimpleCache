public class SimpleCache
{
    private Dictionary<int, int> _cache = new();
    private void GetOrCreate(int key, Func<int, int> createItem)
    {
        if (_cache.ContainsKey(key))
        {
            Console.WriteLine("Взято из кеша: {0}", _cache[key]);
            return;
        }
        int result = createItem(key);
        _cache[key] = result;
        Console.WriteLine("Взято из функции: {0}", _cache[key]);
    }
    private int Factorial(int n)
    {
        if (n == 1) return n;
        return n * Factorial(n - 1);
    }

    public void factorial(int n) => GetOrCreate(n, Factorial);
}