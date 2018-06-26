using Microsoft.VisualStudio.TestTools.UnitTesting;
// ReSharper disable CompareOfFloatsByEqualityOperator

namespace Handy_Extensions.Tests
{
    [TestClass]
    public class CheckPatternTest
    {
        [TestMethod]
        public void CheckTest()
        {
            var c = new Class3();
            Assert.AreEqual(true, c.Check(c.a==1, c.b == 2, c.c=="3",c.d=="4",c.E==5,c.F == 6).All(true));
            Assert.AreEqual(true, c.Check(c.a==1, c.b == 2, c.c=="3",c.d=="4",c.E==5,c.F == 6).Any(true));
            Assert.AreEqual(true, c.Check(c.a==2, c.b == 3, c.c=="4",c.d=="5",c.E==6,c.F == 7).All(false));
            Assert.AreEqual(true, c.Check(c.a==2, c.b == 3, c.c=="4",c.d=="5",c.E==6,c.F == 7).Any(false));
            
        }
    }


}