using System;
using System.Collections.Generic;
using System.Text;

namespace p175_ex8
{
    class Id_Kid
    {
        private string id_num;//מספר תעודת זהות
        private string first_name;//שם פרטי
        private string last_name;//שם משפחה
        private Date birth;//תאריך לידה
        private string country_of_birth;//ארץ לידה
        private string nation;//לאום

        public Id_Kid (string id_num, string first_name, string last_name, Date birth, string country_of_birth, string nation)
        {
            this.id_num = id_num;
            this.first_name = first_name;
            this.last_name = last_name;
            this.birth = birth;
            this.country_of_birth = country_of_birth;
            this.nation = nation;
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
