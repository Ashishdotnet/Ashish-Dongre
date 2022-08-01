using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace positive_or_Negative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a C# Sharp program to check whether a given number is positive or negative. Go to the editor
              Test Data : 14
              Expected Output :
              14 is a positive number*/
            int num;

            Console.WriteLine("Enter the Number to check it is positive or Negative :");
            num = Convert.ToInt32(Console.ReadLine());

            // using if else block to checking conditions
            if (num > 0)//to checking condition 
            {
              Console.WriteLine("{0} is a positive Number : ", num);//code of block to be executed when condition is to be true
            }
            else {

              Console.WriteLine("{0} is Negetive Number :", num);//code of block to be Executed when condition of if block failed
            
            }



        }
    }
}
