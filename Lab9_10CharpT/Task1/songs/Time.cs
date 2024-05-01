using System;
using System.Collections;

namespace Lab9_10CharpT 
{
    class Time
    {
        public int Minutes { get; }
        public int Seconds { get; }

        public Time(int minutes, int seconds)
        {
            Minutes = minutes;
            Seconds = seconds;
        }

        public override string ToString()
        {
            return $"{Minutes}:{Seconds} min";
        }
    }
}