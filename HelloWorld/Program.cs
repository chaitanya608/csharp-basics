using System;

namespace CSharpFundamentals;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter the speed limit (km/hr): ");
        var limit = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter the recorded speed (km/hr): ");
        var speed = Convert.ToInt32(Console.ReadLine());

        int demerits = 0;

        if (speed > limit)
        {
            demerits = (int)((speed - limit) / 5);
            if (demerits < 12)
            {
                Console.WriteLine($"Overspeeding with demerit points: {demerits}");
            }
            else
            {
                Console.WriteLine($"License suspended. Demerit points: {demerits}");
            }
        }
        else
        {
            Console.WriteLine("Ok");
        }
    }
}