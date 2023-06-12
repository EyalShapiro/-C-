using System;

namespace מגלה
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(8, "rad");
            Circle c2 = new Circle(8, "rad");
            Circle c3 = new Circle();

            Console.WriteLine(c1.get_radi());
            Console.WriteLine(c1.Chi(c2));
            Console.WriteLine(c3.get_radi());
            Console.WriteLine(c3.Chi(c2));
            c1.momo(c2, c3);
            Console.WriteLine(c1.get_radi());
        }
    }
}
