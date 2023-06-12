using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitor
{
    class Competitor
    {
        private string name; // שם מתחרה
        private int minutes; // מספר דקות לסיום המסלול
        private int seconds; // מספר שניות לסיום המסלול
        public Competitor(string name, int minutes, int seconds)
        {
            this.name = name;
            this.minutes = minutes;
            this.seconds = seconds;
        }
        public bool Shorter(Competitor c)
        {
            return (this.minutes * 60 + this.seconds < c.minutes * 60 + c.seconds);
        }
        public string GetName()
        {
            return this.name;
        }
    }
}
