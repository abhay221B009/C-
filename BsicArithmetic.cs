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
    }
    
  }
}