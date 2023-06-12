using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nomer237
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Idan", "123", 90, 87);
            Console.WriteLine(s1.Avg());
            s1.AddPoint("math",5);
            Console.WriteLine(s1);
            Student s2 = new Student(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s1.Equals(s2));




        }
    }
}
