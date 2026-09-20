using Collections2;

Fruit meyve1 = new Fruit("001", "Portakal", 59.99, 50);
Fruit meyve2 = new Fruit("002", "Elma", 49.99, 20);
Fruit meyve3 = new Fruit("003", "Kiraz", 99.99, 40);
Fruit meyve4 = new Fruit("004", "Kavun", 79.99, 150);
Fruit meyve5 = new Fruit("005", "Şeftali", 89.99, 60);


Dictionary<string, Fruit> fruits = new Dictionary<string, Fruit>();
fruits.Add(meyve1.Code, meyve1);
fruits.Add(meyve2.Code, meyve2);
fruits.Add(meyve3.Code, meyve3);
fruits.Add(meyve4.Code, meyve4);
fruits.Add(meyve5.Code, meyve5);
Console.WriteLine("Merhaba Ürünlerimiz Listeleniyor...");
double total = 0;
foreach (Fruit fruit in fruits.Values)
{
    Console.WriteLine($"{fruit.Name} meyvesi KG fiyatı: {fruit.Price}, Stokta {fruit.Stock} KG var. Nekadar almak istiyorsunuz?");
    int.TryParse(Console.ReadLine(), out int miktar);
    if (miktar > 0)
    {
        double temp = fruit.buyFruit(miktar);
        Console.WriteLine($"{miktar} {fruit.Name} meyvesinin tutarı: {temp:f2} TL");
        total += temp;
    }
    else
    {
        Console.WriteLine($"{fruit.Name} meyvesini almak istemediniz");
    }
}
Console.WriteLine($"Toplam ödenecek miktar: {total:f2} TL dir...");















// Tkey,Tvalue -> key tek olmak zorunda
Dictionary<int, string> isimler = new Dictionary<int, string>();
isimler.Add(15, "Ali");
isimler.Add(2, "Aliye");
isimler.Add(32, "zeynep");
isimler.Add(47, "ahmet");
isimler.Add(59, "musa");
isimler.Add(67, "hasan");
isimler.Add(73, "hüseyin");
isimler[88] = "murtaza";
Console.WriteLine(isimler.ContainsKey(32));
Console.WriteLine(isimler.ContainsValue("Musa"));
isimler.TryGetValue(88, out string name);
Console.WriteLine(isimler[32]);
Console.WriteLine(name);
isimler.Remove(32);
Console.WriteLine(isimler.ContainsKey(32));

foreach (KeyValuePair<int, string> item in isimler)
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}

foreach (int key in isimler.Keys)
{
    Console.WriteLine($"{key}- {isimler[key]}");
}
foreach (string value in isimler.Values)
{
    Console.WriteLine($"{value}");
}
