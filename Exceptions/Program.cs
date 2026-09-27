using ClassLibrary1;
using Exceptions;
using System.Globalization;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

var personel = new Person("Abuzer", 45421.25);
var personel2 = new Servant("Abuzer", 45421.25);
Console.WriteLine(personel);
Console.WriteLine($"{personel.maasHesapla2():c2}");
Console.WriteLine($"{personel2.maasHesapla2():c2}");




Console.WriteLine("Bölen giriniz");
    int.TryParse(Console.ReadLine(),out int a);
//.dll .exe Assembly .nupkg
try
{
    int deger=int.Parse(Console.ReadLine());
    BankaHesabi bh = new BankaHesabi();
    bh.ParaCek(1000);
    bh.ParaCek(1000);
    bh.ParaCek(1000);
    bh.ParaCek(10000);

 
    Console.WriteLine(1);
    int resut = 5 / a;
    Console.WriteLine(2);
    int[] numbers = { 1, 2, 3 };
    numbers[2] = 78;

    Console.WriteLine(KareKokHesapla(8));
}
catch (DivideByZeroException de)
{
    Console.WriteLine(de.Message);

}
catch (FormatException fe)
{
    Console.WriteLine(fe.Message+" "+fe.GetType().Name);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
finally
{
    Console.WriteLine(6);
}
Console.WriteLine(7);


double KareKokHesapla(double sayi)
{
    if (sayi < 0)
    {
        throw new ArgumentException("Negatif sayıların karekökü en azından bu gezegende hesaplanmaz...");
    }
    return Math.Sqrt(sayi);
}