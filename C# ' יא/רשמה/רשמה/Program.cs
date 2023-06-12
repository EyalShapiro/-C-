using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace רשמה
{
    class Program
    {
        //פעולת
        public static int Count(Node<int> list)//ex2//int
        {//הפעולה מקבלת רשימה ומחזרה אתה כמות עברים  
            int count = 0;
            while (list != null)
            {
                count++;
                list = list.GetNext();
            }
            return count;
        }
        public static int Count<T>(Node<T> list)//ex2//הכולה
        {//הפעולה מקבלת רשימה ומחזרה אתה כמות עברים  
            int count = 0;
            while (list != null)
            {
                count++;
                list = list.GetNext();
            }
            return count;
        }

       
        public static int GetMin(Node<int> list)//int
        {//הפעולה מקבלת רשימה מחזרה את הערך הקטן
            int min = list.GetValue();
            while (list != null)
            {
                if (list.GetValue() < min)
                    min = list.GetValue();
                list = list.GetNext();
            }
            return min;
        }
        public static int GetMax(Node<int> list)//int
        {//הפעולה מקבלת רשימה מחזרה את הערך הגדול
            int max = list.GetValue();
            while (list != null)
            {
                if (list.GetValue() > max)
                    max = list.GetValue();
                list = list.GetNext();
            }
            return max;
        }
        public static double GetMin(Node<double> list)//double
        {//הפעולה מקבלת רשימה מחזרה את הערך הקטן
            double min = list.GetValue();
            while (list != null)
            {
                if (list.GetValue() < min)
                    min = list.GetValue();
                list = list.GetNext();
            }
            return min;
        }

        public static double GetMax(Node<double> list)
        {//הפעולה מקבלת רשימה מחזרה את הערך הגדול
            double max = list.GetValue();
            while (list != null)
            {
                if (list.GetValue() > max)
                    max = list.GetValue();
                list = list.GetNext();
            }
            return max;
        }
        public static void Order_Null(Node<int> list)
        {//  הפעולה מקבלת רשימה והם יש איברים ברשימה מסדרת אותו ואם אין הזה היא מקבלת מספרים מה המשתמש המשתמשה ומחזר אות משודר
            if (list != null)
            {
                Console.WriteLine("A neat list :" + Order(list));
            }
            else
            {
                Console.WriteLine("enter num to stop enter -1 ");
                int num = int.Parse(Console.ReadLine());
                list.SetNext(new Node<int>(num));
                while (num != -1)
                {
                    list.GetNext();
                    Console.WriteLine("enter num to stop enter -1 ");
                    num = int.Parse(Console.ReadLine());
                    list.SetNext(new Node<int>(num));// לסיף לסוף הרשימה
                }
                Order(list);
            }
        }

        public static Node<int> Order(Node<int> list)//פעולת עזר
        {//הפעולה מקבלת רשימה ומסדרת איברים ברשימה מהקטן לגדול
            Node<int> n = new Node<int>(0);
            for (int i = 0; i < Count(list); i++)
            {
                n.SetValue(GetMin(list));// לסיף לתחלת הרשימה
                n.SetNext(list.GetNext());

            }
            return n;
        }
        /*
        public static char Several_Types(Node<int> list) //p76 ex4 
        {
            if (Count(list) / 2 < SomeDoublesLoop(list, Count(list)))
            {
                return 'z';
            }
            else if (Count(list) / 2 > SomeDoublesLoop(list, Count(list)))
            {
                return 'e';
            }
            //else if (Count(n)/2== SomeDoubles(list,0,Count(n)))
            return 's';

        }
        //לא עובד
        public static int SomeDoublesLoop(Node<int> list, int len)//לולאה
        {// הפעולה מקבלת רשימה סופר וגודל ומחזרה מסופר אתה כמות המספרים הזוגים 
            int count = 0;
            for (int i =1 ; i <= len; i++)
            {
                if (list.GetValue()%2==0)
                {
                    count++;
                    list =list.GetNext();
                }
            }
            return count;
        }
        //לא עובד
        public static int SomeDoublesRecursion(Node<int> list, int count, int len)//רקורשיה 
        {// הפעולה מקבלת רשימה סופר וגודל ומחזרה מסופר אתה כמות המספרים הזוגים 
            if (len <= 0)
            {
                return count;
            }
            if (list.GetValue() % 2 == 0)
            {
                return SomeDoublesRecursion(list, count++, len - 1);
            }
            return SomeDoublesRecursion(list, count, len - 1);
        }

       */
        static void Main(string[] args)
        {
            //ex1//1-10 לבנות רשימה על ערכים
            Node<int> number = new Node<int>(1);//number->1 -> null ,תחילת הרשמה
            Node<int> n = number;// מצביע עזר שמתקדם מחולים לחוליה
            for (int i = 2; i <= 10; i++)
            {
                n.SetNext(new Node<int>(i)); // או  n.GetValue()+ 1;
                n = n.GetNext();
            }
        
            Console.WriteLine("n= " + n);// המספר האחרון ברשמה n=10->
            Console.WriteLine("number= " + number);//הרשמה כולה  number= 1-> 2-> 3-> 4-> 5-> 6-> 7-> 8-> 9-> 10->
            Console.WriteLine("count=" + Count(number));
            /*
            //p76 ex4// דוגמה לא מה הכיתה
            Console.WriteLine("p76_ex4_______");
            Console.WriteLine(SomeDoublesLoop(number, Count(number)));//לולאה
            Console.WriteLine(SomeDoublesRecursion(number,0,Count(number)));//רקורשיה
            Console.WriteLine("Several_Types(number)= " + Several_Types(number));
            */
            //Node<int> n1 = new Node<int>(null);
            Console.WriteLine("ex ___Order_Null_+_Orde");
            Console.WriteLine("Order: " + Order(number));
            Console.Write("Order_Null(number): "); ; Order_Null(number);
            Console.Write("Order_Null(null): "); ; Order_Null(null);

            
        }
    }
}
