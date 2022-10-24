using System;
using System.Collections.Generic;

namespace DeckShuffle
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            int draw = 0;
            while (draw < 1 || draw > 53)
            {
                Console.WriteLine("How Many Cards Would you like to Draw?");
                draw = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < draw; i++)
            {
                Console.WriteLine(deck.Cards[i]);
            }

            Console.WriteLine("Press ENTER to quit");
            Console.ReadLine();
        }
    }

}
