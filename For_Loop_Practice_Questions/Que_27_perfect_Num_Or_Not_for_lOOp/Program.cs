using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que_27_perfect_Num_Or_Not_for_lOOp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Write a C# Sharp program to check whether a given number is perfect number or not.
               Test Data :
               Input the number : 56
               Expected Output :
               The positive divisor : 1 2 4 7 8 14 28
               The sum of the divisor is : 64
               So, the number is not perfect. */
            //solution :-
            Console.WriteLine("----------------------------------");
            Console.WriteLine("To check Number is Perfect Or Not ");
            Console.WriteLine("----------------------------------\n");
            int i, num, sum;
            Console.Write("Enter The Positive Number To check Perfect Or Not : ");
            num = Convert.ToInt32(Console.ReadLine());
            sum = 0;
            Console.Write("The Positive Number Divisor is : ");
            for(i = 1; i <= num; i++)
            {
                if(num % i == 0)
                {
                    sum = sum + i;
                    Console.Write("{0} ", i);
                }
            }
            Console.Write("\n\nThe Sum Of The Divisor is : {0} ",sum);
            if (sum == num)
                Console.WriteLine("\nStatement:- So,the Number is Perfect.\n");
            else
                Console.WriteLine("\nStatement:- so,the Number is Not Perfect.\n");
            
        }
    }
}
