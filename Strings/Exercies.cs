using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    public class Exercies
    {
        public static void Problem1()
        {
            /*
             * Write a program and ask the user to enter a few numbers separated by a hyphen.
             * Work out if the numbers are consecutive.
             * For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive";
             * otherwise, display "Not Consecutive".
             */
            Console.WriteLine("Please enter hyphen separated numbers:");
            var input = Console.ReadLine();

            if (input == null)
            {
                throw new ArgumentNullException("Please enter some input");
            }

            var numbers = ParseInput(input);
            var areNumbersConsecutive = true;

            for (var i = 0; i < numbers.Length - 1; i++)
            {
                if (Math.Abs(numbers[i] - numbers[i + 1]) != 1)
                {
                    areNumbersConsecutive = false;
                }
            }

            Console.WriteLine(areNumbersConsecutive ? "Consecutive" : "Not Consecutive");
        }

        public static void Problem2()
        {
            /*
             * Write a program and ask the user to enter a few numbers separated by a hyphen.
             * If the user simply presses Enter, without supplying an input, exit immediately;
             * otherwise, check to see if there are duplicates.
             * If so, display "Duplicate" on the console.
             */
            Console.WriteLine("Please enter hyphen separated numbers:");
            var input = Console.ReadLine();

            if (input == null)
            {
                return;
            }

            var numbers = ParseInput(input);
            var duplicatesPresent = false;

            for (var i = 0; i < numbers.Length; i++)
            {
                for (var j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        duplicatesPresent = true;
                    }
                }
            }

            Console.WriteLine(duplicatesPresent ? "Duplicate" : "No Duplicates");
        }

        public static void Problem3()
        {
            /*
             *  Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00).
             *  A valid time should be between 00:00 and 23:59.
             *  If the time is valid, display "Ok";
             *  otherwise, display "Invalid Time".
             *  If the user doesn't provide any values, consider it as invalid time.
             */
            Console.WriteLine("Please enter time in 24-hour format");
            var input = Console.ReadLine();

            if (input == null)
            {
                Console.WriteLine("Invalid time.");
            }

            var inputDate = new DateTime();
            if (DateTime.TryParse(input, out inputDate))
            {
                Console.WriteLine("Ok");
                Console.WriteLine($"Entered time is: {inputDate.ToString("t")}");
            } else
            {
                Console.WriteLine("Invalid time");
            }
        }

        public static void Problem4()
        {
            /*
             *  Write a program and ask the user to enter a few words separated by a space.
             *  Use the words to create a variable name with PascalCase.
             *  For example, if the user types: "number of students", display "NumberOfStudents".
             *  Make sure that the program is not dependent on the input.
             *  So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".
             */
            Console.WriteLine("Please enter space separated words:");
            var input = Console.ReadLine();
            
            if (input == null)
            {
                Console.WriteLine("Invalid input");
                return;
            }

            var words = input.Split(" ");
            for (var i = 0; i < words.Length; i++)
            {
                var word = words[i].Trim().ToLower();
                if (i == 0)
                {
                    Console.WriteLine("first word");
                    string? first = word[0].ToString();
                    words[i] = first + word.Substring(1);
                } else
                {
                    words[i] = word;
                }

            }

            var result = string.Empty;
            foreach(var w in words)
            {
                result += w + " ";
            }

            Console.WriteLine(result);
        }

        public static void Problem5()
        {
            /*
             * Write a program and ask the user to enter an English word. 
             * Count the number of vowels (a, e, o, u, i) in the word. 
             * So, if the user enters "inadequate", the program should display 6 on the console.
             */
            var VOWELS = new List<char> { 'a', 'e', 'i', 'o', 'u' };
            Console.WriteLine("Please enter a word:");
            var input = Console.ReadLine();

            if (input == null)
            {
                Console.WriteLine("Invalid input");
                return;
            }

            var vowelCount = 0;
            var chars = input.ToCharArray();

            foreach (var c in chars)
            {
                foreach (var vowel in VOWELS)
                {
                    if (vowel == c)
                    {
                        vowelCount++;
                    }
                }
            }

            Console.WriteLine(vowelCount);
        }

        private static int[] ParseInput(string input)
        {
            var result = new List<int>();
            var numStrings = input.Split("-");

            foreach (var numStr in numStrings)
            {
                result.Add(int.Parse(numStr.Trim()));
            }

            return result.ToArray();
        }
    }
}
