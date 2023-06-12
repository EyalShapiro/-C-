using System;

namespace p137_138
{
    class Program
    {
        static void Main(string[] args)
        {
            //ex47
            /*
            int num,sum=0;
            Console.WriteLine("enter a num");
            num = int.Parse(Console.ReadLine());
            for (int i = 2; i <=num; i=+2)
            {
                    Console.WriteLine(i);
                    sum = sum + i;
                  
            }
              Console.WriteLine(sum);
            */

            //ex48
            /*
            int num;
            int sum = 0;
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("enter a three digit num");
                num = int.Parse(Console.ReadLine());
                if (num%10==num/100||num%10==(num/10)%10||(num/10)%10==num/100)
                {
                    Console.WriteLine(num);
                    sum++;
                }
            }
            Console.WriteLine(sum);
            */
            //ex49
            /*
            int num,num2,num3,num4,sum;
            Console.WriteLine("enter a three digit num");
            num = int.Parse(Console.ReadLine());
            num2 = num % 10;
            num3 = (num / 10)%10;
            num4 = num / 100;
            sum = num2 + num3 + num4;
            if (num%sum==0)
            {
                Console.WriteLine(num);
            }
            */
            //ex50
            /*
            int num,sum=0;
            Console.WriteLine("enter a  num");
            num = int.Parse(Console.ReadLine());
            for (int i = 1; i <=num; i++)
            {
                sum =i + sum;
            }
            Console.WriteLine(sum);
            */
            //ex51
            /*
            int sum=0, money, Notebooks;
            Console.WriteLine("enter a of money Notebooks");
            money = int.Parse(Console.ReadLine());
            for (int i =1; i <=10; i++)
            {
                Console.WriteLine("enter a  num");
                Notebooks = int.Parse(Console.ReadLine());
                sum = sum + Notebooks;

            }
            Console.WriteLine(sum);
            Console.WriteLine(sum+money);
            */
            //ex52
            /*
            int num,num2,num3;
            Console.WriteLine("enter a four digit num");
            num = int.Parse(Console.ReadLine());
            num2 = num / 100;
            num3 = num % 100;
            if (num2==num3)
            {
                Console.WriteLine(num2+"="+num3);
            }
            */
            //ex53
            /*
            int Licen,num, average = 0;       
            for (int i = 1; i <= 40; i++)
            {
                Console.WriteLine("enter a Licensing number");
                Licen = int.Parse(Console.ReadLine());
                Console.WriteLine("enter a number Time in seconds");
                num = int.Parse(Console.ReadLine());
                if (num>300)
                {
                    Console.WriteLine("You do not go to the final stage");
                }
                else if (num<240)
                {
                    Console.WriteLine(Licen);
                }
                average = average + num;
            }
            Console.WriteLine("average:" + average/40);
            */
            //ex54
            /*
            int num,n,sum=0, average=0,sum8=0,sum9=0,sum10=0;
            Console.WriteLine("enter a number ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Random randNum = new Random();
                num = randNum.Next(8, 10);
                average = average + num;
                if (num==8)
                {
                    sum8++;
                }
                else if (num == 9)
                {
                    sum9++;
                }
                else if (num == 10)
                {
                    sum10++;
                }
                if (num>sum)
                {
                    sum = num;
                }
            }
            if(sum10>sum8&&sum10>sum9)
                Console.WriteLine("10");
            else if(sum9 > sum8 && sum9 > sum10)
                Console.WriteLine("9");
            else if (sum8 > sum9 && sum8 > sum10)
                Console.WriteLine("8");
            Console.WriteLine("average:" + average / n);
            */








            //ex55
            int n,num,num2, average=0,sum=1000000000,cont=0;
            Console.WriteLine("enter a number ");
            n = int.Parse(Console.ReadLine());
            if (n%2!=0)
            {
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine("enter a number ");
                    num = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter a number ");
                    num2 = int.Parse(Console.ReadLine());
                    average = num + num2+ average;
                    cont = Math.Abs(num - num2);
                    if (cont < sum)
                    {
                        sum = cont;
                    }
                }
                Console.WriteLine("average:" + average / n);
                Console.WriteLine("sum:"+cont);
                Console.ReadKey(); 

                

            }
        }
    }
}
