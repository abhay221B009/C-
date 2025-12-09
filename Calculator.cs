using System;
namespace App1
{
  class Calculator
  {
    public static void Main12(string[]args)
    {
      Console.WriteLine("CALCULATOR");

      string answer = "yes";
      do{

      double num1=0, num2=0, result=0;
      Console.WriteLine("Enter first number: ");
      num1= Convert.ToDouble(Console.ReadLine());
      
      Console.WriteLine("Enter an operator (+, -, *, /): ");
      char Op = Console.ReadLine()[0];

      Console.WriteLine("Enter second number: ");
      num2= Convert.ToDouble(Console.ReadLine());

      

      switch(Op)
      {
        case '+':
          result = num1 + num2;
          Console.WriteLine($"Your result: {num1}+{ num2}= {result}");
          break;
        case '-':
          result = num1 - num2;
          Console.WriteLine($"Your result: {num1}-{ num2}= {result}");
          break;
        case '*':
          result = num1 * num2;
          Console.WriteLine($"Your result: {num1}*{ num2}= {result}");
          break;
        case '/':
          if(num2==0)
          {
            Console.WriteLine("Error: Division by zero is not allowed.");
            break;
          }
          result = num1 / num2;
          Console.WriteLine($"Your result: {num1}/{ num2}= {result}");
          break;    
        default:
        Console.WriteLine("Invalid operator");
          break;
      }
      Console.WriteLine("Do you want to perform another calculation? (yes/no): ");
      answer = Console.ReadLine().ToLower();
      if(answer != "yes")
      {
        Console.WriteLine("Thanks for using the calculator!");
        break;
      }
      }while(answer == "yes");
    }
  }
}