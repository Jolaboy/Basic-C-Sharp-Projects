using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Deck
    {
        public List<Card> Cards { get; set; } 

        public Deck()
        {
            // Constructor logic added here
            Cards = new List<Card>();
            string[] Suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
            string[] Faces = { "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace" };
            foreach (string suit in Suits)
            {
                foreach (String face in Faces)
                {
                    Card card = new Card();
                    card.Suit = suit;
                    card.Face = face;
                    Cards.Add(card); 
                }
            }
        }
    }

}
