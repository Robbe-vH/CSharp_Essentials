// Declaratie
Dictionary<string, int> eindresultaatItOrg;

// Initialisatie, Key moet altijd uniek zijn
eindresultaatItOrg = new Dictionary<string, int>()
{
    {"Emma", 10},
    {"Jos", 20},
    {"Yeet", 15 }
};

// Zeer onhandig om een random als Key te nemen, maar het zou in principe kunnen
Dictionary<Random, TimeSpan> vreemdeDictionary = new Dictionary<Random, TimeSpan>()
{
    {new Random(), TimeSpan.FromMinutes(1)}
};

// toevoegen
eindresultaatItOrg.Add("Jan", 2);

// overschrijven
eindresultaatItOrg["Jan"] = 5;
Console.WriteLine("Jan: " + eindresultaatItOrg["Jan"]);

// eindresultaatItOrg.Add("Jan", 7);   // 2 keer dezelfde Key: "ArgumentException"


// PROPERTIES

// Count: aantal KV pairs
Console.WriteLine("Aantal K/V pairs: " + eindresultaatItOrg.Count);

// Keys
foreach (var key in eindresultaatItOrg.Keys)
{
    Console.WriteLine(key);
}

// Values
foreach (var value in eindresultaatItOrg.Values)
{
    Console.WriteLine(value);
}

// METHODS

// Add (opletten met ArgumentException)
eindresultaatItOrg.Add("Ruben", 14);

// Remove: verwijdert een specifiek K/V pair
eindresultaatItOrg.Remove("Emma");

// Clear: Verwijder alles
//eindresultaatItOrg.Clear();

// ContainsKey, ContainsValue: checken of de opgevraagde K/V bestaat
if (eindresultaatItOrg.ContainsKey("Korneel"))
{
    Console.WriteLine(eindresultaatItOrg["Korneel"]);
}
else
{
    Console.WriteLine("Gevraagde naam bestaat niet!");
}

if (eindresultaatItOrg.ContainsValue(20))
{
    Console.WriteLine("Iemand heeft een perfecte score behaald!");
}


// TryGetvalue: gelijkaardig aan de TryParse
eindresultaatItOrg.Add("Barry", 15);
if (eindresultaatItOrg.TryGetValue("Barry", out int resultaat))
{
    Console.WriteLine($"Barry heeft een resultaat van {resultaat}/20");
}
else
{
    Console.WriteLine("Barry heeft geen resulaat behaald!");
}
