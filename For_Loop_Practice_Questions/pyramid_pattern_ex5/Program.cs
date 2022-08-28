using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pyramid_pattern_ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program in C# Sharp to make such a pattern like a pyramid with numbers increased by 1.

                       1 
                      2 3 
                     4 5 6 
                    7 8 9 10  */
            Console.Write("\n===========================================\n");
            Console.Write("Pyramid Number Pattern value Increased By 1.\n");
            Console.Write("============================================\n");
            int i, j, k,rows,space,B=1;

            Console.Write("Input the Number Of Rows To Print pattern : ");
            rows = Convert.ToInt32(Console.ReadLine());

            space = rows + 4;
            for(i=1; i<=rows; i++)
            {
                for(k=space; k>=1; k--)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= i; j++)
                    Console.Write("{0} ", B++);
                Console.WriteLine();
                space--;
                
            }



        }
    }
}
