// oefening 1
//static int ListSum(List<int> list)
//{
//    int totaal = 0;
//	for (int i = 0; i < list.Count; i++)
//	{
//		totaal += list[i];
//	}
//	return totaal;
//}

// oefening 2
//List<string> startlijst= new List<string>() { "Hallo", "Hallo", "Hallo"};
//static void ConcatWithText(List<string> lijst, string toegevoegdeTekst)
//{
//	for (int i = 0; i < lijst.Count; i++)
//	{
//		lijst[i] += toegevoegdeTekst;
//	}
//}

//ConcatWithText(startlijst, "///");

//foreach (var woord in startlijst)
//{
//	Console.WriteLine(woord);
//}

// oefening 3
//static int GeefGrootste(List<int> lijst)
//{
//	int grootsteGetal = lijst[0];
//	for (int i = 1; i < lijst.Count; i++)
//	{
//		if (lijst[i] > grootsteGetal)
//		{
//			grootsteGetal = lijst[i];
//		}
//	}
//	return grootsteGetal;
//}

//List<int> getallenReesk = new List<int>() { 1,2,3,4,5,1,2,3 };
//Console.WriteLine(GeefGrootste(getallenReesk));

//oefening 4
//static int TelAantal(List<int> lijst, int elem)
//{
//	int teller = 0;
//	for (int i = 0; i < lijst.Count; i++)
//	{
//		if (lijst[i] == elem)
//		{
//			teller++;
//		}
//	}
//	return teller;
//}

//List<int> getallenReeks = new List<int>() { 1, 2, 3, 4, 5, 1, 2, 3 };
//Console.WriteLine(TelAantal(getallenReeks, 5));

//oefening 5
//static int GeefWillekeurigElem(List<int> lijst)
//{
//    Random rnd = new Random();
//    return lijst[rnd.Next(0, lijst.Count)];
//}

//List<int> getallenReeks = new List<int>() { 1, 2, 3, 4, 5, 1, 2, 3 };
//Console.WriteLine(GeefWillekeurigElem(getallenReeks));

//oefening 6
static List<int> GeefRandomSubstring(List<int> lijst, int lengte)
{
	List<int> newList = new List<int>();
	Random rnd = new Random();
	for (int i = rnd.Next(0, lijst.Count-lengte); i < lengte; i++)
	{
		newList.Add(i);
	}
	return newList;
}