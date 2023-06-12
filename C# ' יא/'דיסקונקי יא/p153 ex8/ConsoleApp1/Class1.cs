using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Node<T>
    {
        private T value; // ערך החוליה
        private Node<T> next; // הפניה לחוליה הבאה
        public Node(T value)
        {
            this.value = value;
            this.next = null;
        }
        public Node(T value, Node<T> next)
        {
            this.value = value;
            this.next = next;
        }
        public T GetValue()
        {
            return this.value;
        }
        public Node<T> GetNext()
        {
            return this.next;
        }
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
        public override string ToString()
        {
            return this.value + "-->" + this.next;
        }
    }
    }
