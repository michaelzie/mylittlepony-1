using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLittlePony
{
    class Game
    {
        private List<Player> _players = new List<Player>();
        private List<Card> _cards = new List<Card>();
        private int _lastWinner;

        public Game()
        {
            this.createPlayers();
            this.createCards();
        }

        public void createPlayers()
        {
            _players.Add(new Player("Spieler 1", 1));
            _players.Add(new Player("Spieler 2", 2));
            _players.Add(new Player("Spieler 3", 3));
            _players.Add(new Player("Spieler 4", 4));
        }
        
        public List<Player> getPlayers()
        {
            return _players;
        }

        public void createCards()
        {
            //Card card = new Card();
            //card.createProperties();
            
            Property property = new Property(156, "cm", true);
            // 3 arrays
            List<Property> _property = new List<Property>();
            _property.Add(property);

            _cards.Add(new Card(1, "Island Pony", "G3", _property));
            _cards.Add(new Card(1, "Shagya Araber", "G2", _property));
        }

        public List<Card> getCards()
        {
            return _cards;
        }
    }
}
