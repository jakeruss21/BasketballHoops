using System;
using System.Collections.Generic;
using System.Text;

namespace BasketballHoops
{
    class Player
    {
        public string playerName = "";
        public double shotProf = 0;
        public double defense = 0;
        public double rebound = 0;
        public double ballHandling = 0;

        public Player()
        {

        }

        public Player (string iPlayerName = "", double iShotProf = 0, double iDefense = 0, double iRebound = 0, double iBallHandling = 0)
        {
            playerName = iPlayerName;
            shotProf = iShotProf;
            defense = iDefense;
            rebound = iRebound;
            ballHandling = iBallHandling;
        }


    }
}
