// See https://aka.ms/new-console-template for more information

using System;
namespace App1
{
    class Program
    {
        static void Main(string[] args)
    { 
      Console.Write("\nHey!");
      Console.WriteLine("Hello, World!");

      //THIS IS A TEST COMMENT

      /*THIS
      IS 
      A 
      MULTI-LINE
      COMMENT*/


      Console.WriteLine("\tAbhay");

      // Console.ReadKey(); this stops the console from closing immediately and here it stops next lines of code to be executed until a key is pressed




      //LEARING VARIABLES 
      /*Takes two steps 
      1. Declaration
      2. Initialization
      */


      int x; //Declaration
      x = 5; //Initialization

      int y = 10; //Declaration + Initialization

      int z= x+y;
      Console.WriteLine(x);
      Console.WriteLine(y);
      Console.WriteLine(z);


      int age = 21;
      Console.WriteLine("my age is: " + age); 

      double height = 168.5;
      Console.WriteLine("my height is : "+height);

      bool alive = true;
      Console.WriteLine("Am I alive? " + alive);
      
      char symbol = '@';
      Console.WriteLine("Symbol is: " + symbol);

      string name = "Abhay";
      Console.WriteLine("My name is: " + name);

      string username = symbol+name+age;
      Console.WriteLine(username);


      //LERNING CONSTANTS
      const double pi = 3.14; 
      Console.WriteLine("Value of pi is: " + pi);



      //TYPE CASTING /CONVERSION
      //double to int
      double d = 9.78;
      int  i = Convert.ToInt32(d);

/* .Convert.ToInt32(d) — ROUNDS
 int i = Convert.ToInt32(d);

// ✔ What it does:

// Rounds to the nearest integer

// Uses banker’s rounding (0.5 goes to the nearest even number)

 Safer when you want math-correct behavior
*/
      // int i = (int)d; //Manual casting: double to int
   
/*   Manual Casting (int)d — Truncates
int i = (int)d;

✔ What it does:

Simply drops the decimal part (truncation)

No rounding

Very fast, but less safe
*/
      Console.WriteLine("Double value: " + d);
      Console.WriteLine("Integer value: " + i); 
      Console.WriteLine(d.GetType());     
      Console.WriteLine(i.GetType());
    }
    }
} 