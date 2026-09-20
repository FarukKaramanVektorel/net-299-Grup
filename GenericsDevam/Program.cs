using System.Numerics;
Console.WriteLine(Kareal(5));
Console.WriteLine(Kareal(5.48));
Console.WriteLine(Kareal(5.7896D));


T Kareal<T>(T value) where T : INumber<T>
{
    return value * value;
}
