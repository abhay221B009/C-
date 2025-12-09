using System;
namespace App1
{
  class StringInterpolation
  {
    static void Main(string[]args)
    {

      //string interpolation  = allows us to insert variables into a string literal precede a string literal with $, {} are placeholder

      string firstName = "abhay";
      string lastName = "chauhan";
      int age = 23;

      // Console.WriteLine("Hello "+ firstName+" "+lastName+".");

      // Console.WriteLine("You are "+ age+" years old ");

      //the above method is normal method to print a string  onto a console.

      Console.WriteLine($"Hello {firstName} {lastName}.");
      Console.WriteLine($"You are {age} years old");
      Console.WriteLine($"You are {age,10} years old");//here the 10 with age means i want 10 spaces after are word.
      Console.WriteLine($"You are {age,-10} years old");


      
    }
  }
}