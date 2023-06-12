using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace תרגילי_חזרה_רשימות_עצמים_2
{
    class Student_Teaching
    {
        private int id;
        private string name;
        private Node<int> grades;
        private Node<int> point_grade;//מצביע לאיבר ברשימה

        public Student_Teaching(int id, string name)
        {
            this.id = id;
            this.name = name;
            this.grades = null;
            this.point_grade = this.grades;

        }
        public Student_Teaching(int id,string name,Node<int> grades)
        {
            this.id = id;
            this.name = name;
            this.grades = grades;
            this.point_grade = this.grades;

            while (!this.point_grade.GetNext().GetValue().Equals(null))
                this.point_grade =this.point_grade.GetNext();

        }
        //פעולות מאחזרות  
        public string GetName()
        {
            return this.name;
        }

        public int GetId()
        {
            return this.id;
        }

        public Node<int> GetGrades()
        {
            return this.grades;
        }
        //פעולות קובעות
        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        public void SetGrades(Node<int> grade)
        {
            this.grades = grade;
        }
        //פעולה תיאורית
        public override string ToString()
        {
            return " id: " + this.id + " ,name: " + this.name + " ,grades: " + this.grades;
        }

        public void AddLastGrade(int grade2)//ב 1
        {// O(1) פעולה המוסיפה ציון לתלמיד בסוף רשימת הציונים בסיבוכיות 
           
            if (this.point_grade.Equals(null))
                this.point_grade = this.grades;
            while (!this.point_grade.GetNext().GetValue().Equals(null))
                this.point_grade = this.point_grade.GetNext();
            Node<int> list = new Node<int>(grade2);
            if (this.grades == null)
                this.grades =list;
            else
            {
                this.point_grade = new Node<int>(this.point_grade.GetValue(), list);
            }
        }
        public int Average_Grades()//ב 2 
        {//פעולה המחזירה את ממוצע הציונים
            if (this.grades == null)
            {
                Console.WriteLine("An empty list");
                return 0;
            }
            int count = 0, sum = 0;
            Node<int> point = this.point_grade;
            while (point != null)
            {
                sum += point.GetValue();
                count++;
                point = point.GetNext();
            }
            return sum / count;
        }
        public void Deletes_min_grades()// ב 3
        { //פעולה המבטלת את הציון הנמוך ביותר

            Node<int> point = this.point_grade;
            int min = 101;

            while (point != null)
            {
                if (point.GetValue()<min)
                {
                     min = this.point_grade.GetValue();
                }
                point = point.GetNext();
            }
            point = this.point_grade;
            if (point.GetValue() == min)
            {
                Node<int> delete = point;
                point = point.GetNext();
                delete.SetNext(null);
            }
            while (point != null)
            {
                if (point.GetNext().GetValue() == min)
                {
                    Node<int> delete = point.GetNext();
                    point.SetNext(point.GetNext().GetNext());
                    delete.SetNext(null);
                }
                point = point.GetNext();
            }
            this.grades = new Node<int>(point.GetValue(), point.GetNext());
            this.point_grade = grades;
            while (!this.point_grade.GetNext().GetValue().Equals(null))
                this.point_grade = this.point_grade.GetNext();

        }
        public bool Score_Lowe_5()//ב 4
        {//פעולה המחזירה אמת אם לתלמיד אין ציון הנמוך מהציון הקודם לו ביותר מ-5 נקודות. בכל מקרה אחר מחזירה שקר 
           //בגלל שיש רק לולה אחת o(n)
            Node<int> point = this.point_grade;
          
            while (point != null)
            {
                if (point.GetValue() > point.GetNext().GetValue()+5)
                {
                    return false;
                }
                point = point.GetNext();
            }
            return true;
        }


    }
}
