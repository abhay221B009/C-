using System;
namespace App1
{
  class Methods
  {
    public static void Main(string[]args)
    {
      string name = "alice";
      int age = 23;
      singHappyBirthday(name,age);
      singHappyBirthday(name,age);
      singHappyBirthday(name,age);
    }

    static void singHappyBirthday(string name,int age)
    {
      Console.WriteLine("Happy Birthday to you!");
      Console.WriteLine("Happy Birthday to you  "+name);
      Console.WriteLine("You are "+age+" years old");
    }
  }
}