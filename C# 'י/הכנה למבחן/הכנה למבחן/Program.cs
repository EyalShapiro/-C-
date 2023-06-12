using System;
using System.Security.Cryptography.X509Certificates;

namespace הכנה_למבחן
{
    class Program
    {
        //ex1
        public static int Big_num(int[] arr)
        {
            //הפוקצה מקבלת מערחה ומחזר את המספר הגדול של לה
            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            return max;
        }

        //ex2
        public static int Number(int num)
        {
            //הפונקציה מכלת מספר ומחזירה אתה ספר שה יש החיה הרבה
            int max = 0, sav = 0;
            int[] number = new int[10];
            for (int i = 0; i < number.Length; i++)
            {
                number[i] = 0;
            }
            while (num > 0)
            {
                number[num % 10]++;
                num /= 10;
            }
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] > max)
                {
                    max = number[i];
                    sav = i;
                }
            }
            return sav;
        }
        //ex date
        public static int Date1(Date dat1, Date dat2)
        {
            int day1 = 0, day2 = 0, day = 0;
            day1 += (dat1.GetYear() * 365) + (dat1.GetMonth() * 30) + dat1.GetDay();
            day2 = (dat2.GetYear() * 365) + (dat2.GetMonth() * 30) + dat2.GetDay();
            day = Math.Abs(day1 - day2);
            return day;
        }
        //p55 ex30 'חלק ב
        public static bool Half_sorted(int[]arr)
        {
           //פונקציה מקבלת ומחירה נכון אםה המערך ממוין לחציה או לא נכון אם יש המערך אינו ממוין למחצה  
            int count = arr.Length;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i-1]<arr[i])
                {
                    count--;
                }
                if (arr.Length / 2 == count)
                    return true;
            }
           return false;
        }
        //p55 ex29 'חלק ב
        public static bool Booling(string[]str,int len)
        {
            //  אחרתfolse  $ אם יש במרעך שרשרת של  ture  הפונציה מקבלת מערך ואורך שרשרת ומחזירה  
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if ("$"==str[i])
                {
                    count++;
                }
            }
            return count == len;

        }
        //p55 ex28 'חלק ב
        public static int Sequence(int[]number)
        {
            int indx = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if (indx<number[i])
                {
                    indx = number[i];
                }
            }
            int[] sum = new int[indx+1];
            for (int i= 0; i < sum.Length; i++)
            {
                sum[i] = 0;
            }
            int max=0;
            for (int i = 0; i < number.Length; i++)
            {
                sum[number[i]]++;  
            };
            for (int i = 0; i < sum.Length; i++)
            {
                if (max<sum[i])
                {
                    max = sum[i];
                }
            }
            return max;

        }

        static void Main(string[] args)
        {

            //ex2
            /*
            Console.WriteLine("enetr num");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("num napm is :"+Number(num));
            */
            //ex1
            /*
            int[] arr = {2,9,31,144,1,200 };
            Console.WriteLine("big num: "+Big_num(arr));
            */
            // p63 ex38
            /*
            int[] skor = new int[50];
            for (int i = 0; i < skor.Length; i++)
            {
                skor[i] = 0;
            }
            int judge1;
            int[] judge = new int[3];
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < judge.Length; j++)
                {
                    judge[i] = 0;
                }
                for (int z = 0; z < judge.Length; z++)
                {
                    Console.WriteLine("enert skor"+z+1);
                    judge1 = int.Parse(Console.ReadLine());
                    judge[z] = judge1;
                }
                for (int y =0 ; y < judge.Length; y++)
                {
                    skor[judge[y] - 1] +=3-y;   
                }
                
            }
            int wonr = 0,sev=0;
            for (int i = 0; i < skor.Length; i++)
            {
                if (skor[i]>wonr)
                {
                    wonr = skor[i];
                    sev = i + 1;
                }
            }
            Console.WriteLine("winner: " + sev);
            */
            //תרגל מבגרות
            /*
            int[] arr = { 2, 9, 31, 144, 1, 200,7};
            int num=0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]%2==1)
                {
                    num = arr[i];
                }
            }
            Console.WriteLine(num);
            */
            //ex3
            /*
            int[] number = new int[100];
            Random r = new Random();
            int ran,max_rms=0,max_s=0;
            for (int i = 0; i < number.Length; i++)
            {
                ran = r.Next(0, 100);  
                number[i] = ran;
            }
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i]%2==0)
                {
                    max_rms++;
                    if (max_rms>max_s)
                    {
                        max_s = max_rms; 
                    }
                }
                else
                {
                    max_rms = 0;
                }
            }
            Console.WriteLine("max "+max_s);
            */
            // ex date
            /*
            Console.WriteLine("enter day month year ");        
            Date d1 = new Date(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            Console.WriteLine("enter year month day ");
            Date d2 = new Date(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            Console.WriteLine(Date1(d1,d2));
            */
            //ex33 p62 חלק ב
            /*
            int num;
            int[] number = new int[11];
            Random ran = new Random();
            for (int i = 0; i < 1000; i++)
            {
                num = ran.Next(1, 11);
                Console.WriteLine(num);
                number[num - 1]++;
            }

            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine(i +": "+number[i]);
            }
            */
            //p55 ex30 'חלק ב
            /*
            int[] arr = new int[6];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("enter num");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("half sorted :"+Half_sorted(arr));
            */
            //p55 ex29 'חלק ב
            /*
            string[] str = new string[4];
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine("enter string");
                str[i] = Console.ReadLine();
            }
            Console.WriteLine("enter len");
            int len=int.Parse(Console.ReadLine());
            Console.WriteLine(Booling(str,len));
            */
            //p55 ex28 'חלק ב
            /*
            int[] arr = new int[6];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("enter num");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("num big sequence :" + Sequence(arr));
            */
            //p46 ex13 'חלק ב
            /*
            Console.WriteLine("enter len");
            int len = int.Parse(Console.ReadLine());
            int[] number = new int[len];
            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine("enter num");
                number[i] = int.Parse(Console.ReadLine());

            }
            int idax = 1;
            while (number[idax] < number[idax - 1] && number.Length != idax + 1)
            {
                idax++;
            }
            if (idax + 1 == number.Length)
                Console.WriteLine("The numbers in the array are arranged in series");
            else
                Console.WriteLine("The numbers in the array are not arranged in series");
            */
            //p45ex12 'חלק ב
            /*
            Console.WriteLine("enter len");
            int len = int.Parse(Console.ReadLine());
            int[] number = new int[len];
            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine("enter num");
                number[i] = int.Parse(Console.ReadLine());
                
            }
            int idax = 1;
            while (number[idax] == number[idax-1]&&number.Length!=idax+1)
            {
                idax++;
            }
            if (idax+1==number.Length)
                Console.WriteLine("All organs in the array are equal to each other");
            else
                Console.WriteLine("All the organs in the array are not equal to each other");
            */




        }

    }
}
