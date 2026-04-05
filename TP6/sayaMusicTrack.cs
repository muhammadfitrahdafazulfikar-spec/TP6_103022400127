using System;
using System.Diagnostics;

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
            Debug.Assert(title != null, "Judul tidak boleh null.");
            Debug.Assert(title.Length <= 100, "Judul maksimal 100 karakter.");

            if (title == null)
                throw new ArgumentNullException(nameof(title), "Judul tidak boleh null.");

            if (title.Length > 100)
                throw new ArgumentException("Judul maksimal 100 karakter.");

            this.title = title;
            this.playCount = 0;

            Random rand = new Random();
            this.id = rand.Next(1, 6);
        }

        // method tambah play count
        public void IncreasePlayCount(int count)
        {
            Debug.Assert(count <= 10000000, "Input play count maksimal 10.000.000.");
            Debug.Assert(count >= 0, "Input play count tidak boleh negatif.");

            if (count < 0)
                throw new ArgumentException("Input play count tidak boleh negatif.");

            if (count > 10000000)
                throw new ArgumentException("Input play count maksimal 10.000.000.");

            checked
            {
                playCount += count;
            }
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