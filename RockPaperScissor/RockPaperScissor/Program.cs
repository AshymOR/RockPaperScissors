using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissor
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How many rounds do you want to play? Must be between 1 and 10");
            int rounds = int.Parse(Console.ReadLine());

            if (rounds < 1 || rounds > 10)
            {
                Console.WriteLine("I'm sorry you entered an invalid option");
                return;
            }

            string Game(int turns)
            {

                int playerWins = 0;
                int npcWins = 0;
                int ties = 0;

                for (int i = 0; i < turns; i++)
                {
                    Console.WriteLine("Pick 1 for Rock, 2 for Paper or 3 for Scissors");
                    int choice = int.Parse(Console.ReadLine());

                    Random random = new Random();
                    int NPCchoice = random.Next(1, 4);

                    if (choice == 1 && NPCchoice == 2)
                    {
                        Console.WriteLine("You chose Rock and I chose Paper. I win!");
                        npcWins++;
                    }
                    else if (choice == 1 && NPCchoice == 3)
                    {
                        Console.WriteLine("You chose Rock and I chose Scissors. You win!");
                        playerWins++;
                    }
                    else if (choice == 2 && NPCchoice == 1)
                    {
                        Console.WriteLine("You chose Paper and I chose Rock. You win!");
                        playerWins++;
                    }
                    else if (choice == 2 && NPCchoice == 3)
                    {
                        Console.WriteLine("You chose Paper and I chose Scissors. I win!");
                        npcWins++;
                    }
                    else if (choice == 3 && NPCchoice == 1)
                    {
                        Console.WriteLine("You chose Scissors and I chose Rock. I win!");
                        npcWins++;
                    }
                    else if (choice == 3 && NPCchoice == 2)
                    {
                        Console.WriteLine("You chose Scissors and I chose Paper. You win!");
                        playerWins++;
                    }
                    else if (choice == NPCchoice)
                    {
                        Console.WriteLine("We picked the same thing. We tie!");
                        ties++;
                    }
                }
                Console.WriteLine("That was a lot of fun!");
                Console.WriteLine("You won " + playerWins + " times");
                Console.WriteLine("I won " + npcWins + " times");
                Console.WriteLine("We tied " + ties + " times");

                if (playerWins > npcWins)
                {
                    Console.WriteLine("You are the winner!");
                }
                else if (playerWins < npcWins)
                {
                    Console.WriteLine("I am the winner!");
                }
                else if (playerWins == npcWins)
                {
                    Console.WriteLine("We had the same amount of wins, we are both the winner!");
                }

                Console.WriteLine("Do you want to play again? y/n");
                string playAgain = Console.ReadLine();
                return playAgain;
            }

            string goAgain = Game(rounds);

            while (goAgain == "y")
            {
                Console.WriteLine("How many rounds do you want to play? Must be between 1 and 10");
                rounds = int.Parse(Console.ReadLine());

                if (rounds < 1 || rounds > 10)
                {
                    Console.WriteLine("I'm sorry you entered an invalid option");
                    return;
                }
                goAgain = Game(rounds);
            }
            if (goAgain != "y")
            {
                return;
            }

            

        }
    }
}
