using System;
namespace ControlFlow.ForEachNamespace;

class ForEachLecture
{
  public static void ForEachDemo()
  {
    // var name = "Chaitanya Vuddanti";

    // using for loop
    // for (var i = 0; i < name.Length; i++)
    // {
    //   Console.WriteLine(name[i]);
    // }

    // using foreach loop
    // foreach (var character in name)
    // {
    //   Console.WriteLine(character);
    // }

    var numbers = new int[] { 1, 2, 3, 4 };
    foreach (var num in numbers)
    {
      Console.WriteLine(num);
    }
  }
}