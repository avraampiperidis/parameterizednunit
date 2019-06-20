using NUnit.Framework;
using paramtestnet.Util;
using paramTest;

namespace Tests
{
    [TestFixture(typeof(int),typeof(double),1,5)]
    [TestFixture(typeof(int),typeof(double),2,6.5)]
    public class TestCharge<T,X>
    {
        T categoryType;
        X extraValue;
        public TestCharge(T t,X x) 
        {
            this.categoryType = t;
            this.extraValue = x;
        }

        [Test,TestCaseSource(typeof(Provider),"priceProvider")]
        public void testCalculate(double price,int quantity,double discount,double expectedFinalAmount) 
        {
            Assert.AreEqual(expectedFinalAmount,Util.calculate(price,quantity,discount)); 
        }

        [Test,TestCaseSource(typeof(Provider),"priceProvider")]
        public void testCalculateCategory(double price,int quantity,double discount,double expectedFinalAmount) 
        {
            Assert.AreEqual(expectedFinalAmount+(double)(object)this.extraValue,Util.calculateCategory(price,quantity,discount,(int)(object)this.categoryType)); 
        }

        [TestCase(10,10,10,90)]
        [TestCase(10,10,0,100)]
        public void testCalculate2(double price,int quantity,double discount,double expectedFinalAmount) {
            Assert.AreEqual(expectedFinalAmount,Util.calculate(price,quantity,discount)); 
        }

        //[Test]
        public void testBizarreThingsOnCalculate() 
        {
            //1 null's
            //2 negative and zero input's
            //3 exception/input validation handling
            //4 rounding
        }
    }
}