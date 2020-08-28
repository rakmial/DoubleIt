using System;

class DoubleIt
{
  static void Main()
  {
    Console.WriteLine("What number should I double?");
    string inputString = Console.ReadLine();
    int yourNumber = int.Parse(inputString);
    int yourDoubledNumber = yourNumber * 2;
    string stringDouble = yourDoubledNumber.ToString();
    Console.WriteLine(stringDouble + " is double " + inputString);
  }
}