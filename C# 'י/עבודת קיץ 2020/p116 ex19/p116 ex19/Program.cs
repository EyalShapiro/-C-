using System;

namespace p116_ex19
{
    class Program
    {
        //p116 ex19 ג
        public static int Num(CoupleNames[,] arr)
        {
            // ןמחזירה את מספר תהתלמידים בכיתה CoupleNames פעולה מקבלת מערך דו מדדי של טיפוס
            int count = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j].GetName1() != "" && arr[i, j].GetName2() != "")
                    {
                        count += 2;
                    }
                    else if (arr[i, j].GetName1() == "" && arr[i, j].GetName2() != "")
                    {
                        count += 1;
                    }
                    else if (arr[i, j].GetName1() != "" && arr[i, j].GetName2() != "")
                    {
                        count += 1;
                    }
                }
            }
            return count;
        }
        //p116 ex19 ד
        public static int Location(CoupleNames[,] arr,string name)
        {
            // ושם תלמידה ומחירה מספר דו ספרתי מאתר את מקום  CoupleNames פעולה מקבלת מערך דו מדדי של טיפוס  
            int num=0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j].GetName1()==name|| arr[i, j].GetName2()==name)
                    {
                        num = j * 10 + i;
                    }
                }
            }
            return num;
        }
        static void Main(string[] args)
        {
            //p116 ex19 
            CoupleNames[,] cles = new CoupleNames[8, 4];
            for (int i = 0; i < cles.GetLength(0); i++)
            {
                for (int j = 0; j < cles.GetLength(1); j++)
                {
                    Console.WriteLine("enter name");
                    cles[i, j] = new CoupleNames(Console.ReadLine(), Console.ReadLine());
                }
            }
            Console.WriteLine(Num(cles));
            Console.WriteLine(Location(cles,"niv"));
        }
    }
}
