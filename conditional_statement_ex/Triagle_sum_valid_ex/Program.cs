using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triagle_sum_valid_ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a C# Sharp program to check whether a triangle can be 
             formed by the given value for the angles. Go to the editor
             Test Data : 40 55 65
             Expected Output : The triangle is not valid. */

            int sideA, sideB, sideC,sum;

            Console.WriteLine("Enter the First Side Of Triangle:");
            sideA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Second side of Triangle:");
            sideB = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Third side of Triangle:");
            sideC = Convert.ToInt32(Console.ReadLine()); 
            
            sum = sideA + sideB + sideC;

            if (sum == 180)
            {
                Console.WriteLine("The Triangle is Valid.");
            }
            else 
            {
                Console.WriteLine("The Triangle is Not Valid.");
            }

        }
    }
}
