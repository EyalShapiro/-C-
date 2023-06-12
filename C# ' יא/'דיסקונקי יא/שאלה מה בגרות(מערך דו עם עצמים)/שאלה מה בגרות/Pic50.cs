using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Image
{
    class Pic50 // כותרת המחלקה תמונה 50 על 50
    {
        private Pixel[,] pic; // תמונה
        private int row; // שורה נוכחית
        private int col; // עמודה נוכחית בשורה נוכחית
        public Pic50()
        {
            Random r = new Random();
            this.pic = new Pixel[50, 50];
            for (int i = 0; i < this.pic.GetLength(0); i++) // לולאת שורות
                for (int j = 0; j < this.pic.GetLength(1); j++) // לולאת עמודות
                    this.pic[i, j] = new Pixel(r.Next(256), r.Next(256), r.Next(256)); // new Pixel(); // פיקסל בצבע שחור
        }
        public void Add(Pixel p)
        {
            // מילוי לפי שורות, מילוי שורה שורה
            if (this.col == this.pic.GetLength(1)) // == 50
            {
                this.row++; // לרדת שורה
                this.col = 0; // להגיע לתחילת השורה
            }
            if (this.row < this.pic.GetLength(0)) // < 50
            {
                this.pic[this.row, this.col] = p;
                this.col++; // לקדם עמודה
            }
        }
        public void Mix(Pic50 other)
        {
            for (int i = 0; i < this.pic.GetLength(0); i++) // לולאת שורות
                for (int j = 0; j < this.pic.GetLength(1); j++) // לולאת עמודות
                    this.pic[i, j].Mix(other.pic[i, j]); // ערבוב פיקסלים
        }
    }
}
