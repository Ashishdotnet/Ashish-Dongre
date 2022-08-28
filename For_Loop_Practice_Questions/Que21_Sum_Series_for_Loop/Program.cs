using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que21_Sum_Series_for_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Write a program in C# Sharp to display the sum of the series [ 9 + 99 + 999 + 9999 ...].
               Test Data :
               Input the number or terms : 5
               Expected Output : 9 99 999 9999 99999
               The sum of the series = 111105 */
            int i, num ,t=9, sum=0;

            Console.WriteLine("\nDisplay the Sum Of the Series [9 + 99 + 999 + 9999 .....].");
            Console.WriteLine("------------------------------------------------------------\n");
           

            Console.Write("Input the Number Or Terms : ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Solution :- ");
            Console.Write("OutPut Of Series : ");

            for(i = 1; i <= num; i++)
            {
                sum = sum + t;
                Console.Write("{0} + ",t);
                t = t * 10 + 9;
                
            }
            Console.WriteLine("\n\nThe Sum Of The Series = {0}\n ", sum);
            
        }
    }
}
