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
