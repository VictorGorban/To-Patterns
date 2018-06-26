using System;
using IBools = System.Collections.Generic.IEnumerable<bool>;
using System.Linq;
namespace Handy_Extensions
{
    public static class CheckPattern
    {
        public static bool[] Check<T>(this T o, params bool[] pattern) => pattern;

        public static bool All(this IBools pattern, bool value)
        {
            return pattern.All(x => x.Equals(value));
        }

        public static bool Any(this IBools pattern, bool value) =>
            pattern.Any(x => x.Equals(value));
        

        public static int Count(this IBools pattern, bool value) =>
            pattern.Count(x => x.Equals(value));
    }

}