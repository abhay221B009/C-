using System;
namespace App1
{
  class HypotenusCalculator
  {
    static void Main3(string[] args)
    {
       Console.WriteLine("Enter side A: ");
       double A = Convert.ToDouble(Console.ReadLine());


       Console.WriteLine("Enter side B: ");
       double B = Convert.ToDouble(Console.ReadLine());


       double C = Math.Sqrt(Math.Pow(A,2)+Math.Pow(B,2));
       double roundeC = Math.Round(C,3);
       Console.WriteLine("The hypotenus C is: "+ roundeC);
       
    }
  }
}