using System;

namespace פעולות_שאינן_מחזירות_ערך
{
    class Program
    {
        /*
        public static void Code(int num)
        {
            //ex1
            
            //  המקבלת מספר המציין קוד קורס ומדפיסה את שם הפקולטה אופי הקורס ומספר הכיתה
            if (num/10000==1 )
            {
                Console.WriteLine("Exact sciences");   
            }
            else if (num / 10000 ==2)
            {
                Console.WriteLine("Life science");
            }
            else if (num / 10000 ==3)
            {
                Console.WriteLine("Social Sciences");
            }
            if ((num/1000)%10==0)
            {
                Console.WriteLine("workshop");
            }
            else if ((num / 1000)% 10== 1)
            {
                Console.WriteLine("lecture");
            }
            Console.WriteLine("class: "+num%1000);
            }
        */
        //ex2
        public static void Rectangl(double length, double width, Char c)
        {
            Console.WriteLine("Area: " + length * width);
            Console.WriteLine("Scope: " + 2 * (length + width));
            Console.WriteLine("The diagonal: " + Math.Sqrt(Math.Pow(length, 2) + Math.Pow(width, 2)));
            for (int i = 0; i < length; i++)
            {
                for (int g = 0; g < width; g++)
                {

                    if (i!=0&&i!=length-1)
                    {
                        if (g!= 0&&g!=width-1)
                        {
                            Console.Write("");
                        }
                        else
                        {
                            Console.Write(c);
                        }
                    }
                    else
                    {
                        Console.Write(c);
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("length:"+ length*2);            
            Console.WriteLine("Area: " + 2*(length * width));
            Console.WriteLine("Scope: " + 2*(2 * (length + width)));
            Console.WriteLine("The diagonal: " +2*( Math.Sqrt(Math.Pow(length, 2) + Math.Pow(width, 2))));
            width = width - 3.0; 
            Console.WriteLine("width " + width);
        }


    
            
   
        static void Main(string[] args)
        {
        //ex1
        /*
        int C = 12345; 
        Code(11345);
        //X = Code(20746);
        //מדפס ולא מחזרה ערך 
        Code(C);
        //תקין
        //Console.WriteLine(Code(C));
        //אי אפשר לדפס את הדפס
        //Code(C + 2.5);
        //c מספר שלם
        Code(C + 2);
        //תקין
        */
        //ex2
            double length, width;
            Console.WriteLine("enter length");
            length = double.Parse(Console.ReadLine());
            Console.WriteLine("enter width");
            width = double.Parse(Console.ReadLine());
            Console.WriteLine("enter char");
            char c = char.Parse(Console.ReadLine());
            Rectangl(length, width, c);

        }
    }
}
