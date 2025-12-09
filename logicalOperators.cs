using System;
namespace App1
{
  class logicalOperators
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Whats the temperature (C)outside?");

      double temperature = Convert.ToDouble(Console.ReadLine());
      if(temperature >=10 && temperature<= 25)
      {
        Console.WriteLine("The weather is good today.");
      }
      else if(temperature <10 || temperature > 25)
      {
        Console.WriteLine("The weather is bad today.");
      }
      else
      {
        Console.WriteLine("Temperature is extreme hot today.");
      }
    }
  }
}