using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_Prog_repeat_values_each_row_ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Write a program in C# Sharp to make such a pattern like right angle triangle with a
               number which will repeat a number in a row.
               The pattern like :1
                                 22
                                 333
                                 4444 */
            int i, rows, j;
            Console.WriteLine("\n===================================================");
            Console.WriteLine("Star pattern program that show right angle triangle");
            Console.WriteLine("====================================================");

            Console.Write("\n\n Input The Number Of Rows To print : ");
            rows = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= i; j++)
                    Console.Write("{0}",i);
                Console.WriteLine();
            }


        }
    }
}
