int[] getallen = new int[] { 0, 1, 2, 3, 6 };
string[] namen = new string[] { "Jan", "Piet", "Barry", "Peter", "Jos", "Zakkie", "Djempie", "Adriaan" };

static void Print(string[] namen)
{
    foreach (var item in namen)
    {
        Console.WriteLine(item);
    }
}

// hulpfuncties van arrays

// IndexOf
Console.WriteLine(Array.IndexOf(namen, "Piet")); // geeft de index terug
Console.WriteLine(Array.IndexOf(namen, "Yeet")); // niet gevodnen shit is -1

//LastIndexOf
Console.WriteLine(Array.LastIndexOf(namen, "Piet")); // geeft de laatste occurance terug van "object"

// Copy
int[] kopie = new int[getallen.Length];
Array.Copy(getallen, kopie, getallen.Length);

Print(namen);

//Reverse
Array.Reverse(getallen);
Print(namen);



// Lambda functies

static bool ZoekVoorwaarde(string element)
{
    return true;
}

// (element) => element.StartsWith("N");

Array.Sort(namen);
Print(namen);


// BinarySearch (Gaat een rij van woorden telkens in twee splitsen tot hij het vindt) werkt alleen met gesorteerde lijsten

int indexOfBarry = Array.BinarySearch(namen, "Barry");
Console.WriteLine($"De index van Barry is { indexOfBarry }");

// Clear
// Array.Clear(array, startIndex, lengte)
Array.Clear(namen, 3, 2);
Print(namen);

// Resize altijd ByRef

Array.Resize(ref namen, 10);
namen[9] = "tien";
Print(namen);