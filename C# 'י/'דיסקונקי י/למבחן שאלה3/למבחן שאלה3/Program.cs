using System;

namespace למבחן_שאלה3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num_snip=0;
            double num, sum_store = 0, max_store = 0,avg=0; 
            double[] stores = new double[20];
            for (int i = 0; i < stores.Length; i++)
            {
                stores[i] = 0;
            }
            Console.WriteLine("enetr num snip");
            num_snip = int.Parse(Console.ReadLine());
            Console.WriteLine("enetr num skot To tax income num -1");
            num = double.Parse(Console.ReadLine());
            if (num_snip > 0 && num_snip < 21)
            {
                Console.WriteLine("not snip dis");
            }
            while (num!=-1)
            {
                stores[num_snip-1] +=num;
                Console.WriteLine("enetr num snip");
                num_snip = int.Parse(Console.ReadLine());
                Console.WriteLine("enetr num skot To tax income num -1");
                num = double.Parse(Console.ReadLine());
                if (num_snip>0&&num_snip<21)
                {
                    Console.WriteLine("not snip dis");
                }
            }
            num_snip = 0;
            for (int i = 0; i < stores.Length; i++)
            {
                sum_store += stores[i];
                if (stores[i] > max_store)
                {
                    max_store = stores[i];
                    num_snip = i + 1;
                }
            }
            avg = sum_store/stores.Length;
            Console.WriteLine("max :"+num_snip+" : "+max_store);
            Console.WriteLine("avg all store :"+avg);
            for (int i = 0; i < stores.Length; i++)
            {
                Console.WriteLine(i+1+" : "+stores[i]);
            }


        }
    }
}
