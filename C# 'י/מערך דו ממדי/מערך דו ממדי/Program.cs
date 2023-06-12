using System;

namespace מערך_דו_ממדי
{
    class Program
    {
        public static int Sum (int[,] arr )
        {
            //מחזרה אתה סכום של כל מערך
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int s = 0; s < arr.GetLength(1); s++)
                {
                    sum += arr[i, s];
                }
            }
            return sum;    
        }
        public static void Sum_Row(int[,] arr)
        {
            //מחזירה לפי שדר אתה שורת 
            int sum;
            for (int i = 0; i <arr.GetLength(0); i++)
            {
                sum = 0;
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sum += arr[i, j];
                }
                Console.WriteLine(i+1+": "+sum);
            } 
        }
        public static int Sum_Row_Max(int[,] arr)
        {
            // מחזירה  אתה גדול שורת 
            int sum=0,max=0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                sum = 0;
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sum += arr[i, j];
                }
                if (max<sum)
                {
                    max = sum;
                }
            }
            return max;
        }
        public static void Strg(char[,]arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i,j]);
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            // שורות וזה המודות
            /*
            int num;
            Random r=new Random() ;
            int[,] arr = new int[3,3];
            for (int i = 0; i <arr.GetLength(0); i++)
            {
                for (int s = 0; s < arr.GetLength(1); s++)
                {
                    num = r.Next(1, 10);
                    arr[i, s] = num;
                }
            }
            Console.WriteLine("sum: "+Sum(arr));
            Console.WriteLine("sum row ");
            Sum_Row(arr);
            Console.WriteLine("Sum Row max: " + Sum_Row_Max(arr));
            */
            char cha;
            char[,] strg = new char[2, 2];
            for (int i = 0; i < strg.GetLength(0); i++)
            {
                for (int s = 0; s < strg.GetLength(1); s++)
                {
                    Console.WriteLine("enter char");
                    cha = char.Parse(Console.ReadLine());
                    strg[i, s] = cha;
                }
            }
            Strg(strg);
        }
    }
}
