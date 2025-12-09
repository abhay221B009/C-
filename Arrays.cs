using System;
namespace App1
{
  class Arrays
  {
    public static void Main13(string[]args)
    {
      //string[] cars = {"BMW","AUDI","FORD","TOYOTS"};
      string[] cars = new string [4];
      cars[0] = "BMW";
      cars[1] = "AUDI";
      cars[2] = "FORD";
      cars[3] = "TOYOTA";
      for(int i = 0;i < cars.Length; i++)
      {
        Console.WriteLine(cars[i]);
      }
      cars[3] = "MERCEDES";
      Console.WriteLine("updated car: "+ cars[3]);
      for(int i = 0;i < cars.Length; i++)
      {
        Console.WriteLine(cars[i]);
      }

    }
  }
}