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
        }

        public void DisplaySchedule()
        {
            foreach (var course in Courses)
            {
                Console.WriteLine(course);
            }
        }

        public override string ToString()
        {
            return $"Name: {FirstName} {LastName}, Age: {Age}";
        }
    }
}