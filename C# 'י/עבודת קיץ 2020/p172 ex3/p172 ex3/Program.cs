using System;

namespace p172_ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            //p172 ex3
            Trarin t = new Trarin(new Engine(5, 1900), 5, 4);
            Engine e = new Engine(4, 1950);
            t.SetEngine(e);
            Carriage c=new Carriage(5,100,50)
            t.Carriage_pls(c);
            Console.WriteLine(t.Max());
            Console.WriteLine(t.Avg_Expriments());
        }
    }
}
