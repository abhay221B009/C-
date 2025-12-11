/*using System;

namespace App1
{
    class Inheritance
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Bike bike = new Bike();
            Boat boat = new Boat();

            Console.WriteLine($"Car speed: {car.speed}");
            Console.WriteLine($"Car wheels: {car.wheels}");
            car.go();
            Console.WriteLine();

            Console.WriteLine($"Bike speed: {bike.speed}");
            Console.WriteLine($"Bike wheels: {bike.wheels}");
            bike.go();
            Console.WriteLine();

            Console.WriteLine($"Boat speed: {boat.speed}");
            Console.WriteLine($"Boat wheels: {boat.wheels}");
            boat.go();
            Console.WriteLine();
        }
    }

    class Vehicle
    {
        public int speed = 20;

        public void go()
        {
            Console.WriteLine("This vehicle is moving");
        }
    }

    class Car : Vehicle
    {
        public int wheels = 4;
    }

    class Bike : Vehicle
    {
        public int wheels = 2;
    }

    class Boat : Vehicle
    {
        public int wheels = 0;
    }
}
*/