using System;
using System.Collections.Generic;
using System.Text;

namespace שאלה_בגרות_2
{
    class Game
    {
        private string gameName;
        private int gamePlayers;
        private bool isWater;

        public Game(string gameName, int gamePlayers, bool isWater)
        {
            this.gameName = gameName;
            this.gamePlayers = gamePlayers;
            this.isWater = isWater;
        }
        public string GetGameName()
        {
            return this.gameName;
        }
    }
}
