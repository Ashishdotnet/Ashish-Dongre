using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_with_Number_for_loop_tri_ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Write a program in C# Sharp to display the pattern like right angle triangle with a number.
                The pattern like :1
                                  12
                                  123
                                  1234 */
            int rows, i, j;
            Console.WriteLine("");
            Console.WriteLine("=======================================");
            Console.Write("Input the rows to print Number Pattern:");
            rows = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= i; j++)
                    Console.Write(" {0}",j);
                Console.Write("\n");
            }
            Console.WriteLine("");
        }
    }
}
