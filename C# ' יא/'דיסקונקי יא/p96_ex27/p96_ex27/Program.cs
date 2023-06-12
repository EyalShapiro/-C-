using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace p95_ex27
{
    class Program
    {
        public static int Count<T>(Node<T> list)//פעולת בדיקה//רקורסיה
        {//הפעולה מקבלת רשימה ומחזרה אתה כמות עברים  
            if (list == null)
            {
                return 0;
            }
            return Count(list.GetNext()) + 1;
        }

        public static Node<int> Reduces_Exces(Node<int> list)// p95 ex 27
        {//הפעולה רשימה מקבלת שלמים ומבטלת  כל רצף המכיל יותר מ2 מספרים    
            if (list == null) // הרשימה ריקה    
                return null;
            if (!list.HasNext())
                return list;
            //Node<int> save = list;
            Node<int> point = list;
            int count = SeveralTimesListed(list, list.GetValue());
            while (count > 2)
            {
                while (list != null && count > 0)
                {
                    Node<int> delete = list;
                    list = delete.GetNext();
                    delete.SetNext(null);
                    count -= 1;
                }
                count = SeveralTimesListed(point, point.GetValue());
            }
            point = list;
            while (point != null && point.HasNext())
            {
                count = SeveralTimesListed(point.GetNext(), point.GetNext().GetValue());
                if (count > 2)
                {
                    while (count > 0)
                    {
                        Node<int> delete = point.GetNext();
                        point.SetNext(delete.GetNext());
                        delete.SetNext(null);
                        count -= 1;
                    }
                }
                    point = point.GetNext();
            }
            return list;
        }
        public static int SeveralTimesListed(Node<int> list, int num)//p95 ex 27 פעולה עזר ל 
        {// הפעולה מקבלת מספר ורשימה ומחזרה אתה כמות הפעמים שהיא נמצת  
            if (list!=null && num.Equals(list.GetValue()))
                return (SeveralTimesListed(list.GetNext(), num) + 1);
            return 0;
        }
        public static Node<int> AddRandom(int i)//int //לולא
        {//הפעולה מקבלה מספר ומתקנת ומוספיה לרשמה הרחים רנדומלים בגודלה המספר 
            Random r = new Random();
            Node<int> list = new Node<int>(r.Next(1, 6));
            Node<int> n = list;// מצביע עזר שמתקדם מחולים לחוליה;
            for (i = i - 1; 0 < i; i--)
            {
                n.SetNext(new Node<int>(r.Next(1, 6))); //מגרלה מספרים 1 עד 5 
                n = n.GetNext();
            }
            return list;
        }
        static void Main(string[] args)
        {          
            //p95 ex 27
            Console.WriteLine("Reduces_Exces(4) = " + Reduces_Exces(new Node<int>(4)));
            Console.WriteLine("Reduces_Exces(null) = " + Reduces_Exces(null));
            Node<int> number = AddRandom(20);
            Console.WriteLine("number = " + number);
            // Console.WriteLine("SeveralTimesListed(number) = " + SeveralTimesListed(number, number.GetValue()));
            Console.WriteLine("Count(number) = " + Count(number));
            Console.WriteLine("Reduces_Duplication(number) = " + Reduces_Exces(number));
            Console.WriteLine("Count(number) = " + Count(number));
        }
        public static Node<int> Direct()
        {//הפעולה מקולת מספר מחנסה אותם לרשימה ומחזרה הותם בסדר הקליטה 
            Console.WriteLine(":::::::::ENTER A NUMBER::::::: stop -1");
            int num = int.Parse(Console.ReadLine());
            if (num == -1)
            {
                return null;
            }
            Node<int> n = new Node<int>(num);
            num = int.Parse(Console.ReadLine());
            Node<int> start = n;
            while (num != -1)
            {
                n.SetNext(new Node<int>(num));//פעולה בונה
                n = n.GetNext();
                num = int.Parse(Console.ReadLine());
            }
            return start;
        }

    }
}
