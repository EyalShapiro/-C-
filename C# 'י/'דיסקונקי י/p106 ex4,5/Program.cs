using System;

namespace p106_ex4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ex4
            int num, num2,sum;
            Console.WriteLine("nubr ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("nubr ");
            num2 = int.Parse(Console.ReadLine());
            sum = num * num + num2 * num2;
            Console.WriteLine(Math.Sqrt(sum));
            */
            double n1, n2, n3,sum;
            Random randNum = new Random();
            n1 =randNum.Next(0, 1);
            Random randNum = new Random();
            n2 = randNum.Next(0, 1);
            Random randNum = new Random();
            n3 = randNum.Next(0, 1);
            sum = n1 + n2 + n3;
            Console.WriteLine(sum/3);


        }
    }
}
