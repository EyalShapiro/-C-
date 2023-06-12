using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p101_ex54
{
    class Program
    {
        public static int Min_Remainder_Max(int[] arr) //p101_ex54  פעולת עזר
        {//הפעולה מקבלת מערך מחזרה את הערך הפרש בין הגדול לקטן
            //o(6)  שש זה גודל המערך   
            int max = 0, min = 41;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
                if (arr[i] < min)
                    min = arr[i];
            }
            return max - min;
        }
        public static int Leg_Balanced(Node<int[]> list)//רקוסיה //p101_ex54
        {// פעולה מקבלה רשמה של מערכים ומחזר את מספר פעמים שהמספר אינו מוזמן
            //o(n*n) שש זה גודל המערך   
            if (list == null)
                return 0;
            if (Min_Remainder_Max(list.GetValue()) > 20)
                return Leg_Balanced(list.GetNext()) + 1;
            return Leg_Balanced(list.GetNext());
        }
        public static Node<int[]> AddRandom(int size)//פעול בונה רשימה 
        {//הפעולה מקבלה מספר ומתקנת ומוספיה לרשמה מערך של הרחים רנדומלים מספר בין 1 ל40 בגודלה המספר 
            //  (o(n*n)) 
            Random ran = new Random();
            int[] arr = new int[6];
            for (int a = 0; a < arr.Length; a++)
            {
                arr[a] = ran.Next(1, 41);
            }
            Node<int[]> list = new Node<int[]>(arr);
            for (int i = 0; i < size-1; i++)
            {
                arr = new int[6];
                for (int a = 0; a < arr.Length ; a++)
                {
                    arr[a] = ran.Next(1, 41);
                }
                list = new Node<int[]>(arr, list);
            }
            return list;
        }
        public static void Print(Node<int[]> list)
        {// פעולה מקבלה רשמה של מערכים מדפיס את  רשמה של מערכים
            //o(n)*o(n)
            int num = 1;
            while (list != null)
            {
                int[] arr = list.GetValue();
                Console.Write(num + ":  "+ arr[0]);
                for (int i = 1; i < arr.Length; i++)
                {
                    Console.Write(" ," + arr[i] );
                }
                num++;
                Console.WriteLine();
                list = list.GetNext();
            }
        }
        static void Main(string[] args)
        {
           // int[] arr = { 5, 10, 6, 8, 9, 4 };
            //Console.WriteLine(Min_Remainder_Max(arr));
            Node<int[]> list = AddRandom(5);
            //list = new Node<int[]>(arr, list);
            Print(list);
            Console.WriteLine("number is not invited : " + Leg_Balanced(list));
        }
    }
}
