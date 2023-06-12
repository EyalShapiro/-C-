using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p26_ex_13_א_ב
{
    class Program
    {
        //p26 ex13 א
        public static int Place_size(int n)
        {
            //הפעולה מקבלת מספר סידורי ומחזרה את ערכו 
            if (n == 1 || n == 2)
            {
                return n - 1;
            }
            return (int)(Math.Pow(Place_size(n - 1), 2) + Math.Pow(Place_size(n - 2), 2));
        }
        //p26 ex13 ב
        public static int Square_amount(int n)
        {
            //הפעולה מקבלת מספר סידורי ומחזרה את ערכו 
            if (n == 0)
            {
                return 0;
            }
            return Square_amount(n - 1) + Place_size(n);
        }
        static void Main(string[] args)
        {
            //p26 ex13
            Console.WriteLine(Place_size(5));
            //Place_size(5)=Place_size(4)^2+Place_size(3)^2=0->Place_size(4)=Place_size(3)^2+Place_size(2)^2=1-> Place_size(3)=Place_size(2)^2+Place_size(1)^2=2->Place_size(2)=Place_size(1)^2+Place_size(0)^2=5->Place_size(1)=if=29  
            Console.WriteLine(Square_amount(5));
            //Square_amount(5)=Square_amount(4) + Place_size(5)=29->Square_amount(4)=Square_amount(3) + Place_size(4)=34->Square_amount(3)=Square_amount(2) + Place_size(3)=36->Square_amount(2)=Square_amount(1) + Place_size(2)=37->Square_amount(1)=Square_amount(0) + Place_size(1)=37

        }
    }
}
