using System;

namespace קלתה_בפעולה
{
    class Program
    {
        //ex2
        public static bool Dig_Positive(int num)
        {
        //פעולה המקבלת מספר ובודקת אם כל ספרותיו זוגיות

                while (num%2==0&&num!=0)
            {
                num = num/10;
            }
            return (num==0);
        }
        public static int Aver()
        {
            // פעולה הקולטת סידרה של מספרים שלמים חיוביים עד למספר שלילי  
            int count = 0, sum = 0, num;
            Console.WriteLine("enter  num");
            num = int.Parse(Console.ReadLine());
            while (num>0)
            {
                if (Dig_Positive(num)==true)
                {
                    sum+=num;
                    count++;
                }
                Console.WriteLine("enter  num");
                num = int.Parse(Console.ReadLine());
            }
            return sum / count;
        }
        //ex3 
        //פעולה מקבלת מספר שלם ומחזירה את מספר ספרותיו 
        public static int Num(int num)
        {
            int count = 0;
            while (num>0)
            {
                count++;
                num = num / 10;
            }
            return count;

        }
        //פעולה מקבלת מספר ומחזירה את המספר לאחר הפעולה סיבוב ימינה
        public static int Turn_right(int num)
        {
            int dig = 0;
            dig=num % 10;
            for (int i = 1; i <Num(num); i++)
            {
                dig *= 10;
            }
            num /= 10;
            num += dig;
            return num;
        }
        //ex4
        //פעולה בוליאנית המקבלת מספר טבעי כלשהו ומחזירה אמת אם המספר הוא משוכלל ושקר בכל מקרה אחר
        public static bool Natural_4(int num)
        {
            int sum = 0;
            for(int i = 1; i<num;i++)
            {
                if (num%i==0)
                {
                    sum += i;
                } 
            }

            return num==sum; 
        }
        //ex5 
        //פעולה המקבלת מספר טבעי ומחזירה את סכום מחלקיו של המספר 
        public static int Natural_5(int num)
        {
                int sum = 0;            
                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        sum += i;
                    }
                }
            return sum;
        }
        // הפעולה בדכת הם החבר שלו מבין המספרים הטבעיים הקטנים מ-1000
        public static void Member_num(int num)
        {
            int friend=-1;
            for (int i = 1; i < 1000; i++)
            {
                if (Natural_5(num) == Natural_5(i) && num != i)
                {
                    friend = i;
                    Console.WriteLine(i);
                }
            }
            if(friend==-1)
                Console.WriteLine("not num Friend");
        }
        // פעולה בוליאנית המקבלת שני מספרים טבעיים ומחזירה אמת אם שני המספרים הם מספרים חברים
        public static bool Member_two(int num, int num2)
        {
            return (Natural_5(num) == Natural_5(num2));
        }
        //ex6   
        public static int Cancel(int num,int pos)
        {
            int new_num=0,dig,lec=1,num2=num;
            if (Num(num2)<pos)
            {
                return 0; 
            }
            for (int i = 1; i <= Num(num2); i++)
            {
                if (i == pos)
                {
                    num /= 10;
                }
                else
                {
                    dig = num%10;
                    dig *= lec;
                    lec *= 10;
                    new_num += dig;
                    num /= 10;
                }
            }
            return new_num;
        }
        static void Main(string[] args)
        {
            //ex2
            /*
            int num;
            Console.WriteLine("enter num");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine(Dig_Positive(num));
            Console.WriteLine(Aver());
            */


            //ex3
            /*
            int num;
            Console.WriteLine("enter num");
            num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= Num(num); i++)
            {
               num=Turn_right(num);
                Console.WriteLine(num);
            }
            */
            //ex4
            /*
            int num;
            Console.WriteLine("enter num");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine(Natural_4(num));
            */
            //ex5
            /*
            int num,num2;
            Console.WriteLine("enter num ");
            num = int.Parse(Console.ReadLine());     
            Member_num(num);
            Console.WriteLine("enter num ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(Member_two(num,num2));
            */
            //ex6
            int num, pos;
            Console.WriteLine("enter num ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("enter pos ");
            pos = int.Parse(Console.ReadLine());
            Console.WriteLine(Cancel(num,pos));
            
        }
    }
}
