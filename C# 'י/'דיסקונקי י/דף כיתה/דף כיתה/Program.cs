using System;

namespace דף_כיתה
{
    class Program
    {
        public static void Ex1(int[,] arr)
            {
            //הפעולה מדיפסה לפי טבלה
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i,j] +" ");
                }
                Console.WriteLine();
            }
        }
        public static int Ex2(int[,] arr, int lines)
        {
            //הפעןלה מחזר את הרחה הגדול  בשורה
            int max = 0;
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                if (max < arr[lines, i])
                {
                    max = arr[lines, i];
                }
            }
            return max;
        }
        public static int Ex3(int[,] arr, int column)
        {
            //הפעולה מחזרה את ממוצה אורים
            int sum=0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                sum += arr[i, column];
            }
            return sum / arr.GetLength(0);
        }
        public static int Ex4(int[,] arr)
        {
            //הפעולה מחזרה אתה סכום אלכסון הראשי
            int sum=0;
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                sum += arr[i, i];
            }
            return sum;
        }
        public static bool Ex5(int[,] arr, int lines)
        {
            //הפעולה מקבלת מערך דו ממדי ושורה ומחזירה אתה אמת הם שורה מוינת בסדר עולה ושקר אחרת
            for (int i = 1; i < arr.GetLength(1); i++)
            {
                if (arr[lines, i-1] > arr[lines, i])
                {
                    return false;
                }
            }
            return true;

        }
        public static bool Ex6(int[,] arr)
        {
            //הפעולה מקבלת מערך דו ממדי ומחזירה במדה כולה שורות משודרת בשדרה עלוה אמת ןשקר הם לא
            int latest = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {  
                    if (Ex5(arr,i)== false||latest>arr[i,0])
                    {
                        return false;
                    }
                latest =arr[i, arr.GetLength(0) - 1];
            }
            return true;
        }
        static void Main(string[] args)
        {
            
            int[,] number = new int[5, 5];
            Random r = new Random();
            for (int i = 0; i<number.GetLength(0); i++)
		    {
                for (int j = 0; j<number.GetLength(1); j++)
			    {
                    number[i, j] = r.Next(101);
                }
		    }
            Console.WriteLine("ex1");
            Ex1(number);
            Console.WriteLine("ex2  "+Ex2(number, 4));
            Console.WriteLine("ex3  "+Ex3(number, 4));
            Console.WriteLine("ex4  "+Ex4(number));
            Console.WriteLine("ex5  " +Ex5(number, 4));
            Console.WriteLine("ex6  " +Ex6(number));
        }
    }
}
