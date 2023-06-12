using System;


    public class Date
    {
        private int day;
        private int month;
        private int year;

        

        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }


        /*public Date(Date date)
        {
            this.day = date.day;
            this.month = date.month;
            this.year = date.year;
        }*/

       

        public int GetYear()
        {
            return this.year;
        }

        /// <summary>
        /// returns the month
        /// </summary>
        /// <returns> the month </returns>
        public int GetMonth()
        {
            return this.month;
        }

        /// <summary>
        /// returns the day
        /// </summary>
        /// <returns> the day </returns>
        public int GetDay()
        {
            return this.day;
        }

        

        public void SetYear(int yearToSet)
        {
            this.year = yearToSet;
        }

        

        public void SetMonth(int monthToSet)
        {
            this.month = monthToSet;
        }


        public void SetDay(int dayToSet)
        {
            this.day = dayToSet;
        }

        

        public int CompareTo(Date other)
        {
            if (this.year != other.year)
                return (this.year - other.year);
            //equals in years
            if (this.month != other.month)
                return (this.month - other.month);
            //equals also in months
            return (this.day - other.day);
        }

        

        public override string ToString()
        {
            return this.day + "." + this.month + "." + this.year;
        }
    }

