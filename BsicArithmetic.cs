using System;

namespace App1
{
class BsicArithmetic
  {
    static void Main(string[] args)
    {
      int friends = 10;
      Console.WriteLine(friends);
      //friends + 2
      friends+=1;
      Console.WriteLine("updated friends"); 
      Console.WriteLine(friends); //3
      Console.WriteLine("subtracr one friend friends");
      friends--;
      Console.WriteLine(friends); //2
      friends= friends * 2;
      Console.WriteLine("friends time 2 = "+friends); //4

      friends = friends / 2;
      Console.WriteLine("friends divided by 2= "+ friends); //2

      int remainder = friends % 3;
      Console.WriteLine("Remainder when friends is divided into 3 = "+ remainder);



      //LEARING BASIC MATH CLASS;

      double x = 3;
      double a = Math.Pow(x, 2); //x squared
      Console.WriteLine("x squared = "+ a);

      Console.WriteLine("finding square root ");
      double b = Math.Sqrt(a);
      Console.WriteLine(b);

      Console.WriteLine("let z = -3");
      double z = -3;
      double y = Math.Abs(z);
      Console.WriteLine("absolute value of z is: "+ y);


      Console.WriteLine("let x be 3.14");
      double d = 3.14;
      double c = Math.Round(d);
      double f = Math.Ceiling(d);
      double g = Math.Floor(d);
      Console.WriteLine("x rounded is: "+ c);
      Console.WriteLine("x ceiling (rounded up) is: "+f );
      Console.WriteLine("x floor (rounded down) is: "+ g );




      //finding max and min

      double m = Math.Max(d, f);
      Console.WriteLine("maximum between d and f is: "+ m);
      

      double k = Math.Min(d,g);
      Console.WriteLine("minimum between d and g is: "+k);






    }
    
  }
}