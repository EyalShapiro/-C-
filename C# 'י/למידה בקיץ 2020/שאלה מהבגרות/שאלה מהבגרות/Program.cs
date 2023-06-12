using System;
using System.Reflection.Metadata;

namespace שאלה_מהבגרות
{
    class Program
    {
        public static int Mani_movi(int num, Actor[]arr )
        {
            int count=0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].GetNumfilms()>num)
                {
                    count++;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            Actor[] actArr = new Actor[3];
            for (int i = 0; i < actArr.Length; i++)
            {
                Console.WriteLine("enetr string id,string gander, int numfilms ");
                actArr[i] = new Actor(Console.ReadLine(), Console.ReadLine(), int.Parse(Console.ReadLine()));

            }
            Console.WriteLine("enetr  num");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(": "+Mani_movi (num,actArr));
        }
    }
}
