using System.Collections.Generic;
using NUnit.Framework;

namespace paramTest
{
    public class Provider
    {
         public static IEnumerable<TestCaseData> priceProvider() 
         {
             yield return new TestCaseData(5.52,5,15,23.46);
             yield return new TestCaseData(10,10,10,90);
             yield return new TestCaseData(10,10,0,100);
        }
    }
}