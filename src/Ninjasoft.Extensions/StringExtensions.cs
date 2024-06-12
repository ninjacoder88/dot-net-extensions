namespace Ninjasoft.Extensions
{
    public static class StringExtensions
    {
        public static int ParseInt(this string str) => int.Parse(str);

        public static decimal ParseDecimal(this string str) => decimal.Parse(str);

        public static double ParseDouble(this string str) => double.Parse(str);

        public static bool ParseBool(this string str) => bool.Parse(str);

        public static int? TryParseInt(this string str)
        {
            if(int.TryParse(str, out int result))
                return result;
            return null;
        }

        public static decimal? TryParseDecimal(this string str)
        {
            if (decimal.TryParse(str, out decimal result))
                return result;
            return null;
        }

        public static double? TryParseDouble(this string str)
        {
            if (double.TryParse(str, out double result))
                return result;
            return null;
        }

        public static bool? TryParseBool(this string str)
        {
            if (bool.TryParse(str, out bool result))
                return result;
            return null;
        }
    }
}
