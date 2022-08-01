using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric_shape
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Write a program in C# Sharp which is a Menu-Driven Program to compute the area 
            of the various geometrical shape. Go to the editor
            Test Data :
            Input your choice : 1
            Input radius of the circle : 5

            Expected Output :
            The area is : 78.500000 */
            int shapes, l, h, b, w, r;
            double A=0;
            Console.WriteLine("\n====[Menu Driven program to compute the Area of the various geometrical shape]====\n");
            Console.Write("Enter 1 to calculate Area Of Circle:\n");
            Console.Write("Enter 2 to calculate Area of Rectangle:\n");
            Console.Write("Enter 3 to calculate Area Of Triangle:\n");
            shapes = Convert.ToInt32(Console.ReadLine());
            switch (shapes)
            {
                case 1:
                    Console.Write("Enter the Radius of the Circle:\n");
                    r= Convert.ToInt32(Console.ReadLine());
                    A = 3.14 * r * r;
                    Console.WriteLine("Area of the Circle is : "+ A);
                    break;
                case 2:
                    Console.Write("Enter the length of the rectangle:\n");
                    l= Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the Width Of The Rectangle:\n");
                    w= Convert.ToInt32(Console.ReadLine());
                    A=l * w;
                    Console.WriteLine("Area Of the Rectangle is : "+A);
                    break;
                case 3:
                    Console.Write("Enter the base of the Triangle:\n");
                    b= Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the height of the Triangle:\n");
                    h= Convert.ToInt32(Console.ReadLine());
                    A=0.5 * b * h;
                    Console.WriteLine("Area Of the Triangle is : "+ A);
                    break;
                default:
                    Console.WriteLine("Please Enter 1,2,3 options to choose shape for calculate Area:");
                    break;


                    
            }
            

        }
    }
}
