using DeckOfCard.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCard
{
    public class PlayGame
    {
        private List<Card> cards;
        private readonly string noCardsLeftError = "No cards left in the deck, Press 3 to restart the game";

        private readonly string[] cardNames = { "Ace", "2", "3", "4", "5", "6" , "7", "8", "9", "10", "Jack", "Queen", "King"};

        //Constructor that will instantiate the deck
        public PlayGame()
        {
            cards = new List<Card>();
            foreach(var suit in Enum.GetValues(typeof(Suit)))
            {
                foreach(var cardName in cardNames)
                {
                    cards.Add(new Card
                    {
                        name = cardName,
                        suit = (Suit)suit
                    });
                }
            } 
        }

        private bool ValidateCards()
        {
            if(cards.Count <= 0)
            {
                return false;
            }

            return true;
        }

        public void ShuffleTheDeck()
        {
            if(!ValidateCards())
            {
                Console.WriteLine(noCardsLeftError);
                return;
            }
            int numberOfCards = cards.Count;

            var rng = new Random();
            while (numberOfCards > 1)
            {
                numberOfCards--;
                int k = rng.Next(numberOfCards + 1);
                Card value = cards[k];
                cards[k] = cards[numberOfCards];
                cards[numberOfCards] = value;
            }
        }

        public void PlayTheCard()
        {
            if (!ValidateCards())
            {
                Console.WriteLine(noCardsLeftError);
                return;
            }

            var cardToPlay = cards[0];

            Console.WriteLine("Played Card: " + cardToPlay.name + " of " + cardToPlay.suit.ToString());
            cards.RemoveAt(0);
            Console.WriteLine("Number of Cards left in the Deck: " + NumberOfCardLeft());
        }

        private int NumberOfCardLeft()
        {
            return cards.Count;
        }
    }
}
