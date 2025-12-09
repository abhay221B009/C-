using System;
namespace App1
{
  class NumberGuessing
  {
    public static void Main10(string[] args)
    {
      Random random = new Random();
      bool playAgain = true;
      int min = 1;
      int max = 100;
      int guess;
      int number;
      int guesses;
      while (playAgain)//dony need to write like a(playagain==true), because it is already true
      {
        guess = 0;
        guesses= 0;
        number = random.Next(min,max+1); //+1 because max is exclusive
        while(guess !=number)
        {
          Console.WriteLine("Guess a number between "+min +" and " +max+" :");
          guess = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Guess: "+guess);

          if(guess< number)
          {
            Console.WriteLine("Too low!");
          }
          else if(guess> number)
          {
            Console.WriteLine("Too high!");
          }
          guesses++;
        }Console.WriteLine("You guessed it right! The number is "+number);  
        Console.WriteLine("You took "+guesses+" guesses.");
        Console.WriteLine("Do you want to play again? (yes/no)"); 
        string answer = Console.ReadLine().ToLower();
        if(answer != "yes")
        {
          playAgain = false;
          Console.WriteLine("Thanks for playing!");         

      }
    }
  }
}
}