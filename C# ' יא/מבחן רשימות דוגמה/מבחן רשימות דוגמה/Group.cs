using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace מבחן_רשימות_דוגמה
{
    class Group
    {
        private int nClass;//מספר התלמידים בכיתה 
        private int members;//מספר התלמידים מהכיתה שמשתתפים בתחרות
        private Node<Pupil> list;//רשימה של התלמידים  המשתתפים בתחרות

        public Group(int members, int nClass)
        {
            this.members = members;
            this.nClass = nClass;
        }
        public void add(String name, int points)
        {
            if (this.list.Equals(null))
            {
                this.list = new Node<Pupil>(new Pupil(name, points));
            }
            else
            {
                Node<Pupil> lin = this.list;
                while (lin.Equals(null))
                {
                    if (lin.GetValue().GetName() == name)
                    {
                        this.list.GetValue().addPoints(points);
                    }
                    lin = lin.GetNext();
                }
            }
        }
        //פעולה המחזירת 
        public int GetNClass()
        {
            return this.nClass;
        }

        public int GetMembers()
        {
            return this.members;
        }
        public Node<Pupil> GetList()
        {
            return this.list;
        }
        //הוסף שלי 
        public Pupil Mex_Points()
        {//
            if (this.list.Equals(null))
                Console.WriteLine("An empty list");
            
            Node<Pupil> lin = this.list;
            Pupil max = lin.GetValue();
            while (list != null)
            {
                if (list.GetValue().GetPoints() > max.GetPoints())
                    max = list.GetValue();
                list = list.GetNext();
            }
            return max;

        }

        
    }
}
