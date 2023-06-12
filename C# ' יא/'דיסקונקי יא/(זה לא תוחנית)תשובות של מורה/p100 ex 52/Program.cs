using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birthdays
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int day, month;
            AllBirthday ab = new AllBirthday();
            Console.WriteLine("enter number of students in grade");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("enter name");
                name = Console.ReadLine();
                Console.WriteLine("enter day");
                day = int.Parse(Console.ReadLine());
                Console.WriteLine("enter month");
                month = int.Parse(Console.ReadLine());
                ab.Add(new Birthday(name, day), month);
            }
            Console.WriteLine(ab);
            Console.WriteLine(ab.Max());
            Console.WriteLine();
            ab.Remove(new Birthday("idan1", 22));
            Console.WriteLine(ab);
            ab.Remove(new Birthday("idan2", 23));
            Console.WriteLine(ab);
        }
    }
}
