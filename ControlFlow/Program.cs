using System;
using ControlFlow.ForEachNamespace;
using ControlFlow.RandomNamespace;
using ControlFlow.WhileNamespace;
namespace ControlFlow;

class Program
{
  static void Main(string[] args)
  {
    // for (var i = 1; i <= 10; i++)
    // {
    //   if (i % 2 == 0)
    //   {
    //     Console.WriteLine(i);
    //   }
    // }

    // for (var i = 10; i >= 1; i--)
    // {
    //   if (i % 2 == 0)
    //   {
    //     Console.WriteLine(i);
    //   }
    // }

    // ForEachLecture.ForEachDemo();

    // WhileLecture.WhileDemo();

    // var result = ControlFlowExercises.Factorial();
    // var result = ControlFlowExercises.GuessNumber(4);
    var result = ControlFlowExercises.FindMax();
    Console.WriteLine(result);
  }
}