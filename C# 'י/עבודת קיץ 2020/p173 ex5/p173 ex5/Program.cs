using System;

namespace p173_ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            //p173_ex5
            Cube[] cub= new Cube [(2, "rad"),(2,"y")];
            CubesTower c = new CubesTower(5, 2, cub)  ;
            Console.WriteLine("enetr -1 '+'Cube enetr '-'Cube  enter 0  to dan");
            int num =int.Parse( Console.ReadLine());
            while (num!=0 && c.Maximum_occupancy()== false)
            {
                if (num!=-1&&num!=-2)
                {
                    Console.WriteLine("num not good");
                }
                if (num==-1)
                {
                    c.SetNum_containing(c.GetNum_containing()+1);
                }
                if (num==-2)
                {
                    c.SetNum_containing(c.GetNum_containing() - 1);
                }
                num = int.Parse(Console.ReadLine());
            }
            if (c.Maximum_occupancy() == false)
            {
                Console.WriteLine("not in to mara");
            }
            Console.WriteLine(c.CubesTower_color());
        }
    }
}
