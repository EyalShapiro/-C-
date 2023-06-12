using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace רקורסיה_הלה_תור
{
    class Program
    {
        /*
        public static int Len<T>(Queue<T> list)//רקורסיה 1
        {//הפעולה מקבלת  ומחזרה אתה כמות עברים  

            if (list.IsEmpty())
                return 0;
            list.Remove();
            return Len<T>(list) + 1;

        }*/
        public static int Len<T>(Queue<T> list, Queue<T> remo)//רקורסיה 2//שומר תור 
        {//הפעולה מקבלת  ומחזרה אתה כמות עברים  

            if (list.IsEmpty())
                return 0;
            remo.Insert(list.Remove());
            return Len(list,remo) + 1;

        }
        /*
        public static int Sum(Queue<int> list)//1 רוקרסיה
        {//הפעולה מקבלת  ומחזרה אתה סכום עברים  
            if (list.IsEmpty())
                return 0;
            return  list.Remove()+Sum(list);
           
        }*/
        public static int Sum(Queue<int> list,Queue<int> remo)//2 רוקרסיה
        {//הפעולה מקבלת  ומחזרה אתה סכום עברים  
            if (list.IsEmpty())
                return 0;
            remo.Insert(list.Head());
            return list.Remove() + Sum(list,remo);
        }
        
        public static bool Find_tav<T>(Queue<T> list, T tav, Queue<T> remo)
        {//הפעולה מקבלת תור ואיבר ובדקה אם איבר נמצה בתור
            if (list.IsEmpty())
                return false;
            if (list.Head().Equals(tav))
            {
                while (!list.IsEmpty())
                    remo.Insert(list.Remove());
                return true;
            }
            remo.Insert(list.Remove());
            return Find_tav(list, tav, remo);
        }
        public static void Reverse<T>(Queue<T> list)
        {//הפעולה מקבלת תור ומחזרה אותו הפוך
            if (!list.IsEmpty())
            {
                T tav = list.Remove();
                Reverse(list);
                list.Insert(tav);
            }
        }
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();
            for (int i = 0; i < 10; i++)
            {
                q.Insert(i);
            }
            //Console.WriteLine(Len(q));
            //Console.WriteLine(Len(q,null));
            //Console.WriteLine(Sum(q));
            //Console.WriteLine(Sum(q,null));
            Console.WriteLine(Find_tav(q,2,null));
        }
    }
}
