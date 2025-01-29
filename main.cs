using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("=====  TRAFFIC LIGHT SIMULATOR     =====");
    Console.ReadLine();

    Console.Write("Enter the current color of the traffic light: ");
    string userInput = Console.ReadLine();

    if (userInput.Equals("red",StringComparison.CurrentCultureIgnoreCase)){
      Console.WriteLine($"Traffic Light Color: {userInput}");
      Console.WriteLine("Vehicle Status: Stop!");
    } 
    else if (userInput.Equals("red",StringComparison.CurrentCultureIgnoreCase)){
      Console.WriteLine($"Traffic Light Color: {userInput}");
      Console.WriteLine("Vehicle Status: Go!");
    } 
    else if (userInput.Equals("yellow",StringComparison.CurrentCultureIgnoreCase)){
      Console.WriteLine($"Traffic Light Color: {userInput}");
      Console.WriteLine("Vehicle Status: Slow Down!");
    } else {
      Console.WriteLine("Invalid Traffic Light Color");
    }
  }
}