﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace תור
{
    class Queue<T>
    {
        private Node<T> first;// ראש התור
        private Node<T> last;//סוף התור 

        public Queue()
        {
            this.first = null;
            this.last = null;
        }
        public void Insert(T x)
        {
            Node<T> nx = new Node<T>(x);
            if (this.first == null)
                this.first = nx;

            else
                this.last.SetNext(nx);
            this.last = nx;

        }
        public T Remove()
        {
            Node<T> past = this.first;
            T x = this.first.GetValue();
            this.first = this.first.GetNext();
            if (this.first == null)
                this.last = null;
            past.SetNext(null);
            return x;
        }

        public T Head()
        {
            return this.first.GetValue();
        }
        public bool IsEmpty()
        {
            return this.first == null;
        }
        public override string ToString()
        {
            return this.first.ToString();
        }
    }
}
