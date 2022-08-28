using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplication_table_user_for_loop_ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Write a program in C# Sharp to display the multiplication table of a given integer.
                Test Data :
                Input the number (Table to be calculated) : 15
                Expected Output :
                15 X 1 = 15
                ...
                ...
                15 X 10 = 150  */
            int num, i;
            Console.WriteLine("\n     Display Multiplication table of given integer:");
            Console.Write("==========================================================\n");
            Console.Write("Input the Number :");
            num = Convert.ToInt32(Console.ReadLine());
            for(i = 1;i<=10;i++)
            {
                Console.WriteLine("output : {0} * {1} = {2}",num,i,num*i);
            }
        }
    }
}
