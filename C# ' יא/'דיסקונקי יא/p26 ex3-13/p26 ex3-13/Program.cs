using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p26_ex3_13
{
    class Program
    {
        //p26 ex3
        public static int Zogi(int n)
        {
            if (n == 0)
                return 1;
            if (n % 2 == 1)
                return Zogi(n - 1) * n;
            else
                return Zogi(n - 1);
        }

        // ex5
        public static int Mana(int num1, int num2)
        {//מקבלת שני מספרים שלמים ומחזירה את המנה השלמה שלהם ע"י פעולות חיבור וחיסור
            if (num1 < num2)
                return 0;
            else //if (num1 >= num2)
                return Mana(num1 - num2, num2) + 1;
        }
        //ex6
        public static int Reminder(int x, int y)  // y - ב  x  מציאת השארית של חלוקת המספרים 
        {
            if (y == 0)  // X / 0 = error 
            {
                return -1;
            }

            if (x >= 0 && x < y) // תנאי עצירה 
            {
                return x;   // x (מחזירים את (שארית  
            }
            x -= y; // x - y = y
            return Reminder(x, y); // קריאה לפונקציה רקורסיבית
        }
        //ex7
        public static bool IsMult(int y, int x)//(7) gets two numbers and return true if x can divide y
        {
            if (y < x && y == 0 || x == y)//simple case
                return true;
            else if (y < x && y != 0)//simple case
                return false;
            else //complecated case
                return IsMult(y - x, x);
        }
        //ex8
        public static bool prime(int num, int half)
        {
            //מקבל מספר ומחצית ממנו ומחזיר אמת אם הוא ראשוני
            if (half == 1)
                return true;
            else if (num % half == 0)
                return false;
            return prime(num, half - 1);
        }
        //ex9
        public static bool AllDigitsAreEvenOrNot(int num)
        {
            // טענת כניסה: פעולה המקבלת מספר חיובי שלם   
            // טענת יציאה: פעולה המחזירה אמת אם כל ספרות המס זוגיות או כל ספרות המס אי זוגיות ושקר אם לא
            if (num< 10)
            {
                return true;
            }
            if (num % 2 != (num / 10) % 2)
            {
                return false;
            }
            return AllDigitsAreEvenOrNot(num / 10);
        }

        //ex12
        public static int IdoGay(int n1, int n2, int num_multi)
        {
            //הפעולה מקבלת שתי מספרים ומחזיה אתה סכום
            if (n1 > n2)
                return 0;
            if (n1 * num_multi > n2)
                return 0;
            return IdoGay(n1, n2, num_multi + 1) + n1 * num_multi;
        }
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
            //p26 ex3
            Console.WriteLine(Zogi(16));//1*3*5*7*9*11*13*15=2,027,025
            
            //ex5
            Console.WriteLine("mana: " + Mana(16, 5));//Mana(16, 5) =Mana(11, 5)+1=Mana(6, 5)+1 +1 = Mana(1,5)+ 1+1+1 = 0 + 1 + 1 + 1 = 3

            //Mana(13, 3)= Mana(10,3) +1= Mana(7,3)+1+1 = Mana(4, 3) +1+1+1 =Mana(1,3) +1+1+1+1 = 0+1+1+1+1 = 4
            //ex6
            Console.WriteLine(Reminder(5, 2)); // Reminder(5, 2) = Reminder(3, 2) = Reminder(1, 2) = 1
            //ex7
            Console.WriteLine(IsMult(11, 5));//IsMult(11, 5) = IsMult(6, 5) = IsMult(1, 5) = false
            Console.WriteLine(IsMult(6, 2));//IsMult(6, 2) = IsMult(4, 2) = IsMult(2, 2) = true

            //ex8
            Console.WriteLine(prime(9, 9 / 2));
            Console.WriteLine(prime(13, 13 / 2));
            // prime(9,4) => prime(9,3)[4-1]=>false
            // prime(13,6) => prime(13,5)[6-1]=>prime(13,4)[5-1]=>prime(13,3)[4-1]=>prime(13,2)[3-1]=>prime(13,1)[2-1]=>true

            //ex9
            Console.WriteLine(AllDigitsAreEvenOrNot(246));
            //AllDigitsAreEvenOrNot(246)=>if(246<10)=>x=>if(0!=0)=>x=>AllDigitsAreEvenOrNot(24)=>if(24<10)=>x=>if(0!=0)=>x=>AllDigitsAreEvenOrNot(2)=>if(2<10)=>true
            
            //ex12
            int n1 = 5, n2 = 50, num_multi = 1;
            Console.WriteLine(IdoGay(n1, n2, num_multi));

            //p26 ex13
            Console.WriteLine(Place_size(5));
            //Place_size(5)=Place_size(4)^2+Place_size(3)^2=0->Place_size(4)=Place_size(3)^2+Place_size(2)^2=1-> Place_size(3)=Place_size(2)^2+Place_size(1)^2=2->Place_size(2)=Place_size(1)^2+Place_size(0)^2=5->Place_size(1)=if=29  
            Console.WriteLine(Square_amount(5));
            //Square_amount(5)=Square_amount(4) + Place_size(5)=29->Square_amount(4)=Square_amount(3) + Place_size(4)=34->Square_amount(3)=Square_amount(2) + Place_size(3)=36->Square_amount(2)=Square_amount(1) + Place_size(2)=37->Square_amount(1)=Square_amount(0) + Place_size(1)=37

        }
    }
}
