﻿using System;
using System.Collections.Generic;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new TwentyOneGame();
            game.Players = new List<Player>();
            Player player = new Player();
            player.Name = "Ben";
            game += player;
            game -= player;

            Deck deck = new Deck(); // create deck
            deck.Shuffle(); // shuffle deck

            foreach (Card card in deck.Cards) // print the deck to user
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }
    }
}
