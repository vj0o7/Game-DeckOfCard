using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCard.Models
{
    public enum Suit
    {
        clubs,
        hearts,
        spade,
        diamonds
    }

    public class Card
    {
        public string name { get; set; }

        public Suit suit { get; set; }
    }
}
