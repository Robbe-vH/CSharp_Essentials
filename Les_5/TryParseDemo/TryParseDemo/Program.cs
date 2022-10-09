
Console.WriteLine("Geef een getal!");
string antwoord = Console.ReadLine();
double getal;

//getal = Convert.ToDouble(antwoord);
//getal = double.Parse(antwoord);

// TryParse probeert te converteren van tekst naar getal, convert voor getal naar getal

bool isConverteerbaar;

isConverteerbaar = double.TryParse(antwoord, out getal);

if (isConverteerbaar)
{
    Console.WriteLine("gelukt");
}
else
{
    Console.WriteLine("niet gelukt");
}

Console.WriteLine(Math.Pow(getal, 2));