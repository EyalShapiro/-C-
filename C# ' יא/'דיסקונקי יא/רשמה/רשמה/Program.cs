using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {

        static void Main_Check_Actions(string[] args)
        {
            Console.WriteLine("Main_Check_Actions:");
            //בדקת הכל הפעולת
            Node<int> n1 = new Node<int>(5);//n1->5->null
            Node<int> n2 = new Node<int>(7);//n2->7->null
            n1.SetNext(n2); //n1->n2->7   n1->5->7->null
            Node<int> n3 = new Node<int>(0);
            n2.SetNext(n3);
            n3.SetNext(new Node<int>(9, new Node<int>(6)));//n1->5->0->9->6->null
            Console.WriteLine("n1=  " + n1);//    5-> 7-> 0-> 9-> 6->
            Console.WriteLine("n2=  " + n2);//     7-> 0-> 9-> 6->
            Console.WriteLine("n3=  " + n3);//    0-> 9-> 6->
            Console.WriteLine("n3.GetNext=   " + n3.GetNext());//   9->6->
            Console.WriteLine("n3.GetNext.GetValue=  " + n3.GetNext().GetValue());//    9
            Console.WriteLine("n3.GetNext.GetNext.GetValue=    " + n3.GetNext().GetNext().GetValue());//    6
            Console.WriteLine("n3.GetValue=    " + n1.GetValue());//    0
            n3.SetValue(4);
            Console.WriteLine("n3.GetValue=    " + n3.GetValue());//    4
            Console.WriteLine("n3.HasNext()= " + n3.HasNext());//n3.HasNext()= True
            Console.WriteLine("-----------------Mian:-------------------");
        }
        // פעולת
        public static int Count(Node<int> list)//ex2
        {//הפעולה מקבלת רשימה ומחזרה אתה כמות עברים  
            int count = 0;
            while (list != null)
            {
                count++;
                list = list.GetNext();
            }
            return count;
        }
        public static int Sum(Node<int> list)//לולאה
        { //  הפעולה מקבלת רשימה של מספרים שלמים ןמחזירה את סכום המספרים ברשימה
            int sum = 0;
            while (list != null)
            {
                sum = sum + list.GetValue();
                list = list.GetNext();
            }
            return sum;
        }
        public static int SumRecursion(Node<int> list)//רקורסיה
        { //  הפעולה מקבלת רשימה של מספרים שלמים ןמחזירה את סכום המספרים ברשימה
            if (list == null)
                return 0;
            return list.GetValue() + SumRecursion(list.GetNext());

        }
        public static bool IsExistLoop<T>(Node<T> list, T val)//לולאה
        {//הפעולה מקבלת רשימה של מספרים שלמים ותהו ומחזרה אמת אם המספר נמצה ברשמה 
            while (list != null)
            {
                if (val.Equals(list.GetValue()))
                    return true;
                list = list.GetNext();

            }
            return false;
        }
        public static bool IsExistRecursion<T>(Node<T> list, T val)//רקורסיה
        {//הפעולה מקבלת רשימה של מספרים שלמים ותהו ומחזרה אמת אם המספר נמצה ברשמה 
            if (list == null)
                return false;

            if (val.Equals(list.GetValue()))
                return true;
            return IsExistRecursion(list.GetNext(), val);
        }
        public static bool IsExistRecursion2<T>(Node<T> list, T val)//רקורסיה
        {//הפעולה מקבלת רשימה של מספרים שלמים ותהו ומחזרה אמת אם המספר נמצה ברשמה 
            if (list == null)
                return false;
            /*
            if (val.Equals(list.GetValue()))
                return true;
            return IsExistRec(list.GetNext(), val);
            */
            return val.Equals(list.GetValue()) || IsExistRecursion2(list.GetNext(), val);
        }
        public static Node<T> Find<T>(Node<T> list, T val)
        {//הפעולה מקבלת רשימה וערך ומחזירה את החוליה של הערך ברשימה
            while (list != null)
            {
                if (val.Equals(list.GetValue()))
                    return list;
                list = list.GetNext();
            }
            return null;
        }
        public static void Add1(Node<int> list)
        {// הפעולה מקבלת רשימת מספרים שלמים ומוסיפה 1 לכל מספר ברשימה

            while (list != null)
            {
                list.SetValue(list.GetValue() + 1); // הוספת 1 למספר בחוליה
                list = list.GetNext();
            }
        }
        public static Node<T> GetLast<T>(Node<T> list)
        {// הפעולה מקבלת רשימה גנרית והפעולה מחזירה את החוליה האחרונה ברשימה
            while (list.HasNext())
                list = list.GetNext();
            return list;
        }

        public static int GetMin(Node<int> list)//int
        {//הפעולה מקבלת רשימה מחזרה את הערך הקטן
            int min = list.GetValue();
            while (list != null)
            {
                if (list.GetValue() < min)
                    min = list.GetValue();
                list = list.GetNext();
            }
            return min;
        }
        public static int LimbBefore(Node<int> list, int num)
        {//הפעולה מקבלת מספר ורשימה ומחזרה אתה אביר לפי אבר ברשימה
            if (list == null)
                return 0;
            else if (num.Equals(list.GetNext().GetValue()))
                return list.GetValue();
            return (LimbBefore(list.GetNext(), num) + 1);
        }
        public static int GetMax(Node<int> list)//int
        {//הפעולה מקבלת רשימה מחזרה את הערך הגדול
            int max = list.GetValue();
            while (list != null)
            {
                if (list.GetValue() > max)
                    max = list.GetValue();
                list = list.GetNext();
            }
            return max;
        }
        public static double GetMin(Node<double> list)//double
        {//הפעולה מקבלת רשימה מחזרה את הערך הקטן
            double min = list.GetValue();
            while (list != null)
            {
                if (list.GetValue() < min)
                    min = list.GetValue();
                list = list.GetNext();
            }
            return min;
        }

        public static double GetMax(Node<double> list)
        {//הפעולה מקבלת רשימה מחזרה את הערך הגדול
            double max = list.GetValue();
            while (list != null)
            {
                if (list.GetValue() > max)
                    max = list.GetValue();
                list = list.GetNext();
            }
            return max;

        }
        public static int GetFirst(Node<int> list)
        {//הפעולה מקבלת רשמה ומחזר החולה הרשונה 
            return list.GetValue();
        }
        /*
        public static void Insert(Node<int> numbers, int num)//1
        {//הפעולה מקבלת רשימה ומספר ומספה אותה במקום המתאים  
            // num = 7, 13
            // numbers->0->1->2->3->4->5->6->7->8->9->10->11->12->
            while (numbers.HasNext() && numbers.GetNext().GetValue() < num)
                numbers = numbers.GetNext();
            // numbers->6->7->8->9->10->11->12->
            // numbers->12->
            Node<int> n = new Node<int>(num, numbers.GetNext()); 
        // n->7->7->8->9->10->11->12-> , n->13->
            numbers.SetNext(n); // numbers->6->7->7->8->9->10->11->12->, numbers->12->13->
        }*/

        public static Node<int> Insert(Node<int> numbers, int num)//2
        {//הפעולה מקבלת רשימה ומספר ומספה אותה במקום המתאים  
            if (numbers == null) // הרשימה ריקה
                numbers = new Node<int>(num);
            else // לרשימה לפחות חוליה אחת
            if (numbers.GetValue() >= num) // צריך להוסיף את החוליה החדשה לפני החוליה הראשונה
                numbers = new Node<int>(num, numbers);
            else
            {
                Node<int> n = numbers;
                // num = 7, 13
                // numbers->0->1->2->3->4->5->6->7->8->9->10->11->12->
                while (n.HasNext() && n.GetNext().GetValue() < num)
                    n = n.GetNext();
                // n->6->7->8->9->10->11->12->
                // n->12->
                Node<int> m = new Node<int>(num, n.GetNext()); // m->7->7->8->9->10->11->12-> , m->13->
                n.SetNext(m); // n->6->7->7->8->9->10->11->12->, n->12->13->
            }
             return numbers;
        }

        public static Node<int> Reverse()
        {//הפעולה מקולת מספר מחנסה אותם לרשימה ומחזרה הותם בסדר הפעוך מסדר הקליטה 
            Console.WriteLine(":::::::::ENTER A NUMBER:::::::stop -999");
            Node<int> n = null;
            int num = int.Parse(Console.ReadLine());
            while (num != -999)
            {
                n = new Node<int>(num, n);
                num = int.Parse(Console.ReadLine());
            }
            return n;

        }

        public static Node<int> Direct()
        {//הפעולה מקולת מספר מחנסה אותם לרשימה ומחזרה הותם בסדר הקליטה 
            Console.WriteLine(":::::::::ENTER A NUMBER:::::::stop -999");
            int num = int.Parse(Console.ReadLine());
            if (num == -999)
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

        public static int SeveralTimesListed(Node<int> list, int num)//p95 ex 27 פעולה עזר ל 
        {// הפעולה מקבלת מספר ורשימה ומחזרה אתה כמות הפעמים שהיא נמצת  
            if (list == null)
                return 0;
            if (num.Equals(list.GetValue()))
                return (SeveralTimesListed(list.GetNext(), num) + 1);
            else
                return SeveralTimesListed(list.GetNext(), num);
        }
        public static void PrintNum(Node<int> list)//פעולת בדיקה
        {//  SeveralTimesListed
            Node<int> save = list;
            int max = list.GetValue();
            while (list != null)
            {
                if (list.GetValue() > max)
                    max = list.GetValue();
                list = list.GetNext();
            }
            list = save;
            for (int i = 1; i <= max; i++)
            {
                Console.WriteLine(i + ": " + SeveralTimesListed(list, i));
            }
        }
        public static Node<int> AddRandom(int i)//int //לולא
        {//הפעולה מקבלה מספר ומתקנת ומוספיה לרשמה הרחים רנדומלים בגודלה המספר 
            Random r = new Random();
            Node<int> list = new Node<int>(r.Next(1, 6));
            Node<int> n = list;// מצביע עזר שמתקדם מחולים לחוליה;
            for (i = i - 1; 0 < i; i--)
            {
                n.SetNext(new Node<int>(r.Next(1, 6))); //מגרלה מספרים 1 עד 5 
                n = n.GetNext();
            }
            return list;
        }
        static void Main(string[] args)
        {
            //Main_Check_Actions(args);
            //ex1 //1-10 לבנות רשימה על ערכים
            Node<int> number = new Node<int>(1);//number->1 -> null ,תחילת הרשמה
            Node<int> n = number;// מצביע עזר שמתקדם מחולים לחוליה
            for (int i = 2; i < 10; i++)
            {
                n.SetNext(new Node<int>(i)); // או  n.GetValue()+ 1;
                n = n.GetNext();
            }
            Console.WriteLine("n= " + n);// המספר האחרון ברשמה n=10->
            Console.WriteLine("number= " + number);//הרשמה כולה  number= 1-> 2-> 3-> 4-> 5-> 6-> 7-> 8-> 9-> 10->
            //כמות הברים //ex2
            Console.WriteLine("new_ex_Count");
            Console.WriteLine("Count(number) " + Count(number));
            Console.WriteLine("Count(n) " + Count(n));
            //ex3
            Console.WriteLine("new_ex_Sum");
            Console.WriteLine(Sum(number));//לולאה
            Console.WriteLine(SumRecursion(number));//רקורסיה
            //ex5
            Console.WriteLine("new_ex__IsExistLoop");
            //__Loop____________
            Console.WriteLine(IsExistLoop(number,10));//רקורסיה//false
            Console.WriteLine(IsExistLoop(number,5));//רקורסיה//ture
            //__Recursion______
            Console.WriteLine(IsExistRecursion(number, 10));//רקורסיה//false
            Console.WriteLine(IsExistRecursion(number, 5));//רקורסיה//ture
            //__Recursion2_____
            Console.WriteLine(IsExistRecursion2(number, 10));//רקורסיה//false
            Console.WriteLine(IsExistRecursion2(number, 5));//רקורסיה//ture
            Console.WriteLine("new_ex__Find");
            Console.WriteLine(Find(number,4));//4-> 5-> 6-> 7-> 8-> 9->
            Console.WriteLine("new_ex__Add1");
            Console.WriteLine(number);//1-> 2-> 3-> 4-> 5-> 6-> 7-> 8-> 9->
            Add1(number);
            Console.WriteLine(number);//2-> 3-> 4-> 5-> 6-> 7-> 8-> 9-> 10->
            Console.WriteLine("new_ex_GetLast");
            Console.WriteLine(GetLast(number));//10->
            Console.WriteLine("new_ex_Add"); 
            n.SetNext(new Node<int>(12));// לסיף לסוף הרשימה
            Console.WriteLine(number);//2-> 3-> 4-> 5-> 6-> 7-> 8-> 9-> 10-> 12->
            number = new Node<int>(0, number);// לסיף לתחלת הרשימה
            Console.WriteLine(number);//0-> 2-> 3-> 4-> 5-> 6-> 7-> 8-> 9-> 10-> 12->
            Node<int> m = new Node<int>(1,number.GetNext());
            number.SetNext(m);
            Console.WriteLine(number);//0-> 1-> 2-> 3-> 4-> 5-> 6-> 7-> 8-> 9-> 10-> 12->
            /*//הוספה לרשמה
            n.SetNext(new Node<int>(12)); // הוספה לסוף הרשימה
            Console.WriteLine(numbers); // 2->3->4->5->6->7->8->9->10->11->12->
            numbers = new Node<int>(0, numbers); // הוספה לתחילת הרשימה
            Console.WriteLine(numbers); // 0->2->3->4->5->6->7->8->9->10->11->12->
            Node<int> m = new Node<int>(1, numbers.GetNext()); // 0->2->3->4->5->6->7->8->9->10->11->12-> , 1->2->3->4->5->6->7->8->9->10->11->12->, 0,1->2->3->4->5->6->7->8->9->10->11->12->
            numbers.SetNext(m); // 0->1->2->3->4->5->6->7->8->9->10->11->12-> , numbers->0, n->11, m->1
            Console.WriteLine(numbers); // 0->1->2->3->4->5->6->7->8->9->10->11->12->
            */
            /*
            Console.WriteLine("enetr num: ");//1
            int num = int.Parse(Console.ReadLine());//8
            if (number == null) // הרשימה ריקה
                 number = new Node<int>(num);
            else // לרשימה לפחות חוליה אחת
                if (number.GetValue() >= num) // צריך להוסיף את החוליה החדשה לפני החוליה הראשונה
                number = new Node<int>(num, number);
            else
                Insert(number, num);
            Insert(number, num);
            Console.WriteLine(number);
            //0-> 1-> 2-> 3-> 4-> 5-> 6-> 7-> 8-> 8-> 8-> 9-> 10-> 12->
            */
            Console.WriteLine("enetr num: ");//2
            int num = int.Parse(Console.ReadLine());//8
            number = Insert(number, num);
            Console.WriteLine(number);//0-> 1-> 2-> 3-> 4-> 5-> 6-> 7-> 8-> 8-> 9-> 10-> 12->
            number = Insert(number, 13);
            Console.WriteLine(number);//0->1->2->3->4->5->6->7->8->8->9->10-> 12->13->

            // הוצאת חוליה לא ראשונה
            n = number.GetNext(); // n->2->3->4->5->6->7->7->8->9->10->11->12->13->
            number.SetNext(n.GetNext()); // numbers->1->3->4->5->6->7->7->8->9->10->11->12->13->
            n.SetNext(null); // n->2->
            Console.WriteLine(number); // 1->3->4->5->6->7->7->8->9->10->11->12->13->
            Console.WriteLine(n); // 2->
            Console.WriteLine("ex Income through action");//הכנסה בעזרת פעולה
            //הפעולה מקולת מספר מחנסה אותם לרשימה ומחזרה הותם בסדר הקליטה 
            Node<int> di= Direct();
            Console.WriteLine("action Direct" + di);//Direct פעולה 
            //הפעולה מקולת מספר מחנסה אותם לרשימה ומחזרה הותם בסדר הפעוך מסדר הקליטה 
            Node<int> re = Reverse();
            Console.WriteLine("action Reverse" + re);//Reverse פעולה 

        }
    }

}

