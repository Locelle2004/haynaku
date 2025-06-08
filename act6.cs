using System;

namespace TestTime
{
    public struct Time
    {
        private readonly int minutes;

        // Constructor from hours and minutes
        public Time(int hh, int mm)
        {
            this.minutes = 60 * hh + mm;
        }

        // Constructor from total minutes
        public Time(int totalMinutes)
        {
            this.minutes = totalMinutes;
        }

        // Read-only properties
        public int Hour => minutes / 60;
        public int Minute => minutes % 60;

        // Format as hh:mm
        public override string ToString()
        {
            return string.Format("{0:D2}:{1:D2}", Hour, Minute);
        }

        // Operator overloading
        public static Time operator +(Time t1, Time t2) => new Time(t1.minutes + t2.minutes);
        public static Time operator -(Time t1, Time t2) => new Time(t1.minutes - t2.minutes);

        // Implicit conversion from int to Time
        public static implicit operator Time(int totalMinutes)
        {
            return new Time(totalMinutes);
        }

        // Explicit conversion from Time to int
        public static explicit operator int(Time t)
        {
            return t.minutes;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Implicit conversion from int
            Time t1 = 90;           // 01:30
            Time t2 = new Time(2, 15);  // 02:15

            // Explicit conversion to int
            int mins = (int)t2;     // 135

            Console.WriteLine("Time 1 (from int): " + t1);
            Console.WriteLine("Time 2 (explicit): " + t2);
            Console.WriteLine("Minutes in Time 2: " + mins);

            // Add implicit and explicit conversions
            Time total = t1 + t2;   // Add times
            Console.WriteLine("Sum of times: " + total); // Should be 03:45

            Console.ReadKey();
        }
    }
}
