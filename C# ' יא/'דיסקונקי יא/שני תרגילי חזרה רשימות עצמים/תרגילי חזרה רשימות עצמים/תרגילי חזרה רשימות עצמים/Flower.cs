using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace תרגילי_חזרה_רשימות_עצמים
{
    class Flower
    {
        private string name;//שם
        private double  height;//גובה
        private string color;//צבע 
        private string season_which_grows;//העונה בה הוא גדל
        //פעולה בונה 
        public Flower (string name , double height , string color , string season_which_grows)
        {
            this.name = name;
            this.height = height;
            this.color = color;
            this.season_which_grows=season_which_grows;
        }
        //פעולה  מאחזרות
        public string GetName()
        {
            return this.name;
        }
        public string Getcolor()
        {
            return this.color;
        }
        public string GetSeason_which_grows()
        {
            return this.season_which_grows;
        }
        public double GetHeight()
        {
            return height;
        }
        //פעולה  קובעות
        public void SetSeason_which_grows(string season_which_grows)
        {
            this.season_which_grows = season_which_grows;
        }
        public void SetHeight(double height)
        {
            this.height = height;
        }
       
        public void SetColors(string color)
        {
            this.color = color;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        //פעולה תיאורית
        public override string ToString()
        {
            return " name: " + this.name + " ,height: " + height + " ,color: " + color + " ,season_which_grows: " + season_which_grows;
        }    
            
    }
}
