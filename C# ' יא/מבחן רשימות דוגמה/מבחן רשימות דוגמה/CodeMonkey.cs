using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace מבחן_רשימות_דוגמה
{
    class CodeMonkey
    {
        private Group[] cm = new Group[12];

        public CodeMonkey (Group[] cm)
        {
            this.cm = cm;
        }

        public void printFirst()
        {
            for (int i = 0; i < this.cm.Length; i++)
            {
                if (this.cm[i].GetNClass() / 2 > this.cm[i].GetMembers())
                {
                    Console.WriteLine("The student is " + this.cm[i].Mex_Points().GetName()+ "  Point: " + this.cm[i].Mex_Points().GetPoints());
                }
                else
                    Console.WriteLine("There is no mask for students in the class"); 
                    
            }
        }
    }
}
