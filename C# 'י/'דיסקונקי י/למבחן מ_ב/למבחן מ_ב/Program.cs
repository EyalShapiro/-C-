using System;

namespace couple
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //couple
            int num, num2, num3, num4;
            num = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());
            num4 = int.Parse(Console.ReadLine());
            Couple co1 = new Couple(num, num2);
            Couple co2 = new Couple(num3, num4);
            if(num+ num2> num3 + num4)
            {
                Console.WriteLine(co1.ToString());
            }
            if (num + num2 < num3 + num4)
            {
                Console.WriteLine(co2.ToString());
            }
             */
            /*
           //couple
           int conutr = 0;
           Console.WriteLine("enter num's");

           Couple co1 = new Couple(int.Parse(Console.ReadLine()),int.Parse(Console.ReadLine()));
           if (co1.GetNum1() < co1.GetNum2())
           {
               Console.WriteLine("big num :" + co1.GetNum2());
               Console.WriteLine("Little num :" + co1.GetNum1());
           for (int i = co1.GetNum1(); i < co1.GetNum2(); i++)
           {
                   conutr++;
           }
           }

           if (co1.GetNum1()>co1.GetNum2())
           {
               Console.WriteLine("big num :" + co1.GetNum1());
               Console.WriteLine("Little num :" + co1.GetNum2());
               for (int i = co1.GetNum2(); i <co1.GetNum1() ; i++)
               {
                   conutr++;
               }
           }
           Console.WriteLine(conutr);
            */
            /*
           //p165 ex2
           int grade, sum= 0, Fail=0;
           for (int i = 1; i <= 10; i++)
           {
               for (int  g = 1; g <= 6; g++)
               {
                   Console.WriteLine("enetr your grade");
                   grade = int.Parse(Console.ReadLine());
                   sum += grade;
                   if (grade <= 55)
                   {
                       Fail++;    
                   }
               }
               Console.WriteLine("sum :"+sum%6);
           }
           Console.WriteLine("Fail: "+Fail);
           */
            /*
            //p1168 ex15 
             int contr = 0, num, contr_num = 1;
             double num2 = 2;
             for (int i = 1; i <= 30; i++)
             {
                 contr_num = 1;
                 num2 = 2;
                 Console.WriteLine("enter num ");
                 num = int.Parse(Console.ReadLine());
                 while (num % num2 != 0)
                 {
                     contr_num++;
                     num2++;
                 }
                 if (contr_num + 1 == num)
                 {
                     contr++;
                 }
             }
             Console.WriteLine("contr: " + contr);
             */
            /*
            //p167 ex13            
            int num,min_num=900;                    
            Console.WriteLine("enter num ");
            num = int.Parse(Console.ReadLine());
            while (100 <= num && num < 1000)
            {

                while(num>0)
                {                 
                    Console.WriteLine("enter num ");
                    num = int.Parse(Console.ReadLine());
                    if (num%10<min_num)
                    {
                        min_num = num % 10;
                     
                    }
                    num = num / 10;
                }
                Console.WriteLine("min num: "+min_num);                     
            }
           */
           /*
            //ex4 בדף
            Random randNum = new Random();
            int max=0,num,before_num;
            before_num = randNum.Next(1, 100);
            Console.WriteLine(before_num);
            for (int i = 1; i <100; i++)
            {
                num = randNum.Next(1, 100);
                if (Math.Abs(num-before_num)>max)
                {
                    max = Math.Abs(num - before_num);
                }
            }
            Console.WriteLine("max :"+max);
            */






        }
    }
}