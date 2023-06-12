using System;

namespace p43_ex3
{
    class Program
    {
        public static void Bloo(int[] Numbr)
        {
            Numbr[0] = 0;
            Console.WriteLine("#"+Numbr[0]);
            double count = 0,avg=0;
            for (int i = 0; i < Numbr.Length; i++)
            {
                count += Numbr[i];
            }
            avg=count/Numbr.Length;
            for (int i = 0; i < Numbr.Length; i++)
            {
                if (avg>Numbr[i])
                {
                    Console.WriteLine(Numbr[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            /*
            //p43 ex3
            int num;
            int[] number = new int[6];
            Console.WriteLine();
            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine("enter num");
                num = int.Parse(Console.ReadLine());
                number[i] = num;
            }
            Console.WriteLine();
            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine(number[i]);
                
            }
            Console.WriteLine();
            for (int i = number.Length-1; i!=0  ; i--)
            {
                Console.WriteLine(number[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < number.Length; i+=2)
            {
                Console.WriteLine(number[i]);
            }
            Console.WriteLine();
            for (int i = 1; i < number.Length; i+=2)
            {
                Console.WriteLine(number[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i]%2==1)
                {
                    Console.WriteLine(number[i]);
                }
                
            }
            */
            //תרגול מערךֳ
            int num,numr;
            Console.WriteLine("enter num  ");
            numr = int.Parse(Console.ReadLine());
            int[] number = new int[numr];
            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine("enter num");
                num = int.Parse(Console.ReadLine());
                number[i] = num;
            }
            Bloo(number);
            Console.WriteLine("!"+ number[0]);

        }
    }
}
