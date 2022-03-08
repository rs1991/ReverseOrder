using System;

namespace ReverseOrder 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String text1, reverseText = "";

            Console.Write("Please enter some text: ");
            text1 = Convert.ToString(Console.ReadLine());
            for (int i = text1.Length - 1; i >= 0; i--)
            {
                reverseText = reverseText + text1[i];
                
            }
            Console.Write("Here is your text in reverse order: " + reverseText);
            Console.Read();
            if (reverseText == text1)
            {
                Console.WriteLine("Is a palindrome");
            }
            else
            {
                Console.WriteLine("Is not a palindrome");
            }

            }
 
        }
    }
