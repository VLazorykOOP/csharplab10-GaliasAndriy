namespace Lab9_10CharpT
{
    public class Course
    {
        public string Name { get; }
        public string Professor { get; }
        public DayOfWeek Day { get; }
        private TimeSpan time;

        // Оголошення події для зміни часу курсу
        public event EventHandler<TimeChangedEventArgs> TimeChanged;

        public TimeSpan Time
        {
            get { return time; }
            set
            {
                if (value.Hours < 8 || value.Hours > 18) 
                    throw new ArgumentOutOfRangeException(nameof(Time), "Time should be between 8:00 AM and 6:00 PM.");
                
                // Перевірка, чи час дійсно змінився перед встановленням нового значення
                if (value != time)
                {
                    time = value;
                    // Виклик події при зміні часу
                    OnTimeChanged(new TimeChangedEventArgs(value));
                }
            }
        }

        public Course(string name, string professor, DayOfWeek day, TimeSpan time)
        {
            Name = name;
            Professor = professor;
            Day = day;
            Time = time;
        }

        // Метод для виклику події
        protected virtual void OnTimeChanged(TimeChangedEventArgs e)
        {
            TimeChanged?.Invoke(this, e);
        }

        public override string ToString()
        {
            return $"Course: {Name}, Professor: {Professor}, Day: {Day}, Time: {Time}";
        }
    }

    // Клас для передачі додаткової інформації про подію зміни часу
    public class TimeChangedEventArgs : EventArgs
    {
        public TimeSpan NewTime { get; }

        public TimeChangedEventArgs(TimeSpan newTime)
        {
            NewTime = newTime;
        }
    }
}