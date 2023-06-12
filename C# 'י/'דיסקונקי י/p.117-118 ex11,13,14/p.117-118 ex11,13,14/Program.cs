using System;

namespace p._117_118_ex11_13_14
{
    class Program
    {
        static void Main(string[] args)
        {
            /* p117 ex11
            int num,num2,num3,num4;
            for (int i = 0; i<50; i++)
            {
                Console.WriteLine("enter numbr");
                num = int.Parse(Console.ReadLine());
                num2 = num % 10;
                num3 = num / 10 % 10;
                num4 = num / 100;
                if(num2!=num3&&num2!=num4&&num3!=num4)
                {
                    Console.WriteLine(num);
                }
                */
            /* p117 ex12  
            int num, num2, num3;
            for (int i = 0; i < 25; i++)
            {
               num = int.Parse(Console.ReadLine());
               num2 = num % 10;
               num3 = num / 10;
               if (num2 % 2 == 0 && num3 % 2 == 0)
                    Console.WriteLine("everyone");
               else if (num2 % 2 != 0 && num3 % 2 != 0)
                    Console.WriteLine("not everyone");
               else
                   Console.WriteLine("1-everyone ,1-not everyone");
               }
           */
           
            
        }
    }
}
