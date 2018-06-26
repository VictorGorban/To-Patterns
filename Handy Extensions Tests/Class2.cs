namespace Handy_Extensions.Tests {
    public class Class2 : Class1
    {
        public string c = "", d = "";
        //Операторы - не virtual. Для каждого класса надо писать свой оператор.
        //А еще операторы обязательно static.
        public static implicit operator int(Class2 value) => value.a + value.b + (int)value.c?.Length + (int)value.d?.Length;
        public override string ToString()
        {
            return base.ToString() + " " + c +", " +d;
        }
    }
}