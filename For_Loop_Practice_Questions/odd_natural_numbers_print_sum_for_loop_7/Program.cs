using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odd_natural_numbers_print_sum_for_loop_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Write a program in C# Sharp to display the n terms of odd natural number and their sum.
                Test Data
                Input number of terms : 10
                Expected Output : The odd numbers are :1 3 5 7 9 11 13 15 17 19
                The Sum of odd Natural Number upto 10 terms : 100 */
            Console.WriteLine("=========================================================");
            Console.Write("Display the n terms off odd natural numbers and their sum\n");
            Console.Write("=========================================================\n");
            int i, num,sum=0;
            Console.Write("Input number of terms :");
            num = Convert.ToInt32(Console.ReadLine());  
            for(i = 1; i <= num; i++)
            {
                Console.Write(" {0}, ", 2 * i - 1);
                sum = sum + 2 * i -1;
            }
            Console.WriteLine("\n\nThe Sum Of Odd Natural Numbers upto {0} terms is = {1}\n ",num,sum);


        }
    }
}
