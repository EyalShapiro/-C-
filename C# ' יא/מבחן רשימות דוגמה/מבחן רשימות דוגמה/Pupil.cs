using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace מבחן_רשימות_דוגמה
{
    class Pupil
    {
        private int points;//מספר נקודות שצבר 
        private string name;//שם 
        //פעולה בונה
        public Pupil( string name, int points)
        {
            this.points = points;
            this.name = name;

        }
        //פעולה המחזירת 
        public string GetName()
        {
            return this.name;
        }

        public int GetPoints()
        {
            return this.points;
        }

        public void addPoints(int points)
        {
            this.points += points;
        }

    }
}
