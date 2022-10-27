/*// oefening 6
using System.Runtime.CompilerServices;

string antwoord = "y";

do
{
    Console.WriteLine("Geef een eerste getal: ");
    int getal1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Geef een tweede getal: ");
    int getal2 = Convert.ToInt32(Console.ReadLine());

    int resultaat = getal1 * getal2;
    Console.WriteLine(resultaat);
    Console.WriteLine("Wilt u nog eens?(Y/N)");
    antwoord = Console.ReadLine();
} while (antwoord.ToUpper().Equals("Y"));
*/

/*//oefening 7
int getalGebruiker = 1;
Console.WriteLine("Geef een getal in, 0 om af te sluiten: ");
getalGebruiker = Convert.ToInt32(Console.ReadLine());
int grootsteGetal = getalGebruiker;
int kleinsteGetal = getalGebruiker;
do
{
    Console.WriteLine("Geef een getal in, 0 om af te sluiten: ");
    getalGebruiker = Convert.ToInt32(Console.ReadLine());
    if (getalGebruiker > grootsteGetal)
    {
        grootsteGetal = getalGebruiker;
    }
    if (getalGebruiker < kleinsteGetal && getalGebruiker != 0)
    {
        kleinsteGetal = getalGebruiker;
    }

} while (getalGebruiker != 0);
Console.WriteLine($"Het grootste getal is: {grootsteGetal}");
Console.WriteLine($"Het kleinste getal is: {kleinsteGetal}");
*/

/*// oefening 8
Console.WriteLine("Geef een getal: ");
int teCheckenGetal = Convert.ToInt32(Console.ReadLine());
int aantaldeelnummers = 0;

for (int i = 2; i <= teCheckenGetal; i++)
{
    if (teCheckenGetal%i == 0)
    {
        aantaldeelnummers++;
    }
}
if (aantaldeelnummers == 1)
{
    Console.WriteLine($"{teCheckenGetal} is een priemgetal.");
}*/

/*
// oefening 10
Console.WriteLine("Aantal rijen hoog?");
int aantalRijen = Convert.ToInt32(Console.ReadLine()); 
for (int i = 0; i < aantalRijen; i++)
{
    for (int j = 0; j < aantalRijen; j++)
    {
        Console.Write("x");
    }
    Console.WriteLine();
}*/