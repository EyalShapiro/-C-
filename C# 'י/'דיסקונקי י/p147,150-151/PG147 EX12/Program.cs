using System;

namespace p147_150_151
{
    class Program
    {
        static void Main(string[] args)
        {
            //p147 ex12
            /*
            int time, money, sum_money = 0, contr = 0;
            Console.WriteLine("enter the num time");
            time = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the num money per hour");
            money = int.Parse(Console.ReadLine());
            money+=time;
            while (time == -999 && money == -999)
            {
                money+=time;
                contr++;
                if (time >= 150)
                {
                    money += 150;
                }
                sum_money += money;
                Console.WriteLine("enter the num time");
                time = int.Parse(Console.ReadLine());
                Console.WriteLine("enter the num money per hour");
                money = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum_money);
            Console.WriteLine(sum_money / contr);
             */
            //p151 ex20
            /*
            int area, area_guy=0, money=0;
            while (area_guy<200)
            {
                money += 30;
                Console.WriteLine("enter the num a area");
                area = int.Parse(Console.ReadLine());


                area_guy += area;
            }
            Console.WriteLine(money);
            */
            //p151 ex22
            /*
            int num, num2,sum=0,max=0;
            Console.WriteLine("enter the num ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the num ");
            num2 = int.Parse(Console.ReadLine());
            sum = num + num2;
            while (num2%2==num%2)
            {
                if (sum>max)
                {
                    max = num + num2;
                }
                Console.WriteLine("enter the num ");
                num = int.Parse(Console.ReadLine());
                Console.WriteLine("enter the num ");
                num2 = int.Parse(Console.ReadLine());           
            }
            Console.WriteLine("max num"+max);
            */
            //p151 ex23
            /*
            int num,sum=0;
            Console.WriteLine("enter the num ");
            num = int.Parse(Console.ReadLine());
            while(num>0)
            {
                sum *= 10;
                sum += (num % 10); 
                num = num / 10;
            }
            Console.WriteLine(sum);
            */
            //p157 ex32
            /*
            char note, Name;
            int contr=1;
            Console.WriteLine("enter the The first letter of a name ");
            Name = char.Parse(Console.ReadLine());
            Console.WriteLine("enter the note ");
            note = char.Parse(Console.ReadLine());
            while (note!=Name)
            {
                contr++;

                Console.WriteLine("enter the note ");
                note = char.Parse(Console.ReadLine());
            }
            Console.WriteLine(contr);
            */
            //p157 ex33
            /*
            double num,num2;
            int contr = 0;
            Console.WriteLine("enter num ");
            num = double.Parse(Console.ReadLine());
            Console.WriteLine("enter num ");
            num2 = double.Parse(Console.ReadLine());
            while (num>0)
            {
                if (num<num2)
                {
                    contr++;
                }

                num2 = num;
                Console.WriteLine("enter the num ");
                num = double.Parse(Console.ReadLine());
            }
            Console.WriteLine(contr); 
            */
            //p158 ex34
            /*
            int num,sum=0,num2,contr=0;
            Console.WriteLine("enter the num ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the num 1 ");
            num2 = int.Parse(Console.ReadLine());
            sum = num;
            while (sum>0)
            {
                if (sum % 10 == num2)
                {
                    contr++;
                }

                sum = sum / 10;
            }
            if (contr>0)
            {
                num = num * 10 + num2;
            }
            Console.WriteLine(num);
            */
            //p158 ex35
            /*
            int num, num2,contr=0;
            Console.WriteLine("enter the num ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the num ");
            num2 = int.Parse(Console.ReadLine());
            while (num>9&&num<100&&num2>9&&num2<100)
            {
                if (num%10==num2/10&&num/10==num2%10||num2%10==num/10&&num2/10==num%10)
                {
                    Console.WriteLine("Similar pairs");
                    contr++;
                }
                else
                {
                    Console.WriteLine("not Similar pairs");
                }



                Console.WriteLine("enter the num ");
                num = int.Parse(Console.ReadLine());
                Console.WriteLine("enter the num ");
                num2 = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(contr);
            */
            //p158 ex36
            int num,  num2= 0, contr = 0;
            Console.WriteLine("enter the num ");
            num = int.Parse(Console.ReadLine());
            while (num>0)
            {

                if (num > num2)
                {
                    contr++;
                }
                else
                {
                    contr = 0;
                }
               num2 = num;
                Console.WriteLine("enter the num ");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(contr);



        }
    }
}
