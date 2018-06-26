using System.Diagnostics.CodeAnalysis;

namespace Handy_Extensions
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    [SuppressMessage("ReSharper", "UnusedParameter.Global")]
    public static class WithPattern
    {
        #region With for classes
        /// <summary>
        /// Does NOTHING, exist only to provide handy syntax like object1.With(
        ///                                                                     object1.field1 = value1,
        ///                                                                     object1.field2 = value2,
        ///                                                                     object1.field3 = value3
        ///                                                                    );
        /// That means such code will NOT change the object1: object1.With(     1,
        ///                                                                     2, 
        ///                                                                     3, 
        ///                                                                     "5", 
        ///                                                                     new object2
        ///                                                               );
        ///                                                                     
        /// </summary>
        public static T With<T>(this T o, params object[] pattern)
            where T : class
            => o;

        /// <summary>
        /// Does NOTHING. Exist only to provide handy syntax like object1.With(
        ///                                                                     object1.field1 = value1,
        ///                                                                     object1.field2 = value2,
        ///                                                                     object1.field3 = value3
        ///                                                                    );
        /// That means such code will NOT change the object1: object1.With(     1,
        ///                                                                     2, 
        ///                                                                     3, 
        ///                                                                     "5", 
        ///                                                                     new object2
        ///                                                               );
        /// </summary>
        public static T With<T, A>(this T o, A a)
            where T : class
            => o;

        /// <summary>
        /// Does NOTHING. Exist only to provide handy syntax like object1.With(
        ///                                                                     object1.field1 = value1,
        ///                                                                     object1.field2 = value2,
        ///                                                                     object1.field3 = value3
        ///                                                                    );
        /// That means such code will NOT change the object1: object1.With(     1,
        ///                                                                     2, 
        ///                                                                     3, 
        ///                                                                     "5", 
        ///                                                                     new object2
        ///                                                               );
        /// </summary>
        public static T With<T, A, B>(this T o, A a, B b)
            where T : class
            => o;

        /// <summary>
        /// Does NOTHING. Exist only to provide handy syntax like object1.With(
        ///                                                                     object1.field1 = value1,
        ///                                                                     object1.field2 = value2,
        ///                                                                     object1.field3 = value3
        ///                                                                    );
        /// That means such code will NOT change the object1: object1.With(     1,
        ///                                                                     2, 
        ///                                                                     3, 
        ///                                                                     "5", 
        ///                                                                     new object2
        ///                                                               );
        /// </summary>
        public static T With<T, A, B, C>(this T o, A a, B b, C c)
            where T : class
            => o;

        /// <summary>
        /// Does NOTHING. Exist only to provide handy syntax like object1.With(
        ///                                                                     object1.field1 = value1,
        ///                                                                     object1.field2 = value2,
        ///                                                                     object1.field3 = value3
        ///                                                                    );
        /// That means such code will NOT change the object1: object1.With(     1,
        ///                                                                     2, 
        ///                                                                     3, 
        ///                                                                     "5", 
        ///                                                                     new object2
        ///                                                               );
        /// </summary>
        public static T With<T, A, B, C, D>(this T o, A a, B b, C c, D d)
            where T : class
            => o;

        /// <summary>
        /// Does NOTHING. Exist only to provide handy syntax like object1.With(
        ///                                                                     object1.field1 = value1,
        ///                                                                     object1.field2 = value2,
        ///                                                                     object1.field3 = value3
        ///                                                                    );
        /// That means such code will NOT change the object1: object1.With(     1,
        ///                                                                     2, 
        ///                                                                     3, 
        ///                                                                     "5", 
        ///                                                                     new object2
        ///                                                               );
        /// </summary>
        public static T With<T, A, B, C, D, E>(this T o, A a, B b, C c, D d, E e)
            where T : class
            => o;

        /// <summary>
        /// Does NOTHING. Exist only to provide handy syntax like object1.With(
        ///                                                                     object1.field1 = value1,
        ///                                                                     object1.field2 = value2,
        ///                                                                     object1.field3 = value3
        ///                                                                    );
        /// That means such code will NOT change the object1: object1.With(     1,
        ///                                                                     2, 
        ///                                                                     3, 
        ///                                                                     "5", 
        ///                                                                     new object2
        ///                                                               );
        /// </summary>
        public static T With<T, A, B, C, D, E, F>(this T o, A a, B b, C c, D d, E e, F f)
            where T : class
            => o;

        /// <summary>
        /// Does NOTHING. Exist only to provide handy syntax like object1.With(
        ///                                                                     object1.field1 = value1,
        ///                                                                     object1.field2 = value2,
        ///                                                                     object1.field3 = value3
        ///                                                                    );
        /// That means such code will NOT change the object1: object1.With(     1,
        ///                                                                     2, 
        ///                                                                     3, 
        ///                                                                     "5", 
        ///                                                                     new object2
        ///                                                               );
        /// </summary>
        public static T With<T, A, B, C, D, E, F, G>(this T o, A a, B b, C c, D d, E e, F f, G g)
            where T : class
            => o;

        /// <summary>
        /// Does NOTHING. Exist only to provide handy syntax like object1.With(
        ///                                                                     object1.field1 = value1,
        ///                                                                     object1.field2 = value2,
        ///                                                                     object1.field3 = value3
        ///                                                                    );
        /// That means such code will NOT change the object1: object1.With(     1,
        ///                                                                     2, 
        ///                                                                     3, 
        ///                                                                     "5", 
        ///                                                                     new object2
        ///                                                               );
        /// </summary>
        public static T With<T, A, B, C, D, E, F, G, H>(this T o, A a, B b, C c, D d, E e, F f, G g, H h)
            where T: class
            => o;
            
        /// <summary>
        /// Does NOTHING. Exist only to provide handy syntax like object1.With(
        ///                                                                     object1.field1 = value1,
        ///                                                                     object1.field2 = value2,
        ///                                                                     object1.field3 = value3
        ///                                                                    );
        /// That means such code will NOT change the object1: object1.With(     1,
        ///                                                                     2, 
        ///                                                                     3, 
        ///                                                                     "5", 
        ///                                                                     new object2
        ///                                                               );
        /// </summary>
        public static T With<T, A, B, C, D, E, F, G, H, I>(this T o, A a, B b, C c, D d, E e, F f, G g, H h, I i)
            where T : class
            => o;

        /// <summary>
        /// Does NOTHING. Exist only to provide handy syntax like object1.With(
        ///                                                                     object1.field1 = value1,
        ///                                                                     object1.field2 = value2,
        ///                                                                     object1.field3 = value3
        ///                                                                    );
        /// That means such code will NOT change the object1: object1.With(     1,
        ///                                                                     2, 
        ///                                                                     3, 
        ///                                                                     "5", 
        ///                                                                     new object2
        ///                                                               );
        /// </summary>
        public static T With<T, A, B, C, D, E, F, G, H, I, J>(this T o, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j) 
            where T : class
            => o;

        /// <summary>
        /// Does NOTHING. Exist only to provide handy syntax like object1.With(
        ///                                                                     object1.field1 = value1,
        ///                                                                     object1.field2 = value2,
        ///                                                                     object1.field3 = value3
        ///                                                                    );
        /// That means such code will NOT change the object1: object1.With(     1,
        ///                                                                     2, 
        ///                                                                     3, 
        ///                                                                     "5", 
        ///                                                                     new object2
        ///                                                               );
        /// </summary>
        public static T With<T, A, B, C, D, E, F, G, H, I, J, K>(this T o, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k)
            where T : class
            => o;

        /// <summary>
        /// Does NOTHING. Exist only to provide handy syntax like object1.With(
        ///                                                                     object1.field1 = value1,
        ///                                                                     object1.field2 = value2,
        ///                                                                     object1.field3 = value3
        ///                                                                    );
        /// That means such code will NOT change the object1: object1.With(     1,
        ///                                                                     2, 
        ///                                                                     3, 
        ///                                                                     "5", 
        ///                                                                     new object2
        ///                                                               );
        /// </summary>
        public static T With<T, A, B, C, D, E, F, G, H, I, J, K, L>(this T o, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k, L l)
            where T : class
            => o;

        /// <summary>
        /// Does NOTHING. Exist only to provide handy syntax like object1.With(
        ///                                                                     object1.field1 = value1,
        ///                                                                     object1.field2 = value2,
        ///                                                                     object1.field3 = value3
        ///                                                                    );
        /// That means such code will NOT change the object1: object1.With(     1,
        ///                                                                     2, 
        ///                                                                     3, 
        ///                                                                     "5", 
        ///                                                                     new object2
        ///                                                               );
        /// </summary>
        public static T With<T, A, B, C, D, E, F, G, H, I, J, K, L, M>(this T o, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k, L l, M m)
            where T : class
            => o;

        /// <summary>
        /// Does NOTHING. Exist only to provide handy syntax like object1.With(
        ///                                                                     object1.field1 = value1,
        ///                                                                     object1.field2 = value2,
        ///                                                                     object1.field3 = value3
        ///                                                                    );
        /// That means such code will NOT change the object1: object1.With(     1,
        ///                                                                     2, 
        ///                                                                     3, 
        ///                                                                     "5", 
        ///                                                                     new object2
        ///                                                               );
        /// </summary>
        public static T With<T, A, B, C, D, E, F, G, H, I, J, K, L, M, N>(this T o, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k, L l, M m , N n)
            where T : class
            => o;

        /// <summary>
        /// Does NOTHING. Exist only to provide handy syntax like object1.With(
        ///                                                                     object1.field1 = value1,
        ///                                                                     object1.field2 = value2,
        ///                                                                     object1.field3 = value3
        ///                                                                    );
        /// That means such code will NOT change the object1: object1.With(     1,
        ///                                                                     2, 
        ///                                                                     3, 
        ///                                                                     "5", 
        ///                                                                     new object2
        ///                                                               );
        /// </summary>
        public static T With<T, A, B, C, D, E, F, G, H, I, J, K, L, M, N, O>(this T o, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k, L l, M m, N n, O o1)
        where T: class
            => o;

        /// <summary>
        /// Does NOTHING. Exist only to provide handy syntax like object1.With(
        ///                                                                     object1.field1 = value1,
        ///                                                                     object1.field2 = value2,
        ///                                                                     object1.field3 = value3
        ///                                                                    );
        /// That means such code will NOT change the object1: object1.With(     1,
        ///                                                                     2, 
        ///                                                                     3, 
        ///                                                                     "5", 
        ///                                                                     new object2
        ///                                                               );
        /// </summary>
        public static T With<T, A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P>(this T o, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k, L l, M m, N n, O o1, P p)
            where T : class
            => o;
        #endregion

        #region WITH for structs
        /// <summary>
        /// Does NOTHING, exist only to provide handy syntax like struct1.With(
        ///                                                                     struct1.field1 = value1,
        ///                                                                     struct1.field2 = value2,
        ///                                                                     struct1.field3 = value3
        ///                                                                    );
        /// That means such code will NOT change the struct1: struct1.With(     1,
        ///                                                                     2, 
        ///                                                                     3, 
        ///                                                                     "5", 
        ///                                                                     new object2
        ///                                                               );
        ///                                                                     
        /// </summary>
        public static T With<T>(ref this T o, params object[] pattern)
            where T : struct
            => o;

        /// <summary>
        /// Does nothing. Exist only to provide handy syntax like struct1.With(
        ///                                                                     struct1.field1 = value1,
        ///                                                                     struct1.field2 = value2,
        ///                                                                     struct1.field3 = value3
        ///                                                                    );
        /// That means such code will NOT change the struct1: struct1.With(     1,
        ///                                                                     2, 
        ///                                                                     3, 
        ///                                                                     "5", 
        ///                                                                     new object2
        ///                                                               );
        /// </summary>
        public static T With<T, A>(ref this T o, A a)
            where T : struct
            => o;

        /// <summary>
        /// Does nothing. Exist only to provide handy syntax like struct1.With(
        ///                                                                     struct1.field1 = value1,
        ///                                                                     struct1.field2 = value2,
        ///                                                                     struct1.field3 = value3
        ///                                                                    );
        /// That means such code will NOT change the struct1: struct1.With(     1,
        ///                                                                     2, 
        ///                                                                     3, 
        ///                                                                     "5", 
        ///                                                                     new object2
        ///                                                               );
        /// </summary>
        public static T With<T, A, B>(ref this T o, A a, B b)
            where T : struct
            => o;

        /// <summary>
        /// Does nothing. Exist only to provide handy syntax like struct1.With(
        ///                                                                     struct1.field1 = value1,
        ///                                                                     struct1.field2 = value2,
        ///                                                                     struct1.field3 = value3
        ///                                                                    );
        /// That means such code will NOT change the struct1: struct1.With(     1,
        ///                                                                     2, 
        ///                                                                     3, 
        ///                                                                     "5", 
        ///                                                                     new object2
        ///                                                               );
        /// </summary>
        public static T With<T, A, B, C>(ref this T o, A a, B b, C c)
            where T : struct
            => o;

        /// <summary>
        /// Does nothing. Exist only to provide handy syntax like struct1.With(
        ///                                                                     struct1.field1 = value1,
        ///                                                                     struct1.field2 = value2,
        ///                                                                     struct1.field3 = value3
        ///                                                                    );
        /// That means such code will NOT change the struct1: struct1.With(     1,
        ///                                                                     2, 
        ///                                                                     3, 
        ///                                                                     "5", 
        ///                                                                     new object2
        ///                                                               );
        /// </summary>
        public static T With<T, A, B, C, D>(ref this T o, A a, B b, C c, D d)
            where T : struct
            => o;

        /// <summary>
        /// Does nothing. Exist only to provide handy syntax like struct1.With(
        ///                                                                     struct1.field1 = value1,
        ///                                                                     struct1.field2 = value2,
        ///                                                                     struct1.field3 = value3
        ///                                                                    );
        /// That means such code will NOT change the struct1: struct1.With(     1,
        ///                                                                     2, 
        ///                                                                     3, 
        ///                                                                     "5", 
        ///                                                                     new object2
        ///                                                               );
        /// </summary>
        public static T With<T, A, B, C, D, E>(ref this T o, A a, B b, C c, D d, E e)
            where T : struct
            => o;

        /// <summary>
        /// Does nothing. Exist only to provide handy syntax like struct1.With(
        ///                                                                     struct1.field1 = value1,
        ///                                                                     struct1.field2 = value2,
        ///                                                                     struct1.field3 = value3
        ///                                                                    );
        /// That means such code will NOT change the struct1: struct1.With(     1,
        ///                                                                     2, 
        ///                                                                     3, 
        ///                                                                     "5", 
        ///                                                                     new object2
        ///                                                               );
        /// </summary>
        public static T With<T, A, B, C, D, E, F>(ref this T o, A a, B b, C c, D d, E e, F f)
            where T : struct
            => o;

        /// <summary>
        /// Does nothing. Exist only to provide handy syntax like struct1.With(
        ///                                                                     struct1.field1 = value1,
        ///                                                                     struct1.field2 = value2,
        ///                                                                     struct1.field3 = value3
        ///                                                                    );
        /// That means such code will NOT change the struct1: struct1.With(     1,
        ///                                                                     2, 
        ///                                                                     3, 
        ///                                                                     "5", 
        ///                                                                     new object2
        ///                                                               );
        /// </summary>
        public static T With<T, A, B, C, D, E, F, G>(ref this T o, A a, B b, C c, D d, E e, F f, G g)
            where T : struct
            => o;

        /// <summary>
        /// Does nothing. Exist only to provide handy syntax like struct1.With(
        ///                                                                     struct1.field1 = value1,
        ///                                                                     struct1.field2 = value2,
        ///                                                                     struct1.field3 = value3
        ///                                                                    );
        /// That means such code will NOT change the struct1: struct1.With(     1,
        ///                                                                     2, 
        ///                                                                     3, 
        ///                                                                     "5", 
        ///                                                                     new object2
        ///                                                               );
        /// </summary>
        public static T With<T, A, B, C, D, E, F, G, H>(ref this T o, A a, B b, C c, D d, E e, F f, G g, H h)
            where T : struct
            => o;

        /// <summary>
        /// Does nothing. Exist only to provide handy syntax like struct1.With(
        ///                                                                     struct1.field1 = value1,
        ///                                                                     struct1.field2 = value2,
        ///                                                                     struct1.field3 = value3
        ///                                                                    );
        /// That means such code will NOT change the struct1: struct1.With(     1,
        ///                                                                     2, 
        ///                                                                     3, 
        ///                                                                     "5", 
        ///                                                                     new object2
        ///                                                               );
        /// </summary>
        public static T With<T, A, B, C, D, E, F, G, H, I>(ref this T o, A a, B b, C c, D d, E e, F f, G g, H h, I i)
            where T : struct
            => o;

        /// <summary>
        /// Does nothing. Exist only to provide handy syntax like struct1.With(
        ///                                                                     struct1.field1 = value1,
        ///                                                                     struct1.field2 = value2,
        ///                                                                     struct1.field3 = value3
        ///                                                                    );
        /// That means such code will NOT change the struct1: struct1.With(     1,
        ///                                                                     2, 
        ///                                                                     3, 
        ///                                                                     "5", 
        ///                                                                     new object2
        ///                                                               );
        /// </summary>
        public static T With<T, A, B, C, D, E, F, G, H, I, J>(ref this T o, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j)
            where T : struct
            => o;

        /// <summary>
        /// Does nothing. Exist only to provide handy syntax like struct1.With(
        ///                                                                     struct1.field1 = value1,
        ///                                                                     struct1.field2 = value2,
        ///                                                                     struct1.field3 = value3
        ///                                                                    );
        /// That means such code will NOT change the struct1: struct1.With(     1,
        ///                                                                     2, 
        ///                                                                     3, 
        ///                                                                     "5", 
        ///                                                                     new object2
        ///                                                               );
        /// </summary>
        public static T With<T, A, B, C, D, E, F, G, H, I, J, K>(ref this T o, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k)
            where T : struct
            => o;

        /// <summary>
        /// Does nothing. Exist only to provide handy syntax like struct1.With(
        ///                                                                     struct1.field1 = value1,
        ///                                                                     struct1.field2 = value2,
        ///                                                                     struct1.field3 = value3
        ///                                                                    );
        /// That means such code will NOT change the struct1: struct1.With(     1,
        ///                                                                     2, 
        ///                                                                     3, 
        ///                                                                     "5", 
        ///                                                                     new object2
        ///                                                               );
        /// </summary>
        public static T With<T, A, B, C, D, E, F, G, H, I, J, K, L>(ref this T o, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k, L l)
            where T : struct
            => o;

        /// <summary>
        /// Does nothing. Exist only to provide handy syntax like struct1.With(
        ///                                                                     struct1.field1 = value1,
        ///                                                                     struct1.field2 = value2,
        ///                                                                     struct1.field3 = value3
        ///                                                                    );
        /// That means such code will NOT change the struct1: struct1.With(     1,
        ///                                                                     2, 
        ///                                                                     3, 
        ///                                                                     "5", 
        ///                                                                     new object2
        ///                                                               );
        /// </summary>
        public static T With<T, A, B, C, D, E, F, G, H, I, J, K, L, M>(ref this T o, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k, L l, M m)
            where T : struct
            => o;

        /// <summary>
        /// Does nothing. Exist only to provide handy syntax like struct1.With(
        ///                                                                     struct1.field1 = value1,
        ///                                                                     struct1.field2 = value2,
        ///                                                                     struct1.field3 = value3
        ///                                                                    );
        /// That means such code will NOT change the struct1: struct1.With(     1,
        ///                                                                     2, 
        ///                                                                     3, 
        ///                                                                     "5", 
        ///                                                                     new object2
        ///                                                               );
        /// </summary>
        public static T With<T, A, B, C, D, E, F, G, H, I, J, K, L, M, N>(ref this T o, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k, L l, M m, N n)
            where T : struct
            => o;

        /// <summary>
        /// Does nothing. Exist only to provide handy syntax like struct1.With(
        ///                                                                     struct1.field1 = value1,
        ///                                                                     struct1.field2 = value2,
        ///                                                                     struct1.field3 = value3
        ///                                                                    );
        /// That means such code will NOT change the struct1: struct1.With(     1,
        ///                                                                     2, 
        ///                                                                     3, 
        ///                                                                     "5", 
        ///                                                                     new object2
        ///                                                               );
        /// </summary>
        public static T With<T, A, B, C, D, E, F, G, H, I, J, K, L, M, N, O>(ref this T o, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k, L l, M m, N n, O o1)
        where T : struct
            => o;

        /// <summary>
        /// Does nothing. Exist only to provide handy syntax like struct1.With(
        ///                                                                     struct1.field1 = value1,
        ///                                                                     struct1.field2 = value2,
        ///                                                                     struct1.field3 = value3
        ///                                                                    );
        /// That means such code will NOT change the struct1: struct1.With(     1,
        ///                                                                     2, 
        ///                                                                     3, 
        ///                                                                     "5", 
        ///                                                                     new object2
        ///                                                               );
        /// </summary>
        public static T With<T, A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P>(ref this T o, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k, L l, M m, N n, O o1, P p)
            where T : struct
            => o;

        #endregion

    }
}