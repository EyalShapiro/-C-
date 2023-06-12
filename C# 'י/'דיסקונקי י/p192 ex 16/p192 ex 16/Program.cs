using System;

namespace p192_ex_16
{
    class Program
    {
        /*
        public static int Num(int num)
        {
            int num=0
            while (num)
            {
                sum += num % 10;
                num = num / 10;

            }
         }
            return sum;
            public static int Num2(int num)
            {
                sum = 0; ;
                for (int i = 0; i < num; i++)
                {
                    if (Num(num)==Num(i))
                    {
                        Console.WriteLine(i);
                        sum += i;
                    }

                }
                return sum;
            }
            */

        public static int Dig(int num,int dig)
        {
            int count = 0;
            bool found= false; 
            while (num>0)
            {
                if (dig ==num%10)
                {
                    Console.WriteLine(count);
                }
                num = num / 10;
                count++;
                if (!found)
                {
                    Console.WriteLine(0);
                }
            }

        }

        static void Main(string[] args)
        {
            /*
            Console.WriteLine("entr num");
            int num = int.Parse(Console.ReadLine());
            Num2(num)
           */

            Dig(1554, 5);




        }




    }
}
