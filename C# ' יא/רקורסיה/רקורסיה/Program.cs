using System;

namespace רקורסיה
{
    class Program
    {
        public static double Multiplication(double num1, double num2)//p12 ex2 הם שדררוגה
        {//פעולה מקבלת שני מספרים חיובי ומחזר את מכפלת של מספרים מבילי כפלה
            if (num2 <= 0)
            {
                return 0;
            }
            return Multiplication(num1, num2 - 1) + num1;
        }
        public static double Division(double num1, double num2)//p12 ex2 הפוך
        {//פעולה מקבלת שני מספרים חיובי בדקת מי גדול מי בין הם ומחזר את חלוקה של מספרים מבילי חילוקה
            if (num1 > num2)
            {
                if (num2 <= 0)
                    return 0;
                return Division(num1, num2 - 1) + num2;
            }
            if (num2 > num1)        
            {
                if (num1 <= 0)
                    return 0;
                return Division(num1 - 1, num2) + num1;
            }
            return num1 / num2;
        }
        public static int Sum_Numbers_Of_Num(int num)
        {//הפעולה מקבלת מספר שלם ומחרזה סכום הספורות 1עד מספר
            if (num==0)
            {
                return 0;
            }
            return Sum_Numbers_Of_Num(num-1)+num-1;
        }
        public static bool DigitsRageNumber(int num)//p26 ex9
        {//הפעולה מקבלת מספרה מחזרה אמת הם כל הספרות של מספר זעים שקר אחרת
            if(num<=1)
            {
                return true;
            }
            if (num%10%2!=num/10%10%2)
            {
                return false;
            }
            return DigitsRageNumber(num / 10);
        }
        static void Main(string[] args)
        {
            //p12 ex2
            Console.WriteLine(Multiplication(1.2, 4));
            //Multiplication(1.2,4)=1.2->Multiplication(1.2,3)=2.4->Multiplication(1.2,2)=3.6->Multiplication(1.2,1)=4.8->Multiplication(1.2,0)=return(0)
            Console.WriteLine(Multiplication(12, 8));//=96
            //p12 ex2 במקום כפל חילוקד
            Console.WriteLine(Division(24, 6));
            //p26 ex1
            Console.WriteLine(Sum_Numbers_Of_Num(5));//Sum_Numbers_Of_Num(5)=4->Sum_Numbers_Of_Num(4)=7->Sum_Numbers_Of_Num(3)=9->Sum_Numbers_Of_Num(2)=10->Sum_Numbers_Of_Num(1)=10->Sum_Numbers_Of_Num(5)=return(0)
            //p26 ex9
            Console.WriteLine("DigitsRageNumber(2468)=" + DigitsRageNumber(2468));
            Console.WriteLine("DigitsRageNumber(1235)=" + DigitsRageNumber(1235));
            Console.WriteLine("DigitsRageNumber(1357)=" + DigitsRageNumber(1357));
        }
    }
}
