using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Birthdays
{
    class AllBirthday // מחלקת ימי ההולדת של תלמידי השכבה
    {
        private Node<Birthday>[] birthdays; // מערך רשימות ימי הולדת חודשיים
        public AllBirthday()
        {
            this.birthdays = new Node<Birthday>[12]; // O(1) - מערך של 12 חודשים של רשימות ימי הולדת ריקות
        }
        public void Add(Birthday b, int month)
        {
            // O(1) - הוספת חוליה אחת כראשונה בתחילת הרשימה
            this.birthdays[month - 1] = new Node<Birthday>(b, this.birthdays[month - 1]); // הוספה להתחלה
        }
        public void Remove(Birthday b)
        {
            Node<Birthday> pb = null; // O(1)
            bool found = false, notFirst = false; // O(1)
            int i = 0; // O(1)
            while (!found && i < 12) // O(1)
            {
                pb = this.birthdays[i]; // O(1)
                if (pb != null && pb.GetValue().Equals(b)) // O(1)
                {
                    this.birthdays[i] = this.birthdays[i].GetNext(); // O(1)
                    pb.SetNext(null); // O(1)
                    found = true; // O(1)
                }
                else // חוליה לא ראשונה
                    if (pb != null)
                    {
                        // n - מספר ימי ההולדת של תלמידים בחודש
                        while (pb.HasNext() && !pb.GetNext().GetValue().Equals(b)) // O(n)
                            pb = pb.GetNext(); // O(1)
                        if (pb.HasNext()) // O(1)
                        {
                            found = true;
                            notFirst = true;
                        }
                        else // O(1)
                            i++;
                    }
                    else // O(1)
                        i++;
            }
            if (found && notFirst) // O(1)
            {
                    Node<Birthday> qb = pb.GetNext();
                    pb.SetNext(qb.GetNext());
                    qb.SetNext(null);
            }
            // פונקצית זמן ריצה
            // O - סיבוכיות/יעילות/מורכבות/סדר גודל
            // f(n) = O(1) + 12XO(n)XO(1) + O(1) = O(1) + O(n) = O(n) - סיבוכיות לינארית
        }
        public int Max()
        {
            int max = 0, month = 1, count;
            Node<Birthday> pb = null;
            for (int i = 0; i < 12; i++) // 12
            {
                pb = this.birthdays[i];
                count = 0;
                while (pb != null) // O(n) - n - מספר התלמידים שנולדו בחודש
                {
                    pb = pb.GetNext();
                    count++;
                }
                if (count > max)
                {
                    max = count;
                    month = i + 1;
                }
            }
            return month;
            // f(n) = O(1) + 12XO(n)xO(1) + O(1) = O(n) - סיבוכיות לינארית
        }
        public override string ToString()
        {
            string months = "";
            for (int i = 0; i < 12; i++)
                if (this.birthdays[i] != null)
                    months += (i + 1) + ":" + this.birthdays[i] + "\n";
            return months;
        }
    }
}
