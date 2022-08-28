using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyramid_Star_Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Write a program in C# Sharp to make such a pattern like a pyramid with an asterisk.

                         *
                        * * 
                       * * *
                      * * * *
           */
            Console.WriteLine("=======================================");
            Console.WriteLine("      Pyramid Shape Star Pattern "      );
            Console.WriteLine("=======================================");
            int i, j,Rows,k, space;

            Console.Write("Input The Number Of Rows To Print : ");
            Rows = Convert.ToInt32(Console.ReadLine());

            space = Rows + 5;
            for (i = 1; i <= Rows; i++)
               
            {
                {
                    for (k = space; k >= 1; k--)
                    {
                        Console.Write(" ");
                    }

                    for (j = 1; j <= i; j++)
                        Console.Write("* ", i);
                        Console.WriteLine();
                        space--;
                }
            }


        }
    }
}
