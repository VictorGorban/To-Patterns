using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace To__Patterns
{
    public static class TypeChecking
    {
        public static bool IsInteger(this ValueType value)
        {
            return (value is SByte || value is Int16 || value is Int32
                    || value is Int64 || value is Byte || value is UInt16
                    || value is UInt32 || value is UInt64
                    || value is System.Numerics.BigInteger);
        }

        public static bool IsFloat(this ValueType value)
        {
            return (value is float | value is double | value is Decimal);
        }

        public static bool IsNumeric(this ValueType value)
        {
            return (value is Byte ||
                    value is Int16 ||
                    value is Int32 ||
                    value is Int64 ||
                    value is SByte ||
                    value is UInt16 ||
                    value is UInt32 ||
                    value is UInt64 ||
                    value is System.Numerics.BigInteger ||
                    value is Decimal ||
                    value is Double ||
                    value is Single);
        }
    }
}
