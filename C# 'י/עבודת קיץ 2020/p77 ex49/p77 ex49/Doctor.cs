using System;
using System.Collections.Generic;
using System.Text;

namespace p77_ex49
{
    class Doctor
    {
        private string name;//שם
        private int id;//תעודת זהות 
        private string specialization;//התחןת
        private int several_ranks ;//מספר מדרגים
        private int average_rating;//ממוצה דרוג
        private string area_in_the_country;//אזור בארץ



        public Doctor(string name, int id, string specialization, string area_in_the_country)
        {
            this.name = name;
            this.id = id;
            this.specialization = specialization;
            this.area_in_the_country = area_in_the_country;
            this.average_rating = 0;
            this.several_ranks = 0;
        }
        public string GetName()
        {
            return this.name;
        }
        public int GetId()
        {
            return this.id;
        }
        public string GetSpecialization()
        {
            return this.specialization;
        }
        public int GetSeveral_ranks()
        {
            return this.several_ranks;
        }        
        public int GetAverage_rating()
        {
            return this.average_rating;
        }
        public string GetArea_in_the_country()
        {
            return this.area_in_the_country;
        }
        public void SetName(string neamToSet)
        {
            this.name = neamToSet;
        }

       public void SetSpecialization(string specializationToSet)
        {
            this.specialization = specializationToSet;
        }

        public void SetAverage_rating(int average_ratingToSet)
        {
            this.average_rating *= this.several_ranks;
            this.several_ranks++;
            this.average_rating += average_ratingToSet;
            this.average_rating /= this.several_ranks;
        }

        public override string ToString()
        {
            return this.name + "," + this. id+ "," + this.specialization+","+this.several_ranks+","+this.average_rating+","+this.area_in_the_country;
        }
   
    }
}
