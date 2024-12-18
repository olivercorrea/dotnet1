// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            // ... (code to add students, input grades, attendance, etc.)

            foreach (var student in students)
            {
                Console.WriteLine($"Student: {student.Name}");
                Console.WriteLine($"Course: {student.CourseCode} - {student.Semester} - {student.GroupClass}");
                Console.WriteLine($"Average Grade: {student.Grade.CalculateAverage()}");
                Console.WriteLine($"Attendance: {student.Attendance.Percentage}% - {(student.Attendance.IsApproved ? "Approved" : "Disapproved")}");
                Console.WriteLine();
            }
        }
    }

    class Student
    {
        public string Name { get; set; }
        public string CourseCode { get; set; }
        public int Semester { get; set; }
        public string GroupClass { get; set; }
        public Grade Grade { get; set; }
        public Attendance Attendance { get; set; }

        public Student(string name, string courseCode, int semester, string groupClass)
        {
            Name = name;
            CourseCode = courseCode;
            Semester = semester;
            GroupClass = groupClass;
            Grade = new Grade();
            Attendance = new Attendance();
        }
    }

    class Grade
    {
        private List<double> regularNotes = new List<double>();
        private List<double> extraNotes = new List<double>();

        public void AddRegularNote(double note) => regularNotes.Add(note);
        public void AddExtraNote(double note) => extraNotes.Add(note);

        public double CalculateAverage()
        {
            double regularAverage = regularNotes.Average();
            double extraAverage = extraNotes.OrderByDescending(n => n).Skip(1).Average();
            return regularAverage * 0.7 + extraAverage * 0.3;
        }
    }

    class Attendance
    {
        private int totalClasses = 0;
        private int attendedClasses = 0;

        public void RegisterClass() => totalClasses++;
        public void RegisterAttendance() => attendedClasses++;

        public double Percentage => (double)attendedClasses / totalClasses * 100;
        public bool IsApproved => Percentage >= 70;
    }
}

