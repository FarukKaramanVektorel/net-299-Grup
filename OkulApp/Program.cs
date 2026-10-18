using Microsoft.EntityFrameworkCore;
using OkulApp.Data;
using OkulApp.Models;

namespace OkulApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolDBContext())
            {
                context.Database.EnsureCreated();
                var yas21VeUzeri = context.Students.Where(s => s.Age >= 21).ToList();
                int siraNo = 1;
                foreach (var s in yas21VeUzeri)
                {
                    Console.WriteLine($"{siraNo++} - Öğrenci Adı: {s.FirstName} {s.LastName} Yaş: {s.Age}");
                    
                }
                Console.WriteLine("Toplam : " + yas21VeUzeri.Count);
            }
            //context.Database.EnsureDeleted();
            
            //Console.WriteLine("Veritabanı ve Tablolar Oluşturuldu...");


            //                var dept = new Department { DapartmentName = "Bilgisayar Mühendisliği" };
            //                var dept1 = new Department { DapartmentName = "Yazılım Mühendisliği" };
            //                var dept2 = new Department { DapartmentName = "Matematik Mühendisliği" };
            //                var dept3 = new Department { DapartmentName = "Fizik Mühendisliği" };
            //                var courses = new List<Course>
            //{
            //    new Course { Title = "Elektronik Devre Tasarımı", Credit = 6, Department = dept },
            //    new Course { Title = "Programlamaya Giriş", Credit = 4, Department = dept1 },
            //    new Course { Title = "Doğal Sayılar", Credit = 3, Department = dept2 },
            //    new Course { Title = "Uzay Fiziği", Credit = 5, Department = dept3 },

            //    new Course { Title = "Veri Yapıları", Credit = 5, Department = dept },
            //    new Course { Title = "Nesne Tabanlı Programlama", Credit = 4, Department = dept1 },
            //    new Course { Title = "Lineer Cebir", Credit = 4, Department = dept2 },
            //    new Course { Title = "Kuantum Fiziği", Credit = 6, Department = dept3 },

            //    new Course { Title = "Veritabanı Yönetimi", Credit = 4, Department = dept },
            //    new Course { Title = "Algoritma Analizi", Credit = 5, Department = dept1 }
            //};

            //                // 40 öğrenci: her bölümde 10 öğrenci
            //                var students = new List<Student>
            //{
            //    // Bilgisayar Mühendisliği - 10 öğrenci
            //    new Student { FirstName = "Polat", LastName = "Alemdar", Age = 19, Department = dept,
            //        Courses = new List<Course> { courses[0], courses[2] } },

            //    new Student { FirstName = "Ali", LastName = "Yılmaz", Age = 20, Department = dept,
            //        Courses = new List<Course> { courses[1], courses[4] } },

            //    new Student { FirstName = "Ayşe", LastName = "Demir", Age = 21, Department = dept,
            //        Courses = new List<Course> { courses[4], courses[6] } },

            //    new Student { FirstName = "Mehmet", LastName = "Kaya", Age = 22, Department = dept,
            //        Courses = new List<Course> { courses[0], courses[8] } },

            //    new Student { FirstName = "Zeynep", LastName = "Çelik", Age = 19, Department = dept,
            //        Courses = new List<Course> { courses[1], courses[7] } },

            //    new Student { FirstName = "Emre", LastName = "Şahin", Age = 23, Department = dept,
            //        Courses = new List<Course> { courses[4], courses[9] } },

            //    new Student { FirstName = "Elif", LastName = "Arslan", Age = 20, Department = dept,
            //        Courses = new List<Course> { courses[2], courses[8] } },

            //    new Student { FirstName = "Burak", LastName = "Aydın", Age = 24, Department = dept,
            //        Courses = new List<Course> { courses[0], courses[5] } },

            //    new Student { FirstName = "Merve", LastName = "Öztürk", Age = 21, Department = dept,
            //        Courses = new List<Course> { courses[4], courses[7] } },

            //    new Student { FirstName = "Can", LastName = "Koç", Age = 22, Department = dept,
            //        Courses = new List<Course> { courses[8], courses[9] } },

            //    // Yazılım Mühendisliği - 10 öğrenci
            //    new Student { FirstName = "Elif", LastName = "Alemdar", Age = 20, Department = dept1,
            //        Courses = new List<Course> { courses[1], courses[3] } },

            //    new Student { FirstName = "Ahmet", LastName = "Kurt", Age = 21, Department = dept1,
            //        Courses = new List<Course> { courses[5], courses[9] } },

            //    new Student { FirstName = "Fatma", LastName = "Kara", Age = 22, Department = dept1,
            //        Courses = new List<Course> { courses[0], courses[5] } },

            //    new Student { FirstName = "Mustafa", LastName = "Polat", Age = 23, Department = dept1,
            //        Courses = new List<Course> { courses[1], courses[8] } },

            //    new Student { FirstName = "Deniz", LastName = "Aksoy", Age = 19, Department = dept1,
            //        Courses = new List<Course> { courses[5], courses[6] } },

            //    new Student { FirstName = "Ece", LastName = "Yıldız", Age = 20, Department = dept1,
            //        Courses = new List<Course> { courses[2], courses[9] } },

            //    new Student { FirstName = "Kerem", LastName = "Bulut", Age = 24, Department = dept1,
            //        Courses = new List<Course> { courses[1], courses[7] } },

            //    new Student { FirstName = "Selin", LastName = "Doğan", Age = 21, Department = dept1,
            //        Courses = new List<Course> { courses[4], courses[5] } },

            //    new Student { FirstName = "Onur", LastName = "Kaplan", Age = 22, Department = dept1,
            //        Courses = new List<Course> { courses[3], courses[9] } },

            //    new Student { FirstName = "Derya", LastName = "Aslan", Age = 23, Department = dept1,
            //        Courses = new List<Course> { courses[5], courses[8] } },

            //    // Matematik Mühendisliği - 10 öğrenci
            //    new Student { FirstName = "Mehmet", LastName = "ÖzTürk", Age = 25, Department = dept2,
            //        Courses = new List<Course> { courses[1], courses[2] } },

            //    new Student { FirstName = "Buse", LastName = "Güneş", Age = 20, Department = dept2,
            //        Courses = new List<Course> { courses[2], courses[6] } },

            //    new Student { FirstName = "Cem", LastName = "Erdem", Age = 21, Department = dept2,
            //        Courses = new List<Course> { courses[3], courses[6] } },

            //    new Student { FirstName = "Seda", LastName = "Özkan", Age = 22, Department = dept2,
            //        Courses = new List<Course> { courses[0], courses[6] } },

            //    new Student { FirstName = "Murat", LastName = "Taş", Age = 23, Department = dept2,
            //        Courses = new List<Course> { courses[2], courses[8] } },

            //    new Student { FirstName = "İrem", LastName = "Polat", Age = 19, Department = dept2,
            //        Courses = new List<Course> { courses[6], courses[9] } },

            //    new Student { FirstName = "Tolga", LastName = "Kılıç", Age = 24, Department = dept2,
            //        Courses = new List<Course> { courses[1], courses[6] } },

            //    new Student { FirstName = "Yağmur", LastName = "Yalçın", Age = 20, Department = dept2,
            //        Courses = new List<Course> { courses[2], courses[7] } },

            //    new Student { FirstName = "Okan", LastName = "Tekin", Age = 22, Department = dept2,
            //        Courses = new List<Course> { courses[4], courses[6] } },

            //    new Student { FirstName = "Gizem", LastName = "Acar", Age = 21, Department = dept2,
            //        Courses = new List<Course> { courses[2], courses[5] } },

            //    // Fizik Mühendisliği - 10 öğrenci
            //    new Student { FirstName = "Eren", LastName = "Şimşek", Age = 22, Department = dept3,
            //        Courses = new List<Course> { courses[3], courses[7] } },

            //    new Student { FirstName = "Aslı", LastName = "Erdoğan", Age = 20, Department = dept3,
            //        Courses = new List<Course> { courses[0], courses[7] } },

            //    new Student { FirstName = "Kaan", LastName = "Özdemir", Age = 23, Department = dept3,
            //        Courses = new List<Course> { courses[3], courses[8] } },

            //    new Student { FirstName = "Cansu", LastName = "Korkmaz", Age = 21, Department = dept3,
            //        Courses = new List<Course> { courses[2], courses[7] } },

            //    new Student { FirstName = "Serkan", LastName = "Avcı", Age = 24, Department = dept3,
            //        Courses = new List<Course> { courses[3], courses[5] } },

            //    new Student { FirstName = "Naz", LastName = "Bulut", Age = 19, Department = dept3,
            //        Courses = new List<Course> { courses[6], courses[7] } },

            //    new Student { FirstName = "Umut", LastName = "Yavuz", Age = 22, Department = dept3,
            //        Courses = new List<Course> { courses[3], courses[9] } },

            //    new Student { FirstName = "Pelin", LastName = "Akın", Age = 20, Department = dept3,
            //        Courses = new List<Course> { courses[0], courses[3] } },

            //    new Student { FirstName = "Berk", LastName = "Çetin", Age = 25, Department = dept3,
            //        Courses = new List<Course> { courses[4], courses[7] } },

            //    new Student { FirstName = "Eylül", LastName = "Karaca", Age = 21, Department = dept3,
            //        Courses = new List<Course> { courses[3], courses[6] } }
            //};

            //                // Verileri veritabanına ekle
            //                context.Departments.AddRange(dept, dept1, dept2, dept3);
            //                context.Courses.AddRange(courses);
            //                context.Students.AddRange(students);

            //                context.SaveChanges();

            //                Console.WriteLine("4 bölüm, 10 ders ve 40 öğrenci başarıyla eklendi.");

            //    var departments = context.Departments
            //        .Include(d => d.Courses)
            //        .Include(d => d.Students)
            //        .ToList();
            //    foreach (var d in departments)
            //    {
            //        Console.WriteLine($"Bölüm :{d.DapartmentName}");
            //        Console.WriteLine(" -> Bölüm Dersleri");
            //        foreach (var c in d.Courses)
            //        {
            //            Console.WriteLine($"     {c.Title} {c.Credit} Kredi");
            //        }
            //        Console.WriteLine(" -> Bölüm Öğrencileri");
            //        foreach (var s in d.Students)
            //        {
            //            Console.WriteLine($"     - {s.FirstName} {s.LastName}");
            //        }
            //    }


        }
    }
}

