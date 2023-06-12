using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Node<T>
    {
        // תכונות
        private T value; // ערך החוליה
        private Node<T> next; // הפניה לחוליה הבאה בזיכרון
        // פעולות בונות
        public Node(T value) // פעולה בונה
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
        public T Getvalue()
        {
            return this.value;
        }
        public Node<T> GetNext()
        {
            return this.next;
        }
        // פעולות קובעות
        public void Setvalue(T value)
        {
            this.value = value;
        }
        public void SetNext(Node<T> next)
        {
            this.next = next;
        }
        // Next פעולת עזר שבודקת אם יש 
        public bool HasNext()
        {
            return this.next != null;
        }
        // פעולה תיאורית
        public override string ToString() // רקורסיה
        {
            return this.value + "->" + this.next; // => this.next.ToString()
        }

    }
    }
