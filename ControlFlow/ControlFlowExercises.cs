namespace ControlFlow;

public class ControlFlowExercises
{
    /*
     * Calculate factorial of the number entered by user.
     */
    public static int? Factorial()
    {
        int? factorial = 1;
        
        Console.WriteLine("Please enter a number: ");
        var input = Console.ReadLine();
        var parsedInput = 0;

        if (input == null)
        {
            ControlFlowExercises.Factorial();
        }
        else
        {
            parsedInput = int.Parse(input);
            for (var i = 1; i <= parsedInput; i++)
            {
                factorial = factorial * i;
            }
        }

        return factorial;
    }
    
    /*
     * Guess the random number
     */
    public static string GuessNumber(int tries)
    {
        var random = new Random();
        var randomNumber = random.Next(1, 10);

        for (var i = 0; i < tries; i++)
        {
            Console.WriteLine("Please enter your guess between 1 and 10.");
            var input = Console.ReadLine();
            var parsedInput = int.Parse(input);

            if (parsedInput == randomNumber)
            {
                return "You won!";
            }
        }

        return "You lost";
    }
    
    /*
     * Find maximum of comma separated numbers.
     */
    public static int FindMax()
    {
        var result = 0;

        Console.WriteLine("Please enter comma separated numbers: ");
        var input = Console.ReadLine();
        var numbers = input?.Split(",");

        if (numbers != null)
            foreach (var number in numbers)
            {
                var parsedNumber = int.Parse(number);
                if (result < parsedNumber)
                {
                    result = parsedNumber;
                }
            }

        return result;
    }
}