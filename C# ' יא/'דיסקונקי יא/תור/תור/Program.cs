using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace תור
{
    class Program
    {
        public static int Len<T>(Queue<T> queue) 
        {//הפעולה מקבלת  ומחזרה אתה כמות עברים  
           
            int len = 0;
            Queue<T> remove = new Queue<T>();
            while (!queue.IsEmpty())
            {
                len++;
                remove.Insert(queue.Remove());
            }
            while (!remove.IsEmpty())
                queue.Insert(remove.Remove());
            return len;
        }
        /*
        public static int Count<T>(T val, Queue<T> list) 
        {//הפעולה מקבלת  ומחזרה אתה כמות עברים  
            int count = 0;
            if (list.IsEmpty())
                return 0;
            return Count(T, list)+1;
        }
        */
        public static double Sum (Queue<double> list)
        {//הפעולה מקבלת  ומחזרה אתה סכום עברים  
            double sum = 0;
            Queue<double> remove = new Queue<double>();
            while (!list.IsEmpty())
            {
                sum += list.Head();
                remove.Insert(list.Remove());
            }
            while (!remove.IsEmpty())
                list.Insert(remove.Remove());

            return sum;
        }
        public static bool Find_tav<T> (Queue<T> list, T tav)
        {//הפעולה מקבלת תור ואיבר ובדקה אם איבר נמצה בתור
            Queue<T> remove = new Queue<T>();
            bool bo =false;
            while (!list.IsEmpty())
            {
                if (list.Head().Equals(tav))
                    bo =true;
                remove.Insert(list.Remove());
            }
            while (!remove.IsEmpty())
                list.Insert(remove.Remove());
            return false;
           
        }
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();
            q.Insert(1);
            q.Insert(2);
            q.Insert(3);
            Console.WriteLine(q);
            Console.WriteLine(q.Remove());
            Console.WriteLine(q);
            Console.WriteLine(Len(q));
            Queue<double> q2 = new Queue<double>();
            q2.Insert(1.3);
            q2.Insert(2.5);
            q2.Insert(3);
            Console.WriteLine(Sum(q2));
            Console.WriteLine(Find_tav(q2,1.3));

        }
    }
}
