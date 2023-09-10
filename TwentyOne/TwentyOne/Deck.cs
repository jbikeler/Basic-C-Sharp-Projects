using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
    class Deck
    {
        public Deck()
        {
            Cards = new List<Card>();
            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Card card = new Card();
                    card.Face = (Face)j;
                    card.Suit = (Suit)i;
                    Cards.Add(card);
                }
            }
        }
        public List<Card> Cards { get; set; } 

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
