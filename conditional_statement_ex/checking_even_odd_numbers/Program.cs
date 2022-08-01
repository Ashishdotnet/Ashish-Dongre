using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checking_even_odd_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Write a C# Sharp program to check whether a given number is even or odd. Go to the editor
               Test Data : 15
               Expected Output :
               15 is an odd integer */
            // above using multiline comment 
            // initialize num variable with built in function bcz converting value from user input
            int rem;
            Console.WriteLine("Enter the number to check even or odd :");
            int  num = Convert.ToInt32(Console.ReadLine());
            rem = num % 2;
            if (rem == 0)
            {
                Console.WriteLine("The {0} is even Number", num);
            }
            else
            {
                Console.WriteLine("The {0} is Odd Number",num);
            }
            




        }
    }
}
