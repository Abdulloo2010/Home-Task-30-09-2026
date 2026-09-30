namespace Domain;

public static class Cache<T>
{
    private static List<T> values = new List<T>();
    public static void Add(T cache)
    {
        values.Add(cache);
    }

    public static List<T> Get()
    {
        return values;
    }

    public static void Remove(T cache)
    {
        values.Remove(cache);
    }
}
