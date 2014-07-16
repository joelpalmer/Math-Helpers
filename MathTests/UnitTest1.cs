using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathFunctions; 

namespace MathTests
{
   [TestClass]
   public class UnitTest1
   {
      [TestMethod]
      public void TestMethod1()
      {
         int i = 6;
         int j = 12;
         int k = 15;
         Assert.IsTrue(i.IsDivisibleBy(3));
         Assert.IsTrue(j.IsDivisibleBy(4));
         Assert.IsTrue(k.IsDivisibleBy(5));
      }
   }
}
