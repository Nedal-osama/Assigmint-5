using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigmint_5.third_project
{
    public class Duration : IComparable, ICloneable
    {
        private int hours, minutes, seconds;

        public int Hours { get { return hours; } }
        public int Minutes { get { return minutes; } }
        public int Seconds { get { return seconds; } }

        public Duration(int hours, int minutes, int seconds)
        {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
        }

        public Duration(int totalSeconds)
        {
            hours = totalSeconds / 3600;
            minutes = (totalSeconds % 3600) / 60;
            seconds = totalSeconds % 60;
        }

        public override string ToString()
        {
            if (hours > 0)
                return $"Hours: {hours}, Minutes: {minutes}, Seconds: {seconds}";
            else
                return $"Minutes: {minutes}, Seconds: {seconds}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Duration d = (Duration)obj;
            return hours == d.hours && minutes == d.minutes && seconds == d.seconds;
        }

        public override int GetHashCode()
        {
            return hours.GetHashCode() ^ minutes.GetHashCode() ^ seconds.GetHashCode();
        }

        public static bool operator ==(Duration d1, Duration d2)
        {
            return d1.Equals(d2);
        }

        public static bool operator !=(Duration d1, Duration d2)
        {
            return !(d1 == d2);
        }

        public static bool operator >(Duration d1, Duration d2)
        {
            return d1.CompareTo(d2) > 0;
        }

        public static bool operator <(Duration d1, Duration d2)
        {
            return d1.CompareTo(d2) < 0;
        }

        public static bool operator >=(Duration d1, Duration d2)
        {
            return d1.CompareTo(d2) >= 0;
        }

        public static bool operator <=(Duration d1, Duration d2)
        {
            return d1.CompareTo(d2) <= 0;
        }

        public static Duration operator +(Duration d1, Duration d2)
        {
            return new Duration(d1.hours + d2.hours, d1.minutes + d2.minutes, d1.seconds + d2.seconds);
        }

        public static Duration operator +(Duration d, int seconds)
        {
            return new Duration(d.hours, d.minutes, d.seconds + seconds);
        }

        public static Duration operator -(Duration d1, Duration d2)
        {
            return new Duration(d1.hours - d2.hours, d1.minutes - d2.minutes, d1.seconds - d2.seconds);
        }

        public static Duration operator ++(Duration d)
        {
            return new Duration(d.hours, d.minutes + 1, d.seconds);
        }

        public static Duration operator --(Duration d)
        {
            return new Duration(d.hours, d.minutes - 1, d.seconds);
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            Duration d = obj as Duration;
            if (d == null) throw new ArgumentException("Object is not a Duration");
            if (hours < d.hours) return -1;
            if (hours > d.hours) return 1;
            if (minutes < d.minutes) return -1;
            if (minutes > d.minutes) return 1;
            if (seconds < d.seconds) return -1;
            if (seconds > d.seconds) return 1;
            return 0;
        }

        public object Clone()
        {
            return new Duration(hours, minutes, seconds);
        }

        public static implicit operator DateTime(Duration d)
        {
            return new DateTime(d.hours, d.minutes, d.seconds);
        }
    }
}
