using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLittlePony
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Player p1 = new Player();
            p1.setName("Klaus");
            p1.setID(1);
            */
            /*
            Player p2 = new Player("Peter", 2);
            Console.WriteLine(p2.getName());
            Console.WriteLine(p2.getID());
            */

            Game game = new Game();

            foreach (Card cards in game.getCards())
            {
                Console.WriteLine(cards.getID() + "\t" + cards.getName() + "\t" + cards.getProperties());
            }
            
            foreach (Player player in game.getPlayers())
            {
                Console.WriteLine(player.getName() + "\t" + player.getID());
            }

            Console.ReadKey();
            
        }
    }
}
