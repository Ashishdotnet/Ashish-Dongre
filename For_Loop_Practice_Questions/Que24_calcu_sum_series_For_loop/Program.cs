using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que24_calcu_sum_series_For_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Write a program in C# Sharp to find the sum of the series [ x - x^3 + x^5 - x^7 + x^9 -.....].
               Test Data :
               Input the value of x : 2
               Input number of terms : 5
               Expected Output :
               The sum = 410
               Number of terms = 5
               The value of x = 2
             */
            int i,num;
            double X, term, P, sum, tr ;
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("Calculate The Sum Of The Series [ X - X^3 + X^5 - X^7 + X^9 - ........]. ");
            Console.WriteLine("-----------------------------------------------------------------------\n");

            Console.Write("Input The Value Of X : ");
            X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Input The Number Of Terms : ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            sum = 0; term = 1;
            for(i = 1,P = 1; i <= num + 1; i++)
            {
                tr = Math.Pow(X,P);
                sum = sum + tr * term;
                term = term * (1);
                P = P + 2;
            }
            Console.WriteLine("-------------------------");
            Console.Write("Solution :->\n\nThe Sum = {0}\n\nNumber Of Terms = {1}\n\nThe Value Of X = {2}\n\n", sum, num, X);
        }
    }
}
