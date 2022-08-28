using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que32_Check_prime_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Write a C# Sharp program to determine whether a given number is prime or not.
               Test Data :
               Input a number: 13
               Expected Output : 13 is a prime number.
             */
            int num, i, ctr=0;
            Console.WriteLine("Checking The Given Number is Prime Number Or Not ");
            Console.WriteLine("-------------------------------------------------");

            Console.Write("Enter The Number to check Prime Number Or Not : ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for(i = 2; i <= num / 2; i++)
            {
                if(num % i == 0)
                {
                    ctr ++;
                    break;
                }
            }
            if (ctr == 0 && num != 1)
                Console.Write(" {0} is The Prime Number.",num);
            else
                Console.Write(" {0} is Not a Prime Number.",num);
            Console.WriteLine("\n");
        }
    }
}
