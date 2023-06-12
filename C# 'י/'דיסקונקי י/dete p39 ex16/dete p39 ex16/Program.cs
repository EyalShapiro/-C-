using System;
namespace dete_p39_ex16
{
    class Program
    {
        public static string strg(Date d1)
        {
            if (d1.GetMonth() <= 3 && d1.GetMonth() >= 1 || d1.GetMonth() == 12)
                return "winter";
            else if (d1.GetMonth() == 4 || d1.GetMonth() == 5)
                return "spring";
            else if (d1.GetMonth() <= 9 && d1.GetMonth() >= 6)
                return "summer";
            else if (d1.GetMonth() <= 11 && d1.GetMonth() >= 10)
                return "autum";
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter year");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("enter day and month ");
            Date d1 = new Date(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), year);
            Console.WriteLine("enter day and month ");
            Date d2 = new Date(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), year);          
            if (d1.GetMonth()>d2.GetMonth())
            {
                Date d_new = new Date(d2.GetDay(),d2.GetMonth() , year);
                for (int i = d2.GetMonth(); i <= d1.GetMonth(); i++)
                {
                    d_new.SetMonth(i);
                    Console.WriteLine(strg(d_new));
                }
            }
            else if (d1.GetMonth() < d2.GetMonth())
            {
                Date d_new = new Date(d1.GetDay(), d1.GetMonth(), year);
                for (int i = d1.GetMonth(); i <= d2.GetMonth(); i++)
                {
                    d_new.SetMonth(i);
                    Console.WriteLine(strg(d_new));
                }
            }




        }        
    }
}
