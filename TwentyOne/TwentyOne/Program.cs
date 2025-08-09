using System;
using System.Collections.Generic;

namespace TwentyOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new TwentyOneGame();
            game.Players = new List<Player>();
            Player player = new Player();
            player.Name = "Test";
            game += player;
            game -= player;

            Deck deck = new Deck();
            deck.Shuffle(times: 1);
            deck.ViewCards(); // Displays cards of deck on screen in order.

        }
    }
}
