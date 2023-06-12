using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Manhous
    {
        private int num;
        private char tav;
        public Manhous(int num, char tav)
        {
            this.num = num;
            this.tav = tav;
        }

        public void SetNum(int num)
        {
            this.num = num;
        }
        public void SetTav(char tav)
        {
            this.tav = tav;
        }

        public int GetNum()
        {
            return this.num;
        }

        public char GetTav()
        {
            return this.tav;
        }

        public string ToString()
        {
            return "the number is" + this.num + "the tav is" + this.tav;
        }

    }
}
