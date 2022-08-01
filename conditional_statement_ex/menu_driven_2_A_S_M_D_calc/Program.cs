using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu_driven_2_A_S_M_D_calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Write a program in C# Sharp which is a Menu-Driven Program to perform a simple calculation.
                Test Date and Expected Output
                Enter the first Integer :10
                Enter the second Integer :2

                Here are the options :
                1-Addition.
                2-Substraction.
                3-Multiplication.
                4-Division.
                5-Exit.

                Input your choice :3
                The Multiplication of 10 and 2 is: 20  */
            int options,num1,num2;
            Console.Write("\n=====[Menu Driven Program to Perform a Simple Calculation]======\n");

            Console.Write("\nEnter the First Number:\n");
            num1 = Convert.ToInt32(Console.ReadLine()); 
            
            Console.Write("Enter the Second Number:\n");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n 1-Addition:");
            Console.Write("\n 2-Substraction:");
            Console.Write("\n 3-Multiplication:");
            Console.Write("\n 4-Division:");
            Console.Write("\n 5-Exit:");

            Console.Write("\n Enter Your Choice:");
            options = Convert.ToInt32(Console.ReadLine());

            switch(options)
            {
                case 1:
                    Console.WriteLine("The Addition of Number {0} and Number {1} is= {2} ",num1,num2,num1 + num2);
                    break;
                case 2:
                    Console.WriteLine("The Substraction of Number {0} and Number {1} is= {2}", num1, num2, num1 - num2);
                    break;
                case 3:
                    Console.WriteLine("The Multiplication Of Number {0} and Number {1} is= {2}",num1, num2, num1 * num2);
                    break;
                case 4:
                    Console.WriteLine("The Divide Of Number {0} and Number {1} is= {2}",num1, num2, num1 / num2);
                    break;
                case 5:
                    Console.WriteLine("Youre Exit From the program:");
                    break;
                default:
                    Console.WriteLine("Please Select Given Option");
                    break;

            }

        }
    }
}
