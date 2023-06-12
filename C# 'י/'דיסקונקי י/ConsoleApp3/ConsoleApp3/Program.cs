using System;

namespace bagrusubject
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double count = 0, count2 = 0, count_shcool=0;
            int students, failed;
            string name;
            for (int i = 0; i <= 2; i++)
            {

                Console.WriteLine("enetr num students");
                students = int.Parse(Console.ReadLine());
                Console.WriteLine("enetr num failents");
                failed = int.Parse(Console.ReadLine());
                BagrutSubject b1 = new BagrutSubject("computer", 899222, double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), students, failed); if (students < failed - students) ;
                count = b1.GetFailed() + count;
                count2 = b1.GetStudents() + count2;
                Console.WriteLine();
                count_shcool = count_shcool+ b1.GetTestAvg();
            }
            count2 = count2 % count;
            count_shcool = count_shcool % 150;
            for (int y = 0; y <= 2; y++)
            {
                Console.WriteLine("enetr name school");
                name = Console.ReadLine();
                Console.WriteLine("enetr num students");
                students = int.Parse(Console.ReadLine());
                Console.WriteLine("enetr num failents");
                failed = int.Parse(Console.ReadLine());
                BagrutSubject b1 = new BagrutSubject("computer", 899222, double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), students, failed);
                {
                    Console.WriteLine(name);
                }
                
            }
            
        }


    }
}