using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade_allot_Ex
{
    internal class Program
    {
        static void Main(string[] args)
        {/*Write a program in C# Sharp to accept a grade and declare the equivalent description 

           Grade	Description
            E	    Excellent
            V	    Very Good
            G	    Good
            A	    Average
            F	    Fail
           Test Data :
           Input the grade :a
           Expected Output :
           You have chosen : Average */

            char ch;
            Console.WriteLine("Enter The Grade In Capital Alphabate to check Grade:");
            ch = Convert.ToChar(Console.ReadLine().ToUpper());
            switch (ch)
            {
                case 'E':
                    Console.WriteLine("You have Chosen : Exellent");
                    break;

                case 'V':
                    Console.WriteLine("You have Chosen : Very Good");
                    break ;

                case 'G':
                    Console.WriteLine ("You have Chosen : Good");
                    break;

                case 'A':
                    Console.WriteLine("You have Chosen : Average");
                    break;

                case 'F':
                    Console.WriteLine("You have Chosen : Fail");
                    break;

                default:
                    Console.WriteLine("sorry your not chosen selected grades,Please choose selected grade like E,V,G,A,F");
                    break;
            }
            Console.ReadKey();

        }
    }
}
