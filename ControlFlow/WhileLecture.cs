using System;
namespace ControlFlow.WhileNamespace;

class WhileLecture
{
  public static void WhileDemo()
  {
    // var i = 0;
    // while (i <= 10)
    // {
    //   if (i % 2 == 0)
    //   {
    //     Console.WriteLine(i);
    //   }

    //   i++;
    // }

    while (true)
    {
      Console.Write("Type your name here: ");
      var name = Console.ReadLine();

      if (!String.IsNullOrWhiteSpace(name))
      {
        Console.WriteLine("@Echo: " + name);
        continue;
      }

      break;
    }
  }
}