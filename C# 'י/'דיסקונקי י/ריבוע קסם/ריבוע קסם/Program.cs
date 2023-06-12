
using System;

namespace ריבוע_קסם
{
    class Program
    {
        public static int The_main_diagonal(int[,] arr)
        {
            //הפעולה מחזרה אתה סכום אלכסון הראשי
            int sum = 0;
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                sum += arr[i, i];
            }
            return sum;
        }
        public static int The_secondary_diagonal(int[,] arr)
        {
            //הפעולה מחזרה אתה סכום אלכסון המשני
            int sum=0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i+j==arr.GetLength(0)-1)
                    {
                        sum += arr[i, j];
                    }
                }
            }
            return sum;
        }


        public static bool Booling(int[,] arr)
        {
            //הפעולה מקבלת ערכים של מערך דו ממדי ומחזירה אמת אם מהווה ריבוע קסם ושקר אחרת
            int[] column = new int[arr.GetLength(1)];
            int[] lines = new int[arr.GetLength(0)];
            for (int i = 0; i <arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    column[j] += arr[i, j];
                    lines[i] += arr[i, j];    
                }
            }
            for (int i = 1; i < column.Length; i++)
            {
                if (column[i]!=column[i-1]|| lines[0]!=column[i]|| The_secondary_diagonal(arr)!= column[i]|| The_main_diagonal(arr)!=column[i])
                {
                    return false;
                }
            }
            for (int i = 1; i < lines.Length; i++)
            {
                if (lines[i] != lines[i - 1] || column[0] != lines[i] || The_secondary_diagonal(arr) != lines[i] || The_main_diagonal(arr) != lines[i])
                {
                    return false;
                }
            }
            return true;
        }


        static void Main(string[] args)
        {
            
            int[,] number = new int[4, 4];
            Random r = new Random();
            for (int i = 0; i < number.GetLength(0); i++)
            {
                for (int j = 0; j < number.GetLength(1); j++)
                {
                    number[i, j] = r.Next(10);
                }
            }
            
            Console.WriteLine(Booling(number));
        }
    }
}
