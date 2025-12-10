using System;
namespace App1
{
  class TwoDarray
  {
    static void Main(string[] args)
    {
      string[] ford = {"mustang","f-150","explorer"};
      string[] chevy =  {"corvette","camaro","silverado"};
      string[] toyota={"corolla","camry","rav4"};


      string[,] parkinglot = {{"mustang","f-150","explorer"}, {"corvette","camaro","silverado"},{"corolla","camry","rav4"}};
    foreach (string car in parkinglot)
      {
        Console.WriteLine(car);        
      }
    parkinglot[0,2]="Fusion";


      Console.WriteLine("\nanother method to print cars in parking lot\n");
    for (int i = 0; i < parkinglot.GetLength(0); i++)
{
    for (int j = 0; j < parkinglot.GetLength(1); j++)
    {
        Console.WriteLine(parkinglot[i, j]);
    }
}

    }
  }
}