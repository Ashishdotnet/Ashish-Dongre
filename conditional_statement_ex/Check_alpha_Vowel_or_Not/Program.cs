using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_alpha_Vowel_or_Not
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a C# Sharp program to check whether an alphabet is a vowel or consonant. Go to the editor
             Test Data : k
             Expected Output :The alphabet is a consonant. */
            char ch;
            Console.WriteLine("Please Enter the Alphabet A-Z or a-z ");
            ch = Convert.ToChar(Console.ReadLine().ToLower());

            int i = ch;

            if (i >= 48 && i <= 57)/* here put logic of Total Number of an alphabets are counting are 
                                      52 so i create a logic for comparing an alphabets here with counting
                                      and if user put value out of condition then code will run inside if block. */
            {
                Console.WriteLine("You Entered a Number,please enter an alphabet");

            }
            else
            {
                switch (ch)
                {
                    case 'a':
                        Console.WriteLine("The Alphabet is Vowel.");
                        break;

                    case 'i':
                        Console.WriteLine("The Alphabet is Vowel.");
                        break;

                    case 'o':
                        Console.WriteLine("The Alphabet is Vowel.");
                        break;

                    case 'u':
                        Console.WriteLine("The Alphabet is Vowel.");
                        break;

                    case 'e':
                        Console.WriteLine("The Alphabet is Vowel.");
                        break;

                    default:
                        Console.WriteLine("The Alphbet is Not Vowel.");
                        break;

                        
                }
                
            }
            Console.ReadKey();




        }
    }
}
