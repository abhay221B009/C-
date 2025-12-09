using System;
namespace App1
{
  class MethodOverriding
  {
    public static void Main15(string[]args)
    {
      double total =  Multiply(4,3);
      Console.WriteLine("The multiplication of x  and y is : "+total);


      double total2 =  Multiply(4,3,4);
      Console.WriteLine("The multiplication of a,b and c is : "+total2);
      
    }
    static double Multiply(double x, double y)
    {
      return x*y;
    }

    static double Multiply(double a, double b, double c)
    {
      return a*b*c;
    }
  }

  
}