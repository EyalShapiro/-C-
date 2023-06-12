using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        public static bool IsExist(int num, Queue<int> q) // 2020/4a
        {
            Queue<int> r = new Queue<int>();
            bool exist = false;
            while (!q.IsEmpty())
            {
                if (q.Head() % 10 == num)
                    exist = true;
                r.Insert(q.Remove());
            }
            while (!r.IsEmpty())
                q.Insert(r.Remove());
            return exist;
        }
        public static Queue<int> Clone(Queue<int> q) // 2020/4b
        {
            Queue<int> r = new Queue<int>();
            Node<int> l = null, p = l;
            if (!q.IsEmpty())
            {
                l = new Node<int>(q.Head());
                p = l;
                r.Insert(q.Remove());
            }
            while (!q.IsEmpty())
            {
                p.SetNext(new Node<int>(q.Head()));
                p = p.GetNext();
                r.Insert(q.Remove());
            }
            p = l;
            while (p != null)
            {
                q.Insert(p.GetValue());
                p = p.GetNext();
            }
            return r;
        }
        public static int LeftDigit(int num) //2020/4b
        {
            while (num > 9)
                num /= 10;
            return num;
        }
        public static bool AllExist(Queue<int> q) // 2020/4b
        {
            Queue<int> r = Clone(q);
            while (!q.IsEmpty())
            {
                if (!IsExist(LeftDigit(q.Remove()), r))
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
        }
    }
}
