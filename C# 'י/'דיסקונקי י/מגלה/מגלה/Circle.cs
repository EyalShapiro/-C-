using System;
using System.Collections.Generic;
using System.Text;

namespace מגלה
{

    class Circle
    {
        private int radi;
        private string colo;
        //בנאי רגיל
        public Circle(int radi, string colo)
        {
            this.radi = radi;
            this.colo = colo;
        }
        //בנאי רקה
        public Circle()
        {
            this.radi = 1;
            this.colo = "black";
        }
        public int get_radi()
        {
            return this.radi;
        }
        public bool Chi( Circle c2)
        {
            if (this.radi>c2.get_radi())
	        {
                return true;
	        }
            else
                return false;
        }
        public void momo(Circle c2,Circle c1)
        {
            this.radi = this.radi + c2.get_radi() + c1.get_radi();
            
        }
        public void Set_colo(string s)
        {
            this.colo = s;
        }
        public string gut_colo()
        {
            return this.colo;
        }
            
    }
}

