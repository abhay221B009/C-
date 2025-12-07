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
      
      int c = 123;
      double e = Convert.ToDouble(c)+0.1;
      Console.WriteLine("Integer value: " + c);
      Console.WriteLine("Double value: " + e);

      //integer to string

    int f = 321;
    string g = Convert.ToString(f);
    Console.WriteLine(f.GetType());
   
    Console.WriteLine("Integer value: " + f);

     Console.WriteLine(g.GetType()); 
    Console.WriteLine("String value: " + g);


    //string to char

    string h = "hello";
    char j = Convert.ToChar(h[0]);//if i want to convert any one char from the string to be converted but if i want to convert the whole string then i have to convert it into a char array.
    char[] arr = h.ToCharArray();
    Console.WriteLine("String value: " + h);  
    Console.WriteLine("Character value: " + j);
    Console.WriteLine("below is the char array: ");
    foreach(char k in arr)
      {
        Console.WriteLine(k);
      }

    



    //==================================================
    //ACCEPTING USER INPUT
    Console.WriteLine("Enter your name: ");
    string youname = Console.ReadLine();//main line
     

    Console.WriteLine("Enter your age: ");
    int yourage = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("hello " + youname + "!");
    Console.WriteLine("You are " + yourage + " years old!");
    }

    }
} 