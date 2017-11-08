using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerHands
{
    class Lobby
    {
        private void Play()
        {
            var blackPlayer = new Player();
            var whitePlayer = new Player();

            var Game = new Game();
            var winPlayer = Game.Result(blackPlayer, whitePlayer);

            Console.Write(winPlayer);
        }
    }

    class Game
    {
        public string Result(Player black, Player white)
        {
            return string.Format("xxx Wins - with card");
        }        
    }

    class Player
    {
        public List<PokereCard> Cards { get; set; }
    }

    class PokereCard
    {
        public PokereCard(int value, int suit)
        {
            Value = value;
            Suit = suit;
        }
        public int Value { get; set; }

        public int Suit  { get; set; }
    }

    class test
    {
        private void initHighCards()
        {
            var Blackcards = new List<PokereCard>()
            {
                { new PokereCard(2, 3)},
                { new PokereCard(3, 2)},
                { new PokereCard(5, 4)},
                { new PokereCard(9, 1)},
                { new PokereCard(13, 2)},
            };

            var WhiteCards = new List<PokereCard>()
            {
                { new PokereCard(2, 1)},
                { new PokereCard(3, 3)},
                { new PokereCard(4, 4)},
                { new PokereCard(8, 1)},
                { new PokereCard(1, 3)},
            };
        }
    }
}
