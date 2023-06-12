using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace רקורסיה_הלה_תור
{
    //Node-חוליה
    class Node<T>
    {
        //T התפוסה סוגה (int,string ...)
        // תכונות
        private T value; // ערך החוליה
        private Node<T> next; // הפניה לחוליה הבאה בזכרון
        // פעולות בונות
        public Node(T value) // פעולה בונה ראשונה
        {
            this.value = value;
            this.next = null;
        }
        public Node(T value, Node<T> next) // פעולה בונה שנייה
        {
            this.value = value;
            this.next = next;
        }
        // פעולות אחזור
        public T GetValue()
        {
            return this.value;
        }
        public Node<T> GetNext()
        {
            return this.next;
        }
        // פעולות קובעות
        public void SetValue(T value)
        {
            this.value = value;
        }
        public void SetNext(Node<T> next)
        {
            this.next = next;
        }
        public bool HasNext()
        {
            return this.next != null;
        }
        // פעולה תיאורית
        public override string ToString() // רקורסיה
        {
            return this.value + "->" + this.next; // this.next.ToString()
        }
    }
}
