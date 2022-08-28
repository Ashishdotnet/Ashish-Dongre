using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que26_calcu_term_for_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Write a program in C# Sharp to find the sum of the series 1 +11 + 111 + 1111 + .. n terms.
               Test Data : Input the number of terms : 5
               Expected Output : 1 + 11 + 111 + 1111 + 11111 +
                                 The Sum is : 12345  */
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("Calculate the Sum Of The Series 1 + 11 + 111 + 1111 +....n terms.");
            Console.WriteLine("-----------------------------------------------------------------");

            int i, sum = 0,term = 1,num;
            Console.Write("Input the Number Of terms : ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n-------------------------------\n");
            Console.Write("Series : ");

            for(i = 1; i <= num; i++)
            {
                Console.Write("{0} +",term);
                sum = sum + term;
                term = (term * 10) + 1;
            }
            Console.Write("\n\nThe Sum is : {0} \n\n",sum);



        }
    }
}
