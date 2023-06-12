using System;
using System.Collections.Generic;
using System.Text;

namespace p174_ex6
{
    class Adress
    {
        private string street;
        private int number;
        private string city;
        public Adress(string street, int number, string city)
        {
            this.street = street;
            this.number = number;
            this.city = city;
        }
        public string GetStreet()
        {
            return street;
        }
        public string GetCity()
        {
            return city;
        }
        public int GetNumber()
        {
            return number;
        }
        public void SetStreet(string street)
        {
            this.street = street;
        }
        public void SetCity(string city)
        {
            this.city = city;
        }
        public void SetNumber(int number)
        {
            this.number = number;
        }
        public override string ToString()
        {
            return "street: " + street + " number: " + number + " city:" + city;
        }
    }
}
