using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial_of_user_num_For_loop_ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *  Write a C# Sharp program to calculate the factorial of a given number.
                Test Data : Input the number : 5
                            Expected Output : The Factorial of 5 is: 120
             */
            Console.WriteLine("=========================================");
            Console.WriteLine("Program To Calculate Factorial Of Number");
            Console.WriteLine("=========================================");
            int i, num, fact = 1;

            Console.Write("\nInput The Number To Calculate Factor : ");
            num = Convert.ToInt32(Console.ReadLine());

            for(i = 1; i <= num; i++)
            
                fact = fact * i;
                Console.WriteLine("\nThe Factorial Of {0} is : {1} \n", num, fact);
               
            
        }
    }
}
 