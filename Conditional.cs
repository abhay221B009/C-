using System;
namespace App1
{
  class Conditional
  {
    static void Main17(string[]args)
    {
      //conditional operator = used in conditional statement if a condition is true/false.
      //(condition)? x:y

      double temp = 42;
      string message;
      // if(temp>=15)
      // {
      //   message = "Its warm outside";
      // }
      // else
      // {
      //   message = "its cold outside";
      // }

      //all the above conditonal statement can be written within a single line.

     message =  (temp>25) ? "Its more than room temperature outside, keep your water bottle with you" : "its less then room temperature outside ,keep yourself warm." ;
      Console.WriteLine(message);

    }
  }
}