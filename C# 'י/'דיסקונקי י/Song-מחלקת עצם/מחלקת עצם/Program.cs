using System;

namespace מחלקת_עצם
{
    class Program
    {
        public static void Nine(Song[] songs)
        {
            //הפונקציה מקבלת מערך של עצם ומדפס את שמות הזמרים שהשירים שלהם קיבלו דירוג גבוה או שווה ל 9
            for (int i = 0; i < songs.Length; i++)
            {
                if (9 <= songs[i].GetRating())
                {
                    Console.WriteLine("name singer rating 9+ " + songs[i].GetName_singer());
                }
            }
        }

        public static void Avg(Song[]son)
        {
            //הפונקציה מקבלת מערך של עצם ומדפס את ממוצע אורכי השירים ואת שמות השירים שמשך השיר שלהם גדול מהממוצע
            double avg = 0;
            for (int i = 0; i < son.Length; i++)
            {
                avg+=son[i].GetLength_song();
            }
            avg = avg / son.Length;
            Console.WriteLine("average :"+avg);
            for (int i = 0; i < son.Length; i++)
            {
                if (avg < son[i].GetRating())
                {
                    Console.WriteLine("name singer rating :" + son[i].GetName_singer());
                }
            }
        }
        static void Main(string[] args)
        {
            
            //בדיקה
            /*
            Console.WriteLine("enetr name song,  enetr name singer, enetr length song, enetr rating song");
            Song s = new Song(Console.ReadLine(), Console.ReadLine(),double.Parse(Console.ReadLine()),int.Parse(Console.ReadLine()));
            s.SetRating(8);
            Console.WriteLine(s);
            */
            //שאלה בכיתה 
            Song[] songs = new Song[3];
            for (int i = 0; i < songs.Length; i++)
            {
                Console.WriteLine("enetr name song,  enetr name singer, enetr length song, enetr rating song");
                songs[i]= new Song(Console.ReadLine(), Console.ReadLine(), double.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            }
            Nine(songs);
            Avg(songs);



        }
    }
}
