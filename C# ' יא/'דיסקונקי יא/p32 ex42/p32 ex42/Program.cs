using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p32_ex42
{
    class Program
    {
        public static int Sum(int num)
        {//הפעולה מבלת מספר שלם חיובי מחשבת את סכום של המספרים  ומחזרה את סכום  
            //o(n)
            if (num != 0)
                return Sum(num / 10) + num % 10;
          return 0 ;

        }


        public static int Sum_SingleDigit(int num)
        {//הפעולה מבלת מספר שלם חיובי מחשבת את ספרת הביקורת ומחזרה את ספרת הביקורת  
            //o(n * n)
            if (num<10)
                return num;
            return Sum_SingleDigit(Sum(num));

        }
        static void Main(string[] args)
        {
            //p32_ex42
            //Console.WriteLine(Sum(869419));
            Console.WriteLine("Sum_SingleDigit(869419) = " + Sum_SingleDigit(869419));
            Console.WriteLine("Sum_SingleDigit(26) = "+ Sum_SingleDigit(26));

        }
    }
}
