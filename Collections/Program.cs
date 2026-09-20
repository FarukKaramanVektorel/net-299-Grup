using Collections;
using System.Net;


Student s1 = new Student("Abdullah Keskin", "OGR001");
Student s2 = new Student("Merve Keskin", "OGR002");
Student s3 = new Student("Fatih Keser", "OGR003");
Student s4 = new Student("Abdullah Demir", "OGR004");
Student s5 = new Student("Elif Deniz", "OGR005");

List<Student> students = new List<Student>();
students.Add(s1);
students.Add(s2);
students.Add(s3);
students.Add(s4);
students.Add(s5);
listele(students);

// Boyut Yönetimi
// Tip güvenliği
// Gelişmiş Metod desteği
// Esnek Algorita Yapısı

// List
// Dictionaty
// Queue
// Stack

List<string> list = new List<string>();
List<string> list2 = new List<string>();
// add metodu ile eleman eklenir
list2.Add("Elma");
list2.Add("Kiraz");
list2.Add("Karpuz");
list2.Add("Kavun");
list2.Add("Karpuz");

list.Add("Elma");
list.Add("Kiraz");
list.Add("Karpuz");
list.Add("Kavun");
list.Add("Karpuz");
listele(list);

// indexof elemanın indexini döner -- iki tane varsa ilk bulduğunu döner
Console.WriteLine(list.IndexOf("Karpuz"));

// addrange birden fazla listi birleştirir

list.AddRange(list2);



listele(list);
Console.WriteLine(list[1]);
// remove metodu ile silinir
list.Remove("Karpuz");
listele(list);

// removeat içerisine verilen indexli elemanı siler
list.RemoveAt(2);

Console.WriteLine(list[1]);
// insert metodu ile istenilen indexe eleman atanır
list.Insert(0, "Portakal");
listele(list);
// contais listin içerisnde araan varmıyı true veya false döner
Console.WriteLine(list.Contains("Elma"));

// sort sıralama işlemi yapar a->z ye
list.Sort();
listele(list);
// reverse tersten sıralar 
list.Reverse();
listele(list);
// clear listeyi temizler
list.Clear();
Console.WriteLine(list.Count);

void listele<T>(List<T> list){
    // count ile eleman sayısını verir
    for (int i = 0; i < list.Count; i++)
    {
        Console.WriteLine($"{i}. index= {list[i]}");
        Thread.Sleep(100);
    }   
}






