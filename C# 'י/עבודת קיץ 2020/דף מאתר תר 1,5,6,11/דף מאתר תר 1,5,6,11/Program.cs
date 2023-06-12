
using System;

namespace דף_מאתר_תר_1_5_6_11
{
    class Program
    {
        /*
        //ex1
        public static bool Lines(int[,]arr)
        {
            // הפעולה מקבלת מערך דו ממדי ומחזר אמת הם הוא ממוינת שורות שקר החרת 
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i,j-1]>arr[i,j])
                    {
                        return false;
                    }
                }
            }
            return true; 
        }
        //ex1
        public static bool Columns(int[,] arr)
        {
            // הפעולה מקבלת מערך דו ממדי ומחזר אמת הם הוא ממוינת עמודות שקר החרת 
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    if (arr[i-1, j] > arr[i, j])
                    {
                        return false;
                    }
                }   
            }
            return true;
        }
        */
        /*
        //ex6 א
        public static bool Matrix_thin(int[,] arr)
        {
            //פעולה מקבלת מערך דו מדי ומחזירה אמת כאשר המטצה דלילה
            int count = 0, all_count = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] != 0)
                        count++;
                    else
                        all_count++;
                }
                if (count > 2)
                    return false;
                count = 0;
            }
            if (arr.Length * 0.2 > all_count)
                return false;
            return true;
        }
        //ex6 ב
        public static int[,] Matrix (int[]values,int[]lines,int[]columns,int sum)
        {
            //פעולה מקבלת 3 מערכים ואת מספר איברים מטריצה מקורית ומחזירה את מטריצה המקורית 
            int[,] arr = new int[(int)Math.Sqrt(sum), (int)Math.Sqrt(sum)];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = 0;
                }
            }
            for (int i = 0; i < values.Length; i++)
            {
                arr[lines[i], columns[i]] = values[i];
            }
            return arr; 
        }
        */
        static void Main(string[] args)
        {
            //ex1
            /*
            int[,] matrix = new int[10,15];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j <matrix.GetLength(1); j++)
                {
                    Console.WriteLine("enter num");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            if (Lines(matrix)==true&&Columns(matrix)==true)
                Console.WriteLine("Fully sorted");
            if(Lines(matrix) == true && Columns(matrix) == false)
                Console.WriteLine("Sorted by rows");
            if (Lines(matrix) == false && Columns(matrix) == true)
                Console.WriteLine("Sorted columns");
            */
            /*
            //ex5
            int[,] number = new int[10, 10];
            Random r = new Random();
            for (int i = 0; i < number.GetLength(0); i++)
            {
                for (int j = 0; j < number.GetLength(1); j++)
                {
                    number[i, j] = r.Next(1,51);
                }
            }
            int[,] arr = new int[2, 2];
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.WriteLine("enter num");
                    arr[i, j]=int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < number.GetLength(0); i++)
            {
                for (int j = 0; j < number.GetLength(1); j++)
                {
                    Console.WriteLine(number[i,j]);
                }
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.WriteLine(arr[i, j] );
                }
            }
            for (int i = 0; i < number.GetLength(0); i++)
            {
                for (int j = 0; j < number.GetLength(1); j++)
                {
                    if (number[i, j]==arr[0,0]&&number[i+1,j]==arr[1,0]&&number[i,j+1]==arr[0,1]&&number[i+1,j+1]==arr[1,1])
                    {
                        Console.WriteLine("The big set decides the little brother too");
                    }                    
                }
            }
            */
            //ex6
            /*
            int[,] number = new int[5,5];
            Random r = new Random();
            for (int i = 0; i < number.GetLength(0); i++)
            {
                for (int j = 0; j < number.GetLength(1); j++)
                {
                    number[i, j] =  r.Next(0, 10);
                }
            }
            Console.WriteLine(Matrix_thin(number));
            int[] vlues = { 9, 8, 25, 15 };
            int[] com = { 3, 2, 2, 4 };
            int[] lien = { 0, 2, 3, 4 };
            number =Matrix(vlues,lien,com,25);
            for (int i = 0; i < number.GetLength(0); i++)
            {
                for (int j = 0; j < number.GetLength(1); j++)
                {
                    Console.WriteLine( number[i, j] );  
                }
            }
            */
            //ex11
            /*
            int[,] number = new int[5, 4];
            Random r = new Random();
            for (int i = 0; i < number.GetLength(0); i++)
            {
                for (int j = 0; j < number.GetLength(1); j++)
                {
                    number[i, j] =  r.Next(0, 100);
                }
            }
            int count_column=0, count_length=0;
            for (int i = 0; i < number.GetLength(0); i++)
            {
                for (int j = 1; j < number.GetLength(1); j+=2)
                {
                    count_column+= number[i, j];
                }
            }
            for (int i = 0; i < number.GetLength(0); i+=2)
            {
                for (int j = 1; j < number.GetLength(1); j ++)
                {
                    count_length += number[i, j];
                }
            }
            if (count_column>count_length)
            {
                Console.WriteLine("Matrix postiive");
            }
            else
            {
                Console.WriteLine("Matrix not postiive");
            }
            */
        }
    }
}
