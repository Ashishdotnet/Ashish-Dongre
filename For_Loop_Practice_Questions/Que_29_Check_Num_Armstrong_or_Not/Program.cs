using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que_29_Check_Num_Armstrong_or_Not
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Write a C# Sharp program to check whether a given number is an Armstrong number or not.
               Test Data :
               Input a number: 153
               Expected Output : 153 is an Armstrong number.
             */
            Console.WriteLine("To check Given Number is an Armstrong Number Or Not ");
            Console.WriteLine("-----------------------------------------------------");
            int num, sum = 0, temp, r;
            Console.Write(" Input The Number : ");
            num = Convert.ToInt32(Console.ReadLine());
            for(temp = num; num != 0; num = num/10)
            {
                r = num % 10;
                sum = sum +(r*r*r);
            }
            if (sum == temp)
                Console.Write(" {0} is an Armstrong Number .\n", temp);
            else
                Console.Write(" {0} is Not an Armstrong Number.\n ",temp);
        }
    }
}
