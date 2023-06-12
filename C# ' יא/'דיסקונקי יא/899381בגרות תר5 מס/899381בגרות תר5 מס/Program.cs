using System;


namespace _899381בגרות_תר5_מס
{
    class Program
    {
        
        public static int Count(Node<int> list)//ex2
        {//הפעולה מקבלת רשימה ומחזרה אתה כמות עברים  
            int count = 0;
            while (list != null)
            {
                count++;
                list = list.GetNext();
            }
            return count;
        }
        public static int ToNumber(Queue<int> list)//א
        {//"תור מספר" הוא תור של ספרות בין 1 ל־ 9( כולל(, המייצג מספר שלם
         // האיבר הראשון )ראש התור( הוא ספרת האחדות, האיבר השני הוא ספרת העשרות וכן הלאה
            int q = 0, n = 1;
            while (!list.IsEmpty())
            {
                q += list.Remove() * n;
                n *= 10;
            }
            return q;
        }
        public static int BigNumber(Node<Queue<int>> lst)//ב
        {//כתוב פעולה בשם BigNumber ב־ #C , המקבלת הפניה lst לשרשרת החוליות,
         //ומחזירה את המספר הגדול ביותר המיוצג בשרשרת החוליות
            //Node<Queue<int>> poit=lst ;
            int max = 0;
            while (!lst.Equals(null))
            {
                if (ToNumber(lst.GetNext().GetValue())>max)
                    max = ToNumber(lst.GetNext().GetValue());
                
                lst = lst.GetNext();
            }

            return max;
        }
        public static Queue<int> AddRandom_Queue(int i)//int //לולא
        {//הפעולה מקבלה מספר ומתקנת ומוספיה לתור הרחים רנדומלים בגודלה המספר 
            //o(n)for זה לולא n
            Random r = new Random();
            Queue<int> q = new Queue<int>();
            for (int z = 0; z < i; z++)
            {
                int h = r.Next(1, 10);//מגרלה מספרים 1 עד9 
                q.Insert(h);
            }
            return q;
        }
        public static Node<int> AddRandom_Node(int i)//int //לולא
        {//הפעולה מקבלה מספר ומתקנת ומוספיה לרשמה הרחים רנדומלים בגודלה המספר 
            Random r = new Random();
            Node<int> list = new Node<int>(r.Next(1, 6));
            Node<int> n = list;// מצביע עזר שמתקדם מחולים לחוליה;
            for (i = i - 1; 0 < i; i--)
            {
                n.SetNext(new Node<int>(r.Next(1, 10))); //מגרלה מספרים 1 עד9 
                n = n.GetNext();
            }
            return list;
        }
        static void Main(string[] args)
        {
            Random r = new Random();
            Queue<int> q = AddRandom_Queue(3);
            Console.WriteLine(q);
            Console.WriteLine(ToNumber(q));
            Queue<int> n = null;
            Node<Queue<int>> lstq = null;
           for (int i = 0; i < 4; i++)
           {
                r = new Random();
                n = AddRandom_Queue(r.Next(2,5));
                lstq = new Node<Queue<int>>(n, lstq);
           }
            Console.WriteLine(lstq);
            Console.WriteLine(BigNumber(lstq));
        } 
    }
}
