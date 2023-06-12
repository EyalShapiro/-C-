using System;
using System.Collections.Generic;
using System.Text;

namespace p174_ex6
{
    class Apartment
    {
        private string name_the_landlord;//שם בעל הדירה
        private Room[] rooms_the_apartment=new Room[10];//אוסף החדרים של הדירה
        public Apartment(Room[] rooms_the_apartment, string name_the_landlord)
        {
            for (int i = 0; i < rooms_the_apartment.Length; i++)
            {
                if (rooms_the_apartment != null)
                {
                    this.rooms_the_apartment[i] = new Room(rooms_the_apartment  [i]);
                }

            }
            this.name_the_landlord = name_the_landlord;
        }
        public Apartment(Apartment apartment)
        {
            rooms_the_apartment = apartment.GetRooms_the_apartment();
            name_the_landlord = apartment.GetName_the_landlord();
        }
        public Room[] GetRooms_the_apartment()
        {
            return rooms_the_apartment;
        }
        public string GetName_the_landlord()
        {
            return name_the_landlord;
        }
        public void SetRooms_the_apartment(Room[] rooms_the_apartment)
        {
            this.rooms_the_apartment = rooms_the_apartment;
        }
        public void SetName_the_landlord(string name_the_landlord)
        {
            this.name_the_landlord = name_the_landlord;
        }
        public int GetApartmentArea()
        {
            int sum = 0;
            for (int i = 0; i <this.rooms_the_apartment.Length; i++)
            {
                if (this.rooms_the_apartment[i] != null)
                {
                    sum += this.rooms_the_apartment[i].Area();
                }
            }

            return sum;
        }
        public string GetCategory()
        {
            if (GetApartmentArea() > 110)
                return "large";
            else if (GetApartmentArea() <= 110 && GetApartmentArea() > 70)
                return "medium";
            else
            {
                return "small";
            }
        }
        public override string ToString()
        {
            string str = "";
            for (int i = 0; i < rooms_the_apartment.Length; i++)
            {
                if (rooms_the_apartment[i] != null)
                {
                    str += rooms_the_apartment[i].ToString() + " ";
                }
            }
            return "rooms: " + str + "name_the_landlord: " + name_the_landlord;
        }

    }
}
