namespace Ninjasoft.Extensions
{
    public static class IEnumerableExtensions
    {
        public static Queue<T> ToQueue<T>(this IEnumerable<T> source)
        {
            if (source == null)
                return new Queue<T>();

            Queue<T> q = new Queue<T>();
            foreach(T item in source)
                q.Enqueue(item);
            return q;
        }

        public static bool None<T>(this IEnumerable<T> source) => !source.Any();
    }
}
