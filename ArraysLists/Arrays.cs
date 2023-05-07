using System;

namespace ArraysLists;

public class Arrays
{
	public static void Examples()
	{
        var numbers = new[]
        {
            3, 8, 4, 9, 6, 10, 23, 18
        };

        // Length
        Console.WriteLine("array length: " + numbers.Length);

        // IndexOf
        var index = Array.IndexOf(numbers, 9);
        Console.WriteLine("Index of 9 is: " + index);

        // Clear
        Array.Clear(numbers, 0, 2);
        Console.WriteLine("Effect of clear()");
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }

        // Copy
        var numbersCopy = new int[5];
        Array.Copy(numbers, numbersCopy, 5);

        Console.WriteLine("Copied array");
        foreach (var number in numbersCopy)
        {
            Console.WriteLine(number);
        }

        // Sort
        Array.Sort(numbers);

        Console.WriteLine("Sorted array");
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }

        // Reverse
        Array.Reverse(numbers);

        Console.WriteLine("Reversed array");
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
