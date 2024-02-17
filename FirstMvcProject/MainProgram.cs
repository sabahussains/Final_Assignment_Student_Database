using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FirstMvcProject.Models;

namespace FirstMvcProject
{
    class Program
    {
        static void Main()
        {
            using (var context = new SchoolContext())
            {
                // Ensure the database is created
                context.Database.EnsureCreated();

                // Add a new student
                var newStudent = new Student { FirstName = "John", LastName = "Doe" };
                context.Students.Add(newStudent);
                context.SaveChanges();

                Console.WriteLine("Student added successfully!");

                // Display all students
                Console.WriteLine("All Students:");
                foreach (var student in context.Students)
                {
                    Console.WriteLine($"{student.StudentId}: {student.FirstName} {student.LastName}");
                }
            }
        }
    }

}