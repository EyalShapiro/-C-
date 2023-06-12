
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace רקוסה_במרך
{
    class Program
    {
        /*
          //ex1
         public static int far(int num)
         {
             if (num == 1)
             {
                 return 1;
             }
             return far(num - 1) * num;
         }
         *//**/
         public static void Arr(int[] num)
         {//הפעולה מקבלת מרך ומחזרה אותה מסודר
            int[] max = new int[num.Length];
            max = MaxArrArranged(num, max, 0);
            PrintArr(max,0);
         }
       
        public static int MaxArr(int[] a) 
        { // הפעולה מקבלת מערך ומחזירה מספר המקסימלי במערך
            return MaxArr(a, 0);
        }

        public static int MaxArr(int[] a, int i)
        { // הפעולה מקבלת מערך ומקום  תא במערך ומחזירה את המספר המקסימלי במערך החל מהמקום הנוכחי
            if (i == a.Length - 1) 
                return a[i];
            return Math.Max(a[i],MaxArr(a, i + 1));
        }
        public static int IsExist(int[] a,int i,int max1)
        {//מיקום הפעולה מקבלת מערך, מספר ומקום ומחזירה את  
            if (a[i]==max1)
            {
                return i;
            }
            return IsExist(a, i+1,max1);
        }
        public static int[] MaxArrArranged(int[] a, int[] max, int i)
        {// הפעולה מקבלת מערך  ומערך רק ןמקום ומחזרה אותה מסודלפי מגדול לקטן
            if (i >= max.Length)
                return max;
            max[i] = MaxArr(a);
            a[IsExist(a,0, max[i])] = 0;
            return MaxArrArranged(a,max,i+1);
        }
        public static void PrintArr(int[] a, int i)
        {// הפעולה מקבלת מערך ומדפסה את אורים שלו
            if (i<=a.Length-1)
            {
                Console.WriteLine(a[i]);
                PrintArr(a, i +1); 
            }
        }
        
        public static bool CheckOrder(int[] num, int leng)//לא בשמוש בתוכנית זהו
        {//הפעולה מקבלת מרך ומחזרה נכון הם מערך מסדר לפי מגדול לקטן ולא נכון אחרת  

            if (leng < 2)
            {
                return true;
            }
            if (num[leng] > num[leng -1])
            {
                return false;
            }
            return CheckOrder(num, leng - 1);
        }
        public static void SmallWhatFirst(int[] arr,int i)
        {//הפעולה מקבלת מעך ומיקום ומדפסה את אברי קטנים מאברה הקודם
            if(i==arr.Length-1||i<=0)
            {
                Console.WriteLine("finish");
            }
            else if (arr[i]<arr[i-1])
            {
                Console.WriteLine(arr[i]);
            }
            SmallWhatFirst(arr,i+1);
        }
        static void Main(string[] args)
        {
            //ex1
            //  Console.WriteLine(far(5));

            //ex2
            int[] num = { 8, 5 ,10, 4,20};
            //Arr(num);
            // CheckOrder({ 8,5,4,1 },4)->CheckOrder({8,5,4,1 },3)->CheckOrder({ 8,5,4,1 },2)->CheckOrder({ 8,5,4,1 },1)
            //PrintArr(num);      

            //p28 ex32
            SmallWhatFirst(num,1);

        }
    }
}
