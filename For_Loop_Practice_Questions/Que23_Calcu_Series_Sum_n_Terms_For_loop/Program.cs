using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que23_Calcu_Series_Sum_n_Terms_For_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Write a program in C# Sharp to display the sum of the series [ 1+x+x^2/2!+x^3/3!+....].
               Test Data :
               Input the value of x : 3
               Input number of terms : 5
               Expected Output :The sum is : 16.375000
                                Number of terms = 5
                                The value of x = 3.000000
             */
            int i, num;
            double sum, X, num_row ;

            Console.WriteLine("\nDisplay the Sum Of the Series [ 1+x+x^2/2!+x^3/3!+......]");
            Console.WriteLine("-----------------------------------------------------------\n");

            Console.Write("Input the Value Of X : ");
            X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Input the Number Of Terms : ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            
            sum = 1; num_row = 1;
            for(i = 1; i <= num; i++)
            {
                num_row = num_row * X / (float)i;
                sum = sum + num_row;

            }
            Console.Write("-------------------");
            Console.Write("\n The Sum is : {0} \n Number Of Terms = {1} \n The Value Of X = {2} \n\n",sum,num,X);
        }
    }
}
