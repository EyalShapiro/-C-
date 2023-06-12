using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace סכום_והדפסת_מספרים_ופירוק_מספר_לספרות_ברקורסיה
{
    class Program
    {
        public static int MultLoop(int x, int y) // מכפלת 2 מספרים בלולאה
        {
            int sum = 0;
            for (int i = 1; i <= y; i++) // x * y = x + x + x + ... + x, y פעמים
                sum += x;
            return sum;
        }
        public static int MultRec(int x, int y) // כפל 2 מספרים ברקורסיה - פעולה שקוראת לעצמה
        {
            // לולאה מוסוות אינסופית, צריך לעצור אותה מתישהו
            if (y == 0)
                return 0;
            return MultRec(x, y - 1) + x; // x * y = x * (y - 1) + x => MultRec(x, y) = MultRec(x, y - 1) + x
        }
        public static int PowRec(int x, int y) // חזקת 2 מספרית ברקורסיה
        {
            if (y == 0) // המקרה הפשוט
                return 1;
            return PowRec(x, y - 1) * x; // כלל הרקורסיה במקרה המורכב
        }
        public static int Factorial(int n) // עצרת  מספר ברקורסיה
        {
            // 4! = 1 X 2 X 3 X 4 = 24
            // עצרת - מכפלת המספרים מ-1 עד n 
            if (n == 0) // המקרה הפשוט
                return 1;
            return Factorial(n - 1) * n; // המקרה המורכב
        }
        public static int Sum1ToN(int n) // סכום המספרים מ-1 עד n
        {
            // n = 4 => 1 + 2 + 3 + 4 = 10
            if (n == 0) // המקרה הפשוט
                return 0;
            return Sum1ToN(n - 1) + n; // המקרה המורכב
        }
        public static void Print1ToN(int n) // הדפסת המספרים מ-1 עד n
        {
            if (n >= 1) // מקרה מורכב
            {
                Print1ToN(n - 1); // האחרון שנקרא מוכן להדפיס ראשון
                Console.WriteLine(n);
            }
        }
        public static void PrintDigits(int num) // הדפסת ספרות של מספר מימין לשמאל אחדות ואילך
        {
            if (num < 10) // המקרה הפשוט - מספר חד ספרתי
                Console.WriteLine(num); // מודפס כמו שהוא
            else // המקרה המורכב - מספר דו ספרתי ומעלה
            {
                Console.WriteLine(num % 10); // הדפסת ספרת האחדות
                PrintDigits(num / 10); // הדפסת שאר הספרות של המספר ללא ספרת האחדות הנוכחית
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(MultLoop(5, 3)); // 0 + 5 + 5 + 5 = 15
            Console.WriteLine(MultRec(5, 3)); // MultRec(5, 3) = MultRec(5, 2) + 5 = MultRec(5, 1) + 5 + 5 = MultRec(5, 0) + 5 + 5 + 5 = 0 + 5 + 5 + 5 = 15
            Console.WriteLine(PowRec(2, 3)); // PowRec(2, 3) = PowRec(2, 2) * 2 = PowRec(2, 1) * 2 * 2 = PowRec(2, 0) * 2 * 2 * 2 = 1 * 2 * 2 * 2 = 8
            Console.WriteLine(Factorial(3)); // Factorial(3) = Factorial(2) * 3 = Factorial(1) * 2 * 3 = Factorial(0) * 1 * 2 * 3 = 1 * 1 * 2 * 3 = 6
            Console.WriteLine(Sum1ToN(4)); // Sum1ToN(4) = Sum1ToN(3) + 4 = Sum1ToN(2) + 3 + 4 = Sum1ToN(1) + 2 + 3 + 4 = Sum1ToN(0) + 1 + 2 + 3 + 4 = 0 + 1 + 2 + 3 + 4 = 10
            Print1ToN(5); // Print1ToN(5) => Print1ToN(4) => Print1TonN(3) => Print1ToN(2) => Print1ToN(1) => Print1ToN(0) => מפסיקה לקרוא לעצמה
            /*
             פלט
             1
             2
             3
             4
             5
            */
            PrintDigits(1234); // PrintDigits(1234) => PrintDigits(123) => PrintDigits(12) => PrintDigits(1) => מפסיקה לקרוא לעצמה
            /* 
              פלט
              4
              3
              2
              1
            */
        }
    } 
}
