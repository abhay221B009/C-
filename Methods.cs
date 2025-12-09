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


      double x , y , result;
      Console.WriteLine("Enter first number to multiply: ");
      
      x= Convert.ToDouble(Console.ReadLine());

      Console.WriteLine("Enter second number to multiply: ");

      y= Convert.ToDouble(Console.ReadLine());

      result = Multiply(x,y);

      Console.WriteLine("The multiplication result is: "+ result);
    }

    static void singHappyBirthday(string name,int age)
    {
      Console.WriteLine("Happy Birthday to you!");
      Console.WriteLine("Happy Birthday to you  "+name);
      Console.WriteLine("You are "+age+" years old");
    }

    static double Multiply(double x, double y)
    {
      double z = x*y;
      return z;
    }
  }
}