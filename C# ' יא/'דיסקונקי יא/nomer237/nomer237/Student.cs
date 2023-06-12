using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nomer237
{
    class Student
    {
        private string name; //שם
        private string id;//מס זהות
        private int math;//ציון במטמתיקה
        private int english;//ציון באנגלית
        public Student(string name, string id, int math, int english)
        {
            this.name = name;
            this.id = id;
            this.math = math;
            this.english = english;
        }
        public Student (Student s)//פעולה בונה מעתיקה
        {
            this.name = s.GetName();
            this.id = s.GetId();
            this.math = s.math;
            this.english = s.english;
        }
        public string GetName()
        {
            return this.name;
        }
        public string GetId()
        {
            return this.id;
        }
        public int GetMath()
        {
            return this.math;
        }
        public int GetEnglish()
        {
            return this.english;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetId(string id)
        {
            this.id = id;
        }
        public void SetMath(int math)
        {
            this.math=math;
        }
        public void SetEnglish(int english)
        {
            this.english=english;
        }
        public double Avg()
        {
            return (double)(english + math) / 2;
        }
        public void AddPoint(string suject ,int point)
        {
            if (suject.Equals("english"))
            {
                if (this.english + point > 100)
                    this.english = 100;
                else

                    this.english += point;
            }
            if (suject.Equals("math"))
            {
                if (this.math + point > 100)
                    this.math = 100;
                else
                    this.math += point;
            }
        }
        public bool Equal(Student s)
        {
            return this.name.Equals(s.name)&& this.id.Equals(s.id)&& this.math == s.math&& this.english == s.english;
        }
        public override string ToString()
        {
            return "name: "+this.name + ",id: " + this.id + ",math:  " + this.math + ",english: " + this.english;
        }

    }
}
