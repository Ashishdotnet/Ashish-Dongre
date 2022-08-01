using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Except_Number_show_Word
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Write a program in C# Sharp to read any digit, display in the word. Go to the editor
               Test Data : 4
               Expected Output : Four
            */
            int Num;
            Console.WriteLine("=========================================");
            Console.WriteLine();
            Console.WriteLine("===Enter Number and see their Spelling===");
            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine();
            Console.WriteLine("Enter the Number ");
            Num = Convert.ToInt32(Console.ReadLine());
            switch (Num)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                    case 2:
                    Console.WriteLine("Two");
                    break ;
                    case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                    default:
                    Console.WriteLine("please select Only Number:-1,2,3,4,5");
                    break;
            }
            Console.ReadKey();  
        }
    }
}
