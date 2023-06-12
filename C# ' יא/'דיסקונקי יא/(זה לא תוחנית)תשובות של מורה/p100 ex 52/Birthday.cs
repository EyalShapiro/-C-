using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birthdays
{
    class Birthday // מחלקת יום הולדת של תלמיד
    {
        private string name; // שם התלמיד
        private int day; // יום ההולדת בחודש
        public Birthday(string name, int day)
        {
            this.name = name;
            this.day = day;
        }
        public bool Equals(Birthday b)
        {
            return this.name == b.name && this.day == b.day;
        }
        public override string ToString()
        {
            return this.name + " " + this.day;
        }
    }
}
