
using System;

namespace p77_ex50
{
    class Program
    {

        //p77 ex50 ב
        public static int Ex50 (Advr[]arr ,string company_name)
        {
            int time=0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].GetCompany_name()==company_name)
                {
                    time += arr[i].GetLength();
                }
            }
            return time;

        }
        static void Main(string[] args)
        {
            //int second_price;//מחיר לשנייה 800
            Advr[] arr = new Advr[53];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("enter advertisement_name and company_name and length In seconds");
                arr[i] = new Advr(Console.ReadLine(), Console.ReadLine(), int.Parse(Console.ReadLine()));
            }
            //arr[0] = new Advr("h", "h", 100);
            int subtlety, Seconds;
            for (int i = 0; i < arr.Length; i++)
            {
                subtlety =arr[i].GetLength()/60;
                Seconds = arr[i].GetLength() - (subtlety * 60);
                Console.WriteLine("subtlety "+ subtlety+ " Seconds "+Seconds );

            }
            int sum_advertising = 0, count_company = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Cost of advertising"+arr[i].GetLength()*800);
                sum_advertising += arr[i].GetLength() * 800;
            }
            string name="";
            Console.WriteLine("Cost per day"+sum_advertising);
            for (int i = 0; i < arr.Length; i++)
            {
                if (Ex50(arr,arr[i].GetCompany_name())>count_company)
                {
                    count_company = Ex50(arr, arr[i].GetCompany_name());
                    name= arr[i].GetCompany_name();
                }
            }
            Console.WriteLine("name " + name+ "  Revenue "+count_company);

        }
    }
}
