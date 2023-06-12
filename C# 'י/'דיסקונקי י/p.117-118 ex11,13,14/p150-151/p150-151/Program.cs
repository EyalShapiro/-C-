using System;

namespace p150_151
{
    class Program
    {
        static void Main(string[] args)
        {
            //p150  ex 15
            int num = 0, contr = 0,sum=0,sum2=1;
            Console.WriteLine("enter numbr");
            num=int.Parse(Console.ReadLine());
            while (num!=0)
            {
                contr++;
                sum += num % 10;
                num=num / 10;
                if(sum2!=0)
                    sum2=sum2*(num % 10);
               
            }
            Console.WriteLine(contr);
            Console.WriteLine(sum);
            Console.WriteLine(sum2);
        }
    }
}
