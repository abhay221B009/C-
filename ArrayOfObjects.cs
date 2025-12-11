// using System;
// namespace App1
// {
//   class ArrayOfObjects
//   {
//     static void Main(string[] args)
//     {

//       // Car[] garage = new Car[3];
//       // Car v1 = new Car("Mustang");
//       // Car v2 = new Car("Corvette");
//       // Car v3 = new Car("Lambo");

      


//       // garage[0]=v1;
//       // garage[1]=v2;
//       // garage[2]=v3;

//       // Console.WriteLine(garage[0].model);
//       // Console.WriteLine(garage[1].model);
//       // Console.WriteLine(garage[2].model);

// //THE ABOVE THING CAN BE DONE LIKE THIS ALSO

//       Car[] garage = new Car[]{new Car("Mustang"),new Car("Corvette"),new Car("Lambo")};
//       foreach(Car car in garage)
//       {
//         Console.WriteLine(car.model);
//       }
      
//     }
//   }
//   class Car
//   {
//     public string model;
    

//     public Car(string model)//constructor
//     {
//       this.model =  model;
//     }
//   }
// }