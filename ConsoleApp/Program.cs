namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. zadatak – Proizvod
            Proizvod p = new Proizvod("Laptop", 999.99m, 5);
            p.IspisiInformacije();

            Console.WriteLine("\n-----------------------------\n");

            // 2. zadatak – Nasljeđivanje
            PametniTelefon telefon = new PametniTelefon("Galaxy S24", "Samsung", 2024, "Android");
            telefon.IspisiInformacije();
            telefon.InstalirajAplikaciju("WhatsApp");

            Console.WriteLine("\n--- Pritisni Enter za kraj ---");
            Console.ReadLine();
        }
    }
}
