// if else

Console.WriteLine("Welkom in de nachtwinkel");

Console.WriteLine("Hoe oud bent u?");
int leeftijd = Convert.ToInt32(Console.ReadLine());

bool isAchtien = leeftijd >= 18;

if (isAchtien)
{
    Console.WriteLine("Kom zuipen");
}
else if(leeftijd <0)
{
    Console.WriteLine("Ongeldige invoer");
}
else
{
    Console.WriteLine("Te jong");
}


// switch

string pizza = Console.ReadLine();
switch (pizza)
{
    case "Hawai":
        Console.WriteLine("Lekker");
        Console.WriteLine("Goede keuze");
        break;
    case "Vier Kazen":
        Console.WriteLine("Geen vlees");
        Console.WriteLine("Ook lekker");
        break;
    default:
        Console.WriteLine("Deze pizza wordt niet verkocht");
        break;

}