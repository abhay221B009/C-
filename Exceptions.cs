using System;
namespace App1
{
  class Exceptions
  {
    static void Main(string[]args)
    {

      //Exception handling:
      /*errors that occur during program execution can be handled using try and catch blocks.*/
      //try : try some code that is cosidered dangerous
      //catch : catches and handles exceptions when they occur
      //finally : always executes regardless of exception is caught or not 

      double x , y ;  
      double result;

      try
      {
        Console.WriteLine("Enter number 1: ");
        x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter number 2: ");
        y = Convert.ToInt32(Console.ReadLine());

        result = x / y;

        Console.WriteLine("result: "+result);
      }

      catch(FormatException e)
      {
        Console.WriteLine("Enter only numbers please! ");
      }
      catch(DivideByZeroException)
      {
        Console.WriteLine("Can't divide a number by 0 !");
      }
      catch(Exception e)
      {
        Console.WriteLine("something went wrong.  "+e.Message);        
      }


      
    }
  }
}