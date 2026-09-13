using System;
using BenchmarkDotNet.Attributes;
using Abstraction;
using Microsoft.VSDiagnostics;

namespace AbstractionBenchmarks
{
    [CPUUsageDiagnoser]
    public class AbstractionBenchmarks
    {
        private string[] birimler;
        [GlobalSetup]
        public void Setup()
        {
            birimler = new string[]
            {
                "Pazarlama",
                "Üretim",
                "Muhasebe"
            };
        }

        [Benchmark]
        public void CreateManyPeople()
        {
            for (int i = 0; i < 10000; i++)
            {
                var y = new Yonetici("Abdullah", "Keskin", new DateTime(1985, 5, 3), "Yönetici", 5, birimler);
                var up = new UretimPersoneli("Elif", "Eylül", new DateTime(1995, 4, 28), "Son Ütücü", 2850);
                var pp = new PazarlamaPersoneli(595000, "Erhan", "Ufak", new DateTime(1998, 9, 30), "Pazarlama");
                // exercise methods
                _ = y.MaasHesapla();
                _ = up.MaasHesapla();
                _ = pp.MaasHesapla();
            }
        }
    }
}