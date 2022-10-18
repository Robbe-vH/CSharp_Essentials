// oefening 1
/*Console.WriteLine("Geef eerste getal");
int getal1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("geef tweede getal");
int getal2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Maximum: ");
if (getal1<getal2)
{
    Console.WriteLine(getal2);
}
else
{
    Console.WriteLine(getal1);
}
*/

// Oefening 2

/*Console.WriteLine("Geef eerste getal");
int getal1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("geef tweede getal");
int getal2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("geef derde getal");
int getal3 = Convert.ToInt32(Console.ReadLine());

int grootste = getal1;
if (getal2 >= grootste)
{
    grootste = getal2;
}
if (getal3 > grootste)
{
    grootste = getal3;
}

Console.WriteLine($"Maximum: {grootste}");*/

// Oefening 3

/*Console.WriteLine("Geef een getal om te checken: ");
int getal = Convert.ToInt32(Console.ReadLine());

bool isDeelbaarDoorVijf = getal % 5 == 0;
bool isDeelbaarDoorZes = getal % 6 == 0;

if (isDeelbaarDoorVijf)
{
    Console.WriteLine("het getal is deelbaar door vijf");
}
else if (isDeelbaarDoorZes)
{
    Console.WriteLine("het getal is deelbaar door zes");
}
else
{
    Console.WriteLine("het getal is niet deelbaar door vijf of zes");
}*/

// oefening 4

/*Console.WriteLine("Geef een letter");
string letter = Console.ReadLine();

bool isKlinker = (letter == "a") || (letter == "e") || (letter == "i") || (letter == "o") || (letter == "u");



if (isKlinker)
{
    Console.WriteLine("De letter is een klinker");
}
else
{
    Console.WriteLine("Het is een medeklinker");
}*/

// oefening 5

/*Console.WriteLine("Geef het cijfer");
int cijfer = Convert.ToInt32(Console.ReadLine());

switch (cijfer)
{
    case < 5:
        Console.WriteLine("Erg slecht");
        break;
    case >= 5 and < 10:
        Console.WriteLine("Gebuisd");
        break;
    case >=10 and < 14:
        Console.WriteLine("Geslaagd");
        break;
    case >= 14 and < 16:
        Console.WriteLine("Goed");
        break;
    case >= 16 and <= 20:
        Console.WriteLine("Geweldig");
        break;

    default:
        Console.WriteLine("Het getal valt niet binnen de reeks");
        break;
}*/

// oefening 6

/*Console.WriteLine("Geef naam van de maand: ");
string maand = Console.ReadLine();

switch (maand)
{
    case ("januari") or ("maart") or ("mei") or ("juli") or ("augustus") or ("oktober") or ("december"):
        Console.WriteLine("de maand heeft 31 dagen");
        break;

    case ("februari"):
        Console.WriteLine("Deze maand heeft 28 dagen");
        break;

    case ("april") or ("juni") or ("september") or ("november"):
        Console.WriteLine("deze maand heeft 30 dagen");
        break;  

    default:
        Console.WriteLine("Deze maand bestaat niet");
        break;
}*/

// oefening 7

// deelbaar door 4
// deelbaar enkel door 100 als deze ook deelbaar is door 400

Console.WriteLine("geef het jaar");
int jaar = Convert.ToInt32(Console.ReadLine());

