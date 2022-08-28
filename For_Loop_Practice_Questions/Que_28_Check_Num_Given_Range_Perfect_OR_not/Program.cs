using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que_28_Check_Num_Given_Range_Perfect_OR_not
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a C# Sharp program to find the perfect numbers within a given range of number.
              Test Data :
              Input the starting range or number : 1
              Input the ending range of number : 50
              Expected Output : The Perfect numbers within the given range : 6 28 */
            Console.Write("\n Find The Perfect Numbers Within a Given Range of Number\n ");
            Console.Write("-----------------------------------------------------------\n");
            int i, num, sum;
            int min, max;

            Console.Write("Input the Starting Range Or Number : ");
            min = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the Ending Range Of Number : ");
            max = Convert.ToInt32(Console.ReadLine());

            Console.Write("The Perfect Numbers Within The Given Range : ");
            for(num = min; num <= max; num++)
            {
                i = 1;
                sum = 0;
                while(i<num)
                {
                    if (num % i == 0)
                        sum = sum + i;
                    i++;
                }
                if(sum == num)
                    Console.Write("{0} ",num);
            }
            Console.Write("\n");


        }
    }
}
