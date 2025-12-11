using System;
namespace App1
{
  class Inheritance
  {
    static void Main(string[]args)
    {
      //inheritance = 1 or more child classes receiving fields, methods,  etc  from a common parent.
      Car car = new Car();
      Bike bike  = new Bike();
      Boat boat = new Boat();

      Console.WriteLine($"speed of the car is : {car.speed}");
      Console.WriteLine($"number of wheels {car.wheels}");
      car.go();
      Console.WriteLine(" ");


      Console.WriteLine($"speed of the bike is: {bike.speed}");
      Console.WriteLine($"number of wheels {bike.wheels}");
      bike.go();
      Console.WriteLine(" ");

      Console.WriteLine($"speed of the boat is: {boat.speed}");
      Console.WriteLine($"number of wheels {boat.wheels}");
      boat.go();
      Console.WriteLine(" ");
      


    }
  }
  class vehicle
  {
    public int speed = 20;
    public void go()
    {
      Console.WriteLine("this vehicle is moving");
    }
  }

  class Car: vehicle
  {
    public int wheels = 4;
  }

  class Bike:vehicle
  {
     public int wheels = 2;
  }
  class Boat:vehicle
  {
    public int wheels = 0;
  }
}