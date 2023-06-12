using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace רשמה
{
    //Node-חוליה
    class Node<T>
    {
        //T התפוסה סוגה (int,string ...)
        private T value;//ערך חוליה
        private Node<T> next; //הפניה לחוליה הבאה בזכרון
        
        public Node(T value)//פעולה בונה רשאונה
        {
            this.value = value;
            this.next = null;
        }
        public Node(T value, Node<T> next)//פעולה בונה שנייה
        {
            this.value = value;
            this.next = next;
        }
        //פעולת אחזור
        public T GetValue()
        {
            return this.value;
        }
        public Node<T> GetNext()
        {
            return this.next;
        }
        //פעולת קובות
        public void SetNext(Node<T> next)
        {
            this.next = next;
        }
        public void SetValue(T value)
        {
            this.value = value;
        } 
        public bool HasNext()
        {//פעולה מחזרה אמת הם יש חוליה הבא ושקרה הם אין
            return (this.next!=null);
        }
        //פעולה תיאורית
        public override string ToString()//רקורסיה
        {
            return this.value+"-> "+this.next;
        }
      
    }
}
