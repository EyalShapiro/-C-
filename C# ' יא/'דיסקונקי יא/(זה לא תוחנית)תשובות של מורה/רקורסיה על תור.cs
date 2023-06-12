using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        public static int LenQR<T>(Queue<T> q)
        {
            if (q.IsEmpty())
                return 0;
            q.Remove();
            return LenQR(q) + 1;
        }
        public static int LenQRS<T>(Queue<T> q, Queue<T> r)
        {
            if (q.IsEmpty())
                return 0;
            r.Insert(q.Remove());
            return LenQRS(q, r) + 1;
        }
        public static int SumQR(Queue<int> q)
        {
            if (q.IsEmpty())
                return 0;
            return q.Remove() + SumQR(q);
        }
        public static int SumQRS(Queue<int> q, Queue<int> r)
        {
            if (q.IsEmpty())
                return 0;
            r.Insert(q.Head());
            return q.Remove() + SumQRS(q, r);
        }
        public static bool IsExistQR<T>(Queue<T> q, T x)
        {
            if (q.IsEmpty())
                return false;
            if (q.Head().Equals(x))
                return true;
            q.Remove();
            return IsExistQR(q, x);
        }
        public static bool IsExistQRS<T>(Queue<T> q, T x, Queue<T> r)
        {
            if (q.IsEmpty())
                return false;
            if (q.Head().Equals(x))
            {
                while (!q.IsEmpty())
                    r.Insert(q.Remove());
                return true;
            }
            r.Insert(q.Remove());
            return IsExistQRS(q, x, r);
        }
        public static void ReverseQR<T>(Queue<T> q)
        {
            if (!q.IsEmpty())
            {
                T x = q.Remove();
                ReverseQR(q);
                q.Insert(x);
            }
        }
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();
            q.Insert(1);
            q.Insert(2);
            q.Insert(3);
            Console.WriteLine(q);
            Queue<int> r = new Queue<int>();
            Console.WriteLine(LenQRS(q, r));
            Console.WriteLine(q);
            Console.WriteLine(r);
            Console.WriteLine(SumQRS(r, q));
            Console.WriteLine(r);
            Console.WriteLine(q);
            Console.WriteLine(IsExistQRS(q, 2, r));
            Console.WriteLine(q);
            Console.WriteLine(r);
            ReverseQR(r);
            Console.WriteLine(r);
        }
    }
}
