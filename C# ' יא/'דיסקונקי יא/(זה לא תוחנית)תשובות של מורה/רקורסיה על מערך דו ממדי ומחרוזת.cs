using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rec2DArrString
{
    class Program
    {
        // טענת כניסה: הפעולה מקבלת מערך דו ממדי של מספרים שלמים, ומצייני שורה ועמודה
        // טענת יציאה: הפעולה מחזירה את המספר המקסימלי בשורה הנוכחית
        public static int MaxRow(int[,] m, int row, int col)
        {
            if (col == m.GetLength(1) - 1) // הגענו לסוף השורה הנוכחית
                return m[row, col];
            return Math.Max(m[row, col], MaxRow(m, row, col + 1)); // מעבר לעמודה הבאה בשורה
        }
        // טענת כניסה: הפעולה מקבלת מערך דו ממדי של מספרים שלמים ומציין שורה
        // טענת יציאה: הפעולה מדפיסה את המספר המקסימלי בכל שורה החל מהשורה שהתקבלה
        public static void PrintMaxs(int[,] m, int row)
        {
            if (row < m.GetLength(0)) // מקרה מורכב - שהשורה קיימת במערך
            {
                Console.WriteLine(MaxRow(m, row, 0)); // מדפיסים את המספר המקסימלי בשורה הנוכחית החל מעמודה ראשונה בשורה
                PrintMaxs(m, row + 1); // מעבר לשורה הבאה
            }
        }
        // טענת כניסה: הפעולה מקבלת מערך דו ממדי של מספרים שלמים
        // טענת יציאה: הפעולה מדפיסה את המספר המקסימלי בכל שורה במערך
        // תרגיל 34 עמוד 28
        public static void PrintMaxs(int[,] m) // פעולה עוטפת
        {
            PrintMaxs(m, 0); // מתחילים משורה ראשונה מספר 0
        }
        // טענת כניסה: הפעולה מקבלת מחרוזת ומציין מקום
        // טענת יציאה: הפעולה מחזירה את מספר אותיות א"ב אנגלי קטנות במחרוזת
        public static int CountLowABC(string s, int i)
        {
            if (i >= s.Length) // חריגה מהמחרוזת
                return 0;
            if (s[i] >= 'a' && s[i] < 'z') // בדיקת אות אנגלית קטנה
                return CountLowABC(s, i + 1) + 1; // ספירה
            return CountLowABC(s, i + 1);
        }
        // טענת כניסה: הפעולה מקבלת מחרוזת
        // טענת יציאה: הפעולה מחזירה את מספר אותיות א"ב אנגלי קטנות במחרוזת
        public static int CountLowABC(string s) // פעולה עוטפת
        {
            return CountLowABC(s, 0); // מתחילים בתא ראשון מספר 0 
        }
        // טענת כניסה: הפעולה מקבלת מחרוזת ומצייני התחלה וסיום
        // טענת יציאה: הפעולה מחזירה אמת אם המחרוזת פלינדרום - מילת ראי ושקר אחרת
        public static bool Palindrome(string s, int i, int j)
        {
            if (i == j || i + 1 == j && s[i] == s[j]) // תו אחד אמצעי או שניים אמצעים
                return true;
            if (s[i] != s[j]) // אין התאמה בין תוי הקצוות
                return false;
            return Palindrome(s, i + 1, j - 1); // מתקדמים אחד קדימה מההתחלה ואחד אחורה מהסוף
        }
        // טענת כניסה: הפעולה מקבלת מחרוזת
        // טענת יציאה: הפעולה מחזירה אמת אם המחרוזת פלינדרום - מילת ראי ושקר אחרת
        // תרגיל 21 עמוד 27
        public static bool Palindrome(string s) // פעולה עוטפת
        {
            return Palindrome(s, 0, s.Length - 1); // מתחילים מההתחלה והסוף
        }
        static void Main(string[] args)
        {
            //עמוד 28 תרגיל 34 - הדפסת המספר המקסימלי בכל שורה במערך דו ממדי. כולל מעקב
            //עמוד 27 תרגיל 21 - ספירת אותיות א"ב אנגלי קטנות במחרוזת
            int[,] m = { { 2, 1, 3 }, { 4, 6, 2 } };
            PrintMaxs(m); // PrintMaxs(m) => PrintMaxs(m, 0) => MaxRow(m, 0, 0) <=> Math.Max(m[0, 0], MaxRow(m, 0, 1)) <=> Math.Max(2, Math.Max(m[0, 1], MaxRow(m, 0, 2))) <=> Math.Max(2, Math.Max(1, m[0, 2])) <=> Math.Max(2, Math.Max(1, 3)) <=> Math.Max(2, 3) <=> 3
            //                                                  PrintMaxs(m, 1) => MaxRow(m, 1, 0) <=> Math.Max(m[1, 0], MaxRow(m, 1, 1)) <=> Math.Max(4, Math.Max(m[1, 1], MaxRow(m, 1, 2))) <=> Math.Max(4, Math.Max(6, m[1, 2])) <=> Math.Max(4, Math.Max(6, 2)) <=> Math.Max(4, 6) <=> 6
            //                                                  PrintMaxs(m, 1) => MaxRow(m, 1, 0) <=> Math.Max(m[1, 0], MaxRow(m, 1, 1)) <=> Math.Max(4, Math.Max(m[1, 1], MaxRow(m, 1, 2))) <=> Math.Max(4, Math.Max(6, m[1, 2])) <=> Math.Max(4, Math.Max(6, 2)) <=> Math.Max(4, 6) <=> 6
            //                                                                     PrintMaxs(m, 2)
            // m.GetLength(0) = 2, m.GetLength(1) = 3
            /*
            פלט
            3
            6
            */
            Console.WriteLine(CountLowABC("CountLowABC")); // 6
            Console.WriteLine(Palindrome("wow")); // true
        }
    }
}
