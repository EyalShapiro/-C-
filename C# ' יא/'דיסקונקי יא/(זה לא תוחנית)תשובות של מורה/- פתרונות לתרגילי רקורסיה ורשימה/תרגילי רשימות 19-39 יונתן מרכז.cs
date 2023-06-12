using System;

namespace ConsoleApp1
{
    class Program
    {
        ///////////////////////////////////////////////////////////////////////////////////////////////////19
        public static Node<string> ReverseList()
        //Gets an input of strings and creates a list with the oppisate order of inputs
        {
            Node<string> strings = null; //empty list
            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();
            while (input != "") //while input isn't empty
            {
                strings = new Node<string>(input, strings); //saves string at the begining of the list
                input = Console.ReadLine();
            }
            return strings;
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////20
        //ex 20 pg 93- כתוב פעולה חיצונית המקבלת רשימה של מחרוזות והופכת את סדר האיברים ברשימה
        //פעולת עזר שמחזירה את האיבר לפני האחרון
        public static Node<string> GetPrev(Node<string> start, Node<string> end)
        {
            Node<string> pointer = start;
            while (pointer.GetNext() != end)
                pointer = pointer.GetNext();
            return pointer;
        }

        //טענת כניסה: הפעולה מקבלת רשימה של מחרוזות והופכת את סדר האיברים
        //טענת יציאה: הפעולה מחזירה את הרשימה שהתקבלה
        public static Node<string> ReverseList(Node<string> list)
        {
            int counter = 0;
            Node<string> start = list;
            Node<string> end = start;
            while (end.GetNext() != null)
            {
                counter++;
                end = end.GetNext();
            }
            counter++;
            Node<string> newlist = new Node<string>(end.GetValue());
            Node<string> pnt = newlist;
            Node<string> prev = null;
            for (int i = 0; i < counter - 2; i++)
            {
                prev = GetPrev(start, end);
                pnt.SetNext(new Node<string>(prev.GetValue()));
                pnt = pnt.GetNext();
                end = prev;
            }
            pnt.SetNext(new Node<string>(start.GetValue()));
            return newlist;
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////21
        public static void PrintList(Node<string> first)
        {
            //טענת כניסה: הפעולה מקבלת את התו
            //טענת יציאה: הפעולה מחזירה את התו, חץ לתו הבא ועוברת לתו הבא
            Node<string> pose = first;
            while (pose != null)
            {
                Console.WriteLine(pose.GetValue() + "->");
                pose = pose.GetNext();
            }
        }
        public static Node<string> ABCheck(Node<string> first)
        {
            //טענת כניסה: הפעולה מקבלת רשימה ובודקת אם המחזרות לפי האב
            //טענת יציאה: הפעולה מחזירה את המחרוזת שלא לפי סגר האב ואם הכל כן אז נל
            Node<string> Pose;
            Pose = first;
            while (Pose.GetNext() != null)
            {
                if (string.Compare(Pose.GetValue(), Pose.GetNext().GetValue()) > 0)
                {
                    return Pose;
                }
                Pose = Pose.GetNext();
            }
            return null;
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////22
        public static string Reverse(string str) // reverse string 0(1)
        {
            return Reverse(str, "");
        }
        public static string Reverse(string str, string new_str) // reverse string
        {
            if (str.Length == 1)
                return new_str + str; // 0(1)
            else
            {
                new_str += str.Substring(str.Length - 1);
                return Reverse(str.Substring(0, str.Length - 1), new_str); // O(n) הרקורסיה מתבצעת כאורך מספר התוים בסטרינג
            }
        } // O(n)*O(1) + O(1) = O(n)

        ///////////////////////////////////////////////////////////////////////////////////////////////////23
        public static void Update(Node<int> st)
        {//פעולה המקבלת רשימה של מספרים, משווה בין ערכו של איבר מסויים לערך האיבר שאחריו, אם האיבר הראשון גדול מהשני, מעדכנת את ערך האיבר השני לערך האיבר הראשון. אם התנאי לא מתקיים ערך האיבר הראשון מתעדכן לערך האיבר השני

            Node<int> p = st;
            Node<int> r = p.GetNext();
            while (r != null)
            {
                if (p.GetValue() > r.GetValue())
                    r.SetValue(p.GetValue());
                else
                    p.SetValue(r.GetValue());
                p = p.GetNext().GetNext();
                if (p != null)
                    r = p.GetNext();
                else
                    r = null;
            }
            Console.WriteLine(st);
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////25
        public static bool Sequencelist(Node<int> list, int num)
        {
        // הפעלוה מחזירה true אם מתקיים רצף של המספרים העוקביים של המספר 
        // הפעולה מחזירה false אם אין רצף
            int counter = 1; // num =3 
            //3,4,5
            Node<int> pointer = list;
            while (pointer != null)
            {
                if (pointer.HasNext() && pointer.GetValue() + 1 == pointer.GetNext().GetValue())
                    counter++;
                else if (pointer.HasNext() && pointer.GetValue() + 1 != pointer.GetNext().GetValue())
                    counter = 1;
                pointer = pointer.GetNext();
            }
            if (counter == num)
                return true;
            return false;
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////26

        public static Node<int> New_26List(Node<int> n)
        {
         //פעולה שמסדרת ומכניסה לרשימה חדשה את את המספרים הזוגיים בהתחלה ואת האי זוגיים בסוף הרשימה
           if (n == null)
                return null;
            Node<int> n2 = n;
            Node<int> n3 = n.GetNext();
            while (n3 != null)
            {
                if (n3.GetValue() % 2 == 0)
                {
                    n.SetNext(n3.GetNext());
                    n3.SetNext(n2);
                    n2 = n3;
                    n3 = n.GetNext();
                }
                else
                {
                    n = n3;
                    n3 = n3.GetNext();
                }
            }
            return n2;
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////27
        public static int Count<T>(Node<T> list)//פעולת בדיקה//רקורסיה
        {//הפעולה מקבלת רשימה ומחזרה אתה כמות עברים  
            if (list == null)
            {
                return 0;
            }
            return Count(list.GetNext()) + 1;
        }
        public static Node<int> Reduces_Exces(Node<int> list)// p95 ex 27
        {//הפעולה רשימה מקבלת שלמים ומבטלת  כל רצף המכיל יותר מ2 מספרים    
            if (list == null) // הרשימה ריקה    
                return null;
            if (!list.HasNext())
                return list;
            //Node<int> save = list;
            Node<int> point = list;
            int count = SeveralTimesListed(list, list.GetValue());
            while (count > 2)
            {
                while (list != null && count > 0)
                {
                    Node<int> delete = list;
                    list = delete.GetNext();
                    delete.SetNext(null);
                    count -= 1;
                }
                count = SeveralTimesListed(point, point.GetValue());
            }
            point = list;
            while (point != null && point.HasNext())
            {
                count = SeveralTimesListed(point.GetNext(), point.GetNext().GetValue());
                if (count > 2)
                {
                    while (count > 0)
                    {
                        Node<int> delete = point.GetNext();
                        point.SetNext(delete.GetNext());
                        delete.SetNext(null);
                        count -= 1;
                    }
                }
                point = point.GetNext();
            }
            return list;
        }
        public static int SeveralTimesListed(Node<int> list, int num)//p95 ex 27 פעולה עזר ל 
        {// הפעולה מקבלת מספר ורשימה ומחזרה אתה כמות הפעמים שהיא נמצת  
            if (list != null && num.Equals(list.GetValue()))
                return (SeveralTimesListed(list.GetNext(), num) + 1);
            return 0;
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////28
        ///אין
        ///////////////////////////////////////////////////////////////////////////////////////////////////29
        /*
        public static int Targil29(LinkedList<int> list)
        {\\טענת כניסה: פעולה המקבלת רשימה של מספרים שלמים
            \\טענת יציאה: הפעולה תחזיר את מספר הסדרות העקביות ברשימה
            LinkedListNode<int> pos = list.First;
            int couterSeries = 0, counter = 1, lastNum = pos.Value;
            pos = pos.Next;
            int dir = 0;
            bool flag = true;
            while (pos != null)
            {
                if (pos.Value != -999)
                {
                    if (pos.Value > lastNum)
                    {
                        if (dir == -1)// שינוי כיוון באמצע הסדרה
                        {
                            flag = false;
                        }
                        else
                        {
                            dir = 1;
                            counter++;
                        }
                    }
                    else
                    {
                        if (pos.Value < lastNum)
                        {
                            if (dir == 1)// שינוי כיוון באמצע הסדרה
                            {
                                flag = false;
                            }
                            else
                            {
                                dir = -1;
                                counter++;
                            }
                        }
                        else //איברים שווים ולכן לא סדרה עקבית
                        {
                            flag = false;
                        }
                    }
                }
                else //הסתיימה סדרה
                {
                    if (flag && counter >= 3)
                        couterSeries++;
                    counter = 1;
                    dir = 0;
                    flag = true;
                    pos = pos.Next;
                }
                lastNum = pos.Value;
                pos = pos.Next;
            }
            return couterSeries;
        }
        */
        ///////////////////////////////////////////////////////////////////////////////////////////////////30
        public static bool IsPalindrom(Node<char> list, int n)
        {
            // טענת כניסה: פעולה המקבלת רשימה ומספר שלם
            // ושקר אחרת N טענת יציאה: פעולה המחזירה אמת אם יש ברשימה תת - רשימה פלינדרום שאורכו הוא 
            Node<char> start = list;
            while (start != null)
            {
                Node<char> end = start;
                for (int i = 0; i < n - 1 && end != null; i++)
                {
                    end = end.GetNext();
                }
                Node<char> start2 = start;
                if (end != null)
                {
                    bool exit = true;
                    for (int i = 0; i < n / 2 && exit == true; i++)
                    {
                        if (start.GetValue() == end.GetValue())
                        {
                            Node<char> prev_end = start;
                            while (prev_end.GetNext() != end)
                            {
                                prev_end = prev_end.GetNext();
                            }
                            end = prev_end;
                            start = start.GetNext();
                        }
                        else
                        {
                            exit = false;
                        }
                    }
                    if (exit == true)
                        return true;
                }
                start = start2.GetNext();
            }
            return false;
        }
        public static int LongestPalindrom(Node<char> list)
        {
            // טענת כניסה: הפעולה מקבלת רשימה
            // טענת יציאה : פעולה שמחזירה את אורך הפלינדרום הארוך ביותר ברשימה ואם אין פלינדרום היא מחזירה 1
            Node<char> start = list;
            int length = 0;
            int max = 0;
            while (start != null)
            {
                start = start.GetNext();
                length++;
            }
            for (int i = 1; i <= length; i++)
            {
                if (IsPalindrom(list, i))
                    max = i;
            }
            return max;
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////31
        public static Node<int> New(Node<int> list1, Node<int> list2)
        {//כניסה:הפעולה מקבלת 2 רשימות
            //יציאה:הפעולה מוצא את האיברים המשותפים לרשימות ,מכניסה אותם לרשימה חדשה ומחזירה אותה
     
            Node<int> p1 = list1;
            Node<int> p2 = list2;
            Node<int> list3 = null;
            Node<int> p3 = list3;
            while (p1 != null)
            {
                while (p2 != null)
                {
                    if (p1.GetValue() == p2.GetValue())
                    {
                        if (list3 == null)
                        {
                            list3 = new Node<int>(p1.GetValue());
                            p3 = list3;
                        }
                        else
                        {
                            p3.SetNext(new Node<int>(p1.GetValue()));
                            p3 = p3.GetNext();
                        }
                        p2 = null;
                    }
                    else
                    {
                        p2 = p2.GetNext();
                    }
                }
                p2 = list2;
                p1 = p1.GetNext();
            }
            return list3;
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////32
        public static int Bigger_num(Node<int> lis1, Node<int> lis2)
        {
            int num1 = 0;
            while (lis1.HasNext())
            {
                num1 *= 10;
                num1 += lis1.GetValue();
                lis1 = lis1.GetNext();
            }
            num1 += lis1.GetValue();

            int num2 = 0;
            while (lis2.HasNext())
            {
                num2 *= 10;
                num2 += lis2.GetValue();
                lis2 = lis2.GetNext();
            }
            num2 += lis2.GetValue();

            if (num1 > num2)
                return 1;
            else if (num1 < num2)
                return 2;
            else
                return 0;
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////33
        public static Node<int> RemoveList2(Node<int> list1, Node<int> list2)
        {//הפעולה מקבלת שתי רשימות ומוחקת את הרשימה השנייה המופיעה ברצף ברשימה הראשונה
            Node<int> l1 = list1, l2 = list2, l11 = l1;//מצביעים נוספים לרשימות
            bool x = false;
            while (list1 != null && !x)
            {
                if (list1.GetValue() == list2.GetValue())
                {
                    list1 = list1.GetNext();
                    list2 = list2.GetNext();
                    while (list2 != null && list1.GetValue() == list2.GetValue())
                    {
                        list1 = list1.GetNext();
                        list2 = list2.GetNext();
                    }
                    if (list2 == null)
                    {
                        if (l1 == l11)
                            l11 = list1;
                        l1.SetNext(list1);
                        x = true;
                    }
                    else
                    {
                        list2 = l2;
                    }
                }
                else
                {
                    list1 = list1.GetNext();
                }
                l1 = l1.GetNext();
            }
            list1 = l11;
            return list1;
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////34
        public static Node<T> Getlast<T>(Node<T> list1)
        {//מקבלת רשימה מחזריה את החוליה אחרונה
            Node<T> last = list1;
            while (last.HasNext())
                last = last.GetNext();
            return last;
        }
        public static Node<T> Getprev<T>(Node<T> list1)
        {//מקבלת רשימה מחזירה את החוליה הקודמת לה
            Node<T> list2 = list1;
            Getlast(list2);
            while (list1.GetNext() != list2)
                list1 = list1.GetNext();
            return list1;
        }
        public static void Flip<T>(Node<T> list, Node<T> final)
        {//מקבלת רשימה ומצביע לאיבר האחרון ומחזירה את הרשימה הפוך
            if (!list.Equals(final) && !list.GetNext().Equals(final))
            {
                T x = list.GetValue();
                T y = final.GetValue();
                if (!x.Equals(y))
                {
                    list.SetValue(y);
                    final.SetValue(x);
                }
                Node<T> prev = list;
                while (prev.GetNext() != final)
                    prev = prev.GetNext();
                Flip(list.GetNext(), prev);
            }
        }
        public static Node<int> Sum(Node<int> list1, Node<int> list2)
        {//מקבלת שתי רשימות מחזירה רשימה עם הסכום שלהם בלי משתנים מאחסנים 
            Node<int> fl1 = list1;
            Node<int> fl2 = list2;
            Flip(fl1, Getlast(fl1));
            Flip(fl2, Getlast(fl2));

            int add = 0;
            Node<int> summary = null;
            while (fl1 != null || fl2 != null)
            {
                if (summary == null)
                {
                    summary = new Node<int>((fl1.GetValue() + fl2.GetValue()) % 10, summary);
                    if (fl1.GetValue() + fl2.GetValue() > 9)
                        add = 1;
                }
                else
                {
                    summary = new Node<int>((fl1.GetValue() + fl2.GetValue() + add) % 10, summary);
                    if (fl1.GetValue() + fl2.GetValue() > 9)
                        add = 1;
                    else
                        add = 0;
                }
                fl1 = fl1.GetNext();
                fl2 = fl2.GetNext();
            }
            if (fl1 == null && fl2 == null)
            {
                return summary;
            }
            if (fl1 == null)
            {
                while (fl2 != null)
                {
                    summary = new Node<int>(fl2.GetValue(), summary);
                    fl2 = fl2.GetNext();
                }
            }
            else if (fl2 == null)
            {
                while (fl1 != null)
                {
                    summary = new Node<int>(fl1.GetValue(), summary);
                    fl1 = fl1.GetNext();
                }
            }
            return summary;
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////38
        public static int SmallestNum(Node<int> lst1, Node<int> lst2)
        {
            //תרגיל 38
            //בהנחה שבשתי הרשימות יש אן חוליות הלולאה מתבצעת מקסימום אן פעמים ולכן הסיבוכיות היא O של n
            Node<int> current1 = lst1, current2 = lst2;
            while (current1 != null && current2 != null)
            {
                if (current1.GetValue() < current2.GetValue())
                    current1 = current1.GetNext();
                if (current2.GetValue() < current1.GetValue())
                    current2 = current2.GetNext();
                if (current1.GetValue() == current2.GetValue())
                {
                    return current1.GetValue();
                }
            }
            return -999;
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////39   
        /*
        // טענת כניסה: הפעולה מקבלת חולייה
        // (טענת יציאה: הפעולה עוברת על החוליות ומדפיסה את הערך שבתוכן (הפעולה לא מחזירה כלום
        public static void PrintList(Node<int> head)
        {
            Node<int> i = head;

            while (i != null)
            {
                Console.Write(i.GetValue() + " -> ");
                i = i.GetNext();
            }
            Console.WriteLine("null");
        }

        // int טענת כניסה: הפעולה מקבלת שתי חוליות מסוג  
        //( O(n) טענת יציאה: הפעולה מוצאת את כלל האיברים המשותפים בשתי הרשימות ומחזיר אותם ברשימה נוספת (בסיבוכיות זמן של 
        public static Node<int> Equal(Node<int> lis1, Node<int> lis2)
        {
            Node<int> i = lis1; // יצירת חוליית עזר על מנת לעבור על הרשימה הראשונה
            Node<int> j = lis2; // יצירת חוליית עזר על מנת לעבור על הרשימה השנייה
            Node<int> result = null; // יצירת רשימת התוצאות שתוחזר
            Node<int> k = result; // יצירת חוליית עזר על מנת לעבור על רשימת התוצאות


            while (i != null && j != null) // כל עוד אף אחת מהרשימות לא הגיעה לסופה הלולאה תמשיך
            {
                if (i.GetValue() == j.GetValue()) // אם חולייה מסויימת ברשימה הראשונה שווה לחולייה מסויימת ברשימה השנייה
                {
                    if (result == null) // אם רשימת התוצאות ריקה 
                    {
                        result = new Node<int>(i.GetValue()); // ראש הרשימה מקבל את הערך שנמצא
                        k = result; // חוליית העזר שווה לראש הרשימה
                    }
                    else // אם הרשימה לא ריקה 
                    {
                        k = k.Insert(i.GetValue()); // הכנסת איבר חדש עם הערך שנמצא וחוליית העזר שווה לבאה בתור
                    }
                    i = i.GetNext(); // חוליית העזר של הרשימה הראשונה מתקדמת באחד
                    j = j.GetNext(); // חוליית העזר של הרשימה השנייה מתקדמת באחד
                }
                else if (i.GetValue() < j.GetValue()) // אם ערך החולייה ברשימה הראשונה קטן מערך החולייה ברשימה השנייה
                {
                    i = i.GetNext(); // חוליית העזר של הרשימה הראשונה מתקדמת באחד
                }
                else // אם ערך החולייה ברשימה הראשונה גדול מערך החולייה ברשימה השנייה
                {
                    j = j.GetNext(); // חוליית העזר של הרשימה השנייה מתקדמת באחד
                }
            }

            return result; // החזרת רשימת התוצאות
        }
        */


        static void Main(string[] args)
        {
            ///////////////////////////////////////////////////////////////////////////////////////////////////19
            Console.WriteLine(ReverseList());
            ///////////////////////////////////////////////////////////////////////////////////////////////////20
            Node<string> list = new Node<string>("cat", new Node<string>("dog", new Node<string>("fish", new Node<string>("lion"))));
            Console.WriteLine(ReverseList(list));
            ///////////////////////////////////////////////////////////////////////////////////////////////////21
            Node<string> first = new Node<string>(Console.ReadLine());
            Node<string> last = first;
            string input = "";
            Console.WriteLine("enter the nodes");
            input = Console.ReadLine();
            while (input != "-999")
            {
                Node<string> current = new Node<string>(input);
                last.SetNext(current);
                last = current;
                Console.WriteLine("enter the nodes");
                input = Console.ReadLine();
            }
            Node<string> result = null;
            PrintList(first);
            result = ABCheck(first);
            if (result == null)
            {
                Console.WriteLine("the nodes are sorted");
            }
            else
            {
                Console.WriteLine("the nodes are not sorted");
                Console.WriteLine(result.GetValue());
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////22
            string abc = "abc";
            Console.WriteLine(Reverse(abc));
            Console.ReadKey();
            ///////////////////////////////////////////////////////////////////////////////////////////////////23
            Node<int> l23 = new Node<int>(1, new Node<int>(8, new Node<int>(7)));//187
            Update(l23);
            ///////////////////////////////////////////////////////////////////////////////////////////////////25

            Node<int> list25 = null;
            Console.WriteLine("please enter num to the list and enter -1 when you done");
            int number25 = int.Parse(Console.ReadLine());
            Node<int> pointer = list25;
            // לולאה שקולטת רשימה מהמשתמש 
            while (number25 != -1)
            {
                if (list25 == null)
                {
                    list25 = new Node<int>(number25);
                    pointer = list25;
                }
                else
                {
                    pointer.SetNext(new Node<int>(number25));
                    pointer = pointer.GetNext();
                }
                Console.WriteLine("please enter num to the list and enter -1 when you done");
                number25 = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(list25);
            Console.WriteLine("please enter a number");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(Sequencelist(list25, num));
            ///////////////////////////////////////////////////////////////////////////////////////////////////26
            Node<int> l26 = new Node<int>(1, new Node<int>(8, new Node<int>(7)));//187
            Console.WriteLine(New_26List(l26));
            ///////////////////////////////////////////////////////////////////////////////////////////////////27
            Console.WriteLine("Reduces_Exces(4) = " + Reduces_Exces(new Node<int>(4)));
            Console.WriteLine("Reduces_Exces(null) = " + Reduces_Exces(null));
            //Node<int> number = AddRandom(20);
            Node<int> number = new Node<int>(1, new Node<int>(8, new Node<int>(7)));
            Console.WriteLine("number = " + number);
            // Console.WriteLine("SeveralTimesListed(number) = " + SeveralTimesListed(number, number.GetValue()));
            Console.WriteLine("Count(number) = " + Count(number));
            Console.WriteLine("Reduces_Duplication(number) = " + Reduces_Exces(number));
            Console.WriteLine("Count(number) = " + Count(number));
            ///////////////////////////////////////////////////////////////////////////////////////////////////28
            ///אין
            ///////////////////////////////////////////////////////////////////////////////////////////////////29
            /*
            LinkedList<int> lst = new LinkedList<int>();
            lst.Add(1);
            lst.Add(2);

            lst.Add(x);
            int num = Targil29(lst);
            Console.WriteLine(num);
            */
            ///////////////////////////////////////////////////////////////////////////////////////////////////30
            Node<char> w1 = new Node<char>('a', new Node<char>('c', new Node<char>('c', new Node<char>('a', new Node<char>('b', new Node<char>('a',
            new Node<char>('b')))))));
            Console.WriteLine(IsPalindrom(w1, 4)); // a->c->c->a->b->a->b => acca => true
            Console.WriteLine(IsPalindrom(w1, 5)); // a->c->c->a->b->a->b => false
            Console.WriteLine(LongestPalindrom(w1)); // a->c->c->a->b->a->b => acca => 4
            ///////////////////////////////////////////////////////////////////////////////////////////////////31
            Node<int> list1 = new Node<int>(12, new Node<int>(8, new Node<int>(7)));
            Node<int> list2 = new Node<int>(7, new Node<int>(8, new Node<int>(6)));
            Console.WriteLine(New(list1, list2));
            Console.ReadKey();
            ///////////////////////////////////////////////////////////////////////////////////////////////////32
            Node<int> l1 = new Node<int>(4, new Node<int>(5, new Node<int>(6, new Node<int>(6, new Node<int>(3, new Node<int>(4))))));//456634
            //Node<int> l2 = new Node<int>(4, new Node<int>(5, new Node<int>(6, new Node<int>(6, new Node<int>(3, new Node<int>(4))))));//456634
            Node<int> l2 = new Node<int>(7, new Node<int>(3, new Node<int>(6, new Node<int>(1, new Node<int>(2, new Node<int>(3))))));//736123
            Console.WriteLine(Bigger_num(l1, l2));
            ///////////////////////////////////////////////////////////////////////////////////////////////////33
            Node<int> l33 = new Node<int>(4, new Node<int>(5, new Node<int>(6, new Node<int>(6, new Node<int>(3, new Node<int>(4))))));//456634
            Node<int> l331 = new Node<int>(2, new Node<int>(5, new Node<int>(6, new Node<int>(2))));
            Console.WriteLine(RemoveList2(l33,l331));
            ///////////////////////////////////////////////////////////////////////////////////////////////////34
            Node<int> list341 = new Node<int>(1, new Node<int>(8, new Node<int>(7)));//187
            Node<int> list342 = new Node<int>(2, new Node<int>(8, new Node<int>(8)));//285
            Console.WriteLine(Sum(list341, list342));//4->7->5
            ///////////////////////////////////////////////////////////////////////////////////////////////////38
            Node<int> lst1 = new Node<int>(4, new Node<int>(5, new Node<int>(6, new Node<int>(7, new Node<int>(8)))));
            Node<int> lst2 = new Node<int>(1, new Node<int>(2, new Node<int>(3, new Node<int>(4, new Node<int>(8)))));
            Console.WriteLine(SmallestNum(lst1, lst2));
            ///////////////////////////////////////////////////////////////////////////////////////////////////39
            /*
            Node<int> lis1 = new Node<int>(1); // יצירת רשימה
            Node<int> i = lis1; // חוליית עזר
            // הכנסת חולייה חדשה וקידום חוליית העזר
            i = i.Insert(3);
            i = i.Insert(4);
            i = i.Insert(7);
            i = i.Insert(8);
            i = i.Insert(9);

            Node<int> lis2 = new Node<int>(1); // יצרת רשימה
            i = lis2; // חוליית עזר
            // הכנסת חולייה חדשה וקידום חוליית העזר
            i = i.Insert(2);
            i = i.Insert(5);
            i = i.Insert(8);
            i = i.Insert(9);
            i = i.Insert(10);

            Node<int> result = Equal(lis1, lis2); //  result = null, k = null, i = 1, j = 1 ->
            // result = 1, k = result.GetNext(), i = 3, j = 2 ->
            // result = 1, k = result.GetNext(), i = 3, j = 5 ->
            // result = 1, k = result.GetNext(), i = 4, j = 5 ->
            // result = 1, k = result.GetNext(), i = 7, j = 5 ->
            // result = 1, k = result.GetNext(), i = 7, j = 8 ->
            // result = 1, k = result.GetNext(), i = 8, j = 8 ->
            // result = 1, result.GetNext(8), k = result.GetNext().GetNext(), i = 9, j = 9 ->
            */
        }
    }
}
