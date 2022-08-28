using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_even_Num_for_loop_Ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Write a program in C# Sharp to display the n terms of even natural number and their sum.
               Test Data : Input number of terms : 5
               Expected Output : The even numbers are :2 4 6 8 10
               The Sum of even Natural Number upto 5 terms : 30
             */
            Console.WriteLine("===========================================================");
            Console.Write("  Display The n Terms of Even Natural Numbers and their Sum\n");
            Console.WriteLine("===========================================================");

            int i, sum = 0,num;

            Console.Write("\nInput Numbers Of Terms : ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nThe Even Numbers are : "); 
            for (i = 1; i <= num; i++)
            {
                Console.Write("{0}  ",2*i);
                sum = sum + 2 * i;
            }
            Console.WriteLine("\n\nThe Sum Of Even Natural Number Upto {0} Terms is : {1} \n\n",num,sum);

        }
    }
}
