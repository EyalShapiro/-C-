using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nomer237
{
    class Class
    {
        private Student[] students;//מערך תלמידים
        private Teacher teacher;// מורה
        private int numOfSubs;//מספר תלמידים בפועל
        public Class(Teacher t)
        {
            this.teacher = t;
            this.Students = new Student[18];
            this.numOfSubs = 0;
        }
        public bool Add(Student s)
        {
            if (this.students.Length>this.numOfSubs)
            {
                this.students[this.numOfSubs] =s;
                this.numOfSubs++;
                return true;
            }
            return false;
        }
        public Student BestInClass()
        {
            Student max = this.students[0];
            for (int i = 1; i <this.numOfSubs; i++)
            {
                if (max.Avg<this.students[i].Avg)
                {
                    max = this.students[i];
                }
            }
            return max;
        }
        public bool InClass(Student s)
        {
            for (int i = 0; i < this.numOfSubs; i++)
                if (this.students[i].Equal(s)==true)
                    return true;
            return false;
        }
        public Student Find(int id)
        {
            for (int i = 0; i < this.numOfSubs; i++)
                if (this.students[i].GetId().Equal(id))
                    return this.students[i];
            return null;
        }
    }
}
