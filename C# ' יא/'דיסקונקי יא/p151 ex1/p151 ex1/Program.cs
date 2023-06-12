using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p151_ex1
{
    class Program
    {
        public static bool Fon_tav<T>(Queue<T> list, T tav)//p151 ex1
        {//הפעולה מקבלת תור ואיבר ובדקה אם איבר נמצה יותר מפעם 1 בתור
            // o(n)
            int count = 0;
            Queue<T> remove = new Queue<T>();

            while (!list.IsEmpty())
            {
                if(list.Head().Equals(tav))
                    count++;
                remove.Insert(list.Remove());
            }
            while (!remove.IsEmpty())
                list.Insert(remove.Remove());
            if (count > 1)
                return true;
            return false;

        }
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();
            q.Insert(1);
            q.Insert(1);
            q.Insert(1);
            q.Insert(2);
            q.Insert(3);
            Console.WriteLine(q);
            Console.WriteLine(q.Remove());
            Console.WriteLine(Fon_tav(q, 1));
        }
    }
}
