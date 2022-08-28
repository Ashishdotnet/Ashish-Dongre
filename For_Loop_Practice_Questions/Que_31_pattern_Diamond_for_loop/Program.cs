using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que_31_pattern_Diamond_for_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Write a program in C# Sharp to display the pattern like a diamond.

                                     *                               
                                    *** 
                                   *****
                                  *******
                                 *********
                                  *******
                                   *****
                                    ***
                                     * 
             */
            Console.WriteLine("Display the Pattern Like a Diamond ");
            Console.WriteLine("-----------------------------------");
            int i, j, num;

            Console.Write("Enter the Number Of Rows (Half Of The Diamond) : ");
            num = Convert.ToInt32(Console.ReadLine());
            for(i = 0; i <= num; i++)
            {
                for (j = 1; j <= num - i; j++)
                    Console.Write(" ");
                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
            for(i= num -1;i>=1;i--)
            {
                for (j = 1; j <= num - i; j++)
                    Console.Write(" ");
                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }

            

            
        }
    }
}
