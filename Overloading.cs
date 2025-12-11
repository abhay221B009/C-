 using System;
 namespace App1
{
  class Overloading
  {
    static void Main(string[]args)
    {
      //overloading constructors: techinique to create multiple constructors with a different set of parameters name + parameters = signature
      pizza pizza1 = new pizza("stuffed crust","red-sauce","mozerella","pepperoni");
      pizza pizza2 = new pizza("flat-bread","green-chilli","amul");
      pizza pizza3 = new pizza("normal-bread","chilli flakes");
      pizza1.eat();
      pizza2.eat();
      pizza3.eat();



    }
  }
  class pizza
  {
    string bread;
    string sauce;
    string cheese;
    string toppings;

//constructor 1
    public pizza(string bread,string sauce,string cheese,string toppings)
    {
      this.bread = bread;
      this.sauce = sauce;
      this.cheese = cheese;
      this.toppings = toppings;
    }

    //construct
    public pizza(string bread,string sauce,string cheese)
    {
      this.bread = bread;
      this.sauce = sauce;
      this.cheese = cheese;
    }

    //constructor3
      public pizza(string bread,string sauce)
    {
      this.bread = bread;
      this.sauce = sauce;
    }
    public void eat()
    {
      Console.WriteLine($"you are eating pizza which have: {bread}, {sauce}, {cheese} , {toppings}");
    }
  }
}