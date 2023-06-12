using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace תרגילי_חזרה_רשימות_עצמים_2
{
    class Program
    {
        public static Node<Student_Teaching> List_Student_Teaching()// ג 1
        {  // פעולה ראשית המייצרת רשימת עצמים מטיפוס מקצוע לימוד של תלמיד 
           //וקולטת אליה מספרי זהות ושמות של תלמידים עד לקליטת מספר זהות 000
            Console.WriteLine("enter id and name  To stop inserting 000 id ");
            int id = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            Node<Student_Teaching> list_st = null;
            if (id != 000)
                list_st = new Node<Student_Teaching>(new Student_Teaching(id, name));

            while (id != 000)
            {
                Console.WriteLine("enter id and ");
                id = int.Parse(Console.ReadLine());
                name = Console.ReadLine();
                list_st = new Node<Student_Teaching>(new Student_Teaching(id, name), list_st);

            }
            return list_st;
        }
        public static void Add_Score(int id, int grades, Node<Student_Teaching> list_st)//הפכתי את לפעולה// ג 2
        {//פעולה מקבת  מספר זהות של התלמיד והציון שלו ורשמית תלמידים  ווהוסיפו אותם לרשימה
            if (list_st == null)// רשימה רקע 
            {
                list_st = List_Student_Teaching();
            }
            Node<Student_Teaching> point = list_st;

            while (list_st != null)
            {
                if (list_st.GetValue().GetId() == id)
                {
                    list_st.GetValue().AddLastGrade(grades);
                }
                list_st = list_st.GetNext();

            }
            list_st = point;

        }
        public static void Delete_Low(Node<Student_Teaching> list_st)//הפכתי את לפעולה// ג 3
        {// הפעולה  מקבלת רשימה תלמידים ומחקת לכל תלמיד את הציון הנמוך ביותר שלו
            if (list_st == null)// רשימה רקע 
            {
                list_st = List_Student_Teaching();
            }
            Node<Student_Teaching> point = list_st;

            while (list_st != null)
            {
                list_st.GetValue().Deletes_min_grades();
                list_st = list_st.GetNext();
            }
            list_st = point;

        }
        public static void Print_Average(Node<Student_Teaching> list_st)//הפכתי את לפעולה// ג 4
        {//הפעולה  מקבלת רשימה תלמידים ומדפיס את ממוצע כל תלמיד 
         //ואת שם התלמיד שממוצע הציונים שלו הגבוה ביותר
         //בגלל שלולה אחת   o(n) 
            if (list_st == null)
            {
                list_st = List_Student_Teaching();

            }
            int count = 0, sum = 0; Node<Student_Teaching> point = list_st;
            Student_Teaching max = list_st.GetValue();
            while (list_st != null)
            {
                sum += list_st.GetValue().Average_Grades();
                count++;
                Console.WriteLine("Average student :" + list_st.GetValue().GetName() + " " + list_st.GetValue().Average_Grades());
                if (max.Average_Grades() < list_st.GetValue().Average_Grades())
                    max = list_st.GetValue();
                list_st = list_st.GetNext();
            }
            Console.WriteLine("Average for the whole class :" + sum / count);
            Console.WriteLine("Highest average students is :" + max.GetName());

            list_st = point;

        }
        public static void Print_Lowe_5(Node<Student_Teaching> list_st)//הפכתי את לפעולה// ג 5
        {// הפעולה מקבלת רשימה תלמידים ומדפיס את מספר התלמידים שאין להם ציון הנמוך מקודמו ביותר מ-5 נקודות      

            if (list_st == null)// רשימה רקע 
            {
                list_st = List_Student_Teaching();
            }
            Node<Student_Teaching> point = list_st;int count = 0;

            while (list_st != null)
            {
                if (list_st.GetValue().Score_Lowe_5())
                    count++;
                list_st = list_st.GetNext();
            }
            list_st = point;
            Console.WriteLine("num student do not have a grade lower: "+  count);
        }
        static void Main(string[] args)
        {
            Node<Student_Teaching> list_st = List_Student_Teaching();
            Add_Score(8,99,list_st);
            Delete_Low(list_st);
            Print_Average(list_st);
            Print_Lowe_5(list_st);
        }
    }
}
