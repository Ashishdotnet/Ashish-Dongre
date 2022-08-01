using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admission_marks_ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Write a C# Sharp program to find the eligibility of admission for a professional 
               course based on the following criteria: Go to the editor
               Marks in Maths >=65
               Marks in Phy >=55
               Marks in Chem>=50
               Total in all three subject >=180
               or
               Total in Math and Subjects >=140

               Test Data :
               Input the marks obtained in Physics :65
               Input the marks obtained in Chemistry :51
               Input the marks obtained in Mathematics :72
               Expected Output :
               The candidate is eligible for admission. */
            int total_marks;
            Console.WriteLine("Input the marks in Maths :");
            int math = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the marks in Physics :");
            int phy = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the marks in chemistry :");
            int che = Convert.ToInt32(Console.ReadLine());

            total_marks = math + phy + che;
            Console.WriteLine("Total in all three subjects :"+total_marks,math,phy,che);

            if (total_marks >= 180 | total_marks >= 140) // using Logical OR operator here to check condition
            {
                Console.WriteLine("The candidate is Eligible for admission :");

            }
            else {

                Console.WriteLine("Not Eligible !");
            
            }
        }
    }
}
