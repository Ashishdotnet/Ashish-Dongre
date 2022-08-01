using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isocles_triangle_ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a C# Sharp program to check whether a triangle is  
             Equilateral, Isosceles or Scalene. Go to the editor
             Test Data : 50 50 60
             Expected Output :This is an isosceles triangle. */
            int side1, side2, side3;

            Console.WriteLine("Enter the Side1 of triangle:");
            side1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Side2 of triangle:");
            side2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Side3 of triangle:");
            side3 = Convert.ToInt32(Console.ReadLine());
            

            if (side1 == side2 && side1 == side3)
            {
                Console.WriteLine("This is an Equilateral Triangle.");
            }
            else if (side1 != side2 && side1 != side3)
            {
                Console.WriteLine("This is a Scalen Triangle.");
            }
            else 
            {
                Console.WriteLine("This is an isosceles Triangle. ");
            }
            


        }
    }
}
