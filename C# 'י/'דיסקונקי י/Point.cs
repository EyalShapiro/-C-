    /*כל הזכויות שמורות להוצאת מבט לחלונות*/
using System;

    class Point
    {
        private double x; // ערך ה-X
        private double y; // ערך ה-Y

        public Point(double x1, double y1)
        {
            this.x = x1;
            this.y = y1;
        }
        public double GetX() 
        { 
            return x; 
        }
        public double GetY() 
        {
            return y; 
        }
        public void SetX(double x1)
        {
            this.x = x1;
        }
        public void SetY(double y1)
        {
            this.y = y1;
        }
        public override string ToString()
        {
            return "x=" + x + " y=" + y;
        }
    }
