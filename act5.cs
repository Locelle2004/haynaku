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

        public Time(int totalMinutes)
        {
            this.minutes = totalMinutes;
        }

      
        public int Hour
        {
            get { return minutes / 60; }
        }

        public int Minute
        {
            get { return minutes % 60; }
        }

      
        public override string ToString()
        {
            return string.Format("{0:D2}:{1:D2}", Hour, Minute);
        }

        // Overload + operator
        public static Time operator +(Time t1, Time t2)
        {
            return new Time(t1.minutes + t2.minutes);
        }

        // Overload - operator
        public static Time operator -(Time t1, Time t2)
        {
            return new Time(t1.minutes - t2.minutes);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Time t1 = new Time(1, 30);   // 01:30
            Time t2 = new Time(2, 45);   // 02:45

            Time sum = t1 + t2;          // 04:15
            Time diff = t2 - t1;         // 01:15

            Console.WriteLine("Time 1: " + t1);
            Console.WriteLine("Time 2: " + t2);
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Difference: " + diff);

            Console.ReadKey();
        }
    }
}
