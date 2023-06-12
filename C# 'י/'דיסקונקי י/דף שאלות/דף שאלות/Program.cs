using System;

namespace דף_שאלות
{
    class Program
    {
        //ex2
       public static int Runn(double[]arr ,double num)
        {//מקבלת מהרכה וספר ומרזר את מקם 
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]==num)
                {
                    return i;
                }
                if (arr[i]<num)
                {
                    return i;
                }
               
            }
            return arr.Length ;
        }
        //ex8
        public static bool Ex8(int[]arr)
        {
            int count;
            for (int i = 0; i < arr.Length; i++)
            {
                count =0;
                for (int z = 1; z < arr.Length; z++)
                {  
                    if (arr[i]==z)
                    {
                        count=i;
                    }
                }
                if (count!=i)
                {
                    return false;
                }
                
            }
            return true;


        }


        static void Main(string[] args)
        {
            /*
            //ex 2
            double num;
            double[] numbrs = {1.2,1.25,1.39,1.41,1.5,1.55,1.6,1.7,1.8,1.9 };//10
            Console.WriteLine(numbrs.Length);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("enter running result");
                num = double.Parse(Console.ReadLine());
                Console.WriteLine( Runn(numbrs,num));
            }     
             */
            //ex8
            int[] number = { 5, 3, 4, 2, 1};
            Console.WriteLine(Ex8(number));
        }
    }
}
