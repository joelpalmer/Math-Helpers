using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFunctions
{
   class Program
   {
      static void Main(string[] args)
      {
         //int i = 6;
         //Console.WriteLine(i.IsDivisibleBy(3));
         //Console.ReadLine();

         ShowDivisibles(1, 100, "divisible by 3", "divisible by 5");
         Console.ReadLine();
      }

      public static void ShowDivisibles(int start, int end, string threeText, string fiveText)
      {
         for (var i = start; end >= i; i++)
         {

            if (i.IsDivisibleBy(3) && i.IsDivisibleBy(5))
            {
               Console.WriteLine(threeText + " and " + fiveText);
            }

            else if (i.IsDivisibleBy(3))
            {
               Console.WriteLine(threeText);
            }
            else if (i.IsDivisibleBy(5))
            {
               Console.WriteLine(fiveText);
            }
            else
            {
               Console.WriteLine(i);
            }
         }
      }
   }
}
