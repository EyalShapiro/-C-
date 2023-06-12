using System;
using System.Collections.Generic;
using System.Text;

namespace שאלה_בגרות_2
{
    class Country
    {
        private string countryName;
        private Game[] games = new Game[43];
        
        public Country (string countryName )
        {
            this.countryName = countryName; 
        }
        public string GetCountryName()
        {
            return this.countryName;
        }
        public void SetCountryName(string countryName)
        {
            this.countryName = countryName;
        }
        public bool Game_in_Country(string g)
        {
            for (int i = 0; i < this.games.Length; i++)
            {
                if (this.games[i]!=null&&g!= null&& this.games[i].GetGameName()==g)
                {
                    return true;
                }
            }
            return false;
        }
            
    }
}
