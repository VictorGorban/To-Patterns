using System;
using System.Numerics;

namespace To__Patterns
{
    /// <summary>
    /// Provides methods for right-sided declaration, assignment, type conversion. Only for classes, none for structs.
    /// </summary>
    public static class Right_sided_conversion
    {
        /// <summary>
        /// Right-sided conversion for classes
        /// </summary>
        public static T To<T>(this object o) 
            where T:class
        {
            return (T) o; 
        }
        //Ладно, для приведения к классу - да, но для приведения к структуре... 
        //Да, valueType - это все структуры. Т.е. не только числовые. Т.е. if(isNumeric)... else if char... else return Convert.ChangeType.

        #region Right-sided conversion for structs 

        #region char, byte, sbyte

        public static T To<T>(this ValueType o)
        {
            if (o.IsNumeric())
            {
                if (o.IsFloat())
                {
                    return (T)Convert.ChangeType(o, typeof(T));
                }
                
                if(o.IsInteger())
                //Не могу засунуть сюда BigInteger
                // int numbers
                if (o is UInt64)
                {
                    object obj = (UInt64)o;
                    return (T)obj;
                }

                //o is not UInt64
                object obj1 = Convert.ChangeType(o, typeof(long));
                return (T)Convert.ChangeType(obj1, typeof(T));

            }

            return (T)Convert.ChangeType(o, typeof(T));

            

            
        }

        public static bool IsInteger(ValueType value)
        {
            return (value is SByte || value is Int16 || value is Int32
                    || value is Int64 || value is Byte || value is UInt16
                    || value is UInt32 || value is UInt64
                    || value is BigInteger);
        }

        #endregion
        #endregion

    }

    public class Class1
    {
        int a, b;
    }

    public class Class2:Class1
    {
        string c, d;
    }
}
