Func<int, string> numberControl = y => (y % 2 == 0) ? "Çift" : "Tek";
Action start = () =>
{
    Console.WriteLine("Bir sayı girniz");
    int.TryParse(Console.ReadLine(), out int number );
    Console.WriteLine($"{number} sayısı bir {numberControl(number)} sayıdır...");
};
start();


//Func<int> gecerliSayiAl = () =>
//{
//    int sayi;
//    Console.WriteLine("Bir Sayı Giriniz...");
//    while (!int.TryParse(Console.ReadLine(), out sayi))
//    {
//        Console.ForegroundColor = ConsoleColor.Red;
//        Console.WriteLine("Hatalı Sayı Girişi Yaptınız Tekrar Deneyiniz!");
//        Console.ResetColor();
//        Console.WriteLine("Tekrar Deneyiniz");
//    }
//    return sayi;

//};


//Func<int, string> tekMiCiftMi = n => (n % 2 == 0) ? "Çift" : "Tek";
//int inputNumber = gecerliSayiAl();
//Console.WriteLine($"{inputNumber} sayısı bir {tekMiCiftMi(inputNumber)} sayıdır...");


//Func<int, int> kareal2 = x => x * x;
//Action<string> mesajYaz = mesaj => Console.WriteLine(mesaj);
//Predicate<string> karakterControl = y => y.Length >= 10;
//Predicate<int> tekCiftControl = z => z % 2 == 0;

//Console.WriteLine(karakterControl("Hello Bro"));
//Console.WriteLine(karakterControl("Hello Bro Nasılsın Hava nasıl???"));
//Console.WriteLine(tekCiftControl(77));
//mesajYaz("26 Eylül 2026 Cumartesi, Hava Çok soğuk");

//Console.WriteLine(kareal2(972));

//Console.WriteLine(kareAl(972));

//int kareAl(int sayi)
//{
//    return sayi * sayi;
//}
