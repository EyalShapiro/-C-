using System;
using System.Collections.Generic;
using System.Text;

namespace p116_ex19
{
    class CoupleNames
    {

        private string name1;
        private string name2;

        public CoupleNames(string name1, string name2)
        {
            this.name1 = name1;
            this.name2 = name2;
        }

        public string GetName1()
        {
            return this.name1;
        }
        public string GetName2()
        {
            return this.name2;
        }
        public void SetName1(string name1ToSet)
        {
            this.name1 = name1ToSet;
        }
        public void SetName2(string name2ToSet)
        {
            this.name2 = name2ToSet;
        }
        
        public int CompareTo(CoupleNames[,] arr)
        {
            int count=0;
            for (int i = 0; i <=2&&arr.GetLength(0)>i ; i++)
            {
                for (int j = 0; j<=2&&j < arr.GetLength(1); j++)
                {
                    count += 2; 
                }
            }
            return count; 
        }
        public override string ToString()
        {
            return this.name1 + " , " + this.name2;
        }
    }
}
