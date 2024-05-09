using System;
using System.Collections.Generic;

namespace Lab9_10CharpT 
{
    public class Student
    {
        public string FirstName { get; }
        public string LastName { get; }
        public int Age { get; }
        public List<Course> Courses { get; }

        public Student(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Courses = new List<Course>();
        }

        public void AddCourse(Course course)
        {
            Courses.Add(course);
            // Підписка на подію зміни часу курсу
            course.TimeChanged += Course_TimeChanged;
        }

        public void DisplaySchedule()
        {
            foreach (var course in Courses)
            {
                Console.WriteLine(course);
            }
        }

        private void Course_TimeChanged(object sender, TimeChangedEventArgs e)
        {
            // Оновлення розкладу після зміни часу курсу
            Console.WriteLine($"Course time changed to {e.NewTime}.");
            Console.WriteLine("\nUpdated schedule:");
            DisplaySchedule();
        }

        public override string ToString()
        {
            return $"Name: {FirstName} {LastName}, Age: {Age}";
        }
    }
}