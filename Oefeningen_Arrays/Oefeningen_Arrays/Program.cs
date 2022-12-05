//// Oefening 1

//string[] studentNamen = new string[5];

//for (int i = 0; i < studentNamen.Length; i++)
//{
//    Console.Write($"Geef naam {i+1}: ");
//    studentNamen[i] = Console.ReadLine();
//}

//Console.Write("Nummer student om weer te geven: ");
//Console.WriteLine(studentNamen[Convert.ToInt32(Console.ReadLine()) - 1]);

//// Oefening 2

//int[] reeksVanVijf = new int[5];
//int[] reeksVanVijftien = new int[15];
//static bool IsLangerDanTien(int[] reeks)
//{
//    if (reeks.Length <= 10)
//    {
//        return false;
//    }
//    else
//    {
//        return true;
//    }
//}

//Console.WriteLine($"Is de reeks langer dan 10? { IsLangerDanTien(reeksVanVijftien)}");

//// oefening 3

//Random rnd = new Random();
//int[] randomGetallen = new int[10];

//for (int i = 0; i < randomGetallen.Length; i++)
//{
//    randomGetallen[i] = rnd.Next(0, 11);
//}

//foreach (var getal in randomGetallen)
//{
//    Console.WriteLine(getal);
//}

//// oefening 4

//int[] reeks = new int[5] { 1, 2, 3, 4, 5};

//static int Som(int[] getallen)
//{
//    int som = 0;
//    for (int i = 0; i < getallen.Length; i++)
//    {
//        som += getallen[i];
//    }
//    return som;
//}

//// oefening 5

//int[] reeks = new int[5] { 1, 2, 3, 4, 5};
//int max;
//static int MinMax(int[] getallen, out int max)
//{
//    max = getallen.Max();

//    return getallen.Min();
//}

//Console.WriteLine($"Minimum getal: { MinMax(reeks,out max) }. Maximum getal: { max }");

//// oefening 6 *hella spicy*

//int[] getallenReeks = new int[8] { 1, 2, 4, 1, 5, 6, 4, 4 };

//static int AantalDuplicaten(int[] getallenReeks)
//{
//    int[] duplicatenReeks = new int[getallenReeks.Length];
//    int duplicaten = 0;

//    for (int i = 0; i < getallenReeks.Length; i++)
//    {
//        for (int j = i + 1; j < getallenReeks.Length; j++)
//        {
//            if (getallenReeks[j] == getallenReeks[i])
//            {
//                Console.WriteLine("Duplicaat gevonden!");
//                if (duplicatenReeks[i] != getallenReeks[i])
//                {
//                    duplicaten++;
//                }

//                duplicatenReeks[i] = getallenReeks[i];
//                duplicatenReeks[j] = getallenReeks[j];
//            }
//        }
//    }
//    return duplicaten;
//}

//Console.WriteLine(AantalDuplicaten(getallenReeks));



// Oefening 7

//int[] gewoneReeks = new int[7] { 1, 2, 4, 1, 5, 6, 7 };
//int[] omgekeerdeReeks = new int[7];
//static int[] Reverse(int[] gwnReeks)
//{
//    int[] omgekeerdeReeks = new int[gwnReeks.Length];

//    for (int i = 0; i < gwnReeks.Length; i++)
//    {
//        omgekeerdeReeks[gwnReeks.Length - i - 1] = gwnReeks[i];
//    }
//    return omgekeerdeReeks;
//}

//omgekeerdeReeks = Reverse(gewoneReeks);
//foreach (var item in omgekeerdeReeks)
//{
//    Console.WriteLine(item);
//}


// oefening 8

//int[] a = new int[3] { 2, 4, 5};
//int[] b = new int[3] { 2, 4, 5 };
//static int[] TelArrayOp(int[] rijEen, int[] RijTwee)
//{
//    if (rijEen.Length == RijTwee.Length)
//    {
//        int[] resultaat = new int[rijEen.Length];

//        for (int i = 0; i < rijEen.Length; i++)
//        {
//            resultaat[i] = rijEen[i] + RijTwee[i];
//        }

//        return resultaat;
//    }
//    else
//    {
//        throw new Exception("Arrays zijn niet even lang!");
//    }
//}

//int[] resultaat = TelArrayOp(a,b);
//foreach (var item in resultaat)
//{
//    Console.WriteLine(item);
//}


// oefening 9

//int[] oudeReeks = new int[3] { 1, 2, 3 };
//static int[] SteekInArray(int[] reeks, int index, int elem)
//{
//    int[] resultaat = new int[reeks.Length + 1];

//    for (int i = 0; i < reeks.Length; i++)
//    {
//        if (i < index)
//        {
//            resultaat[i] = reeks[i];
//        }
//        else if (i == index)
//        {
//            resultaat[i] = elem;
//        }
//        else if (i > index)
//        {
//            resultaat[i] = reeks[i - 1];
//        }
//    }

//    return resultaat;
//}

//foreach (var item in SteekInArray(oudeReeks, 1, 4))
//{
//    Console.WriteLine(item);
//}