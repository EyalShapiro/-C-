using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ListExercises
{
    class Program
    {
        // n - מספר החוליות
        // O(n) - מספר הפעמים שהלולאה מתבצעת
        // O - מדד היעילות/הסיבוכיות/המורכבות
        // יעילות נמדדת על פי זמן ביצוע
        public static Node<T> GetLast<T>(Node<T> list)
        {
            while (list.HasNext()) // הלולאה תלויה במספר החוליות ברשימה כדי להגיע לחוליה האחרונה, n פעמים
                list = list.GetNext(); // O(1)
            return list; // O(1)
        }
        public static Node<T> GetPrev<T>(Node<T> list, Node<T> p) // O(n) - המקרה הגרוע ביותר שבו החוליה המתקבלת היא אחרונה
        {
            Node<T> q = list; // O(1)
            while (q.GetNext() != p) // O(n)
                q = q.GetNext(); // O(1)
            return q; // O(1)
        }
        // טענת כניסה: הפעולה מקבלת רשימת מספרים שלמים
        // טענת יציאה: הפעולה מסדרת את הרשימה כך שקודם המספרים הזוגיים אחר כך המספרים האי זוגיים
        public static void EvenOdd1(Node<int> list) // פתרון תרגיל 26 עמוד 95
        {
            Node<int> left = list; // O(1)
            Node<int> right = GetLast(list); // O(n)
            while (left != right && right.GetNext() != left) // O(n) = O(n/2) + O(n/2)
            {
                while (left.GetValue() % 2 == 0 && left != right) // O(n/2)
                    left = left.GetNext(); // O(1)

                while (right.GetValue() % 2 == 1 && left != right) // O(n/2)
                    right = GetPrev(list, right); // O(n)

                if (left != right) // O(1)
                {
                    int temp = left.GetValue(); // O(1)
                    left.SetValue(right.GetValue()); // O(1)
                    right.SetValue(temp); // O(1)
                    left = left.GetNext(); // O(1)
                    right = GetPrev(list, right); // O(n)
                }
            }
            // f(n) = O(1) + O(n) + O(n)XO(n) = O(n) + O(n^2) = O(n^2)
        }
        public static Node<int> EvenOdd2(Node<int> list)
        {
            Node<int> p = list, q = null; // O(1)
            while (p.HasNext()) // O(n)
            {
                if (p.GetNext().GetValue() % 2 == 0) // O(1)
                {
                    list = new Node<int>(p.GetNext().GetValue(), list); // O(1)
                    q = p.GetNext(); // O(1)
                    p.SetNext(q.GetNext()); // O(1)
                    q.SetNext(null); // O(1)
                }
                else
                    p = p.GetNext(); // O(1)
                // Console.WriteLine(list);
            }
            return list; // O(1)
            // f(n) = O(1) + O(n)O(1) + O(1) = O(n)
        }
        static void Main(string[] args)
        {
            Node<int> list = new Node<int>(12, new Node<int>(34, new Node<int>(45, new Node<int>(9, new Node<int>(8, new Node<int>(90, new Node<int>(3)))))));
            Console.WriteLine(list);
            // EvenOdd1(list);
            // Console.WriteLine(list);
            Console.WriteLine(EvenOdd2(list));
        }
    }
}
