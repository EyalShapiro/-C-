using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace רקושיה_כפעולה
{
    class Program
    {
        // סדרת פיבונאצ'י
        // 0,1,1,2,3,5,8,13,21,...
        // שני האיברים הראשונים הם 0,1
        // כל איבר הוא סכום שני קודמיו
        // טענת כניסה: הפעולה מקבלת מספר סידורי של איבר בסדרת פיבונאצ'י
        // טענת יציאה: הפעולה מחזירה את האיבר של סדרת פיבונאצ'י במקום הסידורי שהתקבל
        // fibo(1) => 0, fibo(2) => 1, fibo(3) => fibo(1) + fibo(2) = 0 + 1 = 1, fibo(4) => fibo(2) + fibo(3) = 1 + 1 = 2, fibo(5) => fibo(3) + fibo(4) = 1 + 2 = 3
        public static int Fibo(int n)
        {
            if (n == 1) // מקרה פשוט - איבר ראשון
                return 0; // האיבר הראשון
            if (n == 2) // מקרה פשוט - איבר שני
                return 1; // האיבר השני
            /*if (n == 1 || n == 2)
                return n - 1;*/
            // if (n < 3) // הנחה שהפרמטר חיובי
            // if (n <= 2) // הנחה שהפרמטר חיובי
            return Fibo(n - 2) + Fibo(n - 1); // המקרה המורכב - האיבר השלישי ואילך
        }
        // טענת כניסה: הפעולה מקבלת פרמטר של מקום סידורי בסדרת פיבונאצ'י
        // טענת יציאה: הפעולה מחזירה את סכום איברי הסדרה עד למקום המתקבל
        public static int SumFibo(int n)
        {
            if (n == 0) // המקרה הפשוט, סכום 0 איברים ראשונים בסדרת פיבונאצ'י
                return 0;
            return SumFibo(n - 1) + Fibo(n); // המקרה המורכב - סכום האיברים הראשונים בסדרת פיבונאצ'י עד למקום מסוים
        }
        // טענת כניסה: הפעולה מקבלת מערך מספרים שלמים ומקום סידורי במערך
        // טענת יציאה: הפעולה מחזירה את סכום איברי המערך מהמקום הסידורי המתקבל
        public static int SumArr(int[] a, int i) // פעולה נעטפת עם פרמטר נוסף
        {
            if (i >= a.Length) // מקרה פשוט - הגעה לסוף המערך
                return 0;
            return SumArr(a, i + 1) + a[i]; // מקרה מורכב
        }
        // טענת כניסה: הפעולה מקבלת מערך של מספרים שלמים
        // טענת יציאה: הפעולה מחזירה את סכום איברי המערך
        public static int SumArr(int[] a) // פעולה עוטפת בלי פרמטר נוסף
        {
            return SumArr(a, 0); // מוסיפים פרמטר של מקום סידורי במערך המציין את מיקום ההתחלה
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Fibo(5)); // Fibo(5) = Fibo(3) + Fibo(4) = Fibo(1) + Fibo(2) + Fibo(2) + Fibo(3) = 0 + 1 + 1 + Fibo(1) + Fibo(2) = 0 + 1 + 1 + 0 + 1 = 3
            Console.WriteLine(SumFibo(5)); // SumFibo(5) = SumFibo(4) + Fibo(5) = SumFibo(3) + Fibo(4) + 3 = SumFibo(2) + Fibo(3) + 2 + 3 = SumFibo(1) + Fibo(2) + 1 + 2 + 3 = SumFibo(0) + Fibo(1) + 1 + 1 + 2 + 3 = 0 + 0 + 1 + 1 + 2 + 3 = 7
            int[] a = { 0, 1, 1, 2, 3 };
            Console.WriteLine(SumArr(a)); // SumArr(a) => SumArr(a, 0) => SumArr(a, 1) + a[0] => SumArr(a, 2) + a[1] + 0 => SumArr(a, 3) + a[2] + 1 + 0 => SumArr(a, 4) + a[3] + 1 + 1 + 0 = SumArr(a, 5) + a[4] + 2 + 1 + 1 + 0 = 0 + 3 + 2 + 1 + 1 + 0 = 7
        }
    }
}
