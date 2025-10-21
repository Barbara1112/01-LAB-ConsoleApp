namespace ConsoleApp
{

    public class Proizvod
    {
        public string Naziv { get; set; }
        public decimal Cijena { get; set; }
        public int DostupnaKolicina { get; set; }
        public Proizvod (string naziv, decimal cijena, int dostupnaKolicina)
        {
            Naziv = naziv;
            Cijena = cijena;
            DostupnaKolicina = dostupnaKolicina;
        }

        public void PrikazInformacije ()
        {
            Console.WriteLine($"Naziv: {Naziv}, Cijena: {Cijena} Eura, Dostupna količina {DostupnaKolicina}");
        }
    }
}
}
