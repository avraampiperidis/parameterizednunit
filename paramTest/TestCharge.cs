using NUnit.Framework;
using System.Collections.Generic;
using paramtestnet.Util;
using System;

namespace Tests
{
    [TestFixture(typeof(int),1)]
    [TestFixture(typeof(int),2)]
    public class TestCharge<T>
    {
        T categoryType;
        public TestCharge(T t) 
        {
            this.categoryType = t;
        }

        [Test,TestCaseSource("priceProvider")]
        public void testCalculate(double price,int quantity,double discount,double expectedFinalAmount) 
        {
            Assert.AreEqual(expectedFinalAmount,Util.calculate(price,quantity,discount,(int)(object)this.categoryType)); 
        }

        //[Test]
        public void testBizarreThingsOnCalculate() 
        {
            //1 null's
            //2 negative and zero input's
            //3 exception/input validation handling
            //4 rounding
        }

         
         // Anyone knows how to put this method in seperate class? 
         // I tried everything from namespace path to class path in 'TestCaseSource' and nothing worked.
         public static IEnumerable<TestCaseData> priceProvider() 
         {
             yield return new TestCaseData(5.52,5,15,23.46);
             yield return new TestCaseData(10,10,10,90);
             yield return new TestCaseData(10,10,0,100);
        }
    }
}