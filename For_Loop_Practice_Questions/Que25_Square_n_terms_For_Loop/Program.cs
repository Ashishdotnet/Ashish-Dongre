using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que25_Square_n_terms_For_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program in C# Sharp to display the n terms of square natural number and their sum. 1 4 9 16 ... n Terms
              Test Data : Input the number of terms : 5
              Expected Output : The square natural upto 5 terms are :1 4 9 16 25
                                The Sum of Square Natural Number upto 5 terms = 55  */
            int i, num, sum = 0;
            Console.WriteLine("\n--------------------------------------------------------------------------");
            Console.WriteLine("Calculate the n terms of Square Natural Number and their sum 1 4 9 16....n");
            Console.WriteLine("----------------------------------------------------------------------------");

            Console.Write("Input the number of terms : ");
            num = Convert.ToInt32(Console.ReadLine());
           
            Console.Write("-----------------------------------------------\n");
            Console.Write("The Square Natural Numbers are : ");

            for (i = 1; i <= num; i++)
            {
                Console.Write("{0} ", i * i);
                sum = sum + i * i;
            }
            Console.Write("\nThe Square Natural Upto {0} terms are : {1}\n\n ", num, sum);

        }
    }
}
