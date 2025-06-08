using System;

namespace TestTime
{
    public struct Time
    {
        private readonly int minutes;

        public Time(int hh, int mm)
        {
            this.minutes = 60 * hh + mm;
        }

        // Read-only Hour property
        public int Hour
        {
            get { return minutes / 60; }
        }

        // Read-only Minute property
        public int Minute
        {
            get { return minutes % 60; }
        }

        // Format time as hh:mm
        public override string ToString()
        {
            return string.Format("{0:D2}:{1:D2}", Hour, Minute);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Declare Time variables
            Time morningTime = new Time(10, 5);  // 10:05
            Time earlyTime = new Time(0, 45);    // 00:45
            Time noonTime = new Time(12, 0);     // 12:00

            // Print formatted Time values
            Console.WriteLine("Morning time: " + morningTime);   // 10:05
            Console.WriteLine("Early time: " + earlyTime);       // 00:45
            Console.WriteLine("Noon time: " + noonTime);         // 12:00

            // Also show Hour and Minute properties (optional)
            Console.WriteLine("\nDetailed:");
            Console.WriteLine($"Morning - Hour: {morningTime.Hour}, Minute: {morningTime.Minute}");
            Console.WriteLine($"Early - Hour: {earlyTime.Hour}, Minute: {earlyTime.Minute}");
            Console.WriteLine($"Noon - Hour: {noonTime.Hour}, Minute: {noonTime.Minute}");
        }
    }
}
