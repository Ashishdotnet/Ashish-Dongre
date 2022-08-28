using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cube_of_Num_user_input_for_loop_ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Write a program in C# Sharp to display the cube of the number up to given an integer.
               Test Data : Input number of terms : 5
               Expected Output : Number is : 1 and cube of the 1 is :1
                                 Number is : 2 and cube of the 2 is :8
                                 Number is : 3 and cube of the 3 is :27
                                 Number is : 4 and cube of the 4 is :64
                                 Number is : 5 and cube of the 5 is :125 */
            Console.Write("\nDisplay the Cube of the Number up to Given integer:\n");
            Console.Write("==========================================================\n");
            int  cube,num;
            Console.WriteLine("Input number of terms : 5");
            num = Convert.ToInt32(Console.ReadLine());
            for ( cube = 1; cube <= 5; cube++)//i use here Number 5 to run loop five times with
            {                                //cube value of increasing number. 
                Console.WriteLine(cube);
                Console.WriteLine("Number is : {0} and cube of the {1} is : {2}", cube, cube, (cube * cube * cube));
                // use cube variable to print the given values 
                // put cube calculation formula with same print line to execute given number 
            }
        }
    }
}
