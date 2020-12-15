using System;

namespace DeckOfCard
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                var playGame = new PlayGame();
                playGame.ShuffleTheDeck();

                while (true)
                {
                    Console.WriteLine("Play:");
                    Console.WriteLine("- Press 1 to play the card from deck");
                    Console.WriteLine("- Press 2 to shuffle the deck");
                    Console.WriteLine("- Press 3 to restart the game");

                    var c = Console.ReadLine();
                    var choice = Convert.ToInt32(c);

                    switch (choice)
                    {
                        case 1:
                            playGame.PlayTheCard();
                            break;

                        case 2:
                            playGame.ShuffleTheDeck();
                            Console.WriteLine("Reshuffled the Deck");
                            break;

                        case 3:
                            playGame = new PlayGame();
                            Console.WriteLine("New game has Started");
                            break;

                        default:
                            Console.WriteLine("Select a valid choice!!");
                            break;
                    }

                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occured:", ex);
            }
        }
    }
}
