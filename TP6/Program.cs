namespace TP6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayaMusicTrack track1 = new SayaMusicTrack("Lagu A"); 

            track1.IncreasePlayCount(5);
            track1.IncreasePlayCount(3);

            track1.PrintTrackDetails();
        }
    }
}
