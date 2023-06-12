using System;

namespace point
{
    class Program
    {
        //Point ex1
        public static double Poin(Point p1, Point p2)
        {
            //הפעולה מקבלת שנ מספרים ובדקת את המרחקה            
            double  dis = Math.Pow(p1.GetX()-p2.GetX(),2)+Math.Pow(p1.GetY()-p2.GetY(),2);              
            return Math.Sqrt(dis);           
        }
        //Point ex2
        public static Point Poin_new(Point p1, Point p2)
        {
            //הפעולה יצרה point חדש 
            double disx, disy;
            disx = (p1.GetX()+p2.GetX())/2;
            disy = (p1.GetY()+p2.GetY())/2;
            Point P_new= new Point(disx, disy);
            return P_new; 
        }
        static void Main(string[] args)
        {
            
            //Point ex1-2
            Console.WriteLine("enter x and y");
            Point p1 = new Point(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            Console.WriteLine("enter x and y");
            Point p2 = new Point(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            Console.WriteLine(Poin_new(p1,p2));








        }
    }
}
