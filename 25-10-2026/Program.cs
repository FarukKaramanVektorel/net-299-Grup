namespace _25_10_2026
{
    class Program
    {
        static void Main(string[] args)
        {
            // IoC Inversion of Control
            SqlVeriTabani sdb = new SqlVeriTabani();
            SiparisServisi sp = new SiparisServisi(sdb);
            sp.SiparisOlustur("5 kg mandalina");
            
        }
    }
}
