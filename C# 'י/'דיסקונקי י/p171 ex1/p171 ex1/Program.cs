using System;

namespace p171_ex1
{
    class Program
    {
        public static int Line_leng(Line[]l1)
        {
            //מקבלת מערך של קווי ומחזירה את קו הארוך
            int max = 0;
            for (int i = 0; i < l1.Length; i++)
            {
                if (max<l1[i].Long_line())
                {
                    max = l1[i].Long_line();
                }
            }
            return max;
        }
        public static int Pointing(Point p,Line[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Getp1().GetX()==p.GetX()&& arr[i].Getp1().GetY() == p.GetY())
                {
                    count++;
                }
                if (arr[i].Getp2().GetX() == p.GetX() && arr[i].Getp2().GetY() == p.GetY())
                {
                    count++;
                }
            }
            return count;
        }

        static void Main(string[] args)
        {
                     
            Line[] l = new Line[8];
            Random r = new Random();
            for (int i = 0; i < l.Length; i++)
            {
                l[i] = new Line(new Point((double)r.Next(10), (double)r.Next(10)), new Point((double)r.Next(10), (double)r.Next(10)));
            }
            Console.WriteLine("ex1  "+Line_leng(l));
            Point p = new Point(2.0,4.0);
            Console.WriteLine("ex2  "+Pointing(p,l));
            int count=0;
            for (int i = 0; i < l.Length; i++)
            {
                if (true==l[i].Parallel())
                {
                    count++;
                } 
            }
            Console.WriteLine("ex3  ג" +count);
        }
    }
}
