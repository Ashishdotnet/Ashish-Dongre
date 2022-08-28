using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_10_Natural_Num_for_loop_ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Write a C# Sharp program to find the sum of first 10 natural numbers. Go to the editor
               Expected Output :
               The first 10 natural number is : 1 2 3 4 5 6 7 8 9 10
               The Sum is : 55 */
            int sum = 0;
            Console.Write("===================================");
            Console.Write("\nFind the sum of 10 Natural numbers");
            Console.Write("\n=====================================\n");
            Console.Write("First 10 Natural Numbers are:\n");
            for (int i = 1; i <= 10; i++)
            {
                sum = sum + i;
                Console.WriteLine(i);
               
            }
            Console.WriteLine("================================================");
            Console.WriteLine("\nThe Sum Of First 10 natural Numbers Is:\n"+sum);
            Console.WriteLine("==================================================");
            
            

        }
    }
}
