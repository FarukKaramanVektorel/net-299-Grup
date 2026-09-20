




using System.IO.Pipes;

HashSet<string> names=new HashSet<string>();
HashSet<string> names2 = new HashSet<string>();
names.Add("Ali Keser");
names.Add("Ali Keskin");
names.Add("Aliye Keser");
names2.Add("Aliye Keser");
names2.Add("elif eylül");
names2.Add("Mustafa Keser");
names2.Add("Zeynep Keser");

Console.WriteLine(names.ElementAt(2));

//names.UnionWith(names2);
//names.IntersectWith(names2);
names.ExceptWith(names2);

Console.WriteLine(names.Count+" "+names2.Count);

HashSet<int> kume1=new HashSet<int>();
HashSet<int> kume2 = new HashSet<int>();
kume1.Add(5);
kume1.Add(7);
kume1.Add(9);
kume2.Add(9);
kume2.Add(1);
kume2.Add(2);

foreach (int item in kume1)
{
    Console.WriteLine(item);
}

Console.WriteLine(string.Join(", ",kume1));

Console.WriteLine("Küme1: " +kume1.Count);
Console.WriteLine("Küme2: " + kume2.Count);
//kume1.UnionWith(kume2);
//kume1.IntersectWith(kume2);
kume1.ExceptWith(kume2);
Console.WriteLine("Küme1: " + kume1.Count);