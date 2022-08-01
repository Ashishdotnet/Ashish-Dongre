using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Except_Month_Num_disp_days_of_month
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              Write a program in C# Sharp to read any Month Number in integer and 
              display the number of days for this month. Go to the editor
              Test Data : 7
              Expected Output: Month have 31 days
             */
            int mon_day;
            Console.WriteLine("Enter the Month number ");
            mon_day = Convert.ToInt32(Console.ReadLine());
            switch (mon_day)
            {
                case 1://(1st category is 31 days in month)
                case 3://(2nd category is 30 days in month)
                case 5://(3rd category is 28,29 days in month)
                case 7://i create 3 categories of months here
                case 8://these months comes in 31 days category
                case 10:
                case 12:
                    Console.WriteLine("Selected Month Comes In 31 days Category!");
                    break;
                case 2:// this is second category which comes in 28 days in a month and in leap year have 29 days
                    Console.WriteLine("Selected Month is February and have 28 days but in leap year have 29 days");
                    break ;
                case 4:
                case 6:
                case 9://these category comes in 30 days in months 
                case 11:
                    Console.WriteLine("Selected Month comes in 30 days category! ");
                    break;
                default:
                    Console.WriteLine("Please Select Valid Month Number To see How much days In that Month");
                    break;


            }
        }
    }
}
