using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace תרגילי_חזרה_רשימות_עצמים
{
    class Program
    {
        public static Node<Flower> Entry_List()//ב 1
        {//	פעולה קולטת את אורך קולטת פרחים מכניסה אותם לרשימה ומחזירה את רשימה של פרחים 
            Console.WriteLine("Enter the length of the list : ");
            int lengt = int.Parse(Console.ReadLine());
            Console.WriteLine("enetr string name , double height , string color , string season_which_grows ");
            Flower flow = new Flower(Console.ReadLine(), double.Parse(Console.ReadLine()), Console.ReadLine(), Console.ReadLine());
            Node<Flower> list = new Node<Flower>(flow);
            Node<Flower> start = list;
            for (int i = 1; i < lengt; i++)
            {
                Console.WriteLine("enetr string name , double height , string color , string season_which_grows ");
                flow = new Flower(Console.ReadLine(), double.Parse(Console.ReadLine()), Console.ReadLine(), Console.ReadLine());
                list.SetNext(new Node<Flower>(flow));
                list = list.GetNext();
            }
            return start;
        }
        public static void Print_This_Color(Node<Flower> list_flower, string color)//ב 2
        {//פעולה המקבלת אוסף-פרחים וצבע מסוים, ומדפיסה את כל הפרחים בצבע זה
            while (!list_flower.Equals(null))
            {
                if (list_flower.GetValue().Getcolor() == color)
                {
                    Console.WriteLine(list_flower.GetValue());
                }
                list_flower = list_flower.GetNext();

            }
        }
        public static void Print_This_Season_Much(Node<Flower> list_flower, string Season)// ב 3
        {//פעולה המקבלת אוסף-פרחים ומדפיסה את שמות העונה/עונות שבהן הכי הרבה פרחים
            string[] arr_seasons = { "Autumn", "winter", "spring", "summer" };
            int[] num = new int[arr_seasons.Length ];
            for (int i = 0; i < arr_seasons.Length; i++)
                num[i] = 0;
            Node<Flower> point = list_flower;
            for (int i = 0; i < arr_seasons.Length; i++)
            {
                while (!list_flower.Equals(null))
                {
                    if (list_flower.GetValue().GetSeason_which_grows()==arr_seasons[i])
                    {
                        num[i]++;
                    }
                    list_flower = list_flower.GetNext();

                }
                list_flower = point;
            }
            int max=0;string maxs= arr_seasons[0];
            for (int i = 1; i < arr_seasons.Length; i++)
            {
                if (max < num[i])
                {
                    max = num[i];
                    maxs = arr_seasons[i];
                }
            }
            Console.WriteLine("Season with the most " +maxs);
            Console.WriteLine("---------------------------------");
            while (!list_flower.Equals(null))
            {
                if (list_flower.GetValue().GetSeason_which_grows() == maxs)
                {
                    Console.WriteLine(list_flower);
                }
                list_flower = list_flower.GetNext();

            }

        }

        public static void Print_This_Limit(Node<Flower> list_flower, double max_limit, double min_limit)//ב 4
        {//פעולה המקבלת אוסף-פרחים, ערך תחתון וערך עליון, ומוחקת מהרשימה את כל הפרחים שגובהם אינו בתחום ערכים אלה 
            //o(n) זה הלולא n
            while (!list_flower.Equals(null))
            {
                if (list_flower.GetValue().GetHeight() < max_limit && list_flower.GetValue().GetHeight() > min_limit)
                {
                    Console.WriteLine(list_flower.GetValue());
                }
                list_flower = list_flower.GetNext();
            }
        }
        static void Main(string[] args)
        {
            Node<Flower> list_flower = Entry_List();
            Console.WriteLine("list_flower : " + list_flower);
            Print_This_Color(list_flower, "white");
            Print_This_Season_Much(list_flower, "December");
            Print_This_Limit(list_flower, 15, 5);
        }
    }
}
