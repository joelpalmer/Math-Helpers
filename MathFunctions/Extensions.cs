using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFunctions
{
   public static class Extensions
   {
      public static bool IsDivisibleBy(this int denominator, int dividend)
      {

         return denominator % dividend == 0;
      }
   }
}
