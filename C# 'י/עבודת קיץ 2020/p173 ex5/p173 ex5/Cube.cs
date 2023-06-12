using System;
using System.Collections.Generic;
using System.Text;

namespace p173_ex5
{
    class Cube
    {
        private int length_side; //אורך צלע של קובייה
        private string color; //צבע הקובייה

        public Cube(int length_side, string color)
        {
            this.length_side = length_side;
            this.color = color;
        }
        public int GetLength_side()
        {
            return this.length_side;
        }

        public string GetColor()
        {
            return this.color;
        }

        public void SetLength_side(int length_side)
        {
            this.length_side = length_side;
        }

        public void SetColor(string color)
        {
            this.color = color;
        }
        public bool Equals(Cube c)
        {
            if (c.GetColor()==this.color && c.GetLength_side()==this.length_side)
            {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return  this.length_side +" "+  this.color;
        }
    }
}
