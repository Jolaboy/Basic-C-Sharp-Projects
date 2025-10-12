using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace StudentApp
{
    // 1. The Model Class (Defines the database table structure)
    // The properties here will become the columns in the database table.
    public class Student
    {
        // By convention, 'StudentId' will automatically be set as the Primary Key (PK).
        public int StudentId { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }

    // 2. The Context Class (Manages the database connection and interaction)
    // This class inherits from DbContext and is the bridge between your code and the database.
    public class SchoolContext : DbContext
    {
        // DbSet<Student> represents the table of students in the database.
        public DbSet<Student> Students { get; set; }

        // This method tells Entity Framework Core which database provider to use (SQLite for simplicity)
        // and where to find the database file.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Use SQLite. It will create a file named 'SchoolDatabase.db'
            // in the application's bin/Debug folder the first time it runs.
            optionsBuilder.UseSqlite("Data Source=SchoolDatabase.db");
        }
    }

    // 3. The Main Program Logic
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Entity Framework Code-First Student App ---");
            Console.WriteLine("Starting database setup and data insertion...");

            // The 'using' statement ensures that the database connection object (db) is
            // properly closed and released when the block finishes.
            using (var db = new SchoolContext())
            {
                // This method checks if the database exists based on the context's configuration.
                // If it doesn't exist, it creates the database and the Students table.
                db.Database.EnsureCreated();
                Console.WriteLine("Database and tables are ready. (A file named 'SchoolDatabase.db' was created or found)");

                // Check if the student "Alex Martinez" already exists in the table.
                var existingStudent = db.Students.FirstOrDefault(s => s.FirstName == "Amadou" && s.LastName == "Jarju");

                if (existingStudent == null)
                {
                    // Create an instance of the Student model
                    var newStudent = new Student
                    {
                        FirstName = "Amadou",
                        LastName = "Jarju",
                        DateOfBirth = new DateTime(2000, 5, 15)
                    };

                    // Add the new student object to the Students table set
                    db.Students.Add(newStudent);

                    // Commit the change to the database. This executes the SQL INSERT command.
                    db.SaveChanges();
                    Console.WriteLine("\nSUCCESS: Added one new student record to the database!");
                    Console.WriteLine($"Student Added: {newStudent.FirstName} {newStudent.LastName}");
                }
                else
                {
                    Console.WriteLine("\nStudent 'Amadou Jarju' already exists in the database. Skipping insertion.");
                }

                // --- Verify Data: Retrieve and display all students ---
                Console.WriteLine("\n--- All Student Records Found ---");
                var allStudents = db.Students.ToList();
                foreach (var student in allStudents)
                {
                    Console.WriteLine($"ID: {student.StudentId}, Name: {student.FirstName} {student.LastName}, DOB: {student.DateOfBirth.ToShortDateString()}");
                }
            }

            Console.WriteLine("\nPress any key to exit.");
            Console.Read();
        }
    }
}
