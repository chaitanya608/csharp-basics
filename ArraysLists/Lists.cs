namespace ArraysLists;

public class Lists
{
    public static void Examples()
    {
        var numbers = new List<int>() { 1, 2, 3, 4 };
        Console.WriteLine("numbers initialised by list");
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }

        numbers.Add(1);
        numbers.AddRange(new int[3] { 5, 6, 7 });
        Console.WriteLine("AddRange");
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }

        // IndexOf
        Console.WriteLine("index of 1: " + numbers.IndexOf(1));

        // LastIndexOf
        Console.WriteLine("last index of 1: " + numbers.LastIndexOf(1));

        // Count
        Console.WriteLine("count of numbers: " + numbers.Count());

        // Remove
        Console.WriteLine("Remove");
        for (var i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] == 1)
            {
                numbers.Remove(numbers[i]);
            }
        }
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }

        // Clear
        numbers.Clear();
        Console.WriteLine("After clear: " + numbers.Count());
    }
}
