using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
    class Deck
    {
        public List<Card> Cards { get; set; }
        public Deck()
        {
            Cards = new List<Card>();
            List<string> Suits = new List<string>() {"Clubs", "Hearts", "Diamonds", "Spades"};
            List<string> Faces = new List<string>()
            {
                "Two", "Three", "Four", "Five", "Six", "Seven",
                "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };

            foreach (string face in Faces)
            {
                foreach (String suit in Suits)
                {
                    Card card = new Card();
                    card.Suit = suit;
                    card.Face = face;
                    Cards.Add(card);
                }
            }
        }

        public void Shuffle(int times = 1) // function to shuffle deck
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>(); // create temperary list to hold cards
                Random random = new Random(); // create object to make rand numbers

                while (Cards.Count > 0) // loop through passed in deck
                {
                    int randomIndex = random.Next(0, Cards.Count); //get rand number in between 0 and the amount of cards in the deck
                    TempList.Add(Cards[randomIndex]); // add the card at rand index to the new temp list
                    Cards.RemoveAt(randomIndex); // remove that card from the current deck so it is not used again in next loop
                }
                Cards = TempList; // assign new list to the Cards parameter in deck;
            }
        }
    }
}
