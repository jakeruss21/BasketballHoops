using System;
using System.Collections.Generic;
using System.Text;

namespace BasketballHoops
{
    class Player
    {
        public string playerName = "";
        public string playerTeam = "";
        public double shotProf = 0;
        public double defense = 0;
        public double rebound = 0;
        public double ballHandling = 0;


        public Player()
        {

        }

        public Player (string iPlayerTeam)
        {
            playerTeam = iPlayerTeam;

            Console.Write("Player Name: ");
            playerName = Console.ReadLine();

            Console.Write("{0}'s shooting percentage: ", playerName);
            shotProf = Utility.DoubleErrorHandler(100);

            Console.Write("{0}'s defensive prowess: ", playerName);
            defense = Utility.DoubleErrorHandler(100);

            Console.Write("{0}'s rebound percentage: ", playerName);
            rebound = Utility.DoubleErrorHandler(100);

            Console.Write("{0}'s ball handling skills: ", playerName);
            ballHandling = Utility.DoubleErrorHandler(100);

            Console.WriteLine();
            
        }

    }
}
