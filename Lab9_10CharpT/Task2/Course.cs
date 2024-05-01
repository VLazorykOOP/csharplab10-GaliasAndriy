namespace Lab9_10CharpT
{
    public class Course
    {
        public string Name { get; }
        public string Professor { get; }
        public DayOfWeek Day { get; }
        private TimeSpan time;

        public TimeSpan Time
        {
            get { return time; }
            set
            {
                if (value.Hours < 8 || value.Hours > 18) 
                    throw new ArgumentOutOfRangeException(nameof(Time), "Time should be between 8:00 AM and 6:00 PM.");
                time = value;
            }
        }

        public Course(string name, string professor, DayOfWeek day, TimeSpan time)
        {
            Name = name;
            Professor = professor;
            Day = day;
            Time = time;
        }

        public void ChangeTime(TimeSpan newTime)
        {
            Time = newTime;
        }

        public override string ToString()
        {
            return $"Course: {Name}, Professor: {Professor}, Day: {Day}, Time: {Time}";
        }
    }
}