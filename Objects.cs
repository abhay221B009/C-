using System;
namespace App1
{
  class objects
  {
    static void Main(string[]args)
    {
      /*Objects: An instance of a class
                 A class can be used as a blurprint to create objects(OOP).
                 Objects can have fields & methods(charactersticks & actions)*/
      


      //Constructor:



      Human human1 = new Human("abhay",23);
      Human human2 = new Human("arsh",21);

      //BELOW HERE IS NORMAL METHOD , WITHOUT USING CONSTRUCTOR

      // human2.name = "abhay";
      // human2.age = 23;

      // human1.name = "Brick";
      // human1.age = 65;
      Console.WriteLine(human1.name+"");
      Console.WriteLine(human1.age+"");

      Console.WriteLine(human2.name+"");
      Console.WriteLine(human2.age+"");

      human1.Eat();
      human1.Sleep();
      human2.Eat();
      human2.Sleep();

    }
  }

  class Human
  {
    public string name ;
    public int age;

    //CONSTRUCTOR
    public Human(string name, int age)
    {
      this.name = name;
      this.age = age;
    }

    public void Eat()
    {
      Console.WriteLine(name+" eating");
    }
    public void Sleep()
    {
      Console.WriteLine(name+ " sleeping");
    }
  }
}