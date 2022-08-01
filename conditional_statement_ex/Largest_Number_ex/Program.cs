using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_Number_ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Write a C# Sharp program to find the largest of three numbers. Go to the editor
                Test Data:
                Input the 1st number :25
                Input the 2nd number :63
                Input the 3rd number :10
                Expected Output :
                The 2nd Number is the greatest among three  */

            int num1, num2, num3;

            Console.WriteLine("Input the 1st number :");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the 2nd number :");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the 3rd number :");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 >= num2 && num1 >= num3)// comparing two numbers to checking condition 
            {
                Console.WriteLine("The 1st number is the greatest among three !");

            }
            else if (num2 >= num1 && num2 >= num3)
            {
                Console.WriteLine("The 2nd number is the greatest among three !");// here also comparing two numbers

            }
            else {

                Console.WriteLine("The 3rd number is the greatest among three !");// here i am directly print the third highest number
                                                                                  // bcs i already comparing two of three numbers

            
            }


        }
    }
}
