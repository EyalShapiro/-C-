using System;

namespace תרגילים_לשיפור_ציון
{
    class Program
    {
        static void Main(string[] args)
        {
            //ex1
            /*
            Console.WriteLine("enter day,month,year ");
            Date date1 = new Date(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            Console.WriteLine("enter day,month ");
            Date date2 = new Date(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), date1.GetYear());
            Console.WriteLine("date1 "+date1);
            Console.WriteLine("date2 "+date2);
            Console.WriteLine(date1.GetDay());
            Console.WriteLine(date2.GetMonth());
            date1.CompareTo(date2);
            //שלחתי תמונה 
            date1.SetDay(date2.GetDay());
            date1.SetMonth(date2.GetMonth());
            //היוצה 0 בגלל שתאריך אם תאריך  שווים 
            Console.WriteLine(date1.CompareTo(date2));
            */

            
            //ex2
            int speed ,cont=0,sum=0,max_speed=0,i, max_speed_num=0;
            SpeedTrap st;             
            for ( i=1 ; i <=100; i++)
            {
                
                Console.WriteLine("enter spee");
                speed = int.Parse(Console.ReadLine());
                Console.WriteLine("enter code, road, Maximum speed is allowed on this road");
                st = new SpeedTrap(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));              
                if (st.GetSpeed()>=speed)
                {
                    Console.WriteLine("Did not exceed the speed limit");                        
                }
                else
                {
                    cont++; 
                    Console.WriteLine("Exceeded speed limit");
                }
                if (max_speed<speed)
                {
                    max_speed = speed;
                    max_speed_num = st.GetRoad();
                }
                
            }
            Console.WriteLine("Percentage of daily cars exceeding the speed limit" +(cont/i)*100);
            Console.WriteLine("License number that traveled the fastest:" + max_speed_num+ "max speed: " + max_speed);
          
            //ex3
            /*
            double grade, grade2, final_grade;
            for (int i = 1; i <= 3; i++)
            {
                final_grade = 0;
                Console.WriteLine("enter num grade");
                grade = double.Parse(Console.ReadLine());
                Console.WriteLine("enter num grade");
                grade2 = double.Parse(Console.ReadLine());
                if (grade2-grade>5)
                    final_grade = grade2;
                else
                    final_grade = (grade + grade2) / 2;                    
                if (final_grade > 90)
                {
                    Console.WriteLine("final grade: "+final_grade+" excellence");
                }
                else if (final_grade<55)
                {
                    Console.WriteLine("final grade: "+final_grade+" failed");
                }
                else
                {
                    Console.WriteLine("final grade: " + final_grade);
                }

            } 
            */
            //ex4
            /*
            Random randNum = new Random();
            int cont = 1,num, sum = 0,ran,ran2;
            Console.WriteLine("enter num ");
            num = int.Parse(Console.ReadLine());
            ran = randNum.Next(100, 1000);
            ran2 = ran;
            while (ran2 > 0)
            {
                sum = sum + ran2 % 10;
                ran2 /= 10;
            }
            while (sum!=num&&num>=1&&num<=27)
            {
                ran = randNum.Next(100, 1000);
                cont++;
                ran2 = ran;
                sum = 0;
                while (ran2 > 0)
                {
                    sum=sum + ran2 % 10;
                    ran2 /= 10;
                }
            }
            Console.WriteLine("Num were drawn: " + cont);
            Console.WriteLine("Random " + ran);
            */




        }
    }
}
