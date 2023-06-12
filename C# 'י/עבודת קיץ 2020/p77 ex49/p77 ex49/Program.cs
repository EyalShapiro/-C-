using System;

namespace p77_ex49
{
    class Program
    {
        //p77 ex49
        public static void Ex49(int n)
        {
            //רופים פעולה תקלותה האזור רפים באזור ואת את התמחןת זו שהדרוג N שלם ובונה מערך בגודל N הפונקצה מקבלת    
            Doctor[] doctors = new Doctor[n];
            for (int i = 0; i < doctors.Length; i++)
            {
                Console.WriteLine("enetr name and id and specialization and area in the country");
                doctors[i] = new Doctor(Console.ReadLine(), int.Parse(Console.ReadLine()), Console.ReadLine(), Console.ReadLine());
            }
            int id;
            Console.WriteLine("enetr id To finish after that num 0");
            id = int.Parse(Console.ReadLine());
            while (id!=000)
            {
                
                for (int i = 0; i < doctors.Length; i++)
                {
                    if (doctors[i].GetId()==id)
                    {
                        Console.WriteLine("enetr raising a doctor");
                        doctors[i].SetAverage_rating(int.Parse(Console.ReadLine()));
                    }
                }
                Console.WriteLine("enetr id To finish after that num 0");
                id = int.Parse(Console.ReadLine());
            }
            string area;
            Console.WriteLine("The introduction of an area in Israel");
            area = Console.ReadLine();
            for (int i = 0; i < doctors.Length; i++)
            {
                if (doctors[i].GetArea_in_the_country()==area)
                {
                    Console.WriteLine(doctors[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            //p77 ex49
 
            Ex49(1);
        }
    }
}
