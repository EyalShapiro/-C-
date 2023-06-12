using System;

namespace p174_ex6
{
    class Program
    {
        public static int GetApartmentArea(Apartment apartment)
        {
            int sum = 0;
            for (int i = 0; i < apartment.GetRooms_the_apartment().Length; i++)
            {
                if (apartment.GetRooms_the_apartment()[i] != null)
                {
                    sum += apartment.GetRooms_the_apartment()[i].Area();
                }

            }
            return sum;
        }
        public static int GetAmountOfLarge(Building building)
        {
            int sum = 0;
            for (int i = 0; i < building.GetApartments().Length; i++)
            {
                if (building.GetApartments()[i].GetCategory() == "large")
                {
                    sum++;
                }
            }
            return sum;
        }
        public static int GetMax(Building[] buildings)
        {
            int max = 0;
            for (int i = 0; i < buildings.Length; i++)
            {
                if (max < GetAmountOfLarge(buildings[i]))
                {
                    max = GetAmountOfLarge(buildings[i]);
                }
            }
            return max;
        }
        public static void PrintMostLarge(Building[] buildings)
        {
            int max = GetMax(buildings);
            for (int i = 0; i < buildings.Length; i++)
            {
                if (GetAmountOfLarge(buildings[i]) == max)
                {
                    Console.WriteLine(buildings);
                }
            }
        }
        static void Main(string[] args)
        {
            /*
            //p 174 ex6
            Room[] rooms = { new Room("hi", 12, 45), new Room("hi", 12, 45), new Room("hi", 54, 45), new Room("hi", 11, 6), new Room("hi", 12, 89), new Room("hi", 46, 12), new Room("hi", 5, 78) };
            Room[] rooms2 = { new Room("hi", 145, 456), new Room("hi", 456, 45646), new Room("hi", 54, 456456), new Room("hi", 11, 456), new Room("hi", 12, 789), new Room("hi", 46, 7), new Room("hi", 5, 987) };
            Apartment[] apartments = { new Apartment(rooms, "yot"), new Apartment(rooms2, "yot") };
            Adress adress = new Adress("yot", 12, "ramat hasharon");
            Adress adress1 = new Adress("yot", 45, "hi");
            Room[] rooms3 = { new Room("hi", 12, 456456), new Room("hi", 12, 456546), new Room("hi", 54, 456456), new Room("hi", 11, 6), new Room("hi", 12, 456456), new Room("hi", 456456, 12), new Room("hi", 456, 78) };
            Room[] rooms4 = { new Room("hi", 145, 456), new Room("hi", 456, 45646), new Room("hi", 54, 456456), new Room("hi", 11, 456), new Room("hi", 12, 789), new Room("hi", 46, 7), new Room("hi", 5, 987) };
            Apartment[] apartments2 = { new Apartment(rooms3, "yot"), new Apartment(rooms4, "yot") };
            Building[] buildings = { new Building(adress, apartments), new Building(adress1, apartments2) };
            */
            
            Room[] arr = new Room[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Room("d", 12, 1);
            }
            Apartment ap1 = new Apartment(arr,"maccabi");
            // Console.WriteLine(ap1.Square_all_apartment());// ----> פעולה 1 במחלקה דירה <------- עובדת
            //Console.WriteLine(ap1.Category()); //----> פעולה 2 במחלקה דירה <------- עובדת
            Apartment[] array = new Apartment[5];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(" enter the characters of apartment number " + i);
                string name = Console.ReadLine();
                array[i] = new Apartment( arr,name);
            }
            Adress ad1 = new Adress("Maccabi", 11, "Tel-Aviv");
            Building b1 = new Building(ad1, array);
            Console.WriteLine( GetAmountOfLarge(b1));
        }
    }
}
