namespace dz1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Korisnik korisnik1 = new Korisnik("Jana", "Janić");
            Korisnik korisnik2 = new Korisnik("Luka", "Lukić");

            
            List<IBankovniRacun> korisnici = new List<IBankovniRacun>();
            korisnici.Add(korisnik1);
            korisnici.Add(korisnik2);

         
            Banka banka = new Banka(korisnici);


            
            Console.WriteLine("Korisnički podaci:");
            korisnik1.PrikaziOsobnePodatke();
            korisnik2.PrikaziOsobnePodatke();

            Console.WriteLine("\n");
            Console.WriteLine("Stanje korisničkih računa:");
            Console.WriteLine($"Stanje korisnika {korisnik1.Ime}: {korisnik1.ProvjeriStanjeRacuna()}");
            Console.WriteLine($"Stanje korisnika {korisnik2.Ime}: {korisnik2.ProvjeriStanjeRacuna()}");


            Console.WriteLine("\n");

            Transakcija uplata = new Uplata(korisnik1, korisnik2, 100);
            banka.NapraviTransakciju(uplata);

            
            Console.WriteLine($"Stanje korisnika {korisnik1.Ime}: {korisnik1.ProvjeriStanjeRacuna()}");
            Console.WriteLine($"Stanje korisnika {korisnik2.Ime}: {korisnik2.ProvjeriStanjeRacuna()}");

            Console.WriteLine("\n");
            Transakcija isplata = new Isplata(korisnik2, korisnik1, 50);
            banka.NapraviTransakciju(isplata);

            
            Console.WriteLine($"Stanje korisnika {korisnik1.Ime}: {korisnik1.ProvjeriStanjeRacuna()}");
            Console.WriteLine($"Stanje korisnika {korisnik2.Ime}: {korisnik2.ProvjeriStanjeRacuna()}");

            Console.ReadLine();
        }
    }

}