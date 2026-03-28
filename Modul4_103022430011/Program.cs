using Modul4_103022430011;
using System;

class Program
{
    static void Main(string[] args)
    {
        KodePaket paket = new KodePaket();
        Console.WriteLine("--- Output Table Driven ---");
        Console.WriteLine("Paket 'Basic': " + paket.getKodePaket("Basic"));
        Console.WriteLine("Paket 'Standard': " + paket.getKodePaket("Standard"));
        Console.WriteLine("Paket 'Premium': " + paket.getKodePaket("Premium"));
        Console.WriteLine("Paket 'Unlimited': " + paket.getKodePaket("Unlimited"));
        Console.WriteLine("Paket 'Gaming': " + paket.getKodePaket("Gaming"));
        Console.WriteLine("Paket 'Streaming': " + paket.getKodePaket("Streaming"));
        Console.WriteLine("Paket 'Family': " + paket.getKodePaket("Family"));
        Console.WriteLine("Paket 'Business': " + paket.getKodePaket("Business"));
        Console.WriteLine("Paket 'Student': " + paket.getKodePaket("Student"));
        Console.WriteLine("Paket 'Traveler': " + paket.getKodePaket("Traveler"));
        Console.WriteLine();

        MesinKopi mesin = new MesinKopi();
        Console.WriteLine("--- Output State Based ---");
        mesin.Transisi("POWER_ON");
        mesin.Transisi("START_BREW");
        mesin.Transisi("FINISH_BREW");
        mesin.Transisi("START_MAINTENANCE");
        mesin.Transisi("FINISH_MAINTENANCE");
        mesin.Transisi("POWER_OFF");
        mesin.Transisi("START_BREW");
    }
}