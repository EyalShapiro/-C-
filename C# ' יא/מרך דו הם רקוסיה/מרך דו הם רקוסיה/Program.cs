using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace מרך_דו_הם_רקוסיה
{
    class Program
    {
        //לא נכון
        public static bool CheckeringLine_1(int[,] arr , int i,int len_line)//הפעולה מקבלת מרך דו ממדי ומקום ואת גודל השורה
        {//הפעולה מחזרה אמת הם אינה 1 שורש ושקר הם 1 מופיה בשורה
     
            if (arr[i,len_line-1]==1)
            {
                return true;
            }
            if (i==arr.GetLength(0))
            {
                return false;
            }
            return CheckeringLine_1(arr,i+1,len_line);

        }
        public static bool CheckeringQueue_1(int[,] arr, int i,int len_Queue)//הפעולה מקבלת מרך דו ממדי ומקום ואת גודל המודה
        {//הפעולה מחזרה אמת הם אינה 1 תור ושקר הם 1 מופיה בתור

            if (arr[len_Queue-1, i] == 1)
            {
                return true;
            }
            if (i == arr.GetLength(1))
            {
                return false;
            }
            return CheckeringQueue_1(arr, i+1,len_Queue) ;

        }
        public static int Checks_sequence (int[,] arr ,int n,int m,int i)
        {//הפועל מקבלת מרך דו ממדי ,גודל שורה ,גודל מועודה ומיקום ומחזרה הם יש רצף 1
            if (n == 2 && m == 2 && arr[1, 1] == 1 && arr[0, 0] == 1)
            {
                return 1;
            }
            else
                return Checks_sequence(arr, n-1, m-1, i);
        }
        public static int Checks_sequence(int[,] arr,int i)
        {//הפועל מקבלת מרך דו ממדי ומחזרה הם יש רצף 1
            if (Checks_sequence(arr, arr.GetLength(0), arr.GetLength(1),i) == 1)
            {
                return 1;
            }

            if(CheckeringLine_1(arr, 0, arr.GetLength(0)-1) ==false&& CheckeringQueue_1(arr, 0, arr.GetLength(1)-1) == false)
                return 0;
            return Checks_sequence(arr, arr.GetLength(0), arr.GetLength(1),0); 
        }
       
        static void Main(string[] args)
        {
            Console.WriteLine("enter num ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("enter num ");
            int n = int.Parse(Console.ReadLine());
            Random r = new Random();
            int[,] arr = new int[m, n];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                { 
                    arr[i, j] = r.Next(0, 2);
                }
                
            }
            Console.WriteLine(Checks_sequence(arr,0));
            
        }
    }
}
