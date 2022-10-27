// By value, waarde wordt gekopieerd en aangepast
static void TelOpEnPrint(int a)
{
    a++;
    Console.WriteLine($" de waarde in de methode is {a}");
}

int b = 10;
TelOpEnPrint(b);
Console.WriteLine($"de waarde buiten de functie is {b}");

// By reference, originele waarde wordt aangepast
static void TelOpEnPrintByRef(ref float c)
{
    c++;
    Console.WriteLine($" de waarde in de methode is {c}");
}

float c = 10f;
TelOpEnPrintByRef(ref c);
Console.WriteLine($"de waarde buiten de functie is {c}");

// out, geeft een referentie mee naar een waarde die ingevuld moet worden
static float BerekenDeHelftEnDubbel(float a, out float dubbel)
{
    dubbel = a * 2;
    return a / 2;
}

float brrr = 6;
float jaaa;
BerekenDeHelftEnDubbel(brrr, out jaaa);