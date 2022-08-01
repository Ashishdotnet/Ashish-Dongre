using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voter_eligibility_ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Write a C# Sharp program to read the age of a candidate and determine
               whether it is eligible for casting his/her own vote. Go to the editor
               Test Data : 21
               Expected Output:
               Congratulation! You are eligible for casting your vote. */
            Console.WriteLine("Please Enter Your Age :");
            int age = Convert.ToInt32(Console.ReadLine()); //using Built-in-Function to read candidate age

            if (age >= 18) // i can use here logic like if(age >= 18 && age == 18) but i use more
                           // readable i use quick understandable logic here and used operators give me 
                           // same output
            {
                Console.WriteLine("Congratulations! You are eligible for casting your vote.");
            }
            else
            {
                Console.WriteLine("Your age is not elible for casting your vote.");
            
            }

        }
    }
}
