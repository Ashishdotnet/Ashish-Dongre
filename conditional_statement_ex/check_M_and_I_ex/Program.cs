using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace check_M_and_I_ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Write a C# Sharp program to read the value of an integer m and 
               display the value of n is 1 when m is larger than 0, 0 when m is 0 and
               -1 when m is less than 0. Go to the editor
               Test Data : -5
               Expected Output:
               The value of n = -1 */
            
            Console.WriteLine("Enter the value of M :");
            int m = Convert.ToInt32(Console.ReadLine());

            if (m <= 0)
            {
                Console.WriteLine("n is -1");

            }
            else {

                Console.WriteLine("n is 1");
            
            }
            



        }
    }
}
