namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Proizvod proizvod1 = new Proizvod("Laptop", 1200.50m, 10);
            Proizvod proizvod2 = new Proizvod("televizija", 800.00m, 25);

            proizvod1.PrikazInformacije();
            proizvod2.PrikazInformacije();

            ElektronickiUredaj elektronickiuredaj=
                new PametniTelefon ("tablet", "Samsung", 2022, "Andorid")


                elektronickiuredaj.IspisInformacije();
        }
    }
}