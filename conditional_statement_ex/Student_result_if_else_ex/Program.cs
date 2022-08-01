using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_result_if_else_ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Write a C# Sharp program to read roll no, name and marks of three subjects and calculate the total, percentage and division. Go to the editor
               Test Data:
               Input the Roll Number of the student: 784
               Input the Name of the Student :James
               Input the marks of Physics, Chemistry and Computer Application: 70 80 90
               Expected Output :
               Roll No : 784
               Name of Student: James
               Marks in Physics: 70
               Marks in Chemistry: 80
               Marks in Computer Application : 90
               Total Marks = 240
               Percentage = 80.00
               Division = First */
            int total_marks;
            double per ;
            string div;

            Console.WriteLine("Input the Roll Number of the student:");
            int Roll_no = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the Name of the student:");
            string stud_Name = Console.ReadLine();
            

            Console.WriteLine("Input the marks of Physics:");
            int phy = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the marks of Chemistry:");
            int chem = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the marks of Computer Application:");
            int com_ap = Convert.ToInt32(Console.ReadLine());

            total_marks = phy + chem + com_ap;
            per = total_marks / 3.0;
           

            if (total_marks >= 240)
            {
                div = "First Division";

            }
            else if (total_marks <= 240)
            {
                div = "Second Division";

            }
            else
            {
                div = "Fail";
            
            }
            Console.WriteLine("Roll No  =" +  Roll_no);
            Console.WriteLine("Name of the Student:" + stud_Name);
            Console.WriteLine("Marks in Physics:" + phy);
            Console.WriteLine("Marks in Chemistry:" + chem);
            Console.WriteLine("Marks in Computer Application:"+com_ap); 
            Console.WriteLine("Total Marks ="+total_marks);
            Console.WriteLine("Percentage =" + per);
            Console.WriteLine("Division ="+div);


        }
    }
}
