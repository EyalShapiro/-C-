using System;

namespace p146_147
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //p 146 ex8 
            int num,contr=0 ;
            Console.WriteLine("enter a num");
            num = int.Parse(Console.ReadLine());
            while (num>0)
            {
                contr++ ;
                Console.WriteLine("enter a num");
                num = int.Parse(Console.ReadLine());

            }
            Console.WriteLine(contr);

            */
            //p 146 ex9
            /*
            int num,min=999999,max=0;
            Console.WriteLine("enter a grade");
            num = int.Parse(Console.ReadLine());
            while (num > 0)
            {
                 if (num > max)
                     max = num;
                 if (min > num)
                     min = num;
                 if(num>=95)
                    Console.WriteLine("Passed cum");
                 if(num<=55)
                    Console.WriteLine("Fails");
                Console.WriteLine("enter a grade");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("max grade: "+max);
            Console.WriteLine("min grade: "+min);
            */
            //p 146 ex6
            /*
            int num,max=0,man,asarot;
            Console.WriteLine("enter a num two digit num");
            num = int.Parse(Console.ReadLine());
            while (num<=99&&num>=10)
            {
                man = num % 10;
                asarot = num / 10;
                if  (num>max&&man!=asarot)
                {
                    max = num;
                }

                Console.WriteLine("enter a num two digit num");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("max num: "+max);
            */
            //p 146 ex7
            /*
            int num, sum=1;
            Console.WriteLine("enter a num ");
            num = int.Parse(Console.ReadLine());
            while (num!=-1)
            {
               sum=sum* num; 
                Console.WriteLine("enter a num ");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum/2);
            Console.WriteLine(sum/3);
            */
            //p 147 ex12
            int mani,tam, sum = 0,num=0,sum2=0;
            Console.WriteLine("enter a tam ");
            tam = int.Parse(Console.ReadLine());
            Console.WriteLine("enter a  mani");
            mani = int.Parse(Console.ReadLine());
            while (tam>0)
            {
                sum2++;
                num = tam * mani;
                if (tam>150)
                {
                    mani = mani + 250;
                }
                num = tam * mani;
                sum = num + sum;
                Console.WriteLine("enter a tam ");
                tam = int.Parse(Console.ReadLine());
                Console.WriteLine("enter a  mani");
                mani = int.Parse(Console.ReadLine());

            }
            Console.WriteLine(sum);
            Console.WriteLine(sum%sum2);
















        }
    }
}
