using System;

namespace TP6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SayaMusicTrack track1 = new SayaMusicTrack("Lagu Favorit");
                track1.IncreasePlayCount(5000);
                track1.PrintTrackDetails();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error track1: " + ex.Message);
            }

            try
            {
                SayaMusicTrack track2 = new SayaMusicTrack(null);
                track2.PrintTrackDetails();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error track2: " + ex.Message);
            }

            try
            {
                SayaMusicTrack track3 = new SayaMusicTrack(new string('A', 101));
                track3.PrintTrackDetails();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error track3: " + ex.Message);
            }

            try
            {
                SayaMusicTrack track4 = new SayaMusicTrack("Overflow Test");

                for (int i = 0; i < 300; i++)
                {
                    track4.IncreasePlayCount(10000000);
                }

                track4.PrintTrackDetails();
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Overflow terjadi: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error track4: " + ex.Message);
            }

            try
            {
                SayaMusicTrack track5 = new SayaMusicTrack("Test Max Input");
                track5.IncreasePlayCount(10000001);
                track5.PrintTrackDetails();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error track5: " + ex.Message);
            }
        }
    }
}