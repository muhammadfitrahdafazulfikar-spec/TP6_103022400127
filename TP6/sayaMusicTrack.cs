using System;

namespace TP6
{
    internal class SayaMusicTrack
    {
        private int id;
        private int playCount;
        private string title;

        // constructor
        public SayaMusicTrack(string title)
        {
            this.title = title;
            Random rand = new Random();
            this.id = rand.Next(1, 6);
            this.playCount = 0;
        }

        // method tambah play count
        public void IncreasePlayCount(int count)
        {
            this.playCount += count;
        }

        // method print
        public void PrintTrackDetails()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Play Count: " + playCount);
        }
    }
}