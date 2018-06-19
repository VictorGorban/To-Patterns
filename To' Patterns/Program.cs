

namespace Handy_Extensions
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Class3();
        }
    }

    public class Class1
    {
        public int a, b;
    }

    public class Class2 : Class1
    {
        public string c = "", d = "";
        //Операторы - не virtual. Для каждого класса надо писать свой оператор.
        //А еще операторы обязательно static.
        public static implicit operator int(Class2 value) => value.a + value.b + (int)value.c?.Length + (int)value.d?.Length;
    }

    public class Class3 : Class2
    {
        public double e, f;
        public Class3()
        {
        }
    }

}
