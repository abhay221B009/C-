using System;
namespace App1
{
  class animal
  {
    static void Main(string[] args)
    {
      janwar janwar1 = new janwar("khatarnak");
      janwar janwar2 = new janwar("Bahot-khatarnak");

      janwar1.ShowInfo();
      janwar2.ShowInfo();

      Console.WriteLine("\nTotal animals created (static): " + janwar.numberOfAnimal);
    }
  }

  class janwar
  {
    string category;
    public static int numberOfAnimal = 0;  // shared by all

    public janwar(string category)
    {
      this.category = category;
      numberOfAnimal++;                     // increases shared count
    }

    public void ShowInfo()
    {
      Console.WriteLine($"Animal type: {category}");
      Console.WriteLine($"Static count inside object: {numberOfAnimal}");
      Console.WriteLine();
    }
  }
}
/*✅ What your program is trying to teach you
🔥 Lesson 1: Instance members belong to each object separately.

Example:
category → each janwar has its own category.

So output is:

Animal type: khatarnak
Animal type: Bahot-khatarnak


They are different for each object.

🔥 Lesson 2: Static members DO NOT belong to the object.

They belong to the class itself, so there is only ONE copy for ALL objects.

Here:

public static int numberOfAnimal;


This variable:

Is created only once.

Is shared by every janwar object.

Increases every time you create any janwar.

Therefore, both objects show:

Static count inside object: 2


Because the static value is shared, not per-object.

🧠 SO WHAT IS THIS TEACHING YOU?
✔ Static = one common variable shared by all objects
✔ Instance = each object has its own separate data
⭐ Real-life analogy (you will understand immediately)
➤ Imagine "category" = the name of a person.

Everyone has their own name.

➤ Imagine "numberOfAnimal" = world population.

This number is shared among all people.

You don’t have your own separate world population count —
Everyone sees the same value.

That is exactly what static does.*/