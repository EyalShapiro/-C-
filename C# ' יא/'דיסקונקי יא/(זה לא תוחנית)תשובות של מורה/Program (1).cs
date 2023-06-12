using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace תרגילי_רשימות
{
    class Program
    {
        //תרגיל 11
        //פעולה שמחזירה את כל המספרים של הרשימה לפי סדר הפוך כלפי הסדר של הקלט
        public static Node<int> Reverse()
        {
            Console.WriteLine(":::::::::ENTER A NUMBER:::::::");
            Node<int> n = null;
            int num = int.Parse(Console.ReadLine());
            while (num != -999)
            {
                n = new Node<int>(num, n);//פעולה בונה
                num = int.Parse(Console.ReadLine());
            }
            return n;
        }
        public static bool SederOle(Node<int> list)
        {
            //ex 8
            // טענת כניסה: פעולה המקבלת רשימה
            // טענת יציאה: פעולה המחזירה אמת אם הרשימה ממוינת בסדר עולה ושקר אחרת
            while (list.GetNext() != null)
            {
                if (list.GetValue() > list.GetNext().GetValue())
                {
                    return false;
                }
                list = list.GetNext();
            }
            return true;
        }

        //16: כתוב פעולה המקבלת רשימה של תווים ומציגה את מספר הפעמים שכל תו מופיע ברשימה. כל תו יוצג רק פעם אחת
        public static Node<char> RemoveChar(Node<char> list, char cha)
        //Removes a char from a list and returns said list without the char
        {
            Node<char> n = null;
            while (list != null && list.GetValue() == cha)
                list = list.GetNext();
            Node<char> newlist1 = list;
            if (list != null)
            {
                n = list;
                list = list.GetNext();
            }
            while (list != null)
            {
                if (list.GetValue() == cha)
                {
                    n.SetNext(list.GetNext());
                    list.SetNext(null);
                    list = n.GetNext();
                }
                else
                {
                    list = list.GetNext();
                    n = n.GetNext();
                }
            }
            return newlist1;
        }
        public static int Char_Count(Node<char> list, char x)
        // counts the number of chars in a list
        {
            int count = 0;
            while (list != null)
            {
                if (list.GetValue() == x)
                    count++;
                list = list.GetNext();
            }
            return count;
        }
        public static void Count_All_Chars(Node<char> list)
        //Prints the number of times each char appears in a list
        {
            while (list != null)
            {
                Console.WriteLine(list.GetValue() + " -> " + Char_Count(list, list.GetValue()));
                list = RemoveChar(list, list.GetValue());
            }
        }

        public static Node<T> NewList<T>(Node<T> list1)
            //ex 6
        //הפעולה מקבלת רשימה ומחזירה רשימה חדשה של הערכים ברשימה הנוכחית ללא כפילויות 
        {
            Node<T> list2 = new Node<T>(list1.GetValue());
            Node<T> p2 = list2;
            list1 = list1.GetNext();
            while (list1 != null)
            {
                if (IsExist(list2, list1.GetValue()) == false)
                {
                    p2.SetNext(new Node<T>(list1.GetValue()));
                    p2 = p2.GetNext();
                }
                list1 = list1.GetNext();
            }
            return list2;
        }

        public static void Ex9(Node<int> list)
            //ex 9
        {//מקבלת רשימה ומדפיסה את כל האיברים ברשימה הגדולים מהאיבר העוקב להם 

            while (list.GetNext() != null)
            {
                if (list.GetValue() > list.GetNext().GetValue())
                    Console.WriteLine(list.GetValue());
                list = list.GetNext();
            }
        }
        public static int GetMax(Node<int> list)//int//פעולת עזר
        {//הפעולה מקבלת רשימה מחזרה את הערך הגדול
            int max = 0;
            while (list != null)
            {
                if (list.GetValue() > max)
                    max = list.GetValue();
                list = list.GetNext();
            }
            return max;
        }

        public static Node<int> Reduces_multiple_n(Node<int> list, int n) // p76 ex 14
        {//קטן ממספר האיברים ברשמה מוריד את כמות nו  n הפעולה מקבלת רשימה ומספר שלם  
            if (list == null) // הרשימה ריקה
                return null;
            if (n <= 0)
                return list;

            while (n > 0)
            {
                list = Reduces(list, GetMax(list));
                n--;
            }
            return list;
        }

        public static Node<int> Reduces(Node<int> list, int n)// p76 ex 14//פעולת עזר
        { // nברשמה מוריד את ה  n הפעולה מקבלת רשימה ומספר שלם
            if (list == null)
                return null;
            if (list.GetValue() == n)
            {
                Node<int> delete = list;
                list = list.GetNext();
                delete.SetNext(null);
                return list;
            }
            Node<int> new_list = list;
            while (new_list != null && new_list.HasNext())
            {
                if (new_list.GetNext().GetValue() == n)
                {
                    Node<int> delete = new_list.GetNext();
                    new_list.SetNext(new_list.GetNext().GetNext());
                    delete.SetNext(null);
                    return list;
                }
                new_list = new_list.GetNext();
            }
            return list;
        }

        //ex 18:
        //כניסה : הפעולה מקבלת רשימה של שמות פרטיים ושמות משפחה ולאחר מכן היא מקבלת שם פרטי 
        //יציאה:הפעולה מחזירה את מספר הפעמים שהשם פרטי הבודד מופיע ברשימה של השמות האחרים 
        public static int Names(Node<string> list, string name)
        {
            int counter = 0;
            Node<string> pointer = list;
            while (pointer != null)
            {
                if (pointer.GetValue().Split(' ')[0] == name)
                    counter++;
                pointer = pointer.GetNext();
            }
            return counter;
        }
        public static Node<string> BuildList()
        {
            Node<string> list = null;
            Console.WriteLine("enter full name , ! to end");
            string name = Console.ReadLine();
            if (name != "!")
            {
                list = new Node<string>(name);
                Node<string> pointer = list;
                name = Console.ReadLine();
                while (name != "!")
                {
                    pointer.SetNext(new Node<string>(name));
                    pointer = pointer.GetNext();
                    name = Console.ReadLine();
                }
            }
            return list;
        }

        //ex 7:
        public static int Count(Node<int> list)
        {//מקבל רשימה  מחזיר כמה איברים

            int count = 0;
            while (list != null)
            {
                count++;
                list = list.GetNext();
            }
            return count;
        }
        public static Node<int> Random_list_no_dup()
        {//מגריל 50 מספרים מחזיר רשימה בלי שיכפולים
            Node<int> list1 = new Node<int>(0);
            Node<int> list2 = list1;
            Random rnd = new Random();
            int num = rnd.Next(10, 100);
            list1.SetValue(num);

            for (int i = 0; i < 49; i++)
            {
                bool notinlist = true;
                num = rnd.Next(10, 100);
                list2 = list1;
                for (int d = 0; d < Count(list1); d++)
                {
                    if (list2.GetValue() == num || num % 10 == num / 10)
                        notinlist = false;
                    if (Count(list1) - 1 != d)
                        list2 = list2.GetNext();
                }
                if (notinlist == true)
                    list2.SetNext(new Node<int>(num));
            }
            return list1;
        }

        //ex 13:
        // טענת כניסה: הפעולה מקבלת רשימה
        // טענת יציאה: הפעולה מחזירה את אורכה, מספר החוליות שבה
        public static int Count(Node<int> list)
        {
            int count = 0;
            while (list != null)
            {
                count++;
                list = list.GetNext();
            }
            return count;
        }
        // טענת כניסה: הפעולה מקבלת רשימת מספרים שלמים
        // טענת יציאה: הפעולה מחזירה את המספר המקסימלי ברשימה
        public static void Number(Node<int> list)
        {
            Node<int> number_middle_before = list;
            if (Count(list) % 2 == 0)
            {
                for (int i = 0; i < Count(list) / 2 - 2; i++)
                {
                    number_middle_before = number_middle_before.GetNext();

                }
                Node<int> number_middle = number_middle_before.GetNext();
                if (number_middle.GetValue() > number_middle.GetNext().GetValue())
                {
                    number_middle_before.SetNext(number_middle.GetNext());
                    number_middle.SetNext(null);
                }
                else
                {
                    number_middle_before = number_middle;
                    number_middle = number_middle.GetNext();
                    number_middle_before.SetNext(number_middle.GetNext());
                    number_middle.SetNext(null);
                }
            }
            else
            {
                list = list.GetNext();
                Node<int> next_null = list;
                while (next_null.GetNext().HasNext())
                {
                    next_null = next_null.GetNext();
                }
                next_null.SetNext(null);
                Console.WriteLine(list);
            }
        }
        static void Main(string[] args)
            {
           
            //ex 8:
            Node<int> k = new Node<int>(2);
            Node<int> save = k;
            for (int i = 3; i <= 5; i++)
            {
                save.SetNext(new Node<int>(i));
                save = save.GetNext();
            }
            Console.WriteLine(k); //  2->3->4->5
            Console.WriteLine(SederOle(k)); // 2->3->4->5 => true
            Node<int> n1 = new Node<int>(3);
            Node<int> n2 = new Node<int>(7);
            n1.SetNext(n2); // 3->7->
            Node<int> n3 = new Node<int>(0);
            n2.SetNext(n3); // 3->7->0
            Console.WriteLine(n1); // 3->7->0
            Console.WriteLine(SederOle(n1)); // 3->7->0 => false

            //Ex9:
            Random rnd = new Random();
            Node<int> list = new Node<int>(5);
            Node<int> numbers = list;//מצביע נוסף
            for (int i = 1; i < 11; i++)
            {
                int n = rnd.Next(10);
                list.SetNext(new Node<int>(n));
                list = list.GetNext();
            }
            Console.WriteLine("list: " + numbers);
            Ex9(numbers);

            //Ex 6:
            Node<int> list1 = new Node<int>(2, new Node<int>(5, new Node<int>(5, new Node<int>(4, new Node<int>(2, new Node<int>(3))))));
            Console.WriteLine(NewList(list1));

            //ex 16:
            char input;
            Console.WriteLine("Enter a char to add to the list ('-' to end): ");
            input = char.Parse(Console.ReadLine());
            Node<char> charlist2 = new Node<char>(input);
            Node<char> i = charlist2;
            input = char.Parse(Console.ReadLine());
            while (input != '-')
            {
                i.SetNext(new Node<char>(input));
                i = i.GetNext();
                input = char.Parse(Console.ReadLine());
            }
            Count_All_Chars(charlist2);

            //ex 14:
            // לבנות רשימה על ערכים של מספרים מוגרילם 
            Random r = new Random();
            Node<int> number = new Node<int>(1);
            Node<int> n = number;// מצביע עזר שמתקדם מחולים לחוליה
            for (int i = 0; i < 20; i++)
            {
                n.SetNext(new Node<int>(r.Next(1, 6))); //מגרלה מספרים 1 עד 5 
                n = n.GetNext();
            }
            // p76 ex 14
            Console.WriteLine("number = " + number);
            Console.WriteLine("Reduces_multiple_n(number, 3)= " + Reduces_multiple_n(number, 3));

            //ex 18:
            Node<string> list = BuildList();
            Console.WriteLine(Names(list, Console.ReadLine()));

            //ex 7:
            Console.WriteLine(Random_list_no_dup());
        }


    }
}
