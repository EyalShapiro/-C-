using ImTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p93_ex15
{
    class Program
    {
        public static int Count_char(Node<char> lst, char tav)//p93 ex 15 א
        {//הפעולה מקבלת רשמת תוים ותו ומחזרה כמות הפעמים שתו תו מופיה ברשמה
            if (lst == null)
                return 0;
            if (lst.GetValue().Equals(tav))
                return Count_char(lst.GetNext(), tav) + 1;
            return Count_char(lst.GetNext(), tav);
        }
        
        public static void Count_abc(Node<char> lst)//p93 ex 15//פעולת עזר
        {//abc הפעולה מקבלת רשמת תוים  ומזמנת את הפעולה מסעיף א הכל אותו ב   

            for (char i = 'a'; i <='z'; i++)
                Console.WriteLine(i + ": " + Count_char(lst,i));
           
        }
        public static Node<char> AddRandom_char(int i)//char //לולא
        {//הפעולה מקבלה מספר ומתקנת ומוספיה לרשמה הרחים רנדומלים בגודלה המספר 
            Random r = new Random();
            Node<char> list = new Node<char>((char)r.Next('a', ((int)'z') + 1));
            Node<char> n = list;// מצביע עזר שמתקדם מחולים לחוליה;
            for (i = i - 1; 0 < i; i--)
            {
                n.SetNext(new Node<char>((char)r.Next('a', ((int)'z') + 1)));// z עד aמגרלה אותיות מ 
                n = n.GetNext();
            }
            return list;
        }
        static void Main(string[] args) 
        {
            //p93_ex15
            Node<char> tav = AddRandom_char(15);
            Console.WriteLine("tav " + tav);
            Console.WriteLine("Count_char(tav,'a') = " + Count_char(tav,'a'));
            Count_abc(tav);
        }
    }
}
