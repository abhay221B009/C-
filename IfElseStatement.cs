using System;
namespace App1
{
  class IfElseStatement
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Enter your age: ");
      int age = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Enter your name: ");
      string name = Console.ReadLine();


      if(name == "")
      {
        Console.WriteLine("You did not entered name.");
      }
      else
      {
        Console.WriteLine("Hello, "+ name);
      }

      if(age>=18)
      {
        Console.WriteLine("You are eligible to apply for a driving license.");
      }
      else if (age >= 16)
      {
        Console.WriteLine("You are soon to be eligible to apply for a driving license.");
      }
      else
      {
        Console.WriteLine("You are not eligible to apply for a driving license.");
      }
    }
  }
}