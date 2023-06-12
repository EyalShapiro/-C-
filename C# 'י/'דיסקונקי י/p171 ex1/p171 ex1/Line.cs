using System;
using System.Xml.Linq;

namespace p171_ex1
{

    class Line
    {
        private Point p1;
        private Point p2;

        public Line(Point p1, Point p2)
        {
            this.p1 = p1;
            this.p2 = p2;
        }
        public Point Getp1()
        {
            return p1;
        }
        public Point Getp2()
        {
            return p2;
        }
        public Point Setp1(Point p1)
        {
            return this.p1 = p1;
        }
        public Point Setp2(Point p2)
        {
            return this.p2 = p2;
        }
        public int Long_line()
        {
            double p =  Math.Sqrt(Math.Pow(this.p1.GetX() + this.p2.GetX(),2)- Math.Pow(this.p1.GetY() +this.p2.GetY(),2)) ;
            int save = 0;
            save= (int)p;
            return save;
        }
        public bool Parallel()
        {
            if (this.p1.GetX()==this.p2.GetX())
            {
                return true;
            }
            return false;
        }
        public Point CompareTo()
        {
            Point p =new Point((double)Math.Abs(this.p1.GetX() - this.p2.GetX()),(double)Math.Abs(this.p1.GetY() - this.p2.GetY()));
            return p;
        }
        public override string ToString()
        {
            return this.p1.ToString() + " - " + this.p1.ToString();
        }


    }
}
