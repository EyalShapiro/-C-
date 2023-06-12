using System;

namespace מערך
{
    class Program
    {
        public static int num(int num)
        {
            for (int i = 0; i < num; i++)
            {
                num=num * 10;
            }
            return num;
        }
        public static int Sum(int[] arr)
        {//ex1
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        public static bool Evv(int[] arr)
        {//ex3
            int count = 0;
            while (count<arr.Length&&arr[count]%2==0)
            {
                count++;
            }
            return arr.Length == count; 
        }
        public static void Moving(int[] arr)
        {//ex4
            int num= arr[-1];
            for (int i = arr.Length - 1; i > 0; i--)
            {
                arr[i] = arr[i-1];
            }
            arr[0]= num;

        }
        static void Main(string[] args)
        { //ex1
            int num;
            int[] number = new int[10];
            Console.WriteLine(number.Length);
            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine("enter num");
                num = int.Parse(Console.ReadLine()); 
            }
            //ex3
            Console.WriteLine(Evv(number));
            Console.WriteLine(Sum(number));
            //ex4
            Moving(number);
            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine(number[i]);
            }
            
        }
    }
}
