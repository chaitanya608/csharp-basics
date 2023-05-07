using System;

namespace ArraysLists;

public class ArraysListsExercises
{
    /*
     * Problem 1
     */
    public static void Facebook()
    {
        var names = new List<string>();

        while (true)
        {
            Console.WriteLine("Enter a name: ");
            var input = Console.ReadLine();
            if (input != "")
            {
                names.Add(input);
            } else
            {
                break;
            }
        }

        if (names.Count == 0)
        {
            Console.WriteLine("No one likes your rant, you pathetic moron!");
        } else if (names.Count == 1)
        {
            Console.WriteLine($"{names[0]} likes your post.");
        } else if (names.Count == 2)
        {
            Console.WriteLine($"{names[0]} and {names[1]} likes your post");
        } else
        {
            Console.WriteLine($"{names[0]}, {names[1]} and {names.Count - 2} others like your post.");
        }
    }

    /*
     * Problem 2
     */
    public static void ReverseName()
    {
        Console.WriteLine("Please enter a name: ");
        var name = Console.ReadLine();
        var reversedArr = new char[name.Length];

        if (name.Length == 0)
        {
            return;
        }

        for (var i = name.Length; i > 0; i--)
        {
            reversedArr[name.Length - i] = name[i - 1];
        }

        Console.WriteLine(String.Join("", reversedArr));
    }

    /*
     * Problem 3
     */
    public static void SortUniqueNumbers()
    {
        var INPUT_COUNT = 5;
        Console.WriteLine($"Please enter {INPUT_COUNT} numbers.");
        var inputList = new List<int>();

        while (inputList.Count < INPUT_COUNT)
        {
            var input = Convert.ToInt32(Console.ReadLine());

            if (inputList.Contains(input))
            {
                Console.WriteLine("Please enter a unique number.");
                continue;
            }

            inputList.Add(input);
        }

        inputList.Sort();

        Console.WriteLine("\nSorted numbers:");
        foreach (var input in inputList)
        {
            Console.WriteLine(input);
        }
    }

    /*
     * Problem 4
     */
    public static void UniqueNumbers()
    {
        Console.WriteLine("Please enter a number to add to list or \"Quit\" to exit.");

        var inputList = new List<int>();
        while(true)
        {
            var input = Console.ReadLine();

            if (input?.ToLower() == "quit")
            {
                break;
            }

            if (!inputList.Contains(Convert.ToInt32(input)))
            {
                inputList.Add(Convert.ToInt32(input));
            }
        }

        Console.WriteLine("List of numbers:");
        foreach (var num in inputList)
        {
            Console.WriteLine(num);
        }
    }

    /*
     * Problem 5
     */
    public static void ParseStringToNumbers()
    {
        Console.WriteLine("Please enter a comma separated list of numbers");
        var input = Console.ReadLine();

        if (String.IsNullOrEmpty(input))
        {
            Console.WriteLine("Invlid List. Please retry.");
            ArraysListsExercises.ParseStringToNumbers();
            return;
        }

        var inputs = input?.Split(',');
        if (inputs?.Length < 5)
        {
            Console.WriteLine("Invlid List. Please retry.");
            ArraysListsExercises.ParseStringToNumbers();
            return;
        }

        var numbers = new List<int>();
        foreach (var numString in inputs)
        {
            numbers.Add(Convert.ToInt32(numString.Trim()));
        }

        numbers.Sort();
        for (var i = 0; i < 3; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}
