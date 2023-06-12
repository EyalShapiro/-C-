using System;

namespace רקורסיה_ש.ב_3_תרגלים
{
    class Program
    {
        //ex 1 
        //.(החזרת מספר הספרות של מספר. (המספר - פרמטר לפעולה
        public static int Digit_Num(int num, int sum)
        {
            //הפעולה מקבלהת מספר וסכום הספרות ומחזרה  מספר הספרות של מספר
            if (num <10)
            {
                return 1;
            }
            return Digit_Num(num / 10, sum+1 );

        }
        //ex2
        //.(החזרת סכום הספרות של מספר. (המספר - פרמטר לפעולה
        public static int Sum_Num(int num)
        {
            //הפעולה מקבלהת מספר ומחזרה את סכום הספרות של מספר
            if (num < 10)
            {
                return num;
            }
            return Sum_Num(num / 10 )*(num%10 );

        }
        //ex3
        //.(החזרת מכפלת הספרות של מספר. (המספר - פרמטר לפעולה
        public static int Hem_Num(int num)
        {
            //הפעולה מקבלהת מספר ומחזרה את מכפלת הספרות של מספר 
            if (num< 10)
            {
                return num ;
            }
            return Hem_Num((num / 10) *(num%10));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("ex1 :"+Digit_Num(1234, 0));//num=1234->123->12->1->0 sum=0->1->2->3->4
            Console.WriteLine("ex2 :"+Sum_Num(1234));//num=1234->(123)+4->(12)+4+3->(1)+4+3+2->4+3+2+1=10 
            Console.WriteLine("ex3 :"+ Hem_Num(1234));//num=1234->(123)*4->(12)*4*3->(1)*4*3*2->4*3*2*1=24 
        }
    }
}
