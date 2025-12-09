using System;
namespace App1
{
  class Params
  {
    public static void Main(string[]args)
    {
      //Params keyword  = a method that takes a variable number of arguments .
      //The params type must be a single-dimensional array.

      double total  = CheckOut(23.4,45.6,67.8,12.3,34.5);
      Console.WriteLine("The total is: "+ total);
      
    }


    static double CheckOut(params double[]prices)
    {
      double total=  0;
      foreach(double price in prices)
      {
        total+=price;
      }
      return total;
    }
  }
}