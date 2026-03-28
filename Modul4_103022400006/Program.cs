using System;

namespace Modul4_103022400006
{
    class Program
    {
        static void Main(string[] args)
        {
            KodePaket kodePaket = new KodePaket();

            Console.WriteLine("Daftar Kode Paket:\n");

            Console.WriteLine("Basic : " + kodePaket.getKodePaket("Basic"));
            Console.WriteLine("Standard : " + kodePaket.getKodePaket("Standard"));
            Console.WriteLine("Premium : " + kodePaket.getKodePaket("Premium"));
            Console.WriteLine("Unlimited : " + kodePaket.getKodePaket("Unlimited"));
            Console.WriteLine("Gaming : " + kodePaket.getKodePaket("Gaming"));
            Console.WriteLine("Streaming : " + kodePaket.getKodePaket("Streaming"));
            Console.WriteLine("Family : " + kodePaket.getKodePaket("Family"));
            Console.WriteLine("Business : " + kodePaket.getKodePaket("Business"));
            Console.WriteLine("Student : " + kodePaket.getKodePaket("Student"));
            Console.WriteLine("Traveler : " + kodePaket.getKodePaket("Traveler"));

        }
    }
}
