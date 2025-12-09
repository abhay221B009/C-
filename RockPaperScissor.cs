using System;
namespace App1
{
    class RockPaperScissor
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            string player;
            string computer;
            string answer;

            while (playAgain)
            {
                player = "";
                computer = "";

                while (player != "ROCK" && player != "PAPER" && player != "SCISSOR")
                {
                    Console.WriteLine("Enter ROCK, PAPER or SCISSOR: ");
                    player = Console.ReadLine().ToUpper();
                }

                int randomNum = random.Next(1, 4); // 1 to 3

                switch (randomNum)
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSOR";
                        break;
                }

                Console.WriteLine("\nPlayer: " + player);
                Console.WriteLine("Computer: " + computer);

                switch (player)
                {
                    case "ROCK":
                        if (computer == "ROCK")
                            Console.WriteLine("It's a draw!");
                        else if (computer == "PAPER")
                            Console.WriteLine("Computer wins!");
                        else
                            Console.WriteLine("Player wins!");
                        break;

                    case "PAPER":
                        if (computer == "ROCK")
                            Console.WriteLine("Player wins!");
                        else if (computer == "PAPER")
                            Console.WriteLine("It's a draw!");
                        else
                            Console.WriteLine("Computer wins!");
                        break;

                    case "SCISSOR":
                        if (computer == "ROCK")
                            Console.WriteLine("Computer wins!");
                        else if (computer == "PAPER")
                            Console.WriteLine("Player wins!");
                        else
                            Console.WriteLine("It's a draw!");
                        break;
                }

                Console.WriteLine("\nDo you want to play again? (Y/N)");
                answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                    playAgain = true;
                else
                    playAgain = false;

                Console.WriteLine();
            }

            Console.WriteLine("Thanks for playing!");
        }
    }
}
