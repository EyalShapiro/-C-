using System;
using System.Security.Cryptography.X509Certificates;

namespace הכנה_למבחן
{
    class Program
    {
        //ex1
        public static int Big_num(int[]arr)
        {
            //הפוקצה מקבלת מערחה ומחזר את המספר הגדול של לה
            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (max<arr[i])
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
            int max=0,sav=0;
            int[] number = new int[10];
            for (int i = 0; i < number.Length; i++)
            {
                number[i] = 0;
            }
            while (num>0)
            {
                number[num % 10]++;
                num /= 10;
            }
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i]>max)
                {
                    max = number[i];
                    sav = i;
                }
            }
            return sav;
        }

        static void Main(string[] args)
        {
            //ex1
            /*
            int[] arr = {2,9,31,144,1,200 };
            Console.WriteLine("big num: "+Big_num(arr));
            */
            //ex 3
            /*
            Console.WriteLine("enetr num");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("num napm is :"+Number(num));
            */



        }
    }
}
