using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace p175_ex8
{
    class Id_Adult
    {
        private string id_num;//מספר תעודת זהות
        private string first_name;//שם פרטי
        private string last_name;//שם משפחה
        private Date birth;//תאריך לידה
        private string country_of_birth;//ארץ לידה
        private Id_Kid[] kids;//תעודות זהות של ילדיו
        public Id_Adult(string id_num, string first_name, string last_name, Date birth, string country_of_birth,int num_kids, Id_Kid[] kids)
        {
            this.id_num = id_num;
            this.first_name = first_name;
            this.last_name = last_name;
            this.birth = birth;
            this.country_of_birth = country_of_birth;
            this.kids = new Id_Kid[num_kids];
            for (int i = 0; i <kids.Length; i++)
            {
                this.kids[i] = kids[i];
            }
        }
        public Id_Kid[] GetKids()
        {
            return this.kids;
        }
        public bool Add_kid(Id_Kid id)
        {
            for (int i = 0; i < this.kids.Length; i++)
            {
                if (null==this.kids[i])
                {
                    this.kids[i] = id;
                    return true;
                }
            }
            return false;
        }
        public void Eightiiln(Id_Kid id)
        {
            for (int i = 0; i < this.kids.Length; i++)
            {
               if (this.kids[i]!=null&& id!=null && this.kids[i].GetId_num() == id.GetId_num())
               {
                    this.kids[i] = null;
               }
                
            }
        }

        public int Adults(Id_Adult id)
        {
            int count = 0;
            for (int i = 0; i < this.kids.Length; i++)
            {
                for (int j = 0; j < id.GetKids().Length; j++)
                {
                    if (this.kids[i] != null && id.GetKids()[j] != null && id.GetKids()[j].GetId_num()==this.kids[i].GetId_num())
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        public string GetFirst_name()
        {
            return this.first_name;
        }
        public string GetId_num()
        {
            return this.id_num;
        }

    }
}
