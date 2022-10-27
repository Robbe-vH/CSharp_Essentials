// oefening 1
static void SwitchValues(ref int a, ref int b)
{
    int c = a;
    a = b;
    b = c;

}

int a = 1;
int b = 2;
Console.WriteLine($"getal 1 {a}, geteal 2 {b}");
SwitchValues(ref a, ref b);
Console.WriteLine($"omgedraaide getal 1 {a}, geteal 2 {b}");


// Oefening 2
static double BerekenOmtrek(double radius)
{
    return Math.PI * radius * 2f;
}

double omtrek = BerekenOmtrek(6);
Console.WriteLine(omtrek);

// oefening 3 A
static string Geefkarakter(int getal)
{
    if (getal % 2 != 0)
    {
        return "%";
    } 
    else
    {
        return "#";
    }
}

// oefening 3B 
Random rng = new Random();

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 4; j++)
    {
        int nummer = rng.Next();
        Console.Write(Geefkarakter(nummer));
    }
    Console.WriteLine();
}

// oefening 4

static bool IsGroterDan(int a, int b, int c)
{
    return (a + b + c) > 100;
}

Console.WriteLine(IsGroterDan(50,10,40));

// oefening 5
static double TweedeMacht(double x, double y)
{
    double uitkomst = x;
    for (int i = 1; i <= y; i++)
    {
        uitkomst *= x;
    }
    return uitkomst;
}

Console.WriteLine(TweedeMacht(3, 3));

// oefening 6 zelfde naam werkt niet omdat het .NET6 is, dit alles zit eigenlijk binnen 1 klasse
static decimal Bereken21BTW(decimal bedrag)
{
    return bedrag * 0.21m;
}

static double Bereken21BTWd(double bedrag)
{
    return bedrag * 0.21;
}

static float Bereken21BTWf(float bedrag)
{
    return bedrag * 0.21f;
}
Console.WriteLine(Bereken21BTW(5000));
Console.WriteLine(Bereken21BTWf(5000));
Console.WriteLine(Bereken21BTWd(5000));

// oefening 7 
static void VerdubbelGetal(ref int a)
{
     a *= 2;
}
int testgetal = 1;
Console.WriteLine(testgetal);
VerdubbelGetal(ref testgetal);
Console.WriteLine(testgetal);

// oefening 8
static bool IsVoldoendeBudget(double totaalkost, double budgetVanKlant, out string beschrijving)
{
    if (budgetVanKlant >= totaalkost)
    {
        beschrijving = "Dankuwel";
        return true;
    }
    else
    {
        beschrijving = $"U heeft {totaalkost - budgetVanKlant} te kort";
        return false;
    }
}
Console.WriteLine(IsVoldoendeBudget(300, 200, out string antwoord));
Console.WriteLine(antwoord);


// oefening 9

