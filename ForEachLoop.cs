using System;
namespace App1
{
  class ForEachLoop
  {
    public static void Main13(string[]args)
    {
      string[] cars = {"BMW","AUDI","FORD","TOYOTA"};
      foreach(string car in cars)
      {
        Console.WriteLine(car);
      }
    }
  }
}