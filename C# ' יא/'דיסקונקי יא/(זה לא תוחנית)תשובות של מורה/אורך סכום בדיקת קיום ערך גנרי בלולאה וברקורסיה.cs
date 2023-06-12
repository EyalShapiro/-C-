using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        // טענת כניסה: הפעולה מקבלת רשימה
        // טענת יציאה: הפעולה מחזירה את אורכה, מספר החוליות שבה
        public static int Count(Node<int> list)
        {
            int count = 0;
            while (list != null)
            {
                count++;
                list = list.GetNext();
            }
            return count;
        }
        // טענת כניסה: הפעולה מקבלת רשימה
        // טענת יציאה: הפעולה מחזירה את אורכה, מספר החוליות שבה
        public static int Count<T>(Node<T> list)
        {
            int count = 0;
            while (list != null)
            {
                count++;
                list = list.GetNext();
            }
            return count;
        }
        // טענת כניסה: הפעולה מקבלת רשימה של מספרים שלמים
        // טענת יציאה: הפעולה מחזירה את סכום המספרים ברשימה
        public static int Sum(Node<int> list)
        {
            int sum = 0;
            while (list != null)
            {
                sum = sum + list.GetValue();
                list = list.GetNext();
            }
            return sum;
        }
        // טענת כניסה: הפעולה מקבלת רשימה וערך
        // טענת יציאה: הפעולה מחזירה אמת אם הערך נמצא ברשימה ושקר אחרת
        public static bool IsExist<T>(Node<T> list, T val)
        {
            while (list != null)
            {
                if (val.Equals(list.GetValue()))
                    return true;
                list = list.GetNext();
            }
            return false;
        }
        // טענת כניסה: הפעולה מקבלת רשימה וערך
        // טענת יציאה: הפעולה מחזירה אמת אם הערך נמצא ברשימה ושקר אחרת
        public static bool IsExistRec<T>(Node<T> list, T val)
        {
            if (list == null)
                return false;
            /*
            if (val.Equals(list.GetValue()))
                return true;
            return IsExistRec(list.GetNext(), val);*/
            return val.Equals(list.GetValue()) || IsExistRec(list.GetNext(), val);
        }
        static void Main(string[] args)
        {
            Node<int> n1 = new Node<int>(5); // n1->5->null
            Node<int> n0 = new Node<int>(4, n1); // n0->4->5->null
            Console.WriteLine(n0);
            Node<int> n2 = new Node<int>(7); // n2->7->null
            n1.SetNext(n2); // n1->5->n2->7   n1->5->7->null
            Node<int> n3 = new Node<int>(0); // n3->0->null
            n2.SetNext(n3); // n1->5->7->0->null
            n3.SetNext(new Node<int>(9, new Node<int>(6))); // n1->5->7->0->9->6->null
            Console.WriteLine(n1); //         5->7->0->9->6->
            Console.WriteLine(n2); //            7->0->9->6->
            Console.WriteLine(n3); //               0->9->6->
            Console.WriteLine(n3.GetNext()); //        9->6->
            Console.WriteLine(n3.GetNext().GetNext()); // 6->
            Console.WriteLine(n1.GetValue()); // 5
            Console.WriteLine(n1); //         5->7->0->9->6->
            Console.WriteLine(n2.GetValue()); // 7
            Console.WriteLine(n3.GetNext().GetNext().GetValue()); // 6
            n1.SetValue(-1); // שינוי ערך החוליה הראשונה
            Console.WriteLine(n1); //        -1->7->0->9->6->

            // לבנות רשימה של ערכים 1-10
            Node<int> numbers = new Node<int>(1); // numbers->1->null, תחילת הרשימה
            Node<int> n = numbers; // מצביע עזר שמתקדם מחוליה לחוליה
            for (int i = 2; i <= 10; i++)
            {
                n.SetNext(new Node<int>(i)); // n.GetValue() + 1
                n = n.GetNext(); // להתקדם לחוליה הבאה
            }
            Console.WriteLine(numbers); // numbers->1->2->3->4->5->6->7->8->9->10->
            Console.WriteLine(Count(numbers)); // 10
            Console.WriteLine(numbers); // numbers->1->2->3->4->5->6->7->8->9->10->
            Console.WriteLine(Count(n)); // 1
            Console.WriteLine(Count<int>(numbers)); // 10
            Console.WriteLine(Sum(numbers)); // 55
            Console.WriteLine(IsExist(numbers, 10)); // True
            Console.WriteLine(IsExist(numbers, 11)); // False
        }
    }
}
