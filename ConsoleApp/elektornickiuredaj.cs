class ElektronickiUredjaj
{
    public string Naziv { get; set; }
    public string Proizvodjac { get; set; }
    public int GodinaProizvodnje { get; set; }

    public ElektronickiUredjaj(string naziv, string proizvodjac, int godina)
    {
        Naziv = naziv;
        Proizvodjac = proizvodjac;
        GodinaProizvodnje = godina;
    }

    public virtual void IspisiInformacije()
    {
        Console.WriteLine("---- Elektronički uređaj ----");
        Console.WriteLine($"Naziv: {Naziv}");
        Console.WriteLine($"Proizvođač: {Proizvodjac}");
        Console.WriteLine($"Godina proizvodnje: {GodinaProizvodnje}");
        Console.WriteLine("-----------------------------");
    }
}

class PametniTelefon : ElektronickiUredjaj
{
    public string OperativniSustav { get; set; }

    public PametniTelefon(string naziv, string proizvodjac, int godina, string os)
        : base(naziv, proizvodjac, godina)
    {
        OperativniSustav = os;
    }

    public override void IspisiInformacije()
    {
        base.IspisiInformacije();
        Console.WriteLine($"Operativni sustav: {OperativniSustav}");
        Console.WriteLine("-----------------------------");
    }

    public void InstalirajAplikaciju(string nazivAplikacije)
    {
        Console.WriteLine($"Instaliram aplikaciju: {nazivAplikacije} na {Naziv} ({OperativniSustav})");
    }
}