using System;
using System.Collections.Generic;
using System.Text;

namespace p173_ex5
{
    class CubesTower
    {
        private int max_cube;// מספר הקוביות מקסמלי שגדל יכל להכיל  
        private int num_containing;//מספר הקוביות שמדל מסוים מכיל בפועל 
        private Cube[] collection_of_dice;// אוסף הקובית  המונחות אחת על השנייה

        public CubesTower(int max_cube, int num_containing, Cube[]collection_of_dice)
        {
            this.max_cube = max_cube;
            this.num_containing = num_containing;
            for (int i = 0; i < this.max_cube; i++)
            {
                this.collection_of_dice[i] = collection_of_dice[i];
            }
        }
        public int Tower_at_maximum_capacity()
        {
            while (this.max_cube > this.num_containing)
            {
                this.num_containing++;
            }
            return this.num_containing;
        }
        public int Cube_removal()
        {
            if (this.num_containing<1)
            {
                this.num_containing--;
            }
            return this.num_containing;
        }
        public bool Color(string color)
        {
            for (int i = 0; i < this.collection_of_dice.Length; i++)
            {
                if (this.collection_of_dice[i].GetColor()==color)
                {
                    return true;
                }
            }
            return false;
        }
        public bool An_empty_tower()
        {
            if (this.num_containing==0)
            {
                return true;
            }
            return false;
        }
        public bool Maximum_occupancy()
        {
            if (this.num_containing == this.max_cube)
            {
                return true;
            }
            return false;
        }
        public int GetMax_cube()
        {
            return this.max_cube;
        }

        public int GetNum_containing()
        {
            return this.num_containing;
        }
        public Cube GetCollection_of_dice(int num)
        {
            return this.collection_of_dice[num];
        }
        public void SetMax_cube(int max_cube)
        {
            this.max_cube = max_cube;
        }

        public void SetNum_containing(int num_containin)
        {
            this.num_containing = num_containin;
        }
        public void SetCollection_of_dice(Cube c)
        {
            for (int i = 0; i < this.collection_of_dice.Length; i++)
            {
                this.collection_of_dice[i] = c[i];
            }
        }
        public bool Equals(CubesTower c)
        {
            bool b = true;
            if (c.GetMax_cube()==this.max_cube&&c.GetNum_containing()==this.num_containing)
            {
                for (int i = 0; i <this.collection_of_dice.Length; i++)
                {
                    if (this.collection_of_dice[i]!=c.GetCollection_of_dice(i))
                    {
                        return false;
                    }
                }
                return true;
            }
        }
        public override string ToString()
        {
            return  this.max_cube + "," + this.num_containing ;
        }
        public string CubesTower_color()
        {
            int sev = this.collection_of_dice.Length;
            Cube[]arr= new Cube[max_cube];
            arr[0] =new Cube (this.collection_of_dice[0].GetLength_side(), this.collection_of_dice[0].GetColor());
            CubesTower c = new CubesTower(5,1,arr);
            for (int i = 1; i <sev ; i++)
            {
                if (c.Color(this.collection_of_dice[i].GetColor())==false)
                {
                    arr[i] = new Cube(this.collection_of_dice[i].GetLength_side(), this.collection_of_dice[i].GetColor());
                    c.Tower_at_maximum_capacity();
                }
                this.Cube_removal();
            }
            return c.ToString();
        }
                
    }
}
