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
        ShowDivisibles(101, 100, "divisible by 3", "divisible by 5");
         Console.ReadLine();
      }

      public static void ShowDivisibles(int start, int end, string threeText, string fiveText)
      {

         try
         {
            if (end < start)
            {
               throw new ArgumentException( "ShowDivisibles: The starting number must be lower than the ending number");
               //return false;
            }

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
         catch (Exception err)
         {
            Console.WriteLine("{0} Exception caught.", err);

         }
         
         
         
   
      }
   }
}
