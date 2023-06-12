using System;

namespace p175_ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*//p175 ex8
            Id_Kid ik = new Id_Kid("2561", "saaey", "sd", new Date(1, 5, 1990), "r", "d");
            Id_Adult ia = new Id_Adult("2561", "ey", "sd", new Date(1, 5, 1900),"t",2,new Id_Kid(ik);
            Console.WriteLine(ia.Add_kid(ik));
            ia.Eightiiln(ik);
            ia.Add_kid(ik);
            Console.WriteLine(ia.Adults(ia)); */

            Id_Kid[] kid = new Id_Kid[5];
            Id_Adult[] ad = new Id_Adult[3];
            for (int i = 0; i < ad.Length; i++)
            {
                for (int j = 0; j < kid.Length; j++)
                {
                    Console.WriteLine(" string id_num, string first_name, string last_name, Date birth, string country_of_birth, string nation");
                    kid[j] = new Id_Kid(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(),
                         new Date(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())),
                         Console.ReadLine(), Console.ReadLine());
                }
                Console.WriteLine("(string id_num, string first_name, string last_name, Date birth, string country_of_birth,int num_kids)");
                ad[i] = new Id_Adult(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), 
                                    new Date(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())),
                                    Console.ReadLine(),3,kid);
            }

            for (int i = 0; i < ad.Length; i++)
            {
                for (int j = i; j < ad.Length; j++)
                {
                    if (i!=j&&ad[i].Adults(ad[j])>0)
                    {
                        Console.WriteLine("1 "+ad[i].GetFirst_name()+" "+ad[i].GetId_num()+"2 "+ ad[j].GetFirst_name() + " " + ad[j].GetId_num());
                    }
                }
            }
        }
    }
}
