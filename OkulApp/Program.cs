using Microsoft.EntityFrameworkCore;
using OkulApp.Data;
using OkulApp.Models;

namespace OkulApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var context=new SchoolDBContext())
            {
                //context.Database.EnsureDeleted();
                //context.Database.EnsureCreated();
                //Console.WriteLine("Veritabanı ve Tablolar Oluşturuldu...");


                var dept = new Department { DapartmentName = "Bilgisayar Mühendisliği" };
                var dept1 = new Department { DapartmentName = "Yazılım Mühendisliği" };
                var dept2 = new Department { DapartmentName = "Matematik Mühendisliği" };
                var dept3 = new Department { DapartmentName = "Fizik Mühendisliği" };
                var course = new Course { Title = "Elektronik Devre Tasarımı", Credit = 6, Department = dept };
                var course1 = new Course { Title = "Programlamaya Giriş", Credit = 4, Department = dept1 };
                var course2 = new Course { Title = "Doğal Sayılar", Credit = 3, Department = dept2 };
                var course3 = new Course { Title = "Uzay Fiziği", Credit = 5, Department = dept3 };

                //var newStudent = new Student
                //{
                //    FirstName = "Polat",
                //    LastName = "Alemdar",
                //    Age = 19,
                //    Department= dept ,
                //    Courses=new List<Course> { course,course2}
                //};
                //var newStudent1 = new Student
                //{
                //    FirstName = "Elif",
                //    LastName = "Alemdar",
                //    Age = 20,
                //    Department = dept1,
                //    Courses = new List<Course> { course3, course2 }
                //};
                //var newStudent2 = new Student
                //{
                //    FirstName = "Fatma",
                //    LastName = "Kara",
                //    Age = 21,
                //    Department = dept2,
                //    Courses = new List<Course> { course3, course }
                //};
                var newStudent3 = new Student
                {
                    FirstName = "Mehmet",
                    LastName = "ÖzTürk",
                    Age = 25,
                    Department = dept3,
                    Courses = new List<Course> { course1, course2 }
                };
                //context.Departments.AddRange(dept,dept1,dept2,dept3);
                //context.Courses.AddRange(course,course1,course2,course3);
                //context.Students.AddRange(newStudent,newStudent1,newStudent2,newStudent3);
                context.Students.Add(newStudent3);
                context.SaveChanges();
                //Console.WriteLine("Yeni Öğrenci Eklendi...");

                var departments = context.Departments
                    .Include(d => d.Courses)
                    .Include(d => d.Students)
                    .ToList();
                foreach (var d in departments)
                {
                    Console.WriteLine($"Bölüm :{d.DapartmentName}");
                    Console.WriteLine(" -> Bölüm Dersleri");
                    foreach (var c in d.Courses)
                    {
                        Console.WriteLine($"     {c.Title} {c.Credit} Kredi");
                    }
                    Console.WriteLine(" -> Bölüm Öğrencileri");
                    foreach (var s in d.Students)
                    {
                        Console.WriteLine($"     - {s.FirstName} {s.LastName}");
                    }
                }
                

            }
        }
    }
}
