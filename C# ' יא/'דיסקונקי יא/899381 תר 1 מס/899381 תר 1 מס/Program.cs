using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _899381_תר_1_מס
{
    class Program
    {
        public static int Exact(string[] arr ,int num)
        {
            //  ומספר שלם — num, המקבלת מערך — arr מטיפוס מחרוזת, 
            //num שאורכן שווה i הפעולה תחזיר את מספר המחרוזות במערך arr
            int count=0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i].Length.Equals(num))
                {
                    count++;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            string [] num = {"dssa","s","dd","aa"};
            Console.WriteLine(Exact(num,2));
        }
    }
}
