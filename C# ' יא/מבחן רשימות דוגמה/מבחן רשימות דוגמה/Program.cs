
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace מבחן_רשימות_דוגמה
{
    class Program
    {
        //ex 2
        public static int GetMin(Node<int> list)//פעולה עדר
        {//הפעולה מקבלת רשימה מחזרה את הערך הקטן
            int min = Math.Abs(list.GetValue());
            while (list != null)
            {
                if (Math.Abs(list.GetValue()) < Math.Abs(min))
                    min = list.GetValue();
                list = list.GetNext();
            }
            return min;
        }
        public static int GetMax(Node<int> list)//פעולה עזר
        {//הפעולה מקבלת רשימה מחזרה את הערך הגדול
            int max = Math.Abs(list.GetValue());
            while (list != null)
            {
                if (Math.Abs(list.GetValue()) > Math.Abs(max))
                    max = list.GetValue();
                list = list.GetNext();
            }
            return max;
        }
        public static Node<int> Number_Absolute(Node<int> list)
        {//הפעולה צריכה למצוא את המספר בעל הערך מוחלט הכי גדול ברשימה ולהעבירו לסוף הרשימה וכן את המספר בעל הערך מוחלט הכי קטן ברשימה ולהעבירו לתחילת הרשימה
            int max = GetMax(list), min = GetMin(list);
            Node<int> new_list = new Node<int> (max);
           
            while (list != null )
            {
                if (max != list.GetValue() && min != list.GetValue())
                {
                    new_list = new Node<int>(list.GetValue(), new_list);
                }
                list = list.GetNext();
            }
            new_list = new Node<int>(min, new_list);
            return new_list;
        }
        static void Main(string[] args)
        {
            Node<int> list = Direct();
            Console.WriteLine(GetMax(list));
            Console.WriteLine(Number_Absolute(list));

        }

        public static Node<int> Direct()
        {//הפעולה מקולת מספר מחנסה אותם לרשימה ומחזרה הותם בסדר הקליטה 
            Console.WriteLine(":::::::::ENTER A NUMBER:::::::");
            int num = int.Parse(Console.ReadLine());
            if (num == -1)
            {
                return null;
            }
            Node<int> n = new Node<int>(num);
            num = int.Parse(Console.ReadLine());
            Node<int> start = n;
            while (num != -999)
            {
                n.SetNext(new Node<int>(num));//פעולה בונה
                n = n.GetNext();
                num = int.Parse(Console.ReadLine());
            }
            return start;
        }

    }
}
