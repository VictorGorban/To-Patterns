using Microsoft.VisualStudio.TestTools.UnitTesting;
using To__Patterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To__Patterns.Tests
{
    [TestClass()]
    public class Right_sided_conversionTests
    {
        
        [TestMethod()]
        public void To_Test1()
        {
            var nullClass2 = null as Class2;
            var nullClass1 = nullClass2.To<Class1>();
            Assert.AreEqual(nullClass1, null);
            Assert.AreEqual(nullClass2, null);
        }

        [TestClass()]
        public class Test_Double
        { 
        #region Char and Byte + SByte
        //Считаю их особыми, поэтому поставил в начале, а не в соответствии с signed-unsigned
        [TestMethod()]
        public void To_TestChar()
        {
            Char val1 = 5.11d.To<Char>();
            Assert.AreEqual(val1, (Char)5);
            Char val2 = 5.98d.To<Char>();
            Assert.AreEqual(val2, (Char)5);
            Char val3 = 0d.To<Char>();
            Assert.AreEqual(val3, (Char)0);
            var dv = -14.54D;
            Assert.ThrowsException<System.OverflowException>(()=>{Char val4 = dv.To<Char>(); }); 
            
        }

        [TestMethod()]
        public void To_TestByte()
        {
            Byte val1 = 5.11d.To<Byte>();
            Assert.AreEqual(val1, (Byte)5);
            Byte val2 = 5.98d.To<Byte>();
            Assert.AreEqual(val2, (Byte)5);
            Byte val3 = 0d.To<Byte>();
            Assert.AreEqual(val3, (Byte)0);
            var dv = -14.54D;
            Assert.ThrowsException<System.OverflowException>(() => { Byte val4 = dv.To<Byte>(); });
        }

        [TestMethod()]
        public void To_TestSByte()
        {
            SByte val1 = 5.11d.To<SByte>();
            Assert.AreEqual(val1, (SByte)5);
            SByte val2 = 5.98d.To<SByte>();
            Assert.AreEqual(val2, (SByte)5);
            SByte val3 = 0d.To<SByte>();
            Assert.AreEqual(val3, (SByte)0);
            var dv = -14.54D;
            SByte val4 = dv.To<SByte>();
        }

        #endregion

        #region signed

        [TestMethod()]
        public void To_TestInt16()
        {
            Int16 val1 = 5.11d.To<Int16>();
            Assert.AreEqual(val1, (Int16)5);
            Int16 val2 = 5.98d.To<Int16>();
            Assert.AreEqual(val2, (Int16)5);
            Int16 val3 = 0d.To<Int16>();
            Assert.AreEqual(val3, (Int16)0);
            var dv = -14.54D;
            Int16 val4 = dv.To<Int16>();
        }

        [TestMethod()]
        public void To_TestInt32()
        {
            Int32 val1 = 5.11d.To<Int32>();
            Assert.AreEqual(val1, (Int32)5);
            Int32 val2 = 5.98d.To<Int32>();
            Assert.AreEqual(val2, (Int32)5);
            Int32 val3 = 0d.To<Int32>();
            Assert.AreEqual(val3, (Int32)0);
            var dv = -14.54D;
            Int32 val4 = dv.To<Int32>();
        }

        [TestMethod()]
        public void To_TestInt64()
        {
            Int64 val1 = 5.11d.To<Int64>();
            Assert.AreEqual(val1, (Int64)5);
            Int64 val2 = 5.98d.To<Int64>();
            Assert.AreEqual(val2, (Int64)5);
            Int64 val3 = 0d.To<Int64>();
            Assert.AreEqual(val3, (Int64)0);
            var dv = -14.54D;
            Int64 val4 = dv.To<Int64>();
        }

        #endregion

        #region unsigned
        [TestMethod()]
        public void To_TestUInt16()
        {
            UInt16 val1 = 5.11d.To<UInt16>();
            Assert.AreEqual(val1, (UInt16)5);
            UInt16 val2 = 5.98d.To<UInt16>();
            Assert.AreEqual(val2, (UInt16)5);
            UInt16 val3 = 0d.To<UInt16>();
            Assert.AreEqual(val3, (UInt16)0);
            var dv = -14.54D;
            Assert.ThrowsException<System.OverflowException>(() => { UInt16 val4 = dv.To<UInt16>();});
        }

        [TestMethod()]
        public void To_TestUInt32()
        {
            UInt32 val1 = 5.11d.To<UInt32>();
            Assert.AreEqual(val1, (UInt32)5);
            UInt32 val2 = 5.98d.To<UInt32>();
            Assert.AreEqual(val2, (UInt32)5);
            UInt32 val3 = 0d.To<UInt32>();
            Assert.AreEqual(val3, (UInt32)0);
            var dv = -14.54D;
            Assert.ThrowsException<System.OverflowException>(() => { UInt32 val4 = dv.To<UInt32>(); });
        }

        [TestMethod()]
        public void To_TestUInt64()
        {
            UInt64 val1 = 5.11d.To<UInt64>();
            Assert.AreEqual(val1, (UInt64)5);
            UInt64 val2 = 5.98d.To<UInt64>();
            Assert.AreEqual(val2, (UInt64)5);
            UInt64 val3 = 0d.To<UInt64>();
            Assert.AreEqual(val3, (UInt64)0);
            var dv = -14.54D;
            Assert.ThrowsException<System.OverflowException>(() => { UInt64 val4 = dv.To<UInt64>(); });
        }
        #endregion

        #region floating-point
        [TestMethod()]
        public void To_TestSingle()
        {
            Single val1 = 5.11d.To<Single>();
            Assert.AreEqual(val1, (Single)5.11);
            Single val2 = 5.98d.To<Single>();
            Assert.AreEqual(val2, (Single)5.98);
            Single val3 = 0d.To<Single>();
            Assert.AreEqual(val3, (Single)0);
            var dv = -14.54D;
            Single val4 = dv.To<Single>();
        }

        [TestMethod()]
        public void To_TestDouble()
        {
            Double val1 = 5.11d.To<Double>();
            Assert.AreEqual(val1, (Double)5.11);
            Double val2 = 5.98d.To<Double>();
            Assert.AreEqual(val2, (Double)5.98);
            Double val3 = 0D.To<Double>();
            Assert.AreEqual(val3, (Double)0);
            var dv = -14.54D;
            Double val4 = dv.To<Double>();
        }

        [TestMethod()]
        public void To_TestDecimal()
        {
            Decimal val1 = 5.11d.To<Decimal>();
            Assert.AreEqual(val1, (Decimal)5.11);
            Decimal val2 = 5.98d.To<Decimal>();
            Assert.AreEqual(val2, (Decimal)5.98);
            Decimal val3 = 0D.To<Decimal>();
            Assert.AreEqual(val3, (Decimal)0);
            var dv = -14.54D;
            Decimal val4 = dv.To<Decimal>();
        }

            #endregion
        }

        [TestClass()]
        public class Test_Single
        {
        #region Char and Byte + SByte
        //Считаю их особыми, поэтому поставил в начале, а не в соответствии с signed-unsigned
        [TestMethod()]
        public void To_TestChar()
        {
            Char val1 = 5.11f.To<Char>();
            Assert.AreEqual(val1, (Char)5);
            Char val2 = 5.98f.To<Char>();
            Assert.AreEqual(val2, (Char)5);
            Char val3 = 0f.To<Char>();
            Assert.AreEqual(val3, (Char)0);
            var dv = -14.54f;
            Assert.ThrowsException<System.OverflowException>(() => { Char val4 = dv.To<Char>(); });

        }

        [TestMethod()]
        public void To_TestByte()
        {
            Byte val1 = 5.11f.To<Byte>();
            Assert.AreEqual(val1, (Byte)5);
            Byte val2 = 5.98f.To<Byte>();
            Assert.AreEqual(val2, (Byte)5);
            Byte val3 = 0f.To<Byte>();
            Assert.AreEqual(val3, (Byte)0);
            var dv = -14.54f;
            Assert.ThrowsException<System.OverflowException>(() => { Byte val4 = dv.To<Byte>(); });
        }

        [TestMethod()]
        public void To_TestSByte()
        {
            SByte val1 = 5.11f.To<SByte>();
            Assert.AreEqual(val1, (SByte)5);
            SByte val2 = 5.98f.To<SByte>();
            Assert.AreEqual(val2, (SByte)5);
            SByte val3 = 0f.To<SByte>();
            Assert.AreEqual(val3, (SByte)0);
            var dv = -14.54f;
            SByte val4 = dv.To<SByte>();
        }

        #endregion

        #region signed

        [TestMethod()]
        public void To_TestInt16()
        {
            Int16 val1 = 5.11f.To<Int16>();
            Assert.AreEqual(val1, (Int16)5);
            Int16 val2 = 5.98f.To<Int16>();
            Assert.AreEqual(val2, (Int16)5);
            Int16 val3 = 0f.To<Int16>();
            Assert.AreEqual(val3, (Int16)0);
            var dv = -14.54f;
            Int16 val4 = dv.To<Int16>();
        }

        [TestMethod()]
        public void To_TestInt32()
        {
            Int32 val1 = 5.11f.To<Int32>();
            Assert.AreEqual(val1, (Int32)5);
            Int32 val2 = 5.98f.To<Int32>();
            Assert.AreEqual(val2, (Int32)5);
            Int32 val3 = 0f.To<Int32>();
            Assert.AreEqual(val3, (Int32)0);
            var dv = -14.54f;
            Int32 val4 = dv.To<Int32>();
        }

        [TestMethod()]
        public void To_TestInt64()
        {
            Int64 val1 = 5.11f.To<Int64>();
            Assert.AreEqual(val1, (Int64)5);
            Int64 val2 = 5.98f.To<Int64>();
            Assert.AreEqual(val2, (Int64)5);
            Int64 val3 = 0f.To<Int64>();
            Assert.AreEqual(val3, (Int64)0);
            var dv = -14.54f;
            Int64 val4 = dv.To<Int64>();
        }

        #endregion

        #region unsigned
        [TestMethod()]
        public void To_TestUInt16()
        {
            UInt16 val1 = 5.11f.To<UInt16>();
            Assert.AreEqual(val1, (UInt16)5);
            UInt16 val2 = 5.98f.To<UInt16>();
            Assert.AreEqual(val2, (UInt16)5);
            UInt16 val3 = 0f.To<UInt16>();
            Assert.AreEqual(val3, (UInt16)0);
            var dv = -14.54f;
            Assert.ThrowsException<System.OverflowException>(() => { UInt16 val4 = dv.To<UInt16>(); });
        }

        [TestMethod()]
        public void To_TestUInt32()
        {
            UInt32 val1 = 5.11f.To<UInt32>();
            Assert.AreEqual(val1, (UInt32)5);
            UInt32 val2 = 5.98f.To<UInt32>();
            Assert.AreEqual(val2, (UInt32)5);
            UInt32 val3 = 0f.To<UInt32>();
            Assert.AreEqual(val3, (UInt32)0);
            var dv = -14.54f;
            Assert.ThrowsException<System.OverflowException>(() => { UInt32 val4 = dv.To<UInt32>(); });
        }

        [TestMethod()]
        public void To_TestUInt64()
        {
            UInt64 val1 = 5.11f.To<UInt64>();
            Assert.AreEqual(val1, (UInt64)5);
            UInt64 val2 = 5.98f.To<UInt64>();
            Assert.AreEqual(val2, (UInt64)5);
            UInt64 val3 = 0f.To<UInt64>();
            Assert.AreEqual(val3, (UInt64)0);
            var dv = -14.54f;
            Assert.ThrowsException<System.OverflowException>(() => { UInt64 val4 = dv.To<UInt64>(); });
        }
        #endregion

        #region floating-point
        
        [TestMethod()]
        public void To_TestSingle()
        {
            Single val1 = 5.11f.To<Single>();
            Assert.AreEqual(val1, (Single)5.11);
            Single val2 = 5.98f.To<Single>();
            Assert.AreEqual(val2, (Single)5.98);
            Single val3 = 0f.To<Single>();
            Assert.AreEqual(val3, (Single)0);
            var dv = -14.54f;
            Single val4 = dv.To<Single>();
        }

        [TestMethod()]
        public void To_TestDouble()
        {
            Double val1 = 5.11f.To<Double>();
            Assert.AreEqual(val1, 5.11f);
            Double val2 = 5.98f.To<Double>();
            Assert.AreEqual(val2, 5.98f);
            Double val3 = 0f.To<Double>();
            Assert.AreEqual(val3, 0f);
            var dv = -14.54f;
            Double val4 = dv.To<Double>();
        }

        [TestMethod()]
        public void To_TestDecimal()
        {
            Decimal val1 = 5.11f.To<Decimal>();
            Assert.AreEqual(val1, (Decimal)5.11);
            Decimal val2 = 5.98f.To<Decimal>();
            Assert.AreEqual(val2, (Decimal)5.98);
            Decimal val3 = 0f.To<Decimal>();
            Assert.AreEqual(val3, (Decimal)0);
            var dv = -14.54f;
            Decimal val4 = dv.To<Decimal>();
        }

        #endregion
        }

        [TestClass]
        public class Test_Decimal
        {
            #region Char and Byte + SByte
            //Считаю их особыми, поэтому поставил в начале, а не в соответствии с signed-unsigned
            [TestMethod()]
            public void To_TestChar()
            {
                Char val1 = 5.11m.To<Char>();
                Assert.AreEqual(val1, (Char)5);
                Char val2 = 5.98m.To<Char>();
                Assert.AreEqual(val2, (Char)5);
                Char val3 = 0m.To<Char>();
                Assert.AreEqual(val3, (Char)0);
                var dv = -14.54m;
                Assert.ThrowsException<System.OverflowException>(() => { Char val4 = dv.To<Char>(); });

            }

            [TestMethod()]
            public void To_TestByte()
            {
                Byte val1 = 5.11m.To<Byte>();
                Assert.AreEqual(val1, (Byte)5);
                Byte val2 = 5.98m.To<Byte>();
                Assert.AreEqual(val2, (Byte)5);
                Byte val3 = 0m.To<Byte>();
                Assert.AreEqual(val3, (Byte)0);
                var dv = -14.54m;
                Assert.ThrowsException<System.OverflowException>(() => { Byte val4 = dv.To<Byte>(); });
            }

            [TestMethod()]
            public void To_TestSByte()
            {
                SByte val1 = 5.11m.To<SByte>();
                Assert.AreEqual(val1, (SByte)5);
                SByte val2 = 5.98m.To<SByte>();
                Assert.AreEqual(val2, (SByte)5);
                SByte val3 = 0m.To<SByte>();
                Assert.AreEqual(val3, (SByte)0);
                var dv = -14.54m;
                SByte val4 = dv.To<SByte>();
            }

            #endregion

            #region signed

            [TestMethod()]
            public void To_TestInt16()
            {
                Int16 val1 = 5.11m.To<Int16>();
                Assert.AreEqual(val1, (Int16)5);
                Int16 val2 = 5.98m.To<Int16>();
                Assert.AreEqual(val2, (Int16)5);
                Int16 val3 = 0m.To<Int16>();
                Assert.AreEqual(val3, (Int16)0);
                var dv = -14.54m;
                Int16 val4 = dv.To<Int16>();
            }

            [TestMethod()]
            public void To_TestInt32()
            {
                Int32 val1 = 5.11m.To<Int32>();
                Assert.AreEqual(val1, (Int32)5);
                Int32 val2 = 5.98m.To<Int32>();
                Assert.AreEqual(val2, (Int32)5);
                Int32 val3 = 0m.To<Int32>();
                Assert.AreEqual(val3, (Int32)0);
                var dv = -14.54m;
                Int32 val4 = dv.To<Int32>();
            }

            [TestMethod()]
            public void To_TestInt64()
            {
                Int64 val1 = 5.11m.To<Int64>();
                Assert.AreEqual(val1, (Int64)5);
                Int64 val2 = 5.98m.To<Int64>();
                Assert.AreEqual(val2, (Int64)5);
                Int64 val3 = 0m.To<Int64>();
                Assert.AreEqual(val3, (Int64)0);
                var dv = -14.54m;
                Int64 val4 = dv.To<Int64>();
            }

            #endregion

            #region unsigned
            [TestMethod()]
            public void To_TestUInt16()
            {
                UInt16 val1 = 5.11m.To<UInt16>();
                Assert.AreEqual(val1, (UInt16)5);
                UInt16 val2 = 5.98m.To<UInt16>();
                Assert.AreEqual(val2, (UInt16)5);
                UInt16 val3 = 0m.To<UInt16>();
                Assert.AreEqual(val3, (UInt16)0);
                var dv = -14.54m;
                Assert.ThrowsException<System.OverflowException>(() => { UInt16 val4 = dv.To<UInt16>(); });
            }

            [TestMethod()]
            public void To_TestUInt32()
            {
                UInt32 val1 = 5.11m.To<UInt32>();
                Assert.AreEqual(val1, (UInt32)5);
                UInt32 val2 = 5.98m.To<UInt32>();
                Assert.AreEqual(val2, (UInt32)5);
                UInt32 val3 = 0m.To<UInt32>();
                Assert.AreEqual(val3, (UInt32)0);
                var dv = -14.54m;
                Assert.ThrowsException<System.OverflowException>(() => { UInt32 val4 = dv.To<UInt32>(); });
            }

            [TestMethod()]
            public void To_TestUInt64()
            {
                UInt64 val1 = 5.11m.To<UInt64>();
                Assert.AreEqual(val1, (UInt64)5);
                UInt64 val2 = 5.98m.To<UInt64>();
                Assert.AreEqual(val2, (UInt64)5);
                UInt64 val3 = 0m.To<UInt64>();
                Assert.AreEqual(val3, (UInt64)0);
                var dv = -14.54m;
                Assert.ThrowsException<System.OverflowException>(() => { UInt64 val4 = dv.To<UInt64>(); });
            }
            #endregion

            #region floating-point

            [TestMethod()]
            public void To_TestSingle()
            {
                Single val1 = 5.11m.To<Single>();
                Assert.AreEqual(val1, (Single)5.11);
                Single val2 = 5.98m.To<Single>();
                Assert.AreEqual(val2, (Single)5.98);
                Single val3 = 0m.To<Single>();
                Assert.AreEqual(val3, (Single)0);
                var dv = -14.54m;
                Single val4 = dv.To<Single>();
            }

            [TestMethod()]
            public void To_TestDouble()
            {
                Double val1 = 5.11m.To<Double>();
                Assert.AreEqual(val1, 5.11);
                Double val2 = 5.98m.To<Double>();
                Assert.AreEqual(val2, 5.98);
                Double val3 = 0m.To<Double>();
                Assert.AreEqual(val3, 0d);
                var dv = -14.54m;
                Double val4 = dv.To<Double>();
            }

            [TestMethod()]
            public void To_TestDecimal()
            {
                Decimal val1 = 5.11m.To<Decimal>();
                Assert.AreEqual(val1, (Decimal)5.11);
                Decimal val2 = 5.98m.To<Decimal>();
                Assert.AreEqual(val2, (Decimal)5.98);
                Decimal val3 = 0m.To<Decimal>();
                Assert.AreEqual(val3, (Decimal)0);
                var dv = -14.54m;
                Decimal val4 = dv.To<Decimal>();
            }

            #endregion
        }

        [TestClass]
        public class Test_Char
        {
            #region Char and Byte + SByte
            //Считаю их особыми, поэтому поставил в начале, а не в соответствии с signed-unsigned
            [TestMethod()]
            public void To_TestChar()
            {
                Char val2 = char.MinValue.To<Char>();
                Assert.AreEqual(val2, char.MinValue);
                Char val3 = char.MaxValue.To<Char>();
                Assert.AreEqual(val3, char.MaxValue);
                Char val4 = '\x1321'.To<Char>();
                Assert.AreEqual(val4, '\x1321');
            }

            
            [TestMethod()]
            public void To_TestByte()
            {
                Byte val1 = char.MinValue.To<Byte>();
                Assert.AreEqual(val1, (Byte)char.MinValue);
                Byte val12 = '~'.To<Byte>();
                Assert.AreEqual(val12, (Byte)'~');
                Assert.ThrowsException<System.OverflowException>(() => 
                {
                    Byte val2 = char.MaxValue.To<Byte>(); 
                });
                
                Assert.ThrowsException<System.OverflowException>(() => 
                {
                    Byte val3 = '\u2151'.To<Byte>(); 
                });
                
            }

            [TestMethod()]
            public void To_TestSByte()
            {
                SByte val1 = char.MinValue.To<SByte>();
                Assert.AreEqual(val1, (SByte)char.MinValue);
                SByte val12 = '~'.To<SByte>();
                Assert.AreEqual(val12, (SByte)'~');
                Assert.ThrowsException<System.OverflowException>(() =>
                {
                    SByte val2 = char.MaxValue.To<SByte>();
                });

                Assert.ThrowsException<System.OverflowException>(() =>
                {
                    SByte val3 = '\u2151'.To<SByte>();
                });
            }

            #endregion

            #region signed

            [TestMethod()]
            public void To_TestInt16()
            {
                Int16 val1 = char.MinValue.To<Int16>();
                Assert.AreEqual(val1, (Int16)char.MinValue);
                Int16 val12 = '~'.To<Int16>();
                Assert.AreEqual(val12, (Int16)'~');
                Assert.ThrowsException<System.OverflowException>(() =>
                {
                    Int16 val2 = char.MaxValue.To<Int16>();
                });
                Int16 val3 = '\u2151'.To<Int16>();
                Assert.AreEqual(val3, (Int16)'\u2151');
            }

            [TestMethod()]
            public void To_TestInt32()
            {
                Int32 val1 = char.MinValue.To<Int32>();
                Assert.AreEqual(val1, (Int32)char.MinValue);
                Int32 val12 = '~'.To<Int32>();
                Assert.AreEqual(val12, (Int32)'~');
                Int32 val2 = char.MaxValue.To<Int32>();
                Assert.AreEqual(val2, (Int32)char.MaxValue);
                Int32 val3 = '\u2151'.To<Int32>();
                Assert.AreEqual(val3, (Int32)'\u2151');
            }

            [TestMethod()]
            public void To_TestInt64()
            {
                Int64 val1 = char.MinValue.To<Int64>();
                Assert.AreEqual(val1, (Int64)char.MinValue);
                Int64 val12 = '~'.To<Int64>();
                Assert.AreEqual(val12, (Int64)'~');
                Int64 val2 = char.MaxValue.To<Int64>();
                Assert.AreEqual(val2, (Int64)char.MaxValue);
                Int64 val3 = '\u2151'.To<Int64>();
                Assert.AreEqual(val3, (Int64)'\u2151');
            }

            #endregion

            #region unsigned
            [TestMethod()]
            public void To_TestUInt16()
            {
                UInt16 val1 = char.MinValue.To<UInt16>();
                Assert.AreEqual(val1, (UInt16)char.MinValue);
                UInt16 val12 = '~'.To<UInt16>();
                Assert.AreEqual(val12, (UInt16)'~');
                UInt16 val2 = char.MaxValue.To<UInt16>();
                Assert.AreEqual(val2, (UInt16)char.MaxValue);
                UInt16 val3 = '\u2151'.To<UInt16>();
                Assert.AreEqual(val3, (UInt16)'\u2151');
            }

            [TestMethod()]
            public void To_TestUInt32()
            {
                UInt32 val1 = char.MinValue.To<UInt32>();
                Assert.AreEqual(val1, (UInt32)char.MinValue);
                UInt32 val12 = '~'.To<UInt32>();
                Assert.AreEqual(val12, (UInt32)'~');
                UInt32 val2 = char.MaxValue.To<UInt32>();
                Assert.AreEqual(val2, (UInt32)char.MaxValue);
                UInt32 val3 = '\u2151'.To<UInt32>();
                Assert.AreEqual(val3, (UInt32)'\u2151');
            }

            [TestMethod()]
            public void To_TestUInt64()
            {
                UInt64 val1 = char.MinValue.To<UInt64>();
                Assert.AreEqual(val1, (UInt64)char.MinValue);
                UInt64 val12 = '~'.To<UInt64>();
                Assert.AreEqual(val12, (UInt64)'~');
                UInt64 val2 = char.MaxValue.To<UInt64>();
                Assert.AreEqual(val2, (UInt64)char.MaxValue);
                UInt64 val3 = '\u2151'.To<UInt64>();
                Assert.AreEqual(val3, (UInt64)'\u2151');
            }
            #endregion

            #region floating-point
            
            [TestMethod()]
            public void To_TestSingle()
            {
                Single val1 = char.MinValue.To<Single>();
                Assert.AreEqual(val1, (Single)char.MinValue);
                Single val12 = '~'.To<Single>();
                Assert.AreEqual(val12, (Single)'~');
                Single val2 = char.MaxValue.To<Single>();
                Assert.AreEqual(val2, (Single)char.MaxValue);
                Single val3 = '\u2151'.To<Single>();
                Assert.AreEqual(val3, (Single)'\u2151');
            }

            [TestMethod()]
            public void To_TestDouble()
            {
                Double val1 = char.MinValue.To<Double>();
                Assert.AreEqual(val1, (Double)char.MinValue);
                Double val12 = '~'.To<Double>();
                Assert.AreEqual(val12, (Double)'~');
                Double val2 = char.MaxValue.To<Double>();
                Assert.AreEqual(val2, (Double)char.MaxValue);
                Double val3 = '\u2151'.To<Double>();
                Assert.AreEqual(val3, (Double)'\u2151');
            }

            [TestMethod()]
            public void To_TestDecimal()
            {
                Decimal val1 = char.MinValue.To<Decimal>();
                Assert.AreEqual(val1, (Decimal)char.MinValue);
                Decimal val12 = '~'.To<Decimal>();
                Assert.AreEqual(val12, (Decimal)'~');
                Decimal val2 = char.MaxValue.To<Decimal>();
                Assert.AreEqual(val2, (Decimal)char.MaxValue);
                Decimal val3 = '\u2151'.To<Decimal>();
                Assert.AreEqual(val3, (Decimal)'\u2151');

            }
            
            #endregion
        }

        [TestClass]
        public class Test_Byte
        {
            #region Char and Byte + SByte
            //Считаю их особыми, поэтому поставил в начале, а не в соответствии с signed-unsigned
            [TestMethod()]
            public void To_TestChar()
            {
                Char val2 = byte.MinValue.To<Char>();
                Assert.AreEqual(val2, (char)byte.MinValue);
                Char val3 = byte.MaxValue.To<Char>();
                Assert.AreEqual(val3, (char)byte.MaxValue);
                Char val4 = ((byte)253).To<Char>();
                Assert.AreEqual(val4, (char)253);
            }


            [TestMethod()]
            public void To_TestByte()
            {
                Byte val2 = byte.MinValue.To<Byte>();
                Assert.AreEqual(val2, (Byte)byte.MinValue);
                Byte val3 = byte.MaxValue.To<Byte>();
                Assert.AreEqual(val3, (Byte)byte.MaxValue);
                Byte val4 = ((byte)253).To<Byte>();
                Assert.AreEqual(val4, (Byte)253);

            }

            /*[TestMethod()]
            public void To_TestSByte()
            {
                SByte val1 = byte.MinValue.To<SByte>();
                Assert.AreEqual(val1, (SByte)byte.MinValue);
                SByte val12 = ((byte)123).To<SByte>();
                Assert.AreEqual(val12, (SByte)123);
                Assert.ThrowsException<System.OverflowException>(() =>
                {
                    SByte val2 = byte.MaxValue.To<SByte>();
                });

                Assert.ThrowsException<System.OverflowException>(() =>
                {
                    SByte val3 = ((byte)253).To<SByte>();
                });
            }

            #endregion

            #region signed

            /*[TestMethod()]
            public void To_TestInt16()
            {
                Int16 val1 = char.MinValue.To<Int16>();
                Assert.AreEqual(val1, (Int16)char.MinValue);
                Int16 val12 = '~'.To<Int16>();
                Assert.AreEqual(val12, (Int16)'~');
                Assert.ThrowsException<System.OverflowException>(() =>
                {
                    Int16 val2 = char.MaxValue.To<Int16>();
                });
                Int16 val3 = '\u2151'.To<Int16>();
                Assert.AreEqual(val3, (Int16)'\u2151');
            }

            [TestMethod()]
            public void To_TestInt32()
            {
                Int32 val1 = char.MinValue.To<Int32>();
                Assert.AreEqual(val1, (Int32)char.MinValue);
                Int32 val12 = '~'.To<Int32>();
                Assert.AreEqual(val12, (Int32)'~');
                Int32 val2 = char.MaxValue.To<Int32>();
                Assert.AreEqual(val2, (Int32)char.MaxValue);
                Int32 val3 = '\u2151'.To<Int32>();
                Assert.AreEqual(val3, (Int32)'\u2151');
            }

            [TestMethod()]
            public void To_TestInt64()
            {
                Int64 val1 = char.MinValue.To<Int64>();
                Assert.AreEqual(val1, (Int64)char.MinValue);
                Int64 val12 = '~'.To<Int64>();
                Assert.AreEqual(val12, (Int64)'~');
                Int64 val2 = char.MaxValue.To<Int64>();
                Assert.AreEqual(val2, (Int64)char.MaxValue);
                Int64 val3 = '\u2151'.To<Int64>();
                Assert.AreEqual(val3, (Int64)'\u2151');
            }

            #endregion

            #region unsigned
            [TestMethod()]
            public void To_TestUInt16()
            {
                UInt16 val1 = char.MinValue.To<UInt16>();
                Assert.AreEqual(val1, (UInt16)char.MinValue);
                UInt16 val12 = '~'.To<UInt16>();
                Assert.AreEqual(val12, (UInt16)'~');
                UInt16 val2 = char.MaxValue.To<UInt16>();
                Assert.AreEqual(val2, (UInt16)char.MaxValue);
                UInt16 val3 = '\u2151'.To<UInt16>();
                Assert.AreEqual(val3, (UInt16)'\u2151');
            }

            [TestMethod()]
            public void To_TestUInt32()
            {
                UInt32 val1 = char.MinValue.To<UInt32>();
                Assert.AreEqual(val1, (UInt32)char.MinValue);
                UInt32 val12 = '~'.To<UInt32>();
                Assert.AreEqual(val12, (UInt32)'~');
                UInt32 val2 = char.MaxValue.To<UInt32>();
                Assert.AreEqual(val2, (UInt32)char.MaxValue);
                UInt32 val3 = '\u2151'.To<UInt32>();
                Assert.AreEqual(val3, (UInt32)'\u2151');
            }

            [TestMethod()]
            public void To_TestUInt64()
            {
                UInt64 val1 = char.MinValue.To<UInt64>();
                Assert.AreEqual(val1, (UInt64)char.MinValue);
                UInt64 val12 = '~'.To<UInt64>();
                Assert.AreEqual(val12, (UInt64)'~');
                UInt64 val2 = char.MaxValue.To<UInt64>();
                Assert.AreEqual(val2, (UInt64)char.MaxValue);
                UInt64 val3 = '\u2151'.To<UInt64>();
                Assert.AreEqual(val3, (UInt64)'\u2151');
            }
            #endregion

            #region floating-point

            [TestMethod()]
            public void To_TestSingle()
            {
                Single val1 = char.MinValue.To<Single>();
                Assert.AreEqual(val1, (Single)char.MinValue);
                Single val12 = '~'.To<Single>();
                Assert.AreEqual(val12, (Single)'~');
                Single val2 = char.MaxValue.To<Single>();
                Assert.AreEqual(val2, (Single)char.MaxValue);
                Single val3 = '\u2151'.To<Single>();
                Assert.AreEqual(val3, (Single)'\u2151');
            }

            [TestMethod()]
            public void To_TestDouble()
            {
                Double val1 = char.MinValue.To<Double>();
                Assert.AreEqual(val1, (Double)char.MinValue);
                Double val12 = '~'.To<Double>();
                Assert.AreEqual(val12, (Double)'~');
                Double val2 = char.MaxValue.To<Double>();
                Assert.AreEqual(val2, (Double)char.MaxValue);
                Double val3 = '\u2151'.To<Double>();
                Assert.AreEqual(val3, (Double)'\u2151');
            }

            [TestMethod()]
            public void To_TestDecimal()
            {
                Decimal val1 = char.MinValue.To<Decimal>();
                Assert.AreEqual(val1, (Decimal)char.MinValue);
                Decimal val12 = '~'.To<Decimal>();
                Assert.AreEqual(val12, (Decimal)'~');
                Decimal val2 = char.MaxValue.To<Decimal>();
                Assert.AreEqual(val2, (Decimal)char.MaxValue);
                Decimal val3 = '\u2151'.To<Decimal>();
                Assert.AreEqual(val3, (Decimal)'\u2151');

            }
            */
            #endregion
        }

        [TestClass]
        public class Test_SByte
        {
        }

        [TestClass]
        public class Test_Int16
        {
        }

        [TestClass]
        public class Test_Int32
        {
                
        }

            [TestClass]
        public class Test_Int64
        {
        }

        [TestClass]
        public class Test_UInt16
        {
        }

        [TestClass]
        public class Test_UInt32
        {
        }

        [TestClass]
        public class Test_UInt64
        {
        }
    }
}