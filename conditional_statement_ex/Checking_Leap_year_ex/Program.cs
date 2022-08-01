using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checking_Leap_year_ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Write a C# Sharp program to find whether a given year is a leap year or not. Go to the editor
               Test Data: 2016
               Expected Output :
               2016 is a leap year. */
            int year;

            Console.WriteLine("Enter a Year To check It is Leap Or Not :");
            year = Convert.ToInt32(Console.ReadLine());


            if ((year % 400) == 0)
            {
                Console.WriteLine("The {0} is Leap Year :", year);

            }
            else if ((year % 100) == 0)
            {

                Console.WriteLine("The {0} is Not Leap Year :", year);

            }
            else if ((year % 4) == 0)
            {
                Console.WriteLine("The {0} is Leap Year :", year);

            }
            else 
            {
                Console.WriteLine("This {0} is Not recommended year : ", year);
            
            }
        





        }
    }
}
