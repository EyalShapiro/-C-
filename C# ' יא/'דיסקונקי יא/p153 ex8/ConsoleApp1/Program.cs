using System;

namespace ConsoleApp1
{
    class Program
    {public static int LenQR<T>(Queue<T> q)
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
        public static Queue<int> Min_Max(Queue<int> man)
        {
            if (man.Equals(null))
            {
                return null;
            }
            Queue<int> q = man;
            Queue<int> em = new Queue<int>();
            while (!q.IsEmpty())
            {
                if (q.Head() > man.Head())
                {
                    em.Insert(Min(q));
                }
                q.Remove();

            }
            while (!em.IsEmpty())
            {
                q.Insert(em.Remove());
            }

            return man;
        
        }
        public static int Min (Queue<int> man)
        {
            Queue<int> omer = new Queue<int>();
            int min=100000;
            while (!man.IsEmpty())
            {
                if (man.Head() < min)
                    min = man.Head();
                omer.Insert(man.Remove());

            }
            while (!omer.IsEmpty())
                man.Insert(omer.Remove());
            return min;
        }
        public static Queue AddRandom<T>(int i)//int //לולא
        {//הפעולה מקבלה מספר ומתקנת ומוספיה לתור הרחים רנדומלים בגודלה המספר 
            //o(n)for זה לולא n
            Random r = new Random();

            Queue<int> q = new Queue<int>();
            q.Insert(1);
            for (int z = 0; z < 10; z++)
            {
                int h = r.Next(1, 11);
                q.Insert(h);
            }

            return q;
        }
        public static void print<T>(Queue<T> list)
        {//הפעולה מקבלת תור ומדפיס
            while (!list.IsEmpty())
            {
                Console.WriteLine(list.Head());
            }
        }

        static void Main(string[] args)
        {
            Queue<int> q = AddRandom(10);
            print(q);
            Console.WriteLine("min "+Min(q));
            Console.WriteLine(Min_Max(q).ToString());
                

            }
    }
}
