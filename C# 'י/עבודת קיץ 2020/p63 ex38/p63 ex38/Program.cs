
using System;

namespace p63_ex38
{
    class Program
    {
        static void Main(string[] args)
        {
            //63 ex38
            int[] par = new int[50];
            for (int i = 0; i < par.Length; i++)
            {
                par[i] = 0;
            }
            int[] judges = new int[3];
            for (int i = 0; i <judges.Length; i++)
            {
                judges[i] = 0;
            }
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("Nest 1 place");
                judges[0] = int.Parse(Console.ReadLine());
                Console.WriteLine("Nest 2 place");
                judges[1] = int.Parse(Console.ReadLine());
                Console.WriteLine("Nest 3 place");
                judges[2] = int.Parse(Console.ReadLine());
                par[judges[0]] += 3;
                par[judges[1]] += 2;
                par[judges[2]] += 1;
            }
            int max1 = 0,sav=0, max2 = 0,sav2=0, max3 = 0,sav3=0;
            for (int i = 0; i < par.Length; i++)
            {
                if (max1<par[i])
                {
                    max1 = par[i];
                    sav = i + 1;
                }
            }
            for (int i = 0; i < par.Length; i++)
            {
                if (max2 < par[i]&&par[i]<max1)
                {
                    max2 = par[i];
                    sav2 = i + 1;
                }
            }
            for (int i = 0; i < par.Length; i++)
            {
                if (max3 < par[i] && par[i] < max2)
                {
                    max3 = par[i];
                    sav3 = i + 1;
                }
            }
            Console.WriteLine("1:  "+ sav+ " Points " +max1);
            Console.WriteLine("2:  " + sav2 + " Points " + max2);
            Console.WriteLine("3:  " + sav3 + " Points " + max3);

        }
    }
}
