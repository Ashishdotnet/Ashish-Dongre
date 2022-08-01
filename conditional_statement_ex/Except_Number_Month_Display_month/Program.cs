using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Except_Number_Month_Display_month
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program in C# Sharp to read any Month Number in integer and 
             display Month name in the word. Go to the editor
             Test Data : 4
             Expected Output: April
             */
            int Month;
            Console.Write("\n==================================================================");
            Console.Write("\n\nEnter the Number and see what Months comes in that Number\n");
            Console.Write("\n===================================================================");
            Console.WriteLine("\nInput The Number:");
            Month = Convert.ToInt32(Console.ReadLine());
            switch (Month)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("October");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;
                default:
                    Console.WriteLine("please Enter Numbers 1 To 12 to See Which Month You Want To see");
                    break ;

            }
          
            


        }
    }
}
