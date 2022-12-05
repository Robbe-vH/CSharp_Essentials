//// Declaratie

//List<string> studenten = new List<string>() { };
//List<double> scores = new List<double>();

//// lijst met standaardwaardes
//List<string> vakken = new List<string>() { "c#", "Web", "Nederlands"};

//// Index notatie
//Console.WriteLine(vakken[2]);

//foreach (var vak in vakken)
//{
//    Console.WriteLine(vak);
//}


////methodes

////toevoegen
//vakken.Add("Frans");

//// clear
//vakken.Clear();

////AddRange
//string[] DVOVakken = new string[] { "Photoshop", "Lightroom" };
//vakken.AddRange(DVOVakken);

////Contains
//if (vakken.Contains("WO3"))
//{
//    Console.WriteLine("We zijn in de toekomst");
//}

//// insert voegt iets toe op een specifieke plaats
//vakken.Insert(4,"WO2");

////Remove een specifieke string
//vakken.Remove("Lightroom");

////RemoveAt op een index
//vakken.RemoveAt(4);

//List<string> oorlogen = vakken.GetRange(4, 2); // start vanaf index 4, gaat dan 2 elementen verder

////sort reverse
//vakken.Sort();
//vakken.Reverse();

////indexOf
//int indexVanWeb = vakken.IndexOf("Web");
//Console.WriteLine(indexVanWeb);

////Count: geeft de lengte van list *Geen methode*
//int lengte = vakken.Count;


//Opdracht 2

List<string> favoSeries = new List<string>();
bool antw = true;
do
{
    Console.Write("Geef een favoriete serie: ");
    favoSeries.Add(Console.ReadLine());
    Console.Write("Wilt u nog een serie ingeven? (y/n) ");
    if (Console.ReadLine() == "y")
    {
        antw = true;
    }
    else
    {
        antw = false;
        foreach (var serie in favoSeries)
        {
            Console.WriteLine(serie);
        }
    }
} while (antw);