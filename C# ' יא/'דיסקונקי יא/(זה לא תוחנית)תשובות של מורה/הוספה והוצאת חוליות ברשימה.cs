using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
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
        // טענת כניסה: הפעולה מקבלת רשימה של מספרים שלמים
        // טענת יציאה: הפעולה מחזירה את סכום המספרים ברשימה
        public static int SumRec(Node<int> list)
        {
            if (list == null) // חוליה ריקה
                return 0;
            return list.GetValue() + SumRec(list.GetNext());
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
        // טענת כניסה: הפעולה מקבלת רשימה וערך
        // טענת יציאה: הפעולה מחזירה את החוליה של הערך ברשימה
        public static Node<T> Find<T>(Node<T> list, T val)
        {
            while (list != null)
            {
                if (val.Equals(list.GetValue()))
                    return list;
                list = list.GetNext();
            }
            return null;
        }
        // טענת כניסה: הפעולה מקבלת רשימת מספרים שלמים
        // טענת יציאה: הפעולה מוסיפה 1 לכל מספר ברשימה
        public static void Add1(Node<int> list)
        {
            while (list != null)
            {
                list.SetValue(list.GetValue() + 1); // הוספת 1 למספר בחוליה
                list = list.GetNext();
            }
        }
        // טענת כניסה: הפעולה מקבלת רשימה גנרית
        // טענת יציאה: הפעולה מחזירה את החוליה האחרונה ברשימה
        public static Node<T> GetLast<T>(Node<T> list)
        {
            while (list.HasNext())
                list = list.GetNext();
            return list;
        }
        // טענת כניסה: הפעולה מקבלת רשימת מספרים לא שלמים
        // טענת יציאה: הפעולה מחזירה את המספר המקסימלי ברשימה
        public static double GetMax(Node<double> list)
        {
            double max = list.GetValue();
            while (list != null)
            {
                if (list.GetValue() > max)
                    max = list.GetValue();
                list = list.GetNext();
            }
            return max;
        }
        // טענת כניסה: הפעולה מקבלת רשימת מספרים שלמים
        // טענת יציאה: הפעולה מחזירה את המספר המקסימלי ברשימה
        public static int GetMax(Node<int> list)
        {
            int max = list.GetValue();
            while (list != null)
            {
                if (list.GetValue() > max)
                    max = list.GetValue();
                list = list.GetNext();
            }
            return max;
        }
        /*
        // טענת כניסה: הפעולה מקבלת רשימה ומספר
        // טענת יציאה: הפעולה מוסיפה את המספר לרשימה תוך שמירה על סדר המיון מקטל לגדול
        // הנחה: הרשימה אינה ריקה והמספר הנוסף לא יהיה בחוליה הראשונה
        public static void Insert(Node<int> numbers, int num) // מעדכנת את הרשימה אך לא מחזירה אותה
        {
            // מתאים רק להוספת חוליה שאינה ראשונה
            // num = 7, 13
            // numbers->0->1->2->3->4->5->6->7->8->9->10->11->12->
            while (numbers.HasNext() && numbers.GetNext().GetValue() < num)
                numbers = numbers.GetNext();
            // numbers->6->7->8->9->10->11->12->
            // numbers->12->
            Node<int> n = new Node<int>(num, numbers.GetNext()); // n->7->7->8->9->10->11->12-> , n->13->
            numbers.SetNext(n); // numbers->6->7->7->8->9->10->11->12->, numbers->12->13->
        }
        */
        // טענת כניסה: הפעולה מקבלת רשימה ומספר
        // טענת יציאה: הפעולה מוסיפה את המספר לרשימה תוך שמירה על סדר המיון מקטן לגדול ומחזירה את הרשימה המעודכנת
        // טיפול ברשימה ריקה, הוספת חוליה ראשונה, הוספת חוליה לא ראשונה
        public static Node<int> Insert(Node<int> numbers, int num)
        {
            if (numbers == null) // הרשימה ריקה
                numbers = new Node<int>(num); // יצירת רשימה עם חוליה אחת
            else // לרשימה לפחות חוליה אחת
                if (numbers.GetValue() >= num) // צריך להוסיף את החוליה החדשה לפני החוליה הראשונה
                    numbers = new Node<int>(num, numbers); // הוספת המספר לפני החוליה הראשונה
                else // הוספת המספר כחוליה לא ראשונה
                {
                    Node<int> n = numbers;
                    // num = 7, 13
                    // numbers->0->1->2->3->4->5->6->7->8->9->10->11->12->
                    while (n.HasNext() && n.GetNext().GetValue() < num)
                        n = n.GetNext();
                    // n->6->7->8->9->10->11->12->
                    // n->12->
                    Node<int> m = new Node<int>(num, n.GetNext()); // m->7->7->8->9->10->11->12-> , m->13->
                    n.SetNext(m); // n->6->7->7->8->9->10->11->12->, n->12->13->
                }
            return numbers;
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
            Console.WriteLine(SumRec(numbers)); // 55
            Console.WriteLine(Find(numbers, 4)); // 4->5->6->7->8->9->10->
            Console.WriteLine(numbers); // 1->2->3->4->5->6->7->8->9->10->
            Add1(numbers); // הוספת 1 לכל מספר ברשימה
            Console.WriteLine(numbers); // 2->3->4->5->6->7->8->9->10->11->
            Console.WriteLine(GetLast(numbers)); // 11->
            Console.WriteLine(GetMax(numbers)); // 11
            Console.WriteLine(n); // 11->
            n.SetNext(new Node<int>(12)); // הוספת חוליה לסוף הרשימה
            Console.WriteLine(numbers); // 2->3->4->5->6->7->8->9->10->11->12->
            numbers = new Node<int>(0, numbers); // הוספת חוליה לתחילת הרשימה
            Console.WriteLine(numbers); // 0->2->3->4->5->6->7->8->9->10->11->12->
            // הוספת חוליה לא ראשונה
            Node<int> m = new Node<int>(1, numbers.GetNext()); // 0->2->3->4->5->6->7->8->9->10->11->12-> , 1->2->3->4->5->6->7->8->9->10->11->12->, 0,1->2->3->4->5->6->7->8->9->10->11->12->
            numbers.SetNext(m); // 0->1->2->3->4->5->6->7->8->9->10->11->12-> , numbers->0, n->11, m->1
            Console.WriteLine(numbers); // 0->1->2->3->4->5->6->7->8->9->10->11->12->
            int num = int.Parse(Console.ReadLine()); // 7
            /*
            if (numbers == null) // הרשימה ריקה
                numbers = new Node<int>(num);
            else // לרשימה לפחות חוליה אחת
                if (numbers.GetValue() >= num) // צריך להוסיף את החוליה החדשה לפני החוליה הראשונה
                    numbers = new Node<int>(num, numbers);
                else
                    Insert(numbers, num);
            */
            // שימוש בפעולת עזר להוספת חוליות לרשימה
            numbers = Insert(numbers, num); // numbers->0->1->2->3->4->5->6->7->7->8->9->10->11->12->
            Console.WriteLine(numbers); // 0->1->2->3->4->5->6->7->7->8->9->10->11->12->
            numbers = Insert(numbers, 13); // numbers->0->1->2->3->4->5->6->7->7->8->9->10->11->12->13->
            Console.WriteLine(numbers); // 0->1->2->3->4->5->6->7->7->8->9->10->11->12->13->
            // הוצאת חוליה ראשונה
            n = numbers; // n->0->1->2->3->4->5->6->7->7->8->9->10->11->12->13->
            numbers = numbers.GetNext(); // numbers->1->2->3->4->5->6->7->7->8->9->10->11->12->13-> , n->0->1->2->3->4->5->6->7->7->8->9->10->11->12->13->
            n.SetNext(null); // 0->
            Console.WriteLine(numbers); // 1->2->3->4->5->6->7->7->8->9->10->11->12->13->
            Console.WriteLine(n); // n->0->
            // הוצאת חוליה לא ראשונה
            n = numbers.GetNext(); // n->2->3->4->5->6->7->7->8->9->10->11->12->13->
            numbers.SetNext(n.GetNext()); // numbers->1->3->4->5->6->7->7->8->9->10->11->12->13->
            n.SetNext(null); // n->2->
            Console.WriteLine(numbers); // 1->3->4->5->6->7->7->8->9->10->11->12->13->
            Console.WriteLine(n); // 2->
        }
    }
}
