using System;
using System.Collections.Generic;
using System.Text;

namespace p77_ex50
{

    class Advr
    {
        private string advertisement_name;//שם הפרסןמת 
        private string company_name;//שם חברה
        private int length;//אורך הפרםומת בשניות
 
        public Advr(string advertisement_name, string company_name, int length)
        {
            this.advertisement_name = advertisement_name;
            this.company_name = company_name;
            this.length = length;
        }
        public string GetAdvertisement_name()
        {
            return this.advertisement_name;
        }
        public string GetCompany_name()
        {
            return this.company_name;
        }
        public int GetLength()
        {
            return this.length;
        }
        public void SetAdvertisement_name(string advertisement_nameToSet)
        {
            this.advertisement_name = advertisement_nameToSet;
        }
        public void SetCompany_name(string company_nameToSet)
        {
            this.company_name = company_nameToSet;
        }
        public void SetLength(int lengthToSet)
        {
            this.length = lengthToSet;
        }
       
        public override string ToString()
        {
            return this.advertisement_name + "," + this. company_name+ "," + this.length;
        }

    }
}
