using System;


namespace Handy_Extensions
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

        public static bool IsNumeric(object value)
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

        public static bool IsNumericType(Type type)
        {
            var value = Activator.CreateInstance(type);
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

        public static bool IsInteger(object value)
        {
            return (value is SByte || value is Int16 || value is Int32
                    || value is Int64 || value is Byte || value is UInt16
                    || value is UInt32 || value is UInt64
                    || value is System.Numerics.BigInteger);
        }

        public static bool IsIntegerType(Type type)
        {
            var value = Activator.CreateInstance(type);
            return (value is SByte || value is Int16 || value is Int32
                    || value is Int64 || value is Byte || value is UInt16
                    || value is UInt32 || value is UInt64
                    || value is System.Numerics.BigInteger);
        }

        public static bool IsFloat(object value)
        {
            return (value is float | value is double | value is Decimal);
        }

        public static bool IsFloatType(Type type)
        {
            var value = Activator.CreateInstance(type);
            return (value is float | value is double | value is Decimal);
        }
    }
}
