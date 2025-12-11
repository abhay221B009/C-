using System;

namespace App1
{
    class AbstractDemo
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Cycle cycle = new Cycle();
            Boat boat = new Boat();

            car.go();
            cycle.go();
            boat.go();

            Console.WriteLine($"Car speed: {car.speed}, wheels: {car.wheels}");
            Console.WriteLine($"Cycle speed: {cycle.speed}, wheels: {cycle.wheels}");
            Console.WriteLine($"Boat speed: {boat.speed}, wheels: {boat.wheels}");

            // ❌ vehicle v = new vehicle(); // NOT allowed, vehicle is abstract
            vehicle v = new Car(); // ✔ allowed
        }
    }

    abstract class vehicle
    {
        public int speed = 10;

        public void go()
        {
            Console.WriteLine("This vehicle is moving");
        }
    }

    class Car : vehicle
    {
        public int wheels = 4;
        int maxSpeed = 500;
    }

    class Cycle : vehicle
    {
        public int wheels = 2;
        int maxSpeed = 20;
    }

    class Boat : vehicle
    {
        public int wheels = 0;
        int maxSpeed = 80;
    }
}
