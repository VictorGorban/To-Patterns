using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace Handy_Extensions.Tests
{
    [TestClass()]
    public class Right_sided_operations_Tests
    {

        [TestMethod()]
        public void Cast_Test()
        {
            var nullClass2 = null as Class2;
            var nullClass1 = nullClass2.Cast<Class1>();
            Assert.AreEqual(nullClass1, null);
            Assert.AreEqual(nullClass2, null);

            Class1 class3 = new Class3();
            { var result = class3.Cast<Class1>(); }
            Class2 class2 = new Class2();
            Assert.ThrowsException<InvalidCastException>(() => { class2.Cast<Class3>(); });
            Assert.ThrowsException<InvalidCastException>(() => { var a = (int)(object)class2; });
            Assert.ThrowsException<InvalidCastException>(() => { var a = class2.Cast<int>(); });
            Assert.ThrowsException<InvalidCastException>(() => { class2.Cast<short>(); });
            Assert.ThrowsException<InvalidCastException>(() => { class2.Cast<double>(); });
            Assert.ThrowsException<InvalidCastException>(() => { class2.Cast<char>(); });
        }

        [TestMethod()]
        public void To_Test()
        {
            int i1 = 345.To(out i1);
            long i2 = -12L.To(out i2);
            //long i3 = -12.To(out long i4);
            //long i3 = -12.To(out i3);
            Class1 class1 = new Class2().To(out class1);
            var class2 = null as Class2;
            var class3 = null as Class3;
            class2.To(out class1);
            class3.To(out class3);
        }

        [TestMethod()]
        public void CastTo_Test()
        {
            // все это дело - проверить на cast+присваивание, а не по отдельности. 
            // А остальные паттерны я делать буду уже в Rider.

            var nullClass2 = null as Class2;
            //var nullClass1 = nullClass2.CastTo<Class1>(out nullClass1); // у nullClass1 тип пока что неопределен (var), поэтому cannot use local variable nullClass1 before it is declared.
            Class1 nullClass1 = nullClass2.CastTo(out nullClass1); // а вот так вот можно
            Assert.AreEqual(nullClass1, null);
            Assert.AreEqual(nullClass2, null);

            Class1 class3 = new Class3();
            { class3.CastTo<Class1>(out var r); }//так тоже можно
            Class2 class2 = new Class2();
            Assert.ThrowsException<InvalidCastException>(() => { class2.CastTo<Class3>(out var res); });
            Assert.ThrowsException<InvalidCastException>(() => { class2.CastTo<int>(out var res); });
            Assert.ThrowsException<InvalidCastException>(() => { class2.CastTo<double>(out var r); });
            Assert.ThrowsException<InvalidCastException>(() => { class2.CastTo<short>(out var r); });
            Assert.ThrowsException<InvalidCastException>(() => { class2.CastTo<DateTime>(out var r); });
            Assert.ThrowsException<InvalidCastException>(() => { class2.CastTo<char>(out var r); });
        }

        [TestMethod]
        public void With_Test()
        {
            var a = new Class2().To(out var p).With(
                5,
                6,
                "7",
                "8"
                );
            Assert.AreEqual(p.a, 0);
            Assert.AreEqual(p.b, 0);
            Assert.AreEqual(p.c, "");
            Assert.AreEqual(p.d, "");
            
            a = new Class2().To(out p)
                                .With(
                                      p.a = 5,
                                      p.b = 6,
                                      p.c = "7",
                                      p.d = "8"
                                     );
            Assert.AreEqual(p.a, 5);
            Assert.AreEqual(p.b, 6);
            Assert.AreEqual(p.c, "7");
            Assert.AreEqual(p.d, "8");
            
            a = new Class2().To(out p)
                            .With(
                                  p.a = 5,
                                  p.b = 6,
                                  p.c = "7",
                                  p.d = "8"
                                 );
            Assert.AreEqual(a.a, 5);
            Assert.AreEqual(a.b, 6);
            Assert.AreEqual(a.c, "7");
            Assert.AreEqual(a.d, "8");

        }

    }
}