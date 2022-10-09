internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Geef naam: ");
        string Naam = Console.ReadLine();
        Console.WriteLine("Voornaam: " + Naam.Split(' ')[0]);
        Console.Write("Achternaam: " + Naam.Split(' ')[1]+ " ");

        if (Naam.Split(' ')[2] != "")
            Console.WriteLine(Naam.Split(' ')[2]);
        
    }
}