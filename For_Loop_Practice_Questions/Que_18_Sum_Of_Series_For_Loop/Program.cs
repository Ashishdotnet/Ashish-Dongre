using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que_18_Sum_Of_Series_For_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Write a program in C# Sharp to find the sum of the series [ 1-X^2/2!+X^4/4!- .........].
               Test Data : Input the Value of x :2
                           Input the number of terms : 5
               Expected Output : the sum = -0.415873
                                 Number of terms = 5
                                 value of x = 2.000000
             */
            Console.WriteLine("\nFind the Sum Of the Series [1-X^2/2!+X^4/4!- ........]");
            Console.WriteLine("=======================================================\n");

            double X, sum, T_value, d_value;
            int i, n;

            Console.Write("Input the Value Of X : ");
            X = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nInput the number Of Terms : ");
            n = Convert.ToInt32(Console.ReadLine());

            sum = 1; T_value = 1;
            for (i = 1; i <= n; i++)
            {
                d_value = (2 * i) * (2 * i - 1);
                T_value = -T_value * X * X / d_value;
                sum = sum + T_value;
            }
            Console.Write("\n\n  The Sum = {0}\n  Number Of Terms = {1}\n  Value Of X = {2} \n\n\n", sum, n, X);

        }
    }
}
