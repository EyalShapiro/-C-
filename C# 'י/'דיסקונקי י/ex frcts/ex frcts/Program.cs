using System;

namespace ex_frcts
{
    class Program
    {
        static void Main(string[] args)
        {
            /* p 118 ex14
            Random randNum = new Random();
            int num,num2;
            Console.WriteLine("enter numbr");
            num=int.Parse(Console.ReadLine());
            for(int i=0;i<30;i++)
            {
                num2=randNum.Next(10, 21);
                if (Math.Abs(num-num2)<=4)
                {
                    Console.WriteLine(num2);
                }
            }
            */
            /* p 106 ex8 
            int num,num2,num3,num4,num5;
            Console.WriteLine("enter numbr");
            num= int.Parse(Console.ReadLine());
            num2 =(int)Math.Pow(num % 10,3);
            num3 =(int)Math.Pow(num / 10 % 10, 3);
            num4 = (int)Math.Pow(num /100, 3);
            num5 = num2 + num3 + num4;
            if(num==num5)
                Console.WriteLine("numbr triangle");
            */
            /* p 106 ex 5
            Random randNum = new Random();
            double n1,n2,n3;
            n1 = randNum.NextDouble();
            n2 =randNum.NextDouble();
            n3 =randNum.NextDouble();
            Console.WriteLine(n1+n2+n3);
            */
        }
    }
}
