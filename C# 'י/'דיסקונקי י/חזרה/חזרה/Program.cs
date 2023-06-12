using System;

namespace חזרה
{
    class Program
    {
        static void Main(string[] args)
        {

            //p146 ex9
            /*
            int max = 0, min = 999999, num;
            Console.WriteLine("enter numbr");
            num = int.Parse(Console.ReadLine());
            while (num > 0)
            {

                if (num > max)
                    max = num;
                if (min > num)
                    min = num;
                Console.WriteLine("enter numbr");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("max numbr " + max);
            if (max >= 95)
            {
                Console.WriteLine("good");
            }
            Console.WriteLine("min numbr " + min);
            if (min < 55)
            {
                Console.WriteLine("n");
            }
            */

            //p151 ex21
            /*
            double num;
            int Counter=0;
            Console.WriteLine("enter numbr");
            num = double.Parse(Console.ReadLine());
            while ((int)num%10!=0)
            {
                Counter++;
                num=num /10;
            }
            Console.WriteLine(Counter);
            */

            //p150 ex15
            /*
            int num, Counter = 0,sum=0,prod=1;
            Console.WriteLine("Please enter an integer: ");
            num = int.Parse(Console.ReadLine());
            while (num!=0)
            {
                Counter++;
                int digit = num % 10;
                sum += digit;
                prod *= digit;
                num /= 10;
            }
            //מספר ספרות של מספר 
            Console.WriteLine(Counter);
            // סכום הספרות 
            Console.WriteLine(sum);
            // מכפלת הספרות
            Console.WriteLine(prod);
            */

            /*
            //p150 ex16
            int num, sum=0, Counter = 0;
            Console.WriteLine("enter numbr");
            num = int.Parse(Console.ReadLine());
            while (num!=0)
            {
                sum = num % 10;
                Counter = (sum*sum)+ Counter;
     
                
                sum = 0;
                num -= num-1;
            }
            Console.WriteLine(Counter);
            */
            /*
            //p146 ex8
            int num, Counter=0;
            Console.WriteLine("enter numbr");
            num = int.Parse(Console.ReadLine());
            while (num>0)
            {
                Counter++;
                Console.WriteLine("enter numbr");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(Counter);
            */








        }
    }
}