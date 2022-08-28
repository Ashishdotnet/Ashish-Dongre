using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que_30_Check_Armstrong_within_range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Write a C# Sharp program to find the Armstrong number for a given range of number.
               Test Data : Input starting number of range: 1
                           Input ending number of range : 1000
               Expected Output : Armstrong numbers in given range are: 1 153 370 371 407
             */
            Console.WriteLine("Find the Armstrong Number For Given Range Of Number ");
            Console.WriteLine("----------------------------------------------------");
            int num, r, sum, temp;
            int min, max;

            Console.Write("Input The Starting Number : ");
            min = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input The Ending Number : ");
            max = Convert.ToInt32(Console.ReadLine());

            Console.Write("Armstrong Numbers in Given Range Are : ");

            for(num = min; num <= max; num++)
            {
                temp = num;
                sum = 0;
                while(temp != 0)
                {
                    r = temp % 10;
                    temp = temp / 10;
                    sum = sum + (r*r*r);
                }
                if(sum == num)
                    Console.Write("{0} ",num);
            }
            Console.WriteLine("\n");
        }
    }
}
