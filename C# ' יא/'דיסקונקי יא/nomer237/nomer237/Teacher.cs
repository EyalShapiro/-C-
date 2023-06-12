using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nomer237
{
    class Teacher
    {
        private string name; //שם
        private string id;//מס זהות
        private bool degree; //בעל תואר
        private string[] sujects;// מערך מקצות
        private int numOfSubs;//מספר מקצועות בפועל  
        public Teacher(string name, string id, bool degree)
        {
            this.name = name;
            this.id = id;
            this.degree = degree;
            this.sujects = new string[5];
            this.numOfSubs = 0;
        }
        public string GetName()
        {
            return this.name;
        }
        public string GetId()
        {
            return this.id;
        }
        public bool GetDegree()
        {
            return this.degree;
        }
        public int GetNumOfSubs()
        {
            return this.numOfSubs;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetId(string id)
        {
            this.id = id;
        }
        public void AddSub(string sub)
        {
            if (this.numOfSubs<this.sujects.Length)
            {
                this.sujects[this.numOfSubs] = sub;
                this.numOfSubs++;
            }
            else
                Console.WriteLine("no place");
        }
        public bool IsTeachingSub(string sub)
        {
            for (int i = 0; i < this.numOfSubs; i++)
                if (this.sujects[i].Equals(sub))
                    return true;
            return false;
        }
    }
}
