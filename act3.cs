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

        public override string ToString()
        {
            return minutes.ToString() + " minutes since midnight";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Declare Time variables
            Time morningTime = new Time(10, 5);  // 10:05 AM
            Time earlyTime = new Time(0, 45);    // 00:45 AM
            Time noonTime = new Time(12, 0);     // 12:00 PM

            // Print Time values
            Console.WriteLine("Morning time: " + morningTime);
            Console.WriteLine("Early time: " + earlyTime);
            Console.WriteLine("Noon time: " + noonTime);
        }
    }
}