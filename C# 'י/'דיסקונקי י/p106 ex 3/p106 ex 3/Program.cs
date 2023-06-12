using System;

namespace p106_ex_3
{
    class Program
    {
       
        public static void Ex5(int[,] arr)
        {
            //'ה
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        sum += arr[i, j];
                    }
                    if (i < j)
                    {
                        Console.WriteLine(arr[i, j]);
                    }
                }
            }
            Console.WriteLine("sum " + sum);
        }
        public static void Ex6(int[,] arr)
        {
            //'ו
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        sum += arr[i, j];
                    }
                    if (i > j)
                    {
                        Console.WriteLine(arr[i, j]);
                    }
                }
            }
            Console.WriteLine("sum " + sum);
        }
       


        static void Main(string[] args)
        { 
            int[,] number = new int[5,5];
            Random r = new Random();
            for (int i = 0; i < number.GetLength(0); i++)
            {
                for (int j = 0; j < number.GetLength(1); j++)
                {
                    number[i, j] = r.Next(11);
                }
            }
            Console.WriteLine("ex5"); 
            Ex5(number);
            Console.WriteLine("ex6");  
            Ex6(number);
        }
    }
}
