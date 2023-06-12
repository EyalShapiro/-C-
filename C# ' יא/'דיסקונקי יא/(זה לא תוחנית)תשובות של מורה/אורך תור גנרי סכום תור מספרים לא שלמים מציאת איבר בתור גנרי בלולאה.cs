using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static int Len<T>(Queue<T> q)
        {
            int len = 0;
            Queue<T> r = new Queue<T>();
            while (!q.IsEmpty())
            {
                len++;
                r.Insert(q.Remove());
            }
            while (!r.IsEmpty())
                q.Insert(r.Remove());
            return len;
        }
        public static double Sum(Queue<double> q)
        {
            double sum = 0;
            Queue<double> r = new Queue<double>();
            while (!q.IsEmpty())
            {
                sum += q.Head();
                r.Insert(q.Remove());
            }
            while (!r.IsEmpty())
                q.Insert(r.Remove());
            return sum;
        }
        public static bool Find<T>(Queue<T> q, T x)
        {
            bool found = false;
            Queue<T> r = new Queue<T>();
            while (!q.IsEmpty())
            {
                if (q.Head().Equals(x))
                    found = true;
                r.Insert(q.Remove());
            }
            while (!r.IsEmpty())
                q.Insert(r.Remove());
            return found;
        }
        static void Main(string[] args)
        {
        }
    }
}
