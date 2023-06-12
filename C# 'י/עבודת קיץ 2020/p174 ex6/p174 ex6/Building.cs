using System;
using System.Collections.Generic;
using System.Text;

namespace p174_ex6
{
    class Building
    {
        private Adress adress;
        private Apartment[] apartments = new Apartment[100];
        public Building(Adress adress, Apartment[] apartments)
        {
            for (int i = 0; i < apartments.Length; i++)
            {
                if (apartments[i] != null)
                {
                    apartments[i] = new Apartment(apartments[i]);
                }
            }
            this.adress = new Adress(adress.GetStreet(), adress.GetNumber(), adress.GetCity());
        }
        public Adress GetAdress()
        {
            return adress;
        }
        public Apartment[] GetApartments()
        {
            return apartments;
        }
        public void SetApartments(Apartment[] apartments)
        {
            for (int i = 0; i < apartments.Length; i++)
            {
                if (apartments[i] != null)
                {
                    apartments[i] = new Apartment(apartments[i]);
                }
            }
        }
        public void SetAdress(Adress adress)
        {
            this.adress = adress;
        }
        public override string ToString()
        {
            string str = "";
            for (int i = 0; i < apartments.Length; i++)
            {
                str += apartments[i].ToString() + " ";
            }
            return "apartments: " + str + " adress: " + adress.ToString();
        }
    }
}
