using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_N_terms_for_loop_ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Write a program in C# Sharp to display n terms of natural number and their sum.Go to the editor
               Test Data : 7
               Expected Output :
               The first 7 natural number is : 1 2 3 4 5 6 7
               The Sum of Natural Number upto 7 terms : 28 */
            int i, sum = 0;
            Console.WriteLine("=================================================");
            Console.WriteLine("Display n terms of Natural Numbers and Thier sum");
            Console.WriteLine("=================================================");
            Console.WriteLine("");
            Console.Write("\nInput The Number to calculate Sum of N terms of Natural Numbers:=");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The First {0} Natural Numbers are:",num);
            for (i = 1; i <= num; i++)
            {
                sum = sum + num;
                Console.WriteLine(i);
            }
            Console.WriteLine("======================================================");
            Console.WriteLine("The Sum Of Natural Numbers upto {0} is : {1}",num,sum);

        }
    }
}
