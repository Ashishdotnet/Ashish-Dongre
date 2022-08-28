using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_table_vertically_ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Write a program in C# Sharp to display the multiplication table vertically from 1 to n.
               Test Data : Input upto the table number starting from 1 : 8
               Expected Output :
               Multiplication table from 1 to 8
               1x1 = 1, 2x1 = 2, 3x1 = 3, 4x1 = 4, 5x1 = 5, 6x1 = 6, 7x1 = 7, 8x1 = 8
               ...
               1x10 = 10, 2x10 = 20, 3x10 = 30, 4x10 = 40, 5x10 = 50, 6x10 = 60, 7x10 = 70, 8x10 = 80  */
            Console.Write("===================================================");
            Console.WriteLine("\nMultiplication Table vaertically from 1 to n");
            Console.Write("====================================================\n\n");
            int i, num,j;

            Console.Write("Input the Number to make table  vertically : ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Multiplication Table from 1 to {0} \n ",num);

            for (i = 1; i <= 8; i++)
            {
                for(j = 1; j <= num; j++)
                {
                    if(j <= num -1)
                    
                        Console.Write("{0} * {1} = {2} , ", j, i, i * j);
                    
                    else 
                    
                        Console.Write("{0} * {1} = {2}" ,j,i, i * j);
                    
                }
                Console.Write("\n");
            }

        }
    }
}
