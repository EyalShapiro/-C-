using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace שאלה_מהבגרות
{
    class Actor
    {
        private string id;
        private string gander;
        private int numfilms;
        public Actor(string id,string gander, int numfilms)
        {
            this.id = id;
            this.gander = gander;
            this.numfilms = numfilms;
        }
        public Actor (Actor actor)
        {
            this.id = actor.GetId();
            this.gander = actor.GetGander();
            this.numfilms = actor.GetNumfilms();
        }
        public void AddFilm()
        {
            this.numfilms++;
        }
        
        public string GetId()
        {
            return this.id;
        }
        public string GetGander()
        {
            return this.gander;
        }
        public int GetNumfilms()
        {
            return this.numfilms;
        }
        public int compare(Actor other)
        {
            if (this.numfilms>other.GetNumfilms())
            {
                return 1;
            }
            if (this.numfilms < other.GetNumfilms())
            {
                return 2;
            }
            return 3;
        }

    }
}
