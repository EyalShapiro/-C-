using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitor
{
    class Race
    {
        private Node<Competitor> competitors; // רשימת מתחרים
        public Race()
        {
            this.competitors = null;
        }
        public void Add(Competitor c)
        {
            if (this.competitors == null) // אם הרשימה ריקה
                this.competitors = new Node<Competitor>(c); // נוסיף את המתחרה כראשון
            else
                if (c.Shorter(this.competitors.GetValue())) // אחרת אם המתחרה קצר מהראשון
                    this.competitors = new Node<Competitor>(c, this.competitors); // נוסיף את המתחרה כראשון
                else // אחרת נחפש את מיקום המתחרה
                {
                    Node<Competitor> p = this.competitors;
                    while (p.HasNext() && p.GetNext().GetValue().Shorter(c))
                        p = p.GetNext();
                    p.SetNext(new Node<Competitor>(c, p.GetNext()));
                }
        }
        public string Rank(int x)
        {
            Node<Competitor> p = this.competitors;
            for (int i = 0; i < x - 1; i++)
                p = p.GetNext();
            return p.GetValue().GetName();
        }
    }
}
