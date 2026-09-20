using System.Collections;

Queue<string> names = new Queue<string>();
names.Enqueue("Murat");
names.Enqueue("Mehmet");
names.Enqueue("Şukufe");
names.Enqueue("Musa");
names.Enqueue("Kezban");
names.Enqueue("Ayşe");
names.Enqueue("Ali");
Console.WriteLine(names.Count);
Console.WriteLine(names.Dequeue());
Console.WriteLine(names.Peek());
Console.WriteLine(names.Count);

while (names.Count>0)
{
   Console.WriteLine(names.Dequeue());
}

//Stack<string> names = new Stack<string>();

//names.Push("Murtaza");
//names.Push("Mehmet");
//names.Push("Şukufe");
//names.Push("Musa");
//names.Push("Kezban");
//names.Push("Ayşe");
//names.Push("Ali");
//foreach (string item in names)
//{
//    Console.WriteLine(names.Count);
//    Console.WriteLine(item);
//}

//while (names.Count>0)
//{
//    Console.WriteLine(names.Pop());
//}
