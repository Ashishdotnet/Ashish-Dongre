using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace check_height_person_ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Write a C# Sharp program to accept the height of a person in centimeter and categorize the
               person according to their height. Go to the editor
               Test Data : 135
               Expected Output :
               The person is Dwarf. */

            Console.WriteLine("Please Enter Your Height in Centimeter :"); //using Built-in Function also initialize variale with built-in function
            int height = Convert.ToInt32(Console.ReadLine());

            if (height >= 147)
            {
                Console.WriteLine(" The Person is Tall !");


            }
            else {

                Console.WriteLine("The person is Dwarf !");
            
            }

                                                                          

             


        }
    }
}
