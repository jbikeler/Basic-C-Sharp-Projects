using System;
using System.Collections.Generic;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck(); // create deck
            deck = Shuffle(deck); // shuffle deck

            foreach (Card card in deck.Cards) // print the deck to user
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }

        public static Deck Shuffle(Deck deck, int times = 1) // function to shuffle deck
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>(); // create temperary list to hold cards
                Random random = new Random(); // create object to make rand numbers

                while (deck.Cards.Count > 0) // loop through passed in deck
                {
                    int randomIndex = random.Next(0, deck.Cards.Count); //get rand number in between 0 and the amount of cards in the deck
                    TempList.Add(deck.Cards[randomIndex]); // add the card at rand index to the new temp list
                    deck.Cards.RemoveAt(randomIndex); // remove that card from the current deck so it is not used again in next loop
                }
                deck.Cards = TempList; // assign new list to the Cards parameter in deck;
            }
            return deck;
        }
    }
}
