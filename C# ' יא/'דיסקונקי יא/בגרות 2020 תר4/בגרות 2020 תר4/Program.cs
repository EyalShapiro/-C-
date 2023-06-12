using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace בגרות_2020_תר4
{
    class Program
    {
        public static Queue<int> clone(Queue<int> q1)
        {//פעולה מקבלת תורה ומשחפלת 
            Node<int> n1 = new Node<int>(q1.Remove());
            Queue<int> q2 = new Queue<int>();
            while (!q1.IsEmpty())
            {
                n1 = new Node<int>(q1.Remove(), n1);
            }
            while (n1 != null)
            {
                q1.Insert(n1.GetValue());
                q2.Insert(n1.GetValue());

                n1 = n1.GetNext();
            }
            return q2;
        }
        static void Main(string[] args)
        {

        }
    }
}
