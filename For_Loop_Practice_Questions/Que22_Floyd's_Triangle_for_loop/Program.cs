using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que22_Floyd_s_Triangle_for_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Write a program in C# Sharp to print the Floyd's Triangle. Go to the editor

                                1
                                01 
                                101
                                0101 
                                10101
             */
            int i, j, num, P, Q;
            Console.WriteLine("\nDisplay Floyd's Triangle");
            Console.WriteLine("-------------------------\n");

            Console.Write("Input the Number Of Rows : ");
            num = Convert.ToInt32(Console.ReadLine());
            
            for(i = 1; i <= num; i++)
            {
                
                if(i % 2 == 0)
                { P = 0; Q = 1; }
                else
                { P = 1; Q = 0; }

                for (j = 1; j <= i; j++)
                    if (j % 2 == 0)
                        Console.Write("{0} ",P);
                    else
                        Console.Write("{0} ",Q);
                Console.Write("\n");
                

            }
            

        }
    }
}
