using System;
using System.Collections.Generic;
using System.Text;

namespace מחלקת_עצם
{
    class Song
    {
        private string name_song;
        private string name_singer;
        private double length_song;
        private int rating;


        public Song(string name_song, string name_singer, double length_song, int rating)
        {
            this.name_song = name_song;
            this.name_singer=name_singer;
            this.length_song= length_song;
            this.rating = rating;
        }


        public string GetName_song()
        {
            return this.name_song;
        }
        public string GetName_singer()
        {
            return this.name_singer;
        }
        public double GetLength_song()
        {
            return this.length_song;
        }
        public int GetRating()
        {
            return this.rating;
        }



        public void SetName_song(string name_songrToSet)
        {
            this.name_song = name_songrToSet;
        }
        public void SetName_singer(string name_singerToSet)
        {
            this.name_singer = name_singerToSet;
        }


        public void SetLength_song(double length_songToSet)
        {
            this.length_song = length_songToSet;
        }
        public void SetRating(int ratingToSet)
        {
            this.rating = ratingToSet;
        }

        public override string ToString()
        {
            return this.name_song + ", " + this.name_singer + ", " + this.length_song+", "+this.rating;
        }
    }
}
