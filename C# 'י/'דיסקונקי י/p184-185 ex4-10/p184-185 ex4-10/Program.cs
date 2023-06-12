using System;

namespace p184_185_ex4_10
{
    class Program
    {
        //p184 ex4

        public static int Dig(int num, int dig)
        {
            //הפועלה מקבלת מספר שלם 
            int cont = 0;
            while (num > 0)
            {
                if (num % 10 == dig)
                {
                    cont++;
                }
                num = num / 10;
            }
            return cont;
        }

        //p184 ex5
        public static int Rand(int num, int num2)
        {
            //פעולה מקבלת 2 מםפרים ,הפעולה תחזיר מםפר אקראי
            Random randNum = new Random();
            int ran;
            ran = randNum.Next(Math.Min(num, num2), Math.Max(num + 1, num2 + 1));
            return ran;
        }
        //p184 ex6
        public static int Numer(int num)
        {
            //פעולה מקבלת מספר ומחזירה מספר ספרותיו הזוגיות
            int conut = 0;
            while (num > 0)
            {
                if (num % 2 == 0)
                {
                    conut++;
                }
                num = num / 10;
            }
            return conut;
        }
        //p184 ex7
        public static int Items(int num_People, int capacity)
        {
            //הפעולה מקבלת מספר אנשים ותפוסה ,מחזירה את מספר היחדות הדרושות לכלל האנשים 
            int conut = 0;
            while (num_People > 0)
            {
                conut++;
                num_People = num_People - capacity;
            }
            return conut;
        }
        //p184 ex8
        public static int Nume(int num, int num2)
        {
            //הפעולה מקבלת 2 מפרים שלים ומחזירה את חלק המשותף המשותף הקטן ביותר
            for (int i = 2; i <Math.Min(num,num2) ; i++)
            {
                if (num%i==0&&num2%i==0)
                {
                    return i ;
                }
            }
            return -1;
        }
        //p185 ex9
        public static bool Tav(char tav)
        {
            //הפעולה מקבלת תו ומחזרה אם אות מה abc
            if (tav >= 'a' && tav <= 'z' || tav >= 'A' && tav <= 'Z')
            {
                return true;
            }
            return false;
        }     
        static void Main(string[] args)
        {

            /*
            //p184 ex4
            Console.WriteLine("enter num");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("enter num dig");
            int dig = int.Parse(Console.ReadLine());
            Console.WriteLine(Dig(num,dig));
            */
            /*
            //p184 ex5  
            Random randNum = new Random();
            int num, num2;
            Console.WriteLine("enter num");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("enter num");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter -999 ");
            while (num!=-999&&num2!=-999)
            {
                for (int i = 1; i <= 5; i++)
                    Console.WriteLine(Rand(num, num2));
                Console.WriteLine("enter num");
                num = int.Parse(Console.ReadLine());
                Console.WriteLine("enter num");
                num2 = int.Parse(Console.ReadLine());            
            }
            */
            /*
            //p184 ex6
            int num, max = 0,n;
            Console.WriteLine("enter num the for");
            n = int.Parse(Console.ReadLine());           
            for (int i = 0; i <n ; i++)
            {
                Console.WriteLine("enter num");
                num = int.Parse(Console.ReadLine());
                if (Numer(max)<Numer(num))
                {
                    max = num;
                }
            }
            Console.WriteLine("even:"+Numer(max));
            Console.WriteLine("max num: "+max);
            */
            /*
            //p184 ex7
            int num, bes_capacity,capacity, capacity2;
            Console.WriteLine("enter num People");
            num = int.Parse(Console.ReadLine());            
            Console.WriteLine("enter num capacity bes");
            bes_capacity = int.Parse(Console.ReadLine());
            Console.WriteLine("num: "+Items(num,bes_capacity));
            Console.WriteLine("enter num capacity car");
            capacity = int.Parse(Console.ReadLine());
            Console.WriteLine("num: "+Items(num, capacity));
            Console.WriteLine("enter num capacity ");
            capacity2 = int.Parse(Console.ReadLine());
            Console.WriteLine("num: "+Items(num,capacity2));
            */
            /*
            //p184 ex8
            int num, num2;
            for (int i = 0; i <4 ; i++)
            {
                Console.WriteLine("enter num ");
                num = int.Parse(Console.ReadLine());
                Console.WriteLine("enter num ");
                num2 = int.Parse(Console.ReadLine());
                if (Nume(num,num2)==-1)
                {
                    Console.WriteLine("num "+num+" , "+num2);                   
                }
                else
                {
                    Console.WriteLine(Nume(num, num2));
                }
            }
            */
            //p185 ex9
            /*
            char str;           
            int contr = 0;            
            for (int i = 1; i <=20 ; i++)
            {
                Console.WriteLine("enter str ");
                str = char.Parse(Console.ReadLine());                                               
                    if (Tav(str)==true)                    
                        contr++;
                                    
                
            }
                Console.WriteLine(contr);
            */


            /*
            //p185 ex10
            int man=0 ,num,sum=0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("enter num stdn");
                num = int.Parse(Console.ReadLine());
                if (num>=10)
                {
                    man = 180;
                    man =man+((num-10)*5);
                }
                sum += man;
                Console.WriteLine(man);
            }
            Console.WriteLine("sum: "+sum/3);
            */
            

        }
    }
}
