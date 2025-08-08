using System;
using System.Collections.Generic;

namespace TwentyOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TwentyOneGame game = new TwentyOneGame();
            game.Players = new List<string> { "Jesse", "Bill", "Joe" };
            game.ListPlayers();
            game.Play();
            Deck deck = new Deck();
            deck.Shuffle(times: 1);
            deck.ViewCards(); // Displays cards of deck on screen in order.

        }
    }
}
