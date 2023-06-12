using System;
using System.Collections.Generic;
using System.Text;

namespace p172_ex3
{
    class Trarin
    {
        private Engine engine; //קטר
        private Carriage[]carriage; //מערך קרונות
        private int num_carriage; // מספר הקרונות שיש ברכבת בפועל
        public Trarin(Engine engine, int N, int num_carriage)
        {
            this.engine = engine;
            this. num_carriage= num_carriage;
            this.carriage = new Carriage[N];
        }
        public SetEngine(Engine engineToSet)
        {
            this.engine = engineToSet;
        }
        public bool Carriage_pls(Carriage c)
        {
            for (int i = 0; i < this.carriage.Length; i++)
            {
                if (this.carriage[i]==null)
                {
                    this.carriage[i] = c;
                    this.num_carriage++;
                    return true;
                }
            }
            return false;
        }
        public int Max()
        {
            int sum = 0;
            for (int i = 0; i < this.carriage.Length; i++)
            {
                sum += this.carriage[i].GetMax_Expriments();
            }
            return  sum;
        }
        public int Avg_Expriments ()
        {
            return Max /num_carriage;
        }

    }
}
