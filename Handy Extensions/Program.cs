

using System;
using System.Diagnostics.CodeAnalysis;

// ReSharper disable InconsistentNaming

namespace Handy_Extensions
{
    class Program
    {
        static void Main()
        {
            var a = new Class2().To(out var i)
                            .With(
                                  i.a = 5,
                                  i.b = 6,
                                  i.c = "7",
                                  i.d = "8"
                                 );
            Console.WriteLine(a);
            Console.ReadLine();
            Console.ReadLine();
        }
    }

    public class Class1
    {
        public int a, b;
    }

    public class Class2: Class1
    {
        public string c = "",
            d = "";

        //Операторы - не virtual. Для каждого класса надо писать свой оператор.
        //А еще операторы обязательно static.
        [SuppressMessage("ReSharper", "PossibleInvalidOperationException")]
        public static explicit operator int(Class2 value)
        {
            if (value != null)
            {
                return value.a + value.b + (int) value.c?.Length + (int) value.d?.Length;
            }

            throw new InvalidCastException("Try to cast null to int");
        }

        #region Overrides of Object

        public override string ToString() => "{"+a+" "+ b +", "+c+", "+d+ "}";

    #endregion
    }

    public sealed class Class3 : Class2
    {
        public double e, f;
    }

}
