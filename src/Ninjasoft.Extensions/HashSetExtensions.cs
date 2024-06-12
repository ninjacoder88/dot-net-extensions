namespace Ninjasoft.Extensions
{
    public static class HashSetExtensions
    {
        public static bool AddRange<T>(this HashSet<T> set, IEnumerable<T> values)
        {
            bool allAdded = true;
            foreach (var value in values)
            {
                allAdded = allAdded && set.Add(value);
            }
            return allAdded;
        }
    }
}
