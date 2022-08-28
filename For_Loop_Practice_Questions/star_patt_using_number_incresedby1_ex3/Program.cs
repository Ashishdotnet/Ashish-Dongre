using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace star_patt_using_number_incresedby1_ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program in C# Sharp to make such a pattern like right angle triangle with number increased by 1.
              The pattern like :1
                                2 3
                                4 5 6
                                7 8 9 10 */
            int i, j, rows,k=1;

            Console.Write("\n\nInput Number of Rows to print:");
            rows = Convert.ToInt32(Console.ReadLine());

            for(i = 1; i <= rows; i++)
            {
                for(j = 1; j <= i; j++)
                    Console.Write("{0} ",k++);//take k variable to store increased value by 1 and print.
                Console.WriteLine();
            }
        }
    }
}
