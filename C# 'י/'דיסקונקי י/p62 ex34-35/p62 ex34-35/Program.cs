using System;

namespace p62_ex34_35
{
    class Program
    {
        //ex34
        public static int Sum(int[]arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;

        }
        static void Main(string[] args)
        {
            
            //ex33 p62 חלק ב
            /*
            Random ran = new Random();
            int[] arrCount = new int[10];
            for (int i = 0; i < arrCount.Length; i++)
            {
                arrCount[i] = 0;
            }
            for (int i = 0; i < 1000; i++)
            {
                int num = ran.Next(0, 11);

                if (num > 0 && num <= 10)
                {
                    arrCount[num - 1]++;
                }
            }
            for (int i = 0; i < arrCount.Length; i++)
            {
                Console.WriteLine(i + 1 + " = " + arrCount[i]);
            }
            */
            //ex34 
            /*
            int num = 0,max=0,min=100000000, storey_of_min=0, max_of_storey =0, max_of_Office = 0;
            int[] arr= new int[30];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = 0;
            }
            int[] storey = new int[7];
            
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j <storey.Length; i++)
                {
                    storey[j] = 0;
                }
                for (int z = 0; z < 7; z++)
                {
                    Console.WriteLine("enter num office"+ z+1);
                    num = int.Parse(Console.ReadLine());
                    storey[z] = num;
                    if (max<num)
                    {
                        max = num;
                        max_of_storey =i+1;
                        max_of_Office = z + 1;
                    }
                }
                    if (min>Sum(storey))
                    {
                        min = Sum(storey);
                        storey_of_min = i + 1;
                        
                    }
                
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(i + 1+": "+arr[i]);
            }
            Console.WriteLine("num of min" + min+ "storey  " +storey_of_min);
            Console.WriteLine("storey of max" + max_of_storey + " Office number max" + max_of_Office);
            */
            //p62 ex35            
            int num,max=0,max_num=0,min=1000000000,min_num=0 ;
            int[] arr = new int[15];
            Console.WriteLine("enter num between1-15 to finish enter the number 0");
            num = int.Parse(Console.ReadLine());
            while (num!=0)
            {
                arr[num - 1]++;
                Console.WriteLine("enter num between1-15 to finish enter the number 0");
                num = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
                if (min>arr[i])
                {
                    min = arr[i];
                    min_num = i + 1;
                }
            }
            Console.WriteLine("min num "+min_num);
            Console.WriteLine("max num"+max_num);
            
            //ex36
            /*
            int num,workr;
            Console.WriteLine("enter num candidates");
            num = int.Parse(Console.ReadLine());
            int[] arr = new int[num+1];
            for (int i = 1; i < arr.Length; i++)
            {
                arr[i] = 0;
            }
            Console.WriteLine("enter workr num");
            workr = int.Parse(Console.ReadLine());
            while (workr!=-999)
            {
                for (int i = 1; i < arr.Length; i++)
                {
                    Console.WriteLine("enter your vote for candidates on/"+i);
                    arr[i]= int.Parse(Console.ReadLine());
                }
                Console.WriteLine("enter workr num");
                workr = int.Parse(Console.ReadLine());
            }
            int winner = 0,sum=0;
            for (int i = 1; i < arr.Length; i++)
            {
                sum += arr[i];
                if (arr[i]>arr[winner])
                {
                    winner = i;
                }
            }
            Console.WriteLine("the winner is :"+winner);
            sum = sum / num;
            for (int i = 1; i < arr.Length; i++)
            {
                if(sum>arr[i]) 
                     Console.WriteLine("i "+arr[i]);
            }
            */
            //ex37 p62 חלק ב
            /*
            int num=0;
            int[] avg = new int[101];
            for (int i = 0; i < avg.Length; i++)
            {
                avg[i] = 0;
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("enter num Zion");
                num = int.Parse(Console.ReadLine());
                avg[num]++;

            }
            for (int i = avg.Length; i >= 0; i--)
            {
                Console.WriteLine("i:"+avg[i]);
            }


            int count ;
            for (int i = 0; i < 10; i++)
            {
                count = 0;
                for (int j = i; j <i+10; j++)
                {
                    count += avg[j];
                }
                Console.WriteLine(i+"-"+i+10+":"+count);
            }
            */
        }
    }
}
