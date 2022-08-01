using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Except_Number_show_Day
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Write a program in C# Sharp to read any day number in integer and 
               display day name in the word. Go to the editor
               Test Data : 4
               Expected Output : Thursday */
            int day;
            Console.WriteLine();
            Console.WriteLine("==============================================================");
            Console.WriteLine();
            Console.WriteLine("=======================Week Days==============================");
            Console.WriteLine();
            Console.WriteLine("===Enter The Number Of Day And What Day It is on that Number==");
            day = Convert.ToInt32(Console.ReadLine());

            
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break ;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Please Input Valid Numbers to show weekdays,Ex:1=Monday");
                    break;
                        

            }
            Console.ReadKey();//I put method to hold Program to Except next Key Input But Not Working

        }
        
    }
}
