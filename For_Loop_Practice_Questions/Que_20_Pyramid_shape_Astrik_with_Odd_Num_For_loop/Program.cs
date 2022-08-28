using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que_20_Pyramid_shape_Astrik_with_Odd_Num_For_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Write a program in C# Sharp to display the pattern like pyramid using 
               an asterisk and each row contain an odd number of an asterisks.
                                       *
                                      ***
                                     *****               
            */
            //Solution :-
            Console.WriteLine("Display the pattern Like Pyramid Using Astrik With each Row Odd Numbers");
            Console.WriteLine("=======================================================================");
            Console.WriteLine();
            int i, j, k, num,space;
            Console.Write("Input the Number of Rows : ");
            num = Convert.ToInt32(Console.ReadLine());

            space = num + 5;
            for(i = 1; i<= num ; i++)
            {
                for (k = space; k >= 1; k--)
                {
                    Console.Write(" ");
                }

                for (j = 1; j <= 2*i-1; j++)
                Console.Write("*");
                Console.WriteLine();
                space--;
            }
            Console.WriteLine();


        }
    }
}
