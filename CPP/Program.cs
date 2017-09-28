using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter a number.");
            //int firstNumber = int.Parse(Console.ReadLine());

            //Console.WriteLine("Please enter another number.");
            //int secondNumber = int.Parse(Console.ReadLine());

            //if (firstNumber == secondNumber)
            //{
            //    Console.WriteLine("These numbers are equal.");
            //}
            //else
            //{
            //    Console.WriteLine("These numbers are not equal.");
            //}

            //Console.WriteLine("Please enter a number.");
            //int thatNumber = int.Parse(Console.ReadLine());

            //if (thatNumber / 2 == 0)
            //{
            //    Console.WriteLine("This is an even number.");
            //}
            //else
            //{
            //    Console.WriteLine("This is an odd number.");
            //}

            //Console.WriteLine("Please enter a number.");
            //int yourNumber = int.Parse(Console.ReadLine());

            //if (yourNumber > 0)
            //{
            //    Console.WriteLine("That is a positive number.");
            //}
            //else if (yourNumber < 0)
            //{
            //    Console.WriteLine("That is a negative number.");
            //}
            //else if (yourNumber == 0)
            //{
            //    Console.WriteLine("That number is neither positive nor negative.");
            //}
            //else
            //{
            //    Console.WriteLine("That is an invalid entry.");
            //}


            //Console.WriteLine("Please enter a letter.");
            string userLetter = Console.ReadLine().ToLower();
            //char yourLetter = char.Parse(userLetter);

            //switch(yourLetter)
            //{
            //    case 'a':
            //        Console.WriteLine("This is a vowel.");
            //        break;
            //    case 'e':
            //        Console.WriteLine("This is a vowel.");
            //        break;
            //    case 'i':
            //        Console.WriteLine("This is a vowel.");
            //        break;
            //    case 'o':
            //        Console.WriteLine("This is a vowel.");
            //        break;
            //    case 'u':
            //        Console.WriteLine("This is a vowel.");
            //        break;
            //    default:
            //        Console.WriteLine("This is a consonant.");
            //        break;
            //}

            Console.WriteLine("Please enter a number.");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter another number.");
            int secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber > secondNumber)
            {
                Console.WriteLine(firstNumber + " is the greater number.");
            }
            else if (secondNumber > firstNumber)
            {
                Console.WriteLine(secondNumber + " is the greater number.");
            }
            else
            {
                Console.WriteLine("These numbers are equal.");
            }

        }
    }
}
