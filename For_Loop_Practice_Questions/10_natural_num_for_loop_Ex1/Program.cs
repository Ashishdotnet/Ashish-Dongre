using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_natural_num_for_loop_Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Write a program in C# Sharp to display the first 10 natural numbers. Go to the editor
             Expected Output : 1 2 3 4 5 6 7 8 9 10 */

            int i;
            Console.WriteLine("First 10 natural Numbers are!");
            for (i = 1; i <= 10; i++) 
            {
                Console.WriteLine("{0}",i);
            }
            Console.Write("\n");
        }
    }
}
