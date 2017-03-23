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

            foreach (Card card in game.getCards())
            {
                Console.WriteLine("\n" + card.getPlayer() + "\t" +card.getID() + "\t" + card.getName());

                for (int i = 0; i <= 3; i++)
                {
                    Console.WriteLine(card.getProperties()[i].getValue() + " " + card.getProperties()[i].getUnit());
                }
            }
            
            foreach (Player player in game.getPlayers())
            {
                Console.WriteLine("\n" + player.getName() + "\t" + player.getID());
            }

            Console.ReadKey();
            
        }
    }
}
