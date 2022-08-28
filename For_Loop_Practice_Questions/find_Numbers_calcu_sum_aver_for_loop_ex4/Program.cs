using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace find_Numbers_calcu_sum_aver_for_loop_ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Write a program in C# Sharp to read 10 numbers from keyboard and find
                their sum and average. Go to the editor
                Test Data : Input the 10 numbers : 
                Number-1 :2
.               Number-10 :2
                Expected Output :
                The sum of 10 no is : 51
                The Average is : 5.100000 */
            int i, sum = 0,n;
            double avg;
            Console.WriteLine("====To find Sum and Average Of Input first 10 Numbers From User====");
            Console.WriteLine("Input 10 Numbers");
            for (i = 1; i <= 10; i++)
            {
                Console.Write("Number-{0} :", i);
                n = Convert.ToInt32(Console.ReadLine());//to store values 10 times from user
                sum = sum + n;
            }
            avg = sum / 10.0;
            Console.WriteLine("The sum Of 10 numbers is {0}  and average is {1}",sum,avg);

        }
    }
}
