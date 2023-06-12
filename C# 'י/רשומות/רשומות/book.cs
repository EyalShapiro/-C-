using System;
using System.Collections.Generic;
using System.Text;

namespace רשומות
{
    class Book
    {
        private int pegs;
        private string name_book ;
        private string  author;



        public Book(int pegs, string name_book, string author)
        {
            this.pegs = pegs;
            this.name_book = name_book;
            this.author = author;
        }


        public Book(Book book)
        {
            this.pegs = book.pegs;
            this.name_book = book.name_book;
            this.author = book.author;
        }



        public int GetPegs()
        {
            return this.pegs;
        }
        public string GetName_book()
        {
            return this.name_book;
        }
        public string GetAuthor()
        {
            return this.author;
        }
        public void Setpegs(int pegsToSet)
        {
            this.pegs = pegsToSet;
        }
        public void SetMonth(string name_bookToSet)
        {
            this.name_book = name_bookToSet;
        }
        public void SetDay(string authorToSet)
        {
            this.author = authorToSet;
        }

  
        public int Length_big(Book book)
        {
            if (this.pegs>book.pegs)
            {
                return this.pegs - book.pegs;
            }
            else
            {
                return book.pegs - this.pegs;
            }
        }


        public override string ToString()
        {
            return this.pegs + "." + this.name_book + "." + this.author;
        }


    }
}
