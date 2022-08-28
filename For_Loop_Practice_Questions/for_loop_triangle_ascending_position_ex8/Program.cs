using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_loop_triangle_ascending_position_ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              Write a program in C# Sharp to display the pattern like right angle triangle using an asterisk.
              The pattern like : *
                                 **
                                 ***
                                 ****
            */
            int j, i, row;
            Console.WriteLine("Input the rows to print:");
            row = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i<=row; i++)//here i put logic to take input from user how much rows want to print
                                    // then i want to print star pattern with acending order so i used inner loop to print
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("*");
                    
                }
                Console.Write("\n");// i can write this code inside the inner loop to execute patter space
                                   // but i put outside from inner loop to try something new.
            }
            
            

        }
    }
}
