using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XY_Co_ordinates_check
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Write a C# Sharp program to accept a coordinate point in an XY coordinate system and 
               determine in which quadrant the coordinate point lies. Go to the editor
               Test Data:
               Input the value for X coordinate :7
               Input the value for Y coordinate :9
               Expected Output :
               The coordinate point(7, 9) lies in the First quadrant. */

            Console.WriteLine("Input the value for X co-ordinate :");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the value for Y co-ordinate :");
            int y = Convert.ToInt32(Console.ReadLine());

            if (x >= 0 && y >= 0)
            {
                Console.WriteLine("The co-ordinates point ({0},{1}) lies in the First Quadrant.",x,y);
                // this code for first Quadrant bcz first quadrant values lies in positive                                                                                         
            }
            else if (x <= 0 && y >= 0)
            {
                Console.WriteLine("The co-ordinates point ({0},{1}) lies in the Second Quadrant.",x,y);
            }

            else if (x <= 0 && y <= 0)
            {
                Console.WriteLine("The Co-Ordinates point ({0},{1}) lies in the Third Quadrant.",x,y);

            }
            else 
            {
                Console.WriteLine("The Co-Ordinates point ({0},{1}) lies in the Fourth Quadrant.",x,y);
            
            }
        


        }
    }
}
