namespace To__Patterns
{
    public static class Right_sided_assignment_or_declaration
    {
        /// <summary>
        /// Right-sided assignment/declaration for case of type1==type2
        /// </summary>
        public static T To<T>(this T o, out T x)
        {
            x = o;
            return x;
        }

        /// <summary>
        /// Right-sided assignment/declaration for case of type1 not equals to type2.
        /// If equals, C# calls to "To<T>(this T o, out T x)"
        /// </summary>
        public static T To<T>(this object o, out T x)
            where T : class
        {
            x = (T)o;
            return x;
        }
    }
}
