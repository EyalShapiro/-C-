
using System;

namespace p76_ex48
{
    class Program
    {
        public static bool Sms_message(SMS[] sms,string moral,string recipient)
        {
            SMS new1 =new SMS (moral,recipient,"");
            for (int i = 0; i < sms.Length; i++)
            {
                if (sms[i].CompareTo(new1))
                { 
                    for (int j = i; j < sms.Length; j++)
                    {
                        if (sms[i].CompareTo(sms[j]) == true && i != j)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;


        }

        static void Main(string[] args)
        {
            SMS s1 = new SMS("054-788", "67", "Hello");
            SMS s2 = new SMS("678", "054-788", "Hello");
            SMS s3 = new SMS("67", "054-788", "Hellop");
            Console.WriteLine("ex2"+s1.CompareTo(s3));
            SMS[] sms = {s1, s2,s3};
            Console.WriteLine("ex3"+ Sms_message(sms, "054-788", "67"));
        }
    }
}
