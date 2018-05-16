using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a word or phrase:");

            string input = Console.ReadLine();

            Console.WriteLine($"You entered {input}");

            string charString = input.Replace(" ", string.Empty).ToLower().ToString();

            var newCharString = "";

            foreach (char c in charString)
            {
                if (!char.IsPunctuation(c))
                {
                    newCharString += c;
                }
            }


            string reverseCharString = new string(newCharString.Reverse().ToArray());

            Console.WriteLine($"The word or phrase '{input}' written backwards is {reverseCharString}.");

            if(newCharString == reverseCharString)
            {
                Console.WriteLine($"The word or phrase '{input}' IS a palindrome!");
            }
            else
            {
                Console.WriteLine($"The word or phrase '{input}' IS NOT a palindrome. ");
            }




            Console.ReadKey();
        }
    }
    
}
        