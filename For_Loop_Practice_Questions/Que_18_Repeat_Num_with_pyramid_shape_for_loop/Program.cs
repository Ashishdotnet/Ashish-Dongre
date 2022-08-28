using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que_18_Repeat_Num_with_pyramid_shape_for_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Write a program in C# Sharp to make such a pattern like a pyramid with a 
               number which will repeat the number in the same row.

                                              1
                                             2 2
                                            3 3 3
                                           4 4 4 4
            */
            Console.WriteLine("=======================================================");
            Console.WriteLine("Pyramid Pattern With Repeat the Number in the same Row");
            Console.WriteLine("=======================================================");
            Console.Write("Shape Should be Like : ");
            Console.WriteLine("\n         1   ");
            Console.WriteLine("        2 2");            //this is the part only for fun with program
            Console.WriteLine("       3 3 3");          //make design to made question like as it is. 
            Console.WriteLine("      4 4 4 4");
            Console.WriteLine("========================================================");
            Console.WriteLine("The solution of the Question is Below : ");
            int i, j,k, num,space;
            Console.Write("Input the Number Of Rows : ");
            num = Convert.ToInt32(Console.ReadLine());

            space = num + 5;
            for (i = 1; i <= num; i++)
            {
                for (k = space; k >= 1; k--)
                {
                    Console.Write(" ");
                }
                
                for (j = 1; j <= i; j++)
                Console.Write("{0} ", i);
                Console.WriteLine();
                space--;
            }
            Console.WriteLine();


        }
    }
}
