//int[] getallen;
//getallen = new int[] { 0, 2, 5, 1, 45, 23 };


//// Foreach
//// Is read-only, beter altijd for loop gebruiken
//foreach (int getal in getallen)
//{
//    // getal++;
//    Console.WriteLine(getal);

//}

//// For 
//// Teller kan incrementeren met andere getallen dan +1
//// aanpassingen kunnen gemaakt worden aan de list items
//for (int i = 0; i < getallen.Length; i += 2)
//{
//    getallen[i]++;
//    Console.WriteLine(getallen[i]);
//}

//static void VerhoogEnPrint(int getal)
//{
//    getal++;
//    Console.WriteLine(getal);
//}
//// by value (originele a wijzigt niet )
//int a = 0;
//VerhoogEnPrint(a);
//Console.WriteLine(a);

//static void VerhoogEnPrintEersteElement(int[] getallen)
//{
//    getallen[0]++;
//    Console.WriteLine(getallen[0]);
//}

//// lists worden standaard by ref doorgestuurd
//// is te complex om te kopieren
//// is op te lossen door een tweede kopie te maken van de array, als er niet permanente bewerkingen gedaan moeten worden
//VerhoogEnPrintEersteElement(getallen);
//Console.WriteLine(getallen[0]);


int[] uren = new int[7];
string[] dagen = new string[7] {"Maandag: ", "Dinsdag: ", "Woensdag: ", "Donderdag: ", "Vrijdag: ", "Zaterdag: ", "Zondag: "};

Console.WriteLine("Hoeveel uren per dag studeer je voor C#?");
for (int i = 0; i < 7; i++)
{
    Console.Write(dagen[i]);
    uren[i] = Convert.ToInt32(Console.ReadLine());
}


Console.WriteLine(BerekenGemiddelde(uren));


static string BerekenGemiddelde(int[] uren) 
{
    int totaal = 0;
    for (int i = 0; i < uren.Length; i++)
    {
        totaal += uren[i];
    }
    return $"Het gemiddeld aantal uren per dag is: {totaal/uren.Length}";
}
