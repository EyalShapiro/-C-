using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace p76_ex14
{
    class Program
    {
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
        public static int GetMax(Node<int> list)//int//פעולת עזר
        {//הפעולה מקבלת רשימה מחזרה את הערך הגדול
            int max = 0;
            while (list != null)
            {
                if (list.GetValue() > max)
                    max = list.GetValue();
                list = list.GetNext();
            }
            return max;
        }

        public static Node<int> Reduces_multiple_n(Node<int> list, int n) // p76 ex 14
        {//קטן ממספר האיברים ברשמה מוריד את כמות nו  n הפעולה מקבלת רשימה ומספר שלם  
            if (list == null) // הרשימה ריקה
                return null;
            if (n <= 0)
                return list;

            while (n > 0)
            {
                list = Reduces(list, GetMax(list));
                n--;
            }
            return list;
        }
        // p76 ex 14//פעולת עזר
        public static Node<int> Reduces(Node<int> list, int n)
        { // nברשמה מוריד את ה  n הפעולה מקבלת רשימה ומספר שלם
            if (list == null)
                return null;
            if (list.GetValue() == n)
            {
                Node<int> delete = list;
                list = list.GetNext();
                delete.SetNext(null);
                return list;
            }
            Node<int> new_list = list;
            while (new_list != null)
            {
                if (new_list.GetNext().GetValue() == n)
                {
                    Node<int> delete = new_list.GetNext();
                    new_list.SetNext(new_list.GetNext().GetNext());
                    delete.SetNext(null);
                    return list;
                }
                new_list = new_list.GetNext();
            }
            return list;
        }
        static void Main(string[] args)
        {            
            Node<int> number = AddRandom(10);//מוספיה לרשמה הרחים רנדומלים בגודלה המספר

            // p76 ex 14
            Console.WriteLine("number = " + number);
            Console.WriteLine("Reduces_multiple_n(number, 3)= " + Reduces_multiple_n(number, 3));

            //Console.WriteLine("_Reduces_multiple_n_");
            //Console.WriteLine("Reduces_multiple_n(null,4)= " + Reduces_multiple_n(null, 4));//=null
            Console.WriteLine("Reduces_multiple_n(number, 0)= " + Reduces_multiple_n(number, 0));//=number
           // Console.WriteLine("Reduces_multiple_n(number, 1) = " + Reduces_multiple_n(number, 1));
            Console.WriteLine("Reduces_multiple_n(number, 3)= " + Reduces_multiple_n(number, 3));

            /*
             לפניהם  x מספרים שהוצאו יש לי          
          _reduces_multiple_n_ דוגמא              
                                 number = 1->5->4->2->2->1->2->4->1->5->2->5->5->4->2->2->2->1->2->5->3->
              Reduces_multiple_n(null,4)= null
           Reduces_multiple_n(number, 0)= 1->5->4->2->2->1->2->4->1->5->2->5->5->4->2->2->2->1->2->5->3->//(כלום לא הוצאה כי מנסים להוציא 0 מספרים)
           1->5->4->2->2->1->2->4->1->5->2->5->5->4->2->2->2->1->2->5->3->
           Reduces_multiple_n(number, 1)= 1->4->2->2->1->2->4->1->5->2->5->5->4->2->2->2->1->2->5->3-> 
            1->x5->4->2->2->1->2->4->1->5->2->5->5->4->2->2->2->1->2->5->3->
           Reduces_multiple_n(number, 3)= 1->4->2->2->1->2->4->1->2->5->4->2->2->2->1->2->5->3->
           1->x5->4->2->2->1->2->4->1->x5->2->x5->5->4->2->2->2->1->2->5->3->
              Reduces_multiple_n(null,4)= null //(רשימה ריקה להכין  לא מודפס כלום)*/
            /*
           Console.WriteLine("_Reduces_");           
           Console.WriteLine("Reduces(number,0)= " + Reduces(number, 0));//=number
           Console.WriteLine("Reduces(number,1)= " + Reduces(number, 1));
           Console.WriteLine("Reduces(number,3)= " + Reduces(number, 3));
           Console.WriteLine("Reduces(null,4)= " + Reduces(null, 4));//=null
           *//*  
            דוגמאות לפלט
               לפניהם  x מספרים שהוצאו יש לי          
            _Reduces_דוגמא
                     number = 1->3->2->5->2->4->2->4->2->5->2->1->4->1->5->1->5->4->3->2->2->
           Reduces(number,0)= 1->3->2->5->2->4->2->4->2->5->2->1->4->1->5->1->5->4->3->2->2->//(כלום לא הוצאה כי המספר לא מופיע)
           Reduces(number,3)= 1->2->5->2->4->2->4->2->5->2->1->4->1->5->1->5->4->3->2->2->
           1->x3->2->5->2->4->2->4->2->5->2->1->4->1->5->1->5->4->3->2->2->
           Reduces(number,1)= 2->3->5->2->4->2->4->2->5->2->1->4->1->5->1->5->4->3->2->2->
           x1->3->2->5->2->4->2->4->2->5->2->1->4->1->5->1->5->4->3->2->2->
           Reduces(null, 4) = null //(רשימה ריקה להכין  לא מודפס כלום)

          */

        }

    }
}
