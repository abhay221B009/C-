using System;
namespace App1
{
  class ObjectAsArguments
  {
    static void Main12(string[] args)
    {
      Car car1 = new Car("Mustang","Red"); 
      System.Console.WriteLine($" color and model of your car us {car1.color} and {car1.model}");  



      System.Console.WriteLine("after changing the color of the car by using object as a argument");

      ChangeColor(car1,"silver");
      System.Console.WriteLine($"{car1.color} , {car1.model}");   
    }
    //PASSING OBJECT AS ARGUMENT
    public static void ChangeColor(Car car, string color)/*here car is Car type(like string, int etc).*/
    {
      car.color = color;
    }
  }
  class Car
  {
    public string model;
    public string color;

    public Car(string model, string color)
    {
      this.model = model;
      this.color = color;
    }
  }
}