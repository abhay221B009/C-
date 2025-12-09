using System;
namespace App1
{
  class loops
  {
    public static void Main(string[] args)
    {
      string name = "";


      //WHILE LOOP
      while(name=="")
      {
        Console.WriteLine("Enter your name: ");
        name  = Console.ReadLine();
      }
      Console.WriteLine("Hello, "+name);


      //FOR LOOP
       for(int i = 0; i < 10; i++)
      {
        Console.WriteLine("Hello, "+name);
      }
    }
  }
}