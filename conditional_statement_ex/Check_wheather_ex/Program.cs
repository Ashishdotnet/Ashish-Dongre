using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_wheather_ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Write a C# Sharp program to read temperature in centigrade and display a 
               suitable message according to temperature state below : Go to the editor
               Temp < 0 then Freezing weather
               Temp 0-10 then Very Cold weather
               Temp 10-20 then Cold weather
               Temp 20-30 then Normal in Temp
               Temp 30-40 then Its Hot
               Temp >=40 then Its Very Hot
               Test Data : 42
               Expected Output : Its very hot. */
            Console.WriteLine("Enter the tempreture in centigrade:");
            int temp = Convert.ToInt32(Console.ReadLine());

            if (temp < 0)
            {
                Console.WriteLine("Its Freazing Wheather.");
            }
            else if (temp < 10)
            {
                Console.WriteLine("Its very cold wheather.");
            }
            else if (temp < 20)
            {
                Console.WriteLine("Its cold wheather.");
            }
            else if (temp < 30)
            {
                Console.WriteLine("Its Normal wheather.");
            }
            else if (temp < 40)
            {
                Console.WriteLine("Its Hot Wheather.");
            }
            else
            {
                Console.WriteLine("Its Very Hot.");
            }

        }
    }
}
