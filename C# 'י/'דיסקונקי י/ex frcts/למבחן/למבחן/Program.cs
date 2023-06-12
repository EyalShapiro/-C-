using System;

namespace למבחן
{
    class Program
    {
        static void Main(string[] args)
        {
            //ex3 
            Random rud = new Random();
            int num , max= 0,num2;
            num = rud.Next(1, 100);
            for (int i = 1; i < 100; i++)
            {
                num2 = num;
                num = rud.Next(1, 100);
                if (Math.Abs(num - num2) > max)
                {
                    max = Math.Abs(num - num2);
                }
            }
            Console.WriteLine(max);





        }
    }
}
